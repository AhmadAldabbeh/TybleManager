using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TableManager;


namespace DataAccesLayer


{
    public class clsFormulaData
    {
       
        // ---------------------------------------------------------
        // 1) ADD FORMULA
        // ---------------------------------------------------------
        public static int AddFormula(int tableID, string rowName, string formulaName,
                              string formulaText, double? resultValue,
                              DateTime? fromDate, DateTime? toDate)
        {
            int formulaID = -1;

            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                string query = @"
            INSERT INTO TableFormulas 
            (TableID, RowName, FormulaName, FormulaText, ResultValue, FromDate, ToDate)
            VALUES 
            (@TableID, @RowName, @FormulaName, @FormulaText, @ResultValue, @FromDate, @ToDate);
            SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@TableID", tableID);
                cmd.Parameters.AddWithValue("@RowName", (object)rowName ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FormulaName", (object)formulaName ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FormulaText", (object)formulaText ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ResultValue", (object)resultValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FromDate", (object)fromDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ToDate", (object)toDate ?? DBNull.Value);

                con.Open();
                formulaID = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return formulaID;
        }

        // ---------------------------------------------------------
        // 2) UPDATE FORMULA
        // ---------------------------------------------------------
        public static bool UpdateFormula(int formulaID, string rowName, string formulaName,
                                  string formulaText, double? resultValue,
                                  DateTime? fromDate, DateTime? toDate)
        {
            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                string query = @"
            UPDATE TableFormulas
            SET RowName = @RowName,
                FormulaName = @FormulaName,
                FormulaText = @FormulaText,
                ResultValue = @ResultValue,
                FromDate = @FromDate,
                ToDate = @ToDate
            WHERE FormulaID = @FormulaID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FormulaID", formulaID);
                cmd.Parameters.AddWithValue("@RowName", (object)rowName ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FormulaName", (object)formulaName ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FormulaText", (object)formulaText ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ResultValue", (object)resultValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FromDate", (object)fromDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ToDate", (object)toDate ?? DBNull.Value);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ---------------------------------------------------------
        // 3) DELETE FORMULA
        // ---------------------------------------------------------
        public static bool DeleteFormula(int formulaID)
        {
            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                string query = "DELETE FROM TableFormulas WHERE FormulaID = @FormulaID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FormulaID", formulaID);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ---------------------------------------------------------
        // 4) GET FORMULA BY ID
        // ---------------------------------------------------------
        public static  DataRow GetFormula(int formulaID)
        {
            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                string query = "SELECT * FROM TableFormulas WHERE FormulaID = @FormulaID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@FormulaID", formulaID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt.Rows.Count > 0 ? dt.Rows[0] : null;
            }
        }

        // ---------------------------------------------------------
        // 5) GET FORMULAS BY TABLE
        // ---------------------------------------------------------
        public static  DataTable GetFormulasByTable(int tableID)
        {
            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                string query = "SELECT * FROM TableFormulas WHERE TableID = @TableID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@TableID", tableID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        // ---------------------------------------------------------
        // 6) CHECK IF FORMULA EXISTS
        // ---------------------------------------------------------
        public  static  bool CheckIfExists(int tableID, string rowName)
        {
            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                string query = @"
            SELECT COUNT(*) 
            FROM TableFormulas 
            WHERE TableID = @TableID AND RowName = @RowName";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TableID", tableID);
                cmd.Parameters.AddWithValue("@RowName", rowName);

                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        // ---------------------------------------------------------
        // 7) GET FORMULA BY ROW NAME
        // ---------------------------------------------------------
        public static  DataRow GetByRowName(int tableID, string rowName)
        {
            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                string query = @"
            SELECT * FROM TableFormulas 
            WHERE TableID = @TableID AND RowName = @RowName";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@TableID", tableID);
                da.SelectCommand.Parameters.AddWithValue("@RowName", rowName);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt.Rows.Count > 0 ? dt.Rows[0] : null;
            }
        }

        // ---------------------------------------------------------
        // 8) EXTRACT FIELD NAMES FROM FORMULA TEXT
        // ---------------------------------------------------------
        public static  List<string> ExtractFieldNames(string formulaText)
        {
            List<string> fields = new List<string>();

            foreach (string part in formulaText.Split(' ', '+', '-', '*', '/', '(', ')'))
            {
                if (part.StartsWith("Field"))
                    fields.Add(part);
            }

            return fields;
        }

        // ---------------------------------------------------------
        // 9) ADD FORMULA FIELDS
        // ---------------------------------------------------------
        public static  void AddFormulaFields(int formulaID, int fieldID)
        {
            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                string query = @"
            INSERT INTO FormulaFields (FormulaID, FieldID)
            VALUES (@FormulaID, @FieldID)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FormulaID", formulaID);
                cmd.Parameters.AddWithValue("@FieldID", fieldID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ---------------------------------------------------------
        // 10) DELETE FORMULA FIELDS
        // ---------------------------------------------------------
        public static  void DeleteFormulaFields(int formulaID)
        {
            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                string query = "DELETE FROM FormulaFields WHERE FormulaID = @FormulaID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FormulaID", formulaID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }





        public static double? ExecuteFlexibleFormula(
            int TableID,
            int FieldID1,
            int? FieldID2,
            string OperationType,
            string FormulaText,
            string RowName,
            DateTime? FromDate,
            DateTime? ToDate,
            int? EmployeeID,
            bool IsMonthly,
            string Mode,
            DateTime? SpecificDate)
        {
            double? resultValue = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    using (SqlCommand command = new SqlCommand("sp_CalculateFlexibleFormula_ByEmployeeID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // -----------------------------
                        // إضافة الباراميترات
                        // -----------------------------
                        command.Parameters.AddWithValue("@TableID", TableID);
                        command.Parameters.AddWithValue("@FieldID1", FieldID1);

                        if (FieldID2.HasValue)
                            command.Parameters.AddWithValue("@FieldID2", FieldID2.Value);
                        else
                            command.Parameters.AddWithValue("@FieldID2", DBNull.Value);

                        command.Parameters.AddWithValue("@OperationType", OperationType);

                        if (!string.IsNullOrEmpty(FormulaText))
                            command.Parameters.AddWithValue("@FormulaText", FormulaText);
                        else
                            command.Parameters.AddWithValue("@FormulaText", DBNull.Value);

                        if (!string.IsNullOrEmpty(RowName))
                            command.Parameters.AddWithValue("@RowName", RowName);
                        else
                            command.Parameters.AddWithValue("@RowName", DBNull.Value);

                        if (FromDate.HasValue)
                            command.Parameters.AddWithValue("@FromDate", FromDate.Value);
                        else
                            command.Parameters.AddWithValue("@FromDate", DBNull.Value);

                        if (ToDate.HasValue)
                            command.Parameters.AddWithValue("@ToDate", ToDate.Value);
                        else
                            command.Parameters.AddWithValue("@ToDate", DBNull.Value);

                        if (EmployeeID.HasValue)
                            command.Parameters.AddWithValue("@EmployeeID", EmployeeID.Value);
                        else
                            command.Parameters.AddWithValue("@EmployeeID", DBNull.Value);

                        command.Parameters.AddWithValue("@IsMonthly", IsMonthly);

                        if (!string.IsNullOrEmpty(Mode))
                            command.Parameters.AddWithValue("@Mode", Mode);
                        else
                            command.Parameters.AddWithValue("@Mode", DBNull.Value);

                        if (SpecificDate.HasValue)
                            command.Parameters.AddWithValue("@SpecificDate", SpecificDate.Value);
                        else
                            command.Parameters.AddWithValue("@SpecificDate", DBNull.Value);

                        // -----------------------------
                        // تنفيذ البروسيجر
                        // -----------------------------
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                            resultValue = Convert.ToDouble(result);
                    }
                }
            }
            catch (Exception ex)
            {
                // بإمكانك تسجيل الخطأ إذا بدك
            }

            return resultValue;
        }


    }

}

