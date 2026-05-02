using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TableManager;

namespace BussinusLayer
{
    public class clsFormula
    {
        public int FormulaID { get; set; }
        public int TableID { get; set; }
        public string FormulaName { get; set; }
        public string FormulaText { get; set; }

        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public clsFormula()
        {
            FormulaID = -1;
            TableID = -1;
            FormulaName = "";
            FormulaText = "";
            Mode = enMode.AddNew;
        }

        public clsFormula(int formulaID, int tableID, string formulaName, string formulaText)
        {
            FormulaID = formulaID;
            TableID = tableID;
            FormulaName = formulaName;
            FormulaText = formulaText;
            Mode = enMode.Update;
        }

        // ============================================================
        // 1) Find Formula
        // ============================================================
        public static clsFormula Find(int formulaID)
        {
            clsFormula formula = null;

            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                string query = @"SELECT * FROM TableFormulas WHERE FormulaID = @FormulaID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FormulaID", formulaID);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    formula = new clsFormula(
                        (int)dr["FormulaID"],
                        (int)dr["TableID"],
                        dr["FormulaName"].ToString(),
                        dr["FormulaText"].ToString()
                    );
                }
            }

            return formula;
        }

        // ============================================================
        // 2) Add New Formula
        // ============================================================
        private bool _AddNew()
        {
            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                string query = @"
                    INSERT INTO TableFormulas (TableID, FormulaName, FormulaText)
                    VALUES (@TableID, @FormulaName, @FormulaText);
                    SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@TableID", TableID);
                cmd.Parameters.AddWithValue("@FormulaName", FormulaName);
                cmd.Parameters.AddWithValue("@FormulaText", FormulaText);

                con.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    FormulaID = Convert.ToInt32(result);
                    return true;
                }
            }

            return false;
        }

        // ============================================================
        // 3) Update Formula
        // ============================================================
        private bool _Update()
        {
            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                string query = @"
                    UPDATE TableFormulas
                    SET FormulaName = @FormulaName,
                        FormulaText = @FormulaText
                    WHERE FormulaID = @FormulaID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FormulaID", FormulaID);
                cmd.Parameters.AddWithValue("@FormulaName", FormulaName);
                cmd.Parameters.AddWithValue("@FormulaText", FormulaText);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ============================================================
        // 4) Save (Add or Update)
        // ============================================================
        public bool Save()
        {
            if (Mode == enMode.AddNew)
            {
                if (_AddNew())
                {
                    Mode = enMode.Update;
                    return true;
                }
                return false;
            }
            else
            {
                return _Update();
            }
        }

        // ============================================================
        // 5) Delete Formula
        // ============================================================
        public static bool Delete(int formulaID)
        {
            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                string query = @"DELETE FROM TableFormulas WHERE FormulaID = @FormulaID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FormulaID", formulaID);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ============================================================
        // 6) Get All Formulas for Table
        // ============================================================
        public static DataTable GetFormulasByTable(int tableID)
        {
            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                string query = @"SELECT * FROM TableFormulas WHERE TableID = @TableID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@TableID", tableID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
        public static DataTable GetFormulasViewByTable(int tableID)
        {
            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                string query = @"SELECT    dbo.TableFormulas.FormulaID, dbo.TableFormulas.RowName, dbo.TableFormulas.FormulaText,
                dbo.TableFormulas.ResultValue, dbo.TableFormulas.FromDate, dbo.TableFormulas.ToDate, dbo.Employee.EmployeeName
                 FROM    dbo.TableFormulas LEFT OUTER JOIN
                         dbo.Employee ON dbo.TableFormulas.EmployeeID = dbo.Employee.EmployeeID
						 where TableID = @TableID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@TableID", tableID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

    }
}
