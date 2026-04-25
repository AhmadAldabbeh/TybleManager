using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableManager;

namespace DataAccesLayer
{
    public class clsFieldsData
    {
        public static DataTable GetAllFields()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = "select fieldsID,Label,DataType from TableFields order by fieldsID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reder = command.ExecuteReader())
                        {
                            if (reder.HasRows)
                            {
                                dt.Load(reder);
                            }

                        }
                    }


                }

            }
            catch (Exception ex) { }
            return dt;

        }

        public static DataTable GetAllLabelFields()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = "select Label from TableFields order by fieldsID ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reder = command.ExecuteReader())
                        {
                            if (reder.HasRows)
                            {
                                dt.Load(reder);
                            }

                        }
                    }


                }

            }
            catch (Exception ex) { }
            return dt;

        }

        public static bool GetFieldByID(int FieldID,ref int TableID,ref string FieldName,ref string Label,ref string DataType)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = "select * from TableFields where fieldsID = @fieldsID";

                    using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@fieldsID", FieldID);

                        connection.Open();

                        using (SqlDataReader reder =command.ExecuteReader())
                        {
                            if (reder.Read())
                            {
                                IsFound= true;
                                TableID = (int)reder["TableID"];
                                FieldName = (string)reder["FieldName"];
                                Label = (string)reder["Label"];
                                DataType = (string)reder["DataType"];
                            }
                            else
                            {
                                IsFound = false;
                            }

                        }

                    }


                }

            }
            catch (Exception ex) { IsFound = false; }

            return IsFound;

        }
        public static bool GetFieldByName(string FieldName, ref int FieldID, ref int TableID,  ref string Label, ref string DataType)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = "select * from TableFields where Label = @FieldName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FieldName", FieldName);

                        connection.Open();

                        using (SqlDataReader reder = command.ExecuteReader())
                        {
                            if (reder.Read())
                            {
                                IsFound = true;
                                FieldID = (int)reder["fieldsID"];
                                TableID = (int)reder["TableID"];
                              
                                Label = (string)reder["Label"];
                                DataType = (string)reder["DataType"];
                            }
                            else
                            {
                                IsFound = false;
                            }

                        }

                    }


                }

            }
            catch (Exception ex) { IsFound = false; }

            return IsFound;

        }

        public static int AddNewField(int TableID,string FieldName, string Label, string DataType)
        {
            int FieldID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = @"insert into TableFields  (TableID,FieldName,Label,DataType) Values (@TableID,@FieldName,@Label,@DataType);
                                  Select Scope_Identity();";

                    using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        if (TableID != -1)
                        {
                            command.Parameters.AddWithValue("@TableID", TableID);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@TableID", DBNull.Value);
                        }
                        if (FieldName != "")
                        {
                            command.Parameters.AddWithValue("@FieldName", FieldName);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@FieldName", DBNull.Value);
                        }

                        if (Label != "")
                        {
                            command.Parameters.AddWithValue("@Label", Label);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Label", DBNull.Value);
                        }
                        if (DataType != "")
                        {
                            command.Parameters.AddWithValue("@DataType", DataType);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@DataType", DBNull.Value);
                        }

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(),out int InsertedId))
                        {
                            FieldID = InsertedId;

                        }

                    }


                }


            }
            catch(Exception ex) { }

            return FieldID;

        }


       
        public static int AddNewFieldAndInitValues(int TableID, string FieldName, string Label, string DataType)
        {
            int FieldID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    connection.Open();

                    // 1) إضافة الفيلد الجديد
                    string queryField = @"
                INSERT INTO TableFields (TableID, FieldName, Label, DataType)
                VALUES (@TableID, @FieldName, @Label, @DataType);
                SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmdField = new SqlCommand(queryField, connection))
                    {
                        if (TableID != -1)
                        {
                            cmdField.Parameters.AddWithValue("@TableID", TableID);
                        }
                        else
                        {
                            cmdField.Parameters.AddWithValue("@TableID",DBNull.Value);
                        }
                        if (FieldName != "")
                        {
                            cmdField.Parameters.AddWithValue("@FieldName", FieldName);
                        }
                        else
                        {
                            cmdField.Parameters.AddWithValue("@FieldName", DBNull.Value);
                        }
                        if (Label != "")
                        {
                            cmdField.Parameters.AddWithValue("@Label", Label);
                        }
                        else
                        {
                            cmdField.Parameters.AddWithValue("@Label",DBNull.Value);
                        }
                        if (DataType != "")
                        {
                            cmdField.Parameters.AddWithValue("@DataType", DataType);
                        }
                        else
                        {
                            cmdField.Parameters.AddWithValue("@DataType", DBNull.Value);
                        }
                       
                        
                       
                        

                        object result = cmdField.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            FieldID = insertedID;
                        }
                    }

                    // إذا ما قدر يجيب FieldID → وقف
                    if (FieldID <= 0)
                        return -1;

                    // 2) إنشاء قيمة فارغة لكل Row موجود
                    string queryInitValues = @"
                INSERT INTO FieldValues (TableID, RowID, FieldID, Value)
                SELECT @TableID, R.RowID, @FieldID, NULL
                FROM TableRows R
                WHERE R.TableID = @TableID;";

                    using (SqlCommand cmdInit = new SqlCommand(queryInitValues, connection))
                    {
                        cmdInit.Parameters.AddWithValue("@TableID", TableID);
                        cmdInit.Parameters.AddWithValue("@FieldID", FieldID);

                        cmdInit.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // يفضل تسجيل الخطأ
            }

            return FieldID;
        }

        public static bool DeleteField(int FieldID)
        {
            int RowEffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = "EXEC DeleteFieldAndValues @FieldID =@@FieldID ";


                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query,connection))

                    {
                        command.Parameters.AddWithValue("@@FieldID", FieldID);

                        RowEffected = command.ExecuteNonQuery();



                    }


                }

            }
            catch(Exception ex)
            { return false; }

            return (RowEffected > 0);

        }

        public static bool UpdateFields(int FieldID, int TableID, string FieldName,  string Label, string DataType)
        {
            int RowEffecteed = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = @"Update TableFields  set                                   
                                      TableID = @TableID,
                                      FieldName = @FieldName,
                                       Label = @Label,
                                      DataType = @DataType
                                 where fieldsID = @fieldsID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@fieldsID", FieldID);
                        

                        if (TableID != -1)
                        {
                            command.Parameters.AddWithValue("@TableID", TableID);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@TableID", DBNull.Value);
                        }
                        if (FieldName != "")
                        {
                            command.Parameters.AddWithValue("@FieldName", FieldName);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@FieldName", DBNull.Value);
                        }
                        if (Label != "")
                        {
                            command.Parameters.AddWithValue("@Label", Label);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Label", DBNull.Value);
                        }
                        if (DataType != "")
                        {
                            command.Parameters.AddWithValue("@DataType", DataType);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@DataType", DBNull.Value);
                        }

                        RowEffecteed = command.ExecuteNonQuery();

                    }
                }


            }
            catch (Exception ex)
            {
                return false;
            }
            return (RowEffecteed > 0);
        }



    }


}
