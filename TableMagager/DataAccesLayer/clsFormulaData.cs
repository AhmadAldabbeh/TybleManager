using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TableManager;

namespace DataAccesLayer
{
    public class clsFormulaData
    {
        // ================================
        // 1) إضافة معادلة جديدة
        // ================================
        public static int AddFormula(int tableID, string formulaName, string formulaText)
        {
            int formulaID = -1;

            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                string query = @"
                INSERT INTO TableFormulas (TableID, FormulaName, FormulaText)
                VALUES (@TableID, @FormulaName, @FormulaText);
                SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@TableID", tableID);
                cmd.Parameters.AddWithValue("@FormulaName", formulaName);
                cmd.Parameters.AddWithValue("@FormulaText", formulaText);

                con.Open();
                formulaID = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return formulaID;
        }

        // ================================
        // 2) تحديث معادلة
        // ================================
        public static bool UpdateFormula(int formulaID, string formulaName, string formulaText)
        {
            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                string query = @"
                UPDATE TableFormulas
                SET FormulaName = @FormulaName,
                    FormulaText = @FormulaText
                WHERE FormulaID = @FormulaID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FormulaID", formulaID);
                cmd.Parameters.AddWithValue("@FormulaName", formulaName);
                cmd.Parameters.AddWithValue("@FormulaText", formulaText);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ================================
        // 3) حذف معادلة
        // ================================
        public static bool DeleteFormula(int formulaID)
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

        // ================================
        // 4) جلب معادلة واحدة
        // ================================
        public static DataRow GetFormula(int formulaID)
        {
            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                string query = @"SELECT * FROM TableFormulas WHERE FormulaID = @FormulaID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@FormulaID", formulaID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt.Rows.Count > 0 ? dt.Rows[0] : null;
            }
        }

        // ================================
        // 5) جلب كل المعادلات لجدول معيّن
        // ================================
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

        // ================================
        // 6) استخراج أسماء الأعمدة من المعادلة
        // ================================
        public static List<string> ExtractFieldNames(string formulaText)
        {
            List<string> fields = new List<string>();

            var matches = Regex.Matches(formulaText, @"

\[(.*?)\]

");

            foreach (Match m in matches)
            {
                fields.Add(m.Groups[1].Value);
            }

            return fields;
        }

        // ================================
        // 7) إضافة الأعمدة المستخدمة في المعادلة
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
        // 8) حذف الأعمدة المستخدمة في المعادلة
        // ================================
        public static void DeleteFormulaFields(int formulaID)
        {
            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            {
                string query = @"DELETE FROM FormulaFields WHERE FormulaID = @FormulaID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FormulaID", formulaID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

}
