using Microsoft.Win32;
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
    public  class clsEmployeeData
    {

        public static DataTable GetAllEmployees()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = "select * from Employee order by id";

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

        public static bool GetEmployeeByID(int ID, ref string Name,ref string PassWord)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = "select * from Employee where id = @id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id",ID);
                        connection.Open();


                        using (SqlDataReader reder = command.ExecuteReader())
                        {
                            if (reder.Read())
                            {
                                IsFound = true;

                                Name = (string)reder["Name"];
                                PassWord = (string)reder["PassWord"];

                            }
                            else
                            {
                                IsFound = false;
                            }

                        }

                    }


                }

            }
            catch (Exception ex)
            { return false; }

            return IsFound;
        }

        public static int AddNewEmployee(string Name,string PassWord)
        {
            int EmployeeID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = @"insert into Employee  (Name,PassWord) Values (@Name,@PassWord);
                                  Select Scope_Identity()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        if (Name != "")
                        {
                            command.Parameters.AddWithValue("@Name", Name);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Name", DBNull.Value);
                        }
                        if (PassWord != "")
                        {
                            command.Parameters.AddWithValue("@PassWord", PassWord);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@PassWord", DBNull.Value);
                        }

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedid))
                        {
                            EmployeeID = insertedid;
                        }

                    }


                }


            }
            catch (Exception ex)
            {
                return -1;
            }

            return EmployeeID;

        }

        public static bool DeleteEmployee(int EmployeeID)
        {
            int RowEffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = "delete Employee where id = @id";

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", EmployeeID);

                        RowEffected = command.ExecuteNonQuery();

                    }

                }


            }
            catch (Exception ex) { return false; }

            return (RowEffected > 0);
        }

        public static bool UpdateEmployee(int EmployeeID,string EmployeeName,string PassWord)
        {
            int RowEffecteed = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = @"Update Employee  set                                   
                                      Name = @Name,
                                      PassWord = @PassWord
                                 where id = @id";

                    using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@id", EmployeeID);
                        command.Parameters.AddWithValue("@Name", EmployeeName);

                        if (PassWord != "")
                        {
                            command.Parameters.AddWithValue("@PassWord", PassWord);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@PassWord", DBNull.Value);
                        }
                        RowEffecteed = command.ExecuteNonQuery();

                    }
                }


            }
            catch(Exception ex)
            {
                return false;
            }
            return (RowEffecteed > 0);
        }



    }
}
