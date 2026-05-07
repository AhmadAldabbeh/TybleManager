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

namespace TableManager
{
    public partial class frmUpdateDeleteCulomns : Form
    {
        private DataTable dt = new DataTable();

       
        private clsFields FieldsInfo;

        public int FieldID { get; set; }
        public frmUpdateDeleteCulomns()
        {
            InitializeComponent();

           
        }

        private void _LoadData()
        {

            dt = clsFields.GetAllFields();
  
            DGWCulumnsFrm.DataSource = dt;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateDeleteCulomns_Load(object sender, EventArgs e)
        {
            _LoadData();

        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            FieldID = Convert.ToInt32(DGWCulumnsFrm.CurrentRow.Cells[0].Value);
            FieldsInfo = clsFields.Find(FieldID);

            if (FieldsInfo == null)
            {
                return;
            }
            Prompt frmprompt = new Prompt();

            string NewName = "";
            if (frmprompt.ShowDialog() == DialogResult.OK)
            {
                NewName = frmprompt.NewName.Trim();
            }

            if (NewName == "")
            {
                return;
            }
            
            
            FieldsInfo.Label = NewName;
            if (FieldsInfo.Save())
            {
                MessageBox.Show("Data is Saved Successfully.", "Saved", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
              
            }
            else
            {
                MessageBox.Show("Data is not saved Successfully.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            _LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FieldID = Convert.ToInt32(DGWCulumnsFrm.CurrentRow.Cells[0].Value);
            FieldsInfo = clsFields.Find(FieldID);

            if (FieldsInfo == null)
            {
                return;
            }

           

            if (MessageBox.Show("are you sure do you want to Deleted ","Delete",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                FieldsInfo.DeleteField(FieldID);
                MessageBox.Show("Deleted Successfully.");
                _LoadData();
            }

        }

 
    }
}
