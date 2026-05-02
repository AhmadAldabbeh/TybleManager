using BussinusLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableManager
{
    public partial class frmFormula : Form
    {
        private DataTable dt = new DataTable();

        private int _TableID = -1;
        private int _FieldID_1 = -1;
        private int?  _FieldID_2 = null;
        private int ? _EmployeeID = null;

        private string _OperationType = "";
        private string _FormularText = "";

        private bool _monthly = false;
        private bool _aouto_monthly = false;
        private bool _aouto_Weekly = false;
        private bool _aouto_yearly = false;

        private DateTime? _SpecificDate = null;
        private DateTime? _FromDate = null;
        private DateTime? _ToDate = null;


        public frmFormula()
        {
            InitializeComponent();
        }

        private void frmFormula_Load(object sender, EventArgs e)
        {
            _ResetValue();

            _DefaultData();
        }

        private void _DefaultData()
        {
            

            dt = clsFormula.GetFormulasViewByTable(clsGlobal.TableID);

            DGWFormula.DataSource = dt;

            DGWFormula.Columns[0].HeaderText = "Formula ID";
            DGWFormula.Columns[0].Width = 85;

            DGWFormula.Columns[1].HeaderText = " RowName ";
            DGWFormula.Columns[1].Width = 250;

            DGWFormula.Columns[2].HeaderText = " FormulaText ";
            DGWFormula.Columns[2].Width = 240;

            DGWFormula.Columns[3].HeaderText = " ResultValue ";
            DGWFormula.Columns[3].Width = 100;

            DGWFormula.Columns[4].HeaderText = " From Date";
            DGWFormula.Columns[4].Width = 85;

            DGWFormula.Columns[5].HeaderText = " To Date ";
            DGWFormula.Columns[5].Width = 80;

            DGWFormula.Columns[6].HeaderText = " EmployeeName ";
            DGWFormula.Columns[6].Width = 90;

            _FillComboboxFields(comColumnName1);
            _FillComboboxFields(comColumnName2);
            _FillEmployeeName();
          
        }

        private void _FillComboboxFields(ComboBox combField)
        {
            DataTable dt = clsFields.GetAllLabelFields();

            foreach (DataRow Row in dt.Rows)
            {
                combField.Items.Add(Row[0].ToString());
            }


        }
        private void _FillEmployeeName()
        {
            DataTable dt = clsEmployees.GetAllEmployeeNames();

            foreach (DataRow Row in dt.Rows)
            {
                comEmployeeName.Items.Add(Row[0].ToString());
            }

        }

        private string _OperationTaype()
        {
            string OperationType = "";

            switch(comTypeOfMath.SelectedItem.ToString())
            {
                case "+":
                    OperationType = "+";
                    break;
                    case "-":
                    OperationType = "-";
                    break;
                    case "*":
                    OperationType = "*";
                    break;
                    case "/":
                    OperationType = "/";
                    break;
                case "SUM":
                    OperationType = "SUM";
                    break;
                case "AVG":
                    OperationType = "AVG";
                     break;
                case "MIN":
                    OperationType = "MIN";
                    break;
                case "MAX":
                    OperationType = "MAX";
                    break;
                case "ROUND":
                    OperationType = "ROUND";
                    break;


            }

            return OperationType;

        }


        private string _DataTypeName()
        {
            string DataType = "";

            switch (comDataType.SelectedItem.ToString())
            {
                case "Whole Number":
                    DataType = "int";
                    break;

                case "Small Number":
                    DataType = "short";
                    break;

                case "Decimal Number":
                    DataType = "float";
                    break;

                case "Precise Decimal":
                    DataType = "double";
                    break;

                case "Text":
                    DataType = "string";
                    break;

                case "Date & Time":
                    DataType = "DataTime";
                    break;

            }
            return DataType;
        }

        private void _ResetValue()
        {
            txtColumnName.Text = "";
            comDataType.SelectedIndex = -1;
            comColumnName1.SelectedIndex = -1;
            comColumnName2.SelectedIndex = -1;
            comTypeOfMath.SelectedIndex = -1;
            comEmployeeName.SelectedIndex = -1;
            chWithDateInfo.Checked = false;
          chAuto_Monthly.Checked = false;
            chAuto_Weekly.Checked = false;
            chAuto_Yearly.Checked = false;
            chkSpecificDate.Checked = false;
            chkFrom.Checked = false;
            chkTo.Checked = false;
            DateForm1.Value = DateTime.Now;
            DateTo1.Value = DateTime.Now;
            DateSpecific.Value = DateTime.Now;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void chWithDateInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (chWithDateInfo.Checked)
            {
                gbDAteInfo.Enabled = true;
            }
            else
            {
                gbDAteInfo.Enabled = false;
            }
        }


        public  double? CalculateFromula(
     int tableID,
     int fieldID1,
     int? fieldID2,
     string operationType,
     string formulaText,
     int? employeeID,
     bool monthly,
     bool autoMonthly,
     bool autoWeekly,
     bool autoYearly,
     DateTime? specificDate,
     DateTime? fromDate,
     DateTime? toDate)
        {
            try
            {
                // التحقق من العملية الرياضية
                bool isTwoFieldsOperation =
                    operationType == "+" ||
                    operationType == "-" ||
                    operationType == "*" ||
                    operationType == "/";

                bool isSingleFieldOperation =
                    operationType == "SUM" ||
                    operationType == "AVG" ||
                    operationType == "MIN" ||
                    operationType == "MAX" ||
                    operationType == "ROUND";

                // 1) AUTO MODES
                if (autoMonthly)
                    return clsFlexibleFormula.CalculateAutoMonthly(tableID, fieldID1, operationType, formulaText, employeeID);

                if (autoWeekly)
                    return clsFlexibleFormula.CalculateAutoWeekly(tableID, fieldID1, operationType, formulaText, employeeID);

                if (autoYearly)
                    return clsFlexibleFormula.CalculateAutoYearly(tableID, fieldID1, operationType, formulaText, employeeID);

                // 2) Specific Date
                if (specificDate.HasValue)
                    return clsFlexibleFormula.CalculateSpecificDate(tableID, fieldID1, operationType, formulaText, specificDate.Value, employeeID);

                // 3) Monthly
                if (monthly)
                {
                    if (!fromDate.HasValue)
                        throw new Exception("يجب تحديد FromDate عند اختيار Monthly");

                    return clsFlexibleFormula.CalculateMonthly(tableID, fieldID1, operationType, formulaText, fromDate.Value, employeeID);
                }

                // 4) Two Fields Operation
                if (isTwoFieldsOperation)
                {
                    if (!fieldID2.HasValue)
                        throw new Exception("العملية تتطلب FieldID2");

                    return clsFlexibleFormula.CalculateTwoFields(tableID, fieldID1, fieldID2.Value, operationType, formulaText, fromDate, toDate, employeeID);
                }

                // 5) Field + Employee
                if (employeeID.HasValue)
                    return clsFlexibleFormula.CalculateFieldForEmployee(tableID, fieldID1, operationType, formulaText, employeeID.Value, fromDate, toDate);

                // 6) Single Field Operation
                if (isSingleFieldOperation)
                    return clsFlexibleFormula.CalculateSingleField(tableID, fieldID1, operationType, formulaText, fromDate, toDate);

                throw new Exception("لم يتم التعرف على نوع العملية الحسابية");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private bool IsCalculated()
        {
            return (CalculateFromula(this._TableID, this._FieldID_1, this._FieldID_2, this._OperationType,
               this._FormularText, this._EmployeeID, this._monthly, this._aouto_monthly, this._aouto_Weekly,
               this._aouto_yearly, this._SpecificDate, this._FromDate, this._ToDate) > -1);

        }


        private void _FillDataFromForm()
        {
            int TableID = clsGlobal.TableID;
            int fieldID1 = -1;

          

            if (comColumnName1.SelectedItem != null)
            {
                string fieldName = comColumnName1.SelectedItem?.ToString();

                var field = clsFields.Find(fieldName);
                if (field != null)
                {
                    fieldID1 = field.FieldID;
                }

            }



           
            int? fieldID2 = null;
            if (comColumnName2.SelectedItem != null)
            {
                string field2 = comColumnName2.SelectedItem?.ToString();

                var field = clsFields.Find(field2);
                if (field != null)
                {
                    fieldID2 = field.FieldID;
                }

            }
            else
            {

            }


                string OperationType = _OperationTaype();
            string NewColumnName = txtColumnName.Text.Trim();
            string ColumnDataType = _DataTypeName();

            string FormulaText;

            if (fieldID2 != null)
            {
                // عملية بين فيلدين
                FormulaText = $"(Field{fieldID1} {OperationType} Field{fieldID2})";
            }
            else
            {
                // عملية فيلد واحد
                FormulaText = $"{OperationType}(Field{fieldID1})";
            }



            int? EmployeeID = null;
            if (comEmployeeName.SelectedItem != null)
            {
                string EmployeeName = comEmployeeName.SelectedItem.ToString();

                var emp = clsEmployees.Find(EmployeeName);
                if (emp != null)
                {
                    EmployeeID = emp.EmployeeID;
                }

            }

            
            bool monthly = chMonthly.Checked;
            bool autoMonthly = chAuto_Monthly.Checked;
            bool autoWeekly = chAuto_Weekly.Checked;
            bool autoYearly = chAuto_Yearly.Checked;


            DateTime? specificDate = chkSpecificDate.Checked
            ? DateSpecific.Value
            : (DateTime?)null;

            DateTime? fromDate = chkFrom.Checked
                ? DateForm1.Value
                : (DateTime?)null;

            DateTime? toDate = chkTo.Checked
                ? DateTo1.Value
                : (DateTime?)null;


            _TableID = TableID;
            _FieldID_1 = fieldID1;
            _FieldID_2 = fieldID2;
            _OperationType = OperationType;
            _FormularText = FormulaText;
            _monthly = monthly;
            _aouto_monthly = autoMonthly;
            _aouto_Weekly = autoWeekly;
            _aouto_yearly = autoYearly;
            _SpecificDate = specificDate;
            _FromDate = fromDate;
            _ToDate = toDate;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillDataFromForm();


            if (IsCalculated())
            {
                MessageBox.Show("Data is Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetValue();

            }
            else
            {
                MessageBox.Show("Data is not Saved Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       
    }
}
