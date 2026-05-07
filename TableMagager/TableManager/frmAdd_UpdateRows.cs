using BussinusLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableManager
{
    public partial class frmAdd_UpdateRows : Form
    {
        public enum enMode {AddNew = 0, Update = 1}
        public enMode Mode = enMode.AddNew;

        private int _RowID = -1;
        private clsTableRows RowInfo;

        private int? _EmployeeID = null;

        private string _FieldName = "";
        private int _FieldID = -1;

        Dictionary<string, string> fieldValues = new Dictionary<string, string>();

        private int _TableID = -1;




        public frmAdd_UpdateRows(int tableID)
        {
            InitializeComponent();
            _TableID = tableID;
            Mode = enMode.AddNew;
        }
        public frmAdd_UpdateRows(int tableID,int RowID,string Fieldname)
        {
            InitializeComponent();
           
            _TableID = tableID;
            _RowID = RowID;
            _FieldName = Fieldname;
            if (_RowID != -1)
            {
                Mode = enMode.Update;
            }
            else if (_RowID == -1)
            {
                Mode = enMode.AddNew;
            }
           

        }

        private void _DefaultData()
        {
            _FillComboBoxFieldsName();
            _FillcomboBoxEmployeeName();
            txtValue.Text = "";
            lblTitel.Text = "Add New Row";

            if (Mode == enMode.AddNew)
            {               
                RowInfo = new clsTableRows();
               
            }
           

        }
        private void _FillComboBoxFieldsName()
        {
            DataTable dt = clsFields.GetAllLabelFields();

            foreach (DataRow Row in dt.Rows)
            {
                comFieldName.Items.Add(Row[0].ToString());
            }

        }

        private void _FillcomboBoxEmployeeName()
        {
            DataTable dt = clsEmployees.GetAllEmployeeNames();

            foreach (DataRow Row in dt.Rows)
            {
                comEmployeeName.Items.Add(Row[0].ToString());
            }

        }

        private void _loadData()
        {
           

            DataTable dt = clsFieldValues.GetRowValuesByRowID(_RowID);

            lblTitel.Text = "Update Row";

         
            _FieldID = clsFields.Find(_FieldName).FieldID;

         
            
            comFieldName.SelectedItem = _FieldName;

            foreach (DataRow Row in dt.Rows)
            {
                string Label = Row["Label"].ToString();
                string Value = Row["Value"].ToString();

            
                fieldValues[Label] = Value;
            }
            RowInfo = clsTableRows.Find(_RowID);
            RowInfo.RowID = _RowID;

            string selectedlabel = comFieldName.SelectedItem.ToString();

            if (fieldValues.ContainsKey(selectedlabel))
            {
                txtValue.Text = fieldValues[selectedlabel];
            }
            else
            {
                txtValue.Text = "";
            }

            lblFieldName.Enabled = true;
            comFieldName.Enabled = true;
            txtValue.Enabled = true;
            lblValue.Enabled = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some filds are not valide, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           

          
            if (chAddEmployee.Checked)
            {
                string FieldName = comFieldName.SelectedItem.ToString();
                clsFields fieldInfo = clsFields.Find(FieldName);

                _FieldID = fieldInfo.FieldID;
                RowInfo._FieldID_EmployeeName = _FieldID;

                string EmployeeName = comEmployeeName.SelectedItem.ToString();
                clsEmployees Employeeinfo = clsEmployees.Find(EmployeeName);
                _EmployeeID = Employeeinfo.EmployeeID;
            }
            else
            {
                _EmployeeID = null;
            }

            if (Mode == enMode.Update)
            {

                string FieldName = comFieldName.SelectedItem.ToString();
                clsFields fieldInfo = clsFields.Find(FieldName);

                RowInfo.FieldID = fieldInfo.FieldID;

                if (fieldInfo == null)
                {
                    return;
                }

                if (chAddEmployee.Checked)
                {
                    RowInfo.EmployeeID = _EmployeeID;
                }
       

                else if (fieldInfo.DataType == "DateTime")
                {
                    RowInfo.Value = Add_UpdateRowDatePicker.Value.ToShortDateString();

                }

                else
                {

                    RowInfo.EmployeeID = null;
                    RowInfo.Value = txtValue.Text.Trim();
                }
            }

            if (Mode == enMode.AddNew)
            {
                RowInfo.TableID = _TableID;
 
                if (chAddEmployee.Checked)
                {
                    RowInfo.EmployeeID = _EmployeeID;
                    RowInfo._FieldID_EmployeeName = _FieldID;

                }
                else
                {
                    RowInfo.EmployeeID = null;
                    RowInfo._FieldID_EmployeeName = null;
                }


            }


            if (RowInfo.Save())
            {
                _RowID = RowInfo.RowID;
                Mode = enMode.Update;
                comEmployeeName.SelectedIndex = -1;
                RowInfo.EmployeeID = null;
                chAddEmployee.Checked = false;
                lblTitel.Text = "Update Row";
                MessageBox.Show("Data is Saved Successfully.", "Saved", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
               
            }
            else
            {
                MessageBox.Show("Data is not Saved Successfully.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void frmAdd_UpdateRows_Load(object sender, EventArgs e)
        {
            _DefaultData();
            if (Mode == enMode.Update)
            {
                _loadData();
            }
        }

        private void comFieldName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comFieldName.Items.ToString()))
            {
                errorProvider1.SetError(comFieldName, "Plesase Enter a FieldName");

            }
            else
            {
                errorProvider1.SetError(comFieldName, null);
            }
        }

        private void comFieldName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedlabel = comFieldName.SelectedItem.ToString();

            if (selectedlabel == "Date")
            {
                txtValue.Visible= false;
                Add_UpdateRowDatePicker.Visible = true;
            }
            else
            {
                txtValue.Visible = true;
                Add_UpdateRowDatePicker.Visible = false;
            }

            if (fieldValues.ContainsKey(selectedlabel))
            {
                txtValue.Text = fieldValues[selectedlabel];
            }
            else
            {
                txtValue.Text = "";
            }

        }



        private void chAddEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (chAddEmployee.Checked)
            {
               
                if (Mode == enMode.AddNew)
                {
                    lblEmployeeName.Enabled = true;
                    comEmployeeName.Enabled = true;

                    lblFieldName.Enabled = true;
                    comFieldName.Enabled = true;
                }
                if (Mode == enMode.Update)
                {
                    lblEmployeeName.Enabled = true;
                    comEmployeeName.Enabled = true;

                    lblFieldName.Enabled = true;
                    comFieldName.Enabled = true;

                    txtValue.Enabled = false;
                    lblValue.Enabled = false;

                }


            }
            else
            {
              
                if (Mode == enMode.AddNew)
                {
                    lblFieldName.Enabled = false;
                    comFieldName.Enabled = false;

                    lblEmployeeName.Enabled = false;
                    comEmployeeName.Enabled = false;

                    txtValue.Enabled = false;
                    lblValue.Enabled = false;
                }
                if (Mode == enMode.Update)
                {
                    lblEmployeeName.Enabled = false;
                    comEmployeeName.Enabled = false;

                    lblFieldName.Enabled = true;
                    comFieldName.Enabled = true;
                    txtValue.Enabled = true;
                    lblValue.Enabled = true;
                }
               




            }
        }
    }
}
