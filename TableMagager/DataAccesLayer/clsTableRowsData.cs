using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TableManager;

namespace DataAccesLayer
{
    public class clsTableRowsData
    {
        public static DataTable GetAllRows()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = "select * from TableRows order by RowID";

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

       


        public static bool GetRowByID(int RowID,ref int TableID,ref int EmployeeID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = "select * from TableRows where RowID = @RowID";

                    using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@RowID", RowID);
                        connection.Open();


                        using (SqlDataReader reder = command.ExecuteReader())
                        {
                            if (reder.Read())
                            {
                                IsFound = true;

                                TableID = (int)reder["TableID"];
                                if (reder["EmployeeID"] == DBNull.Value )
                                {
                                    EmployeeID = -1;
                                  
                                }
                                else
                                {
                                    EmployeeID = (int)reder["EmployeeID"];
                                }
                            }
                            else
                            {
                                IsFound = false;
                            }

                        }

                    }


                }

            }
            catch(Exception ex)
            { return false; }

            return IsFound;
        }

        public static int AddNewRow(int TableID)
        {
            int RowID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = @"insert into TableRows  (TableID) Values (@TableID);
                                  Select Scope_Identity()";

                    using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        connection.Open();

                        if (TableID != -1)
                        {
                            command.Parameters.AddWithValue("@TableID", TableID);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@TableID", DBNull.Value);
                        }

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(),out int insertedid))
                        {
                            RowID = insertedid;
                        }

                    }


                }


            }
            catch(Exception ex)
            {
                return -1;
            }

            return RowID;

        }

        public static bool DeleteRow(int TableID,int RowID)
        {
            

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    

                    connection.Open();
                    using (SqlCommand command = new SqlCommand("DeleteRowAndValues",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TableID", TableID);
                        command.Parameters.AddWithValue("@RowID", RowID);

                         command.ExecuteNonQuery();
                        return true;
                    }

                }


            }
            catch(Exception ex) { return false; }

           
        }

        public static bool UpdateTableRows(int RowID, int TableID)
        {
            int RowEffecteed = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = @"Update TableRows  set                                   
                                      TableID = @TableID        
                                 where RowID = @RowID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@RowID", RowID);


                        if (TableID != -1)
                        {
                            command.Parameters.AddWithValue("@TableID", TableID);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@TableID", DBNull.Value);
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

        public static bool AddNewRowWithValue(int TableID, int FieldID, string Value)
        {


            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    //string query = @"Exec AddNewRow @TableID ,@FieldID , @Value ";

                    using (SqlCommand command = new SqlCommand("AddNewRow", connection))
                    {
                        connection.Open();

                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TableID", TableID);
                        command.Parameters.AddWithValue("@FieldID", FieldID);

                        if (Value != "")
                        {
                            command.Parameters.AddWithValue("@Value", Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Value", DBNull.Value);
                        }

                        command.ExecuteNonQuery();

                        return true;
                    }



                }


            }
            catch (Exception ex)
            {
                return false;
            }


        }

        public static bool UpdateRowWithValues(int RowID, int FieldID, string Value)
        {


            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    //string query = @"Exec UpdateValueByRowID @RowID ,@FieldID ,@NewValue ;";

                    using (SqlCommand command = new SqlCommand("UpdateValueByRowID", connection))
                    {
                        connection.Open();

                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@RowID", RowID);
                        command.Parameters.AddWithValue("@FieldID", FieldID);


                        if (Value != "")
                        {
                            command.Parameters.AddWithValue("@NewValue", Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@NewValue", DBNull.Value);
                        }

                        command.ExecuteNonQuery();
                        return true;

                    }
                }


            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public static (int RowID, int EmployeeNameFieldID) AddNewRow(
           int tableID,
           int? employeeID = null,
           int? fieldID_EmployeeName = null)
        {

            int rowID = -1;
            int employeeNameFieldID = -1;
            try
            {

                using (SqlConnection conn = new SqlConnection(clsConnctionString.Connction))
                using (SqlCommand cmd = new SqlCommand("AddNewRow", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@TableID", tableID);

                    if (employeeID.HasValue)
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeID.Value);
                    else
                        cmd.Parameters.AddWithValue("@EmployeeID", DBNull.Value);

                    if (fieldID_EmployeeName.HasValue)
                        cmd.Parameters.AddWithValue("@FieldID_EmployeeName", fieldID_EmployeeName.Value);
                    else
                        cmd.Parameters.AddWithValue("@FieldID_EmployeeName", DBNull.Value);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                   

                    if (reader.Read())
                    {
                        rowID = reader.GetInt32(0);
                        employeeNameFieldID = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                    }

                   
                }

            }
            catch(Exception ex)
            {
                rowID = -1;
                employeeNameFieldID = -1;
            }

            return (rowID, employeeNameFieldID);
        }


        // ---------------------------------------------------------
        // UPDATE VALUE BY ROW ID
        // ---------------------------------------------------------
        public static bool UpdateValue(
            int rowID,
            int fieldID,
            string newValue,
            int? employeeID = null)
        {

            bool Updated = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsConnctionString.Connction))
                using (SqlCommand cmd = new SqlCommand("UpdateValueByRowID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@RowID", rowID);
                    cmd.Parameters.AddWithValue("@FieldID", fieldID);
                    cmd.Parameters.AddWithValue("@NewValue", newValue ?? (object)DBNull.Value);

                    if (employeeID.HasValue)
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeID.Value);
                    else
                        cmd.Parameters.AddWithValue("@EmployeeID", DBNull.Value);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Updated = true;
                }

            }
            catch (Exception ex) { Updated = false; }
           
            return Updated;
        }




    }


}
