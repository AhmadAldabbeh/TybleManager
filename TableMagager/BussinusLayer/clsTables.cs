using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BussinusLayer
{
    public class clsTables
    {
        public enum enMode { Addnew =0,Update =1};
        public enMode Mode = enMode.Addnew;

        public int TableID {  get; set; }
        
        public string TableName {  get; set; }
        
        public int CreatedByEmployee {  get; set; }


      public  clsTables()
        {
            this.TableID = -1;
            this.TableName = "";
            this.CreatedByEmployee = -1;

            Mode = enMode.Addnew;
        }
       public clsTables(int tableID, string tableName, int createdByEmployee)
        {
           this. TableID = tableID;
           this. TableName = tableName;          
           this  .CreatedByEmployee = createdByEmployee;

            Mode = enMode.Update;
        }

        public static DataTable GEtAllTabls()
        {
            return clsTablesData.GetAllTables();

        }

        public static DataTable GetAllTablesName()
        {
            return clsTablesData.GetAllTablesName();

        }

        public static clsTables Find (int TableID)
        {
            string TableName ="";
            int Createdby = -1;

            if (clsTablesData.GetTableByID(TableID,ref TableName,ref Createdby))
            {
                return new clsTables(TableID, TableName, Createdby);
            }
            else
            {
                return null;
            }

        }

        public static clsTables Find(string TableName)
        {
            
            int Createdby = -1, TableID = -1;

            if (clsTablesData.GetTableByTableName(  TableName,ref TableID, ref Createdby))
            {
                return new clsTables(TableID, TableName, Createdby);
            }
            else
            {
                return null;
            }

        }

        private bool _AddNewTable()
        {
            this.TableID = clsTablesData.AddNewTable(this.TableName,this.CreatedByEmployee);
            return (this.TableID != -1);

        }

        private bool _UpdateTapls()
        {
            return clsTablesData.UpdateTables(this.TableID, this.TableName, this.CreatedByEmployee);
        }

        public bool DeleteTable(int TableID)
        {
            return clsTablesData.DeleteTable(TableID);
        }


        public bool Save()
        {
            switch(Mode)
            {
                case enMode.Addnew:
                    if (_AddNewTable())
                    {
                        Mode = enMode.Update;
                        return true;

                    }
                    else
                        return false;
                    case enMode.Update:
                    return _UpdateTapls();
            }
            return false;
        }



    }


}
