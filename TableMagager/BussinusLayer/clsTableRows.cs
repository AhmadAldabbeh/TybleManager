using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinusLayer
{
    public class clsTableRows
    {
        public enum enMode { AddNew = 0,Update =1};
        public enMode Mode = enMode.AddNew;

        public int RowID { get; set; }

        public string Value {  get; set; }
        public int TableID { get; set; }
        public clsTables TableInfo;

       public clsTableRows()
        {
            this.RowID = -1;
            this.TableID = -1;

            Mode = enMode.AddNew;
        }
       public clsTableRows(int RowID,int TableID)
        {
            this.RowID = RowID;
            this.TableID = TableID;
            this.TableInfo = clsTables.Find(this.TableID);

            Mode = enMode.Update;

        }

        public static DataTable GetAllTableRows()
        {
            return clsTableRowsData.GetAllRows();
        }

        public static clsTableRows Find(int RowID)
        {
            int TableID = -1;

            if (clsTableRowsData.GetRowByID(RowID,ref TableID))
            {
                return new clsTableRows(RowID, TableID);
            }
            else
            {
                return null;
            }

        }


        private bool _AddNewTableRow()
        {
            this.RowID = clsTableRowsData.AddNewRow(this.TableID);
            return (this.RowID > -1);

        }

        private bool _UpdateTableRow()
        {
            return clsTableRowsData.UpdateTableRows(this.RowID, this.TableID);
        }

        

        public  bool DeleteTableRow(int TableID,int RowID)
        {
            return clsTableRowsData.DeleteRow(TableID,RowID);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTableRow())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    case enMode.Update:
                    return _UpdateTableRow();
            }
            return false;

        }

    }
}
