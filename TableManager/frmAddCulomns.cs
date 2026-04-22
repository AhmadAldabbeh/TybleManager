using BussinusLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TableManager
{
    public partial class frmAddCulomns : Form
    {
        private int _TableID = -1;
        private int _FieldsID = -1;
        private clsFields FieldsInfo;

        public enum enMode { AddNew =0,Update = 1};
        public enMode Mode = enMode.AddNew;

        public frmAddCulomns()
        {
            InitializeComponent();
            Mode = enMode.AddNew;   

        }
        public frmAddCulomns(int TableID)
        {
            InitializeComponent();

            _TableID = TableID;
          
       
        }

        private void _DefaultData()
        {
            if (  Mode == enMode.AddNew)
            {
                FieldsInfo = new clsFields();
            }
            txtColumnsName.Text = "";

            comColumnsType.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some filds are not valide, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
                
            FieldsInfo.TableID = _TableID;
            FieldsInfo.FieldName = txtColumnsName.Text.Trim();
            FieldsInfo.Label = txtColumnsName.Text.Trim();
          

                string DataType = comColumnsType.SelectedItem.ToString();
            FieldsInfo.DataType = DataType;

                if (FieldsInfo.Save())
                {
                    MessageBox.Show("Data is Saved Successfully.","Saved",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                   this.Close();
                }
                else
                {
                    MessageBox.Show("Data is not Saved Successfully.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            

        }
     

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddCulomns_Load(object sender, EventArgs e)
        {
            _DefaultData();
        
        }

        private void comColumnsType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comColumnsType.Items.ToString().Trim()))
            {
                errorProvider1.SetError(comColumnsType,"Please Enter the Type of Columns");
            }
            else
            {
                errorProvider1.SetError(comColumnsType, null);
            }
        }

        private void txtColumnsName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtColumnsName.Text.Trim()))
            {
                errorProvider1.SetError(txtColumnsName, "Please Enter the Name of the Column");
            }
            else
            {
                errorProvider1.SetError(txtColumnsName, null);
            }
        }
    }
}
