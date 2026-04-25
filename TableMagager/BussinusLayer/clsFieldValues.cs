using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BussinusLayer
{
    public class clsFieldValues
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ValueID { get; set; }

        public int TableID { get; set; }
        public clsTables TableInfo;
        public int TableRowID { get; set; }
        public clsTableRows TAbleRowInfo;

        public int TableFieldID { get; set; }
        public clsFields TableFieldsinfo;

        public string Value { get; set; }


       public clsFieldValues()
        {
            this.ValueID = -1;
            this.TableID = -1;
            this.TableRowID = -1;
            this.TableFieldID = -1;
            this.Value = "";

            Mode = enMode.AddNew;

        }

       public clsFieldValues(int ValueID, int tableId, int RowID, int  FieldId, string value)
        {
         this.ValueID =ValueID;
            this.TableID =tableId;
            this.TableInfo = clsTables.Find(this.TableID);
            this.TableRowID =RowID;
            this.TAbleRowInfo = clsTableRows.Find(this.TableRowID);
            this.TableFieldID=FieldId;
            this.TableFieldsinfo = clsFields.Find(this.TableFieldID);
            this.Value =value;


            Mode = enMode.Update;
        }


        public static DataTable GetAllFieldValues()
        {
            return clsFieldsData.GetAllFields();

        }

        public static int GetValueIDByRowID(int tableID, int rowID, int fieldID, string value)
        {
            return clsFieldValuesData.GetValueByTableIDandRowIdandFieldID(tableID,rowID,fieldID,value);
        }
        public static int GetValueIDByRowID(int tableID, int rowID, int fieldID)
        {
            return clsFieldValuesData.GetValueByTableIDandRowIdandFieldID(tableID, rowID, fieldID);
        }

        public static DataTable GetRowValuesByRowID(int RowID)
        {
            return clsFieldValuesData.GetRowValuesByRowID(RowID);

        }

        public static clsFieldValues Find (int ValueID)
        {
            int TableID = -1, RowID = -1, FieldID = -1;
            string Value = "";

            if (clsFieldValuesData.GetFieldValueByID(ValueID,ref TableID,ref RowID,ref FieldID,ref Value))
            {
                return new clsFieldValues(ValueID, TableID, RowID, FieldID, Value);
            }
            else
            {
                return null;
            }

        }

        private bool _AddNewFieldValue()
        {
            this.ValueID = clsFieldValuesData.AddNewFieldValue(this.TableID, this.TableRowID, this.TableFieldID, this.Value);
            return (this.ValueID > -1);
        }

        private bool _AddNewRowFullWithValue()
        {
           return clsFieldValuesData.AddNewRowWithValue(this.TableID, this.TableFieldID, this.Value);
            
        }
        private bool _UpdateFieldsValue()
        {
            return clsFieldValuesData.UpdateFieldsValues(this.ValueID, this.TableID, this.TableRowID, this.TableFieldID, this.Value);
        }

        private bool _UpdateRowByRowID()
        {
            return clsFieldValuesData.UpdateRowWithValues(this.TableRowID, this.TableFieldID, this.Value);
        }

        public bool DeleteFieldValue(int ValueID)
        {
            return clsFieldValuesData.DeleteFieldValue(ValueID);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRowFullWithValue())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                    case enMode.Update:
                    return _UpdateRowByRowID();
            }
            return false;

        }

    }


}
