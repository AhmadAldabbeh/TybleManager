using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinusLayer
{
    public class clsEmployees
    {
        public enum enMode { AddNew =0,Update =1};
        public enMode Mode = enMode.AddNew;


        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string PassWord { get; set; }

        clsEmployees()
        {
            this.EmployeeID = -1;
            this.EmployeeName = "";
            this.PassWord = "";

            Mode = enMode.AddNew;
        }
        clsEmployees(int ID,string Name,string PassWord)
        {
            this.EmployeeID = ID;
            this.EmployeeName = Name;
            this.PassWord = PassWord;

            Mode = enMode.Update;
        }

        public static DataTable GetAllEmployees()
        {
            return clsEmployeeData.GetAllEmployees();
        }

        public clsEmployees Find(int EmployeeID)
        {
            string EmployeeName = "", PassWord = "";

            if (clsEmployeeData.GetEmployeeByID(EmployeeID,ref EmployeeName,ref PassWord))
            {
                return new clsEmployees(EmployeeID, EmployeeName, PassWord);
            }
            else
            {
                return null;
            }

        }

        private bool _AddNewEmployee()
        {
            this.EmployeeID = clsEmployeeData.AddNewEmployee(this.EmployeeName, this.PassWord);
            return (this.EmployeeID > 0);
        }

        private bool _UpdateEmployee()
        {
            return clsEmployeeData.UpdateEmployee(this.EmployeeID, this.EmployeeName, this.PassWord);
        }

        public bool DeleteEmployee(int EmployeeID)
        {
            return clsEmployeeData.DeleteEmployee(EmployeeID);

        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if (_AddNewEmployee())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    case enMode.Update:
                    return _UpdateEmployee();
            }
            return false;

        }


    }

}
