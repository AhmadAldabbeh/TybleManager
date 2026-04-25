using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinusLayer
{
    public class clsFields
    {

        public enum enMode { AddNew = 0,Update  = 1};
        public enMode Mode = enMode.AddNew;

        public int FieldID {  get; set; }

        public int TableID { get; set; }
        public clsTables TableInfo;
        public string FieldName { get; set; }

        public string Label { get; set; }

        public string DataType { get; set; }


       public clsFields()
        {
            this.FieldID = -1;
            this.TableID = -1;
            this.FieldName = "";
            this.Label = "";
            this.DataType = "";
            Mode = enMode.AddNew;

        }

       public  clsFields(int fieldID,int tableId,string FieldName,string Label,string DataType)
        {
            this.FieldID =fieldID;
            this.TableID =tableId;
            this.TableInfo = clsTables.Find(this.TableID);
            this.FieldName =FieldName;
            this.Label =Label;
            this.DataType =DataType;

            Mode = enMode.Update;
        }

        public static DataTable GetAllFields()
        {
            return clsFieldsData.GetAllFields();
        }

        public static DataTable GetAllLabelFields()
        {
            return clsFieldsData.GetAllLabelFields();
        }

        public static  clsFields Find(int FieldId)
        {
            int TableID = -1;
            string FieldName = "", Label = "", DataType = "";

            if (clsFieldsData.GetFieldByID(FieldId,ref TableID,ref FieldName,ref Label,ref DataType))
            {
                return new clsFields(FieldId, TableID, FieldName, Label, DataType);
            }
            else
            {
                return null;
            }

        }
        public static clsFields Find(string FieldName)
        {
            int TableID = -1, FieldId = -1;
            string  Label = "", DataType = "";

            if (clsFieldsData.GetFieldByName(FieldName,ref FieldId, ref TableID, ref Label, ref DataType))
            {
                return new clsFields(FieldId, TableID, FieldName, Label, DataType);
            }
            else
            {
                return null;
            }

        }

        private bool _AddNewField()
        {
            this.FieldID = clsFieldsData.AddNewField(this.TableID, this.FieldName, this.Label, this.DataType);

            return (this.FieldID > -1);
        }

        private bool _AddNewFieldandInitValue()
        {
            this.FieldID = clsFieldsData.AddNewFieldAndInitValues(this.TableID, this.FieldName, this.Label, this.DataType);

            return (this.FieldID > -1);
        }

        private bool _UpdateField()
        {
            return clsFieldsData.UpdateFields(this.FieldID, this.TableID, this.FieldName, this.Label, this.DataType);
        }

        public  bool DeleteField(int FieldID)
        {
            return clsFieldsData.DeleteField(FieldID);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if (_AddNewFieldandInitValue())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    case enMode.Update:
                    return _UpdateField();

            }
            return false;

        }


    }


}
