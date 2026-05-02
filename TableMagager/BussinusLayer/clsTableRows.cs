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
       public int FieldID {  get; set; }
        clsFields Fieldsinfo;
        public int RowID { get; set; }
        public int? EmployeeID { get; set; }
        public clsEmployees Employeeinfo;

        public int? _FieldID_EmployeeName { get; set; }

        public string Value {  get; set; }
        public int TableID { get; set; }
        public clsTables TableInfo;

       public clsTableRows()
        {
            this.RowID = -1;
            this.TableID = -1;
            this.EmployeeID = -1;
          

            Mode = enMode.AddNew;
        }
       public clsTableRows(int RowID,int TableID,int EmployeeID)
        {
            this.RowID = RowID;
            this.TableID = TableID; 
            this.EmployeeID = EmployeeID;
            
            this.TableInfo = clsTables.Find(this.TableID);
            

            Mode = enMode.Update;

        }

        public int? FieldID_EmployeeName(int FieldID)
        {
            return _FieldID_EmployeeName = FieldID;
        }
        public static DataTable GetAllTableRows()
        {
            return clsTableRowsData.GetAllRows();
        }

        public static clsTableRows Find(int RowID)
        {
            int TableID = -1, EmployeeID = -1;

            if (clsTableRowsData.GetRowByID(RowID,ref TableID,ref EmployeeID))
            {
                return new clsTableRows(RowID, TableID,EmployeeID);
            }
            else
            {
                return null;
            }

        }


        private bool _AddNewTableRow()
        {
            var result = clsTableRowsData.AddNewRow(
            this.TableID,
             this.EmployeeID,          // اختياري
             this._FieldID_EmployeeName // اختياري
                              );

            this.RowID = result.RowID;

            return (this.RowID > -1);
            

        }

        private bool _UpdateTableRow()
        {
            return clsTableRowsData.UpdateValue(this.RowID, this.FieldID,this.Value,this.EmployeeID);
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
