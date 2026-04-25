using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TableManager;


namespace DataAccesLayer
{
    public class clsTableManagerData
    {

       




        public static DataTable GetFullFormTable (int TableID)
        {
            DataTable dt = new DataTable ();

            try
            {
                using (SqlConnection connation = new SqlConnection(clsConnctionString.Connction))
                {
                    string query = "EXEC GetFullDynamicTable_WithID @TableID = @@TableID";

                    using (SqlCommand command = new SqlCommand(query,connation))
                    {
                        connation.Open();

                        command.Parameters.AddWithValue("@@TableID", TableID);
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
            catch(Exception ex)
            {

            }
            return dt;


        }


       


    }
}
