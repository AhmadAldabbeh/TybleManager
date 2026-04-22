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

        private int _TableID = -1;
        private int _ValueID = -1;
        private clsFieldValues Valueinfo;

        public frmAdd_UpdateRows(int tableID)
        {
            InitializeComponent();
            _TableID = tableID;
            Mode = enMode.AddNew;
        }
        public frmAdd_UpdateRows(int tableID,int RowID)
        {
            InitializeComponent();
           
            _TableID = tableID;
            _RowID = RowID;
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
            txtValue.Text = "";
            lblTitel.Text = "Add New Row";

            if (Mode == enMode.AddNew)
            {

               

                Valueinfo = new clsFieldValues();
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


        private void _loadData()
        {
            

            lblTitel.Text = "Update Row";
            Valueinfo = clsFieldValues.Find(_ValueID);

            _TableID = Valueinfo.TableID;
            //_RowID = Valueinfo.TableRowID;
            
           
            //RowInfo = clsTableRows.Find(_RowID);

            comFieldName.SelectedItem = Valueinfo.TableFieldsinfo.FieldName;
            txtValue.Text = Valueinfo.Value;
          
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

            string FieldName = comFieldName.SelectedItem.ToString();
            clsFields fieldInfo = clsFields.Find(FieldName);

            if (fieldInfo == null)
            {
                return;
            }

            Valueinfo.TableID = _TableID;
            Valueinfo.TableFieldID = fieldInfo.FieldID;
            Valueinfo.Value = txtValue.Text.Trim();



            //if (_RowID == -1)
            //{
            //    RowInfo.TableID = clsGlobal.TableID;
            //    if (!RowInfo.Save())
            //    {
            //        return;
            //    }
            //    _RowID = RowInfo.RowID;
            //}
           

           
            //Valueinfo.TableRowID = _RowID;

            if (Valueinfo.Save())
            {
                Mode = enMode.Update;
                lblTitel.Text = "Update Row";
                MessageBox.Show("Data is Saved Successfully.", "Saved", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                //this.Close();
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
    }
}
