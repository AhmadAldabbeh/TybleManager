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

        public static bool GetRowByID(int RowID,ref int TableID)
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

        



    }


}
