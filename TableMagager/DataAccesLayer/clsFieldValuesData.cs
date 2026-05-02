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
    public class clsFieldValuesData
    {

        public static DataTable GetAllFieldsValue()
        {
            
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = "select * from FieldValues order by ValueID";

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

        public static DataTable GetRowValuesByRowID(int rowID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
            using (SqlCommand cmd = new SqlCommand("GetValuesByRowID", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RowID", rowID);

              
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                return dt;
            }
        }


        public static bool GetFieldValueByID(int ValueID, ref int TableID, ref int RowID, ref int FieldID, ref string Value)
        {
            bool Isfound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = "select * from FieldValues where ValueID = @ValueID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@ValueID", ValueID);

                        using (SqlDataReader reder = command.ExecuteReader())
                        {
                            if (reder.Read())
                            {
                                Isfound = true;

                                TableID = (int)reder["TableId"];
                                RowID = (int)reder["RowID"];
                                FieldID = (int)reder["FieldID"];
                                if (reder["Value"] == DBNull.Value)
                                {
                                    Value = "";
                                }
                                else
                                {
                                    Value = (string)reder["Value"];
                                }

                                
                            }
                            else
                            {
                                Isfound = false;
                            }

                        }


                    }


                }


            }
            catch (Exception ex)
            { Isfound = false; }

            return Isfound;

        }

        public static int GetValueByTableIDandRowIdandFieldID(int tableID, int rowID, int fieldID, string value)
        {
            int valueID = 0;

            try
            {
                using (SqlConnection  con = new SqlConnection(clsConnctionString.Connction))
                {
                    using (SqlCommand cmd = new SqlCommand("GetValueID", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@TableID", tableID);
                        cmd.Parameters.AddWithValue("@RowID", rowID);
                        cmd.Parameters.AddWithValue("@FieldID", fieldID);
                        cmd.Parameters.AddWithValue("@Value", value);

                        con.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                            valueID = insertedID;

                        

                    }


                }



            }
            catch (Exception ex) {  }

            return valueID;
        }
        public static int GetValueByTableIDandRowIdandFieldID(int tableID, int rowID, int fieldID)
        {
            int valueID = 0;

            try
            {
                using (SqlConnection con = new SqlConnection(clsConnctionString.Connction))
                {
                    using (SqlCommand cmd = new SqlCommand("GetValueID", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@TableID", tableID);
                        cmd.Parameters.AddWithValue("@RowID", rowID);
                        cmd.Parameters.AddWithValue("@FieldID", fieldID);
                      

                        con.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                            valueID = insertedID;



                    }


                }



            }
            catch (Exception ex) { }

            return valueID;
        }

       

        public static int AddNewFieldValue( int TableID, int RowID, int FieldID, string Value)
        {
            int ValueID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = @"insert into FieldValues (TableId,RowID,FieldID,Value) Values (@TableId,@RowID,@FieldID,@Value);
                                  Select Scope_Identity()";

                    using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        connection.Open();

                        if (TableID != -1)
                        {
                            command.Parameters.AddWithValue("@TableId", TableID);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@TableId", DBNull.Value);
                        }
                        if (RowID != -1)
                        {
                            command.Parameters.AddWithValue("@RowID", RowID);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@RowID", DBNull.Value);
                        }
                        if (FieldID != -1)
                        {
                            command.Parameters.AddWithValue("@FieldID", FieldID);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@FieldID", DBNull.Value);
                        }
                        if (Value != "")
                        {
                            command.Parameters.AddWithValue("@Value", Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Value", DBNull.Value);
                        }

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(),out int insertedID))
                        {
                            ValueID = insertedID;
                        }

                    }



                }


            }
            catch(Exception ex)
            {
                
            }
            return ValueID;

        }

        public static bool DeleteFieldValue(int ValueID)
        {
            int rowEffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = "delete from FieldValues where ValueID = @ValueID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@ValueID", ValueID);

                        rowEffected = command.ExecuteNonQuery();

                    }



                }


            }
            catch (Exception ex)
            { return false;  }

            return (rowEffected > 0);

        }

        public static bool UpdateFieldsValues(int ValueID, int TableID, int RowID, int FieldID, string Value)
        {
            int RowEffecteed = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = @"Update FieldValues  set                                   
                                      TableId = @TableId,
                                      RowID = @RowID,
                                       FieldID = @FieldID,
                                      Value = @Value
                                 where ValueID = @ValueID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@ValueID", ValueID);


                        if (TableID != -1)
                        {
                            command.Parameters.AddWithValue("@TableId", TableID);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@TableId", DBNull.Value);
                        }
                        if (RowID != -1)
                        {
                            command.Parameters.AddWithValue("@RowID", RowID);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@RowID", DBNull.Value);
                        }
                        if (FieldID != -1)
                        {
                            command.Parameters.AddWithValue("@FieldID", FieldID);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@FieldID", DBNull.Value);
                        }
                        if (Value != "")
                        {
                            command.Parameters.AddWithValue("@Value", Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Value", DBNull.Value);
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
