using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TableManager;

namespace DataAccesLayer
{
    public class clsFormulaFieldsData
    {
        // ================================
        // 1) إضافة سجل جديد إلى FormulaFields
        // ================================
        public static int AddFormulaField(int formulaID, int fieldID)
        {
            int id = -1;

            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                string query = @"
                INSERT INTO FormulaFields (FormulaID, FieldID)
                VALUES (@FormulaID, @FieldID);
                SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FormulaID", formulaID);
                cmd.Parameters.AddWithValue("@FieldID", fieldID);

                con.Open();
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return id;
        }

        // ================================
        // 2) حذف سجل واحد
        // ================================
        public static bool DeleteFormulaField(int id)
        {
            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                string query = @"DELETE FROM FormulaFields WHERE ID = @ID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ================================
        // 3) حذف كل الأعمدة المرتبطة بمعادلة معيّنة
        // ================================
        public static bool DeleteFormulaFieldsByFormula(int formulaID)
        {
            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                string query = @"DELETE FROM FormulaFields WHERE FormulaID = @FormulaID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FormulaID", formulaID);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ================================
        // 4) جلب كل الأعمدة المستخدمة في معادلة معيّنة
        // ================================
        public static DataTable GetFieldsByFormula(int formulaID)
        {
            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                string query = @"SELECT * FROM FormulaFields WHERE FormulaID = @FormulaID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@FormulaID", formulaID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        // ================================
        // 5) إضافة مجموعة أعمدة دفعة واحدة
        // ================================
        public static void AddFormulaFields(int formulaID, List<int> fieldIDs)
        {
            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                con.Open();

                foreach (int fieldID in fieldIDs)
                {
                    string query = @"
                    INSERT INTO FormulaFields (FormulaID, FieldID)
                    VALUES (@FormulaID, @FieldID)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@FormulaID", formulaID);
                    cmd.Parameters.AddWithValue("@FieldID", fieldID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ================================
        // 6) جلب سجل واحد
        // ================================
        public static DataRow GetFormulaField(int id)
        {
            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                string query = @"SELECT * FROM FormulaFields WHERE ID = @ID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@ID", id);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt.Rows.Count > 0 ? dt.Rows[0] : null;
            }
        }





    }
}
