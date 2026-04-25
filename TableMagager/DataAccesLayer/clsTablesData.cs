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
    public class clsTablesData
    {

        public static DataTable GetAllTables()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = "select * from Tables order by TablID";

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

        public static DataTable GetAllTablesName()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = "select TableName from Tables order by TablID";

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

        public static bool GetTableByID(int TableID,ref string TableName,ref int CreatedBy)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {

                    string query = "select * from Tables where TablID = @TablID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@TablID", TableID);

                        using (SqlDataReader reder = command.ExecuteReader())
                        {
                            if (reder.Read())
                            {
                                IsFound = true;
                                TableName = (string)reder["TableName"];
                                CreatedBy = (int)reder["CreatedbyEmployeeID"];

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

        public static bool GetTableByTableName(string TableName,ref int TableID , ref int CreatedBy)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {

                    string query = "select * from Tables where TableName = @TableName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@TableName", TableName);

                        using (SqlDataReader reder = command.ExecuteReader())
                        {
                            if (reder.Read())
                            {
                                IsFound = true;
                                CreatedBy = (int)reder["CreatedbyEmployeeID"];
                                TableID = (int)reder["TablID"];
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

        public static int AddNewTable(string TableName,int CreatedBy)
        {
            int TableID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = @"insert into Tables  (TableName,CreatedbyEmployeeID) Values (@TableName,@CreatedbyEmployeeID);
                                  Select Scope_Identity();";

                    using (SqlCommand comamnd = new SqlCommand(query,connection))
                    {

                       
                       

                        if (TableName != "")
                        {
                            comamnd.Parameters.AddWithValue("@TableName", TableName);
                        }
                        else
                        {
                            comamnd.Parameters.AddWithValue("@TableName", DBNull.Value);
                        }
                        if (CreatedBy != -1)
                        {
                            comamnd.Parameters.AddWithValue("@CreatedbyEmployeeID", CreatedBy);
                        }
                        else
                        {
                            comamnd.Parameters.AddWithValue("@CreatedbyEmployeeID", DBNull.Value);
                        }

                        connection.Open();

                        object Result = comamnd.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int Inserted))
                        {
                           TableID = Inserted;
                        }


                    }


                }
            }
            catch(Exception ex)  {     }

            return TableID;
        }

        public static bool DeleteTable(int TableID)
        {
            int RowEfected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = "Delete Tables where TablID = @TablID";

                    using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@TablID", TableID);

                        connection.Open();

                        RowEfected = command.ExecuteNonQuery();

                    }

                }

            }
            catch(Exception ex)
            {
                return false;
            }

            return (RowEfected > 0);
        }

        public static bool UpdateTables(int TableID, string TableName, int CreatedBy)
        {
            int RowEffecteed = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = @"Update TableRows  set                                   
                                      TableName = @TableName,
                               CreatedbyEmployeeID = @CreatedbyEmployeeID 
                                 where TablID = @TablID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@TablID", TableID);


                        if (TableName != "")
                        {
                            command.Parameters.AddWithValue("@TableName", TableName);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@TableName", DBNull.Value);
                        }
                        if (CreatedBy != -1)
                        {
                            command.Parameters.AddWithValue("@CreatedbyEmployeeID", CreatedBy);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@CreatedbyEmployeeID", DBNull.Value);
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
