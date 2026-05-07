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
    public partial class frmDeleteFormula : Form
    {
        public frmDeleteFormula()
        {
            InitializeComponent();
        }

        private void frmDeleteFormula_Load(object sender, EventArgs e)
        {
            
            _LoadAllData(); 
        }

        private void _FillEmployeeName()
        {
            DataTable dt = clsEmployees.GetAllEmployeeNames();

            foreach (DataRow Row in dt.Rows)
            {
                comEmployeeName.Items.Add(Row[0].ToString());
            }


        }

        private void _LoadAllData()
        {
            _FillEmployeeName();




        }
        private void _FillData()
        {


            


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int _EmployeeID = -1;
            DateTime from = DateTime.Now;
            DateTime to = DateTime.Now;


            if (chWithEmployee.Checked && chWithRowName.Checked && chWithDate.Checked && chDeleteAll.Checked)
            {
                MessageBox.Show("");
            }


            if (chWithEmployee.Checked)
            {
                string EmployeeName = comEmployeeName.SelectedItem.ToString();

                _EmployeeID = clsEmployees.Find(EmployeeName).EmployeeID;


                chWithRowName.Checked = false;
                gbRowName.Enabled = false;

                chDeleteAll.Checked = false;
                gbDeleteALl.Enabled = false;

                if (chWithDate.Checked)
                {
                    from = DateForm1.Value;
                    to = DateTo1.Value;


                  
                        if (MessageBox.Show("Are you sure do you want to Deleted", "Delete ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (FlexibleFormulaDeleteService.DeleteByEmployeeAndDate(clsGlobal.TableID, _EmployeeID, from, to))
                            {
                                MessageBox.Show("Data is Deleted Successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Data is not Deleted Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                   
                   

                    


                }
                if (MessageBox.Show("Are you sure do you want to Delet", "Delete ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (FlexibleFormulaDeleteService.DeleteByEmployee(clsGlobal.TableID, _EmployeeID))
                    {
                        MessageBox.Show("Data is Deleted Successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Data is not Deleted Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

            }
            else
            {
                
            }
            if (chWithRowName.Checked)
            {
                chWithEmployee.Checked = false;
                gbEmployee.Enabled = false;
                chWithDate.Checked = false;
                gbDate.Enabled = false;
                chDeleteAll.Checked = false;
                gbDeleteALl.Enabled = false;


                string _RowName = txtRowName.Text.Trim();

                if (MessageBox.Show("Are you sure do you want to Delet", "Delete ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (FlexibleFormulaDeleteService.DeleteByRowName(clsGlobal.TableID, _RowName))
                    {
                        MessageBox.Show("Data is Deleted Successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Data is not Deleted Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

            }
            if (chWithDate.Checked)
            {
                from = DateForm1.Value;
                to = DateTo1.Value;


                if (MessageBox.Show("Are you sure do you want to Delet", "Delete ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (FlexibleFormulaDeleteService.DeleteByDateRange(clsGlobal.TableID, from, to)) 
                    {
                        MessageBox.Show("Data is Deleted Successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Data is not Deleted Successfully.Date is no in Range ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

            }
            if (chDeleteAll.Checked)
            {

                chWithDate.Checked = false;
                gbDate.Enabled = false;
                chWithEmployee.Checked = false;
                gbEmployee.Enabled = false;
                chWithRowName.Checked = false;
                gbRowName.Enabled = false;

                if (MessageBox.Show("Are you sure do you want to Delet", "Delete ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (FlexibleFormulaDeleteService.DeleteAllForTable(clsGlobal.TableID))
                    {
                        MessageBox.Show("Data is Deleted Successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Data is not Deleted Successfully.Date is no in Range ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }


        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chWithEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (chWithEmployee.Checked)
            {
                gbEmployee.Enabled = true;
            }
            else
            {
                gbEmployee.Enabled = false;
            }
        }

        private void chWithRowName_CheckedChanged(object sender, EventArgs e)
        {
            if (chWithRowName.Checked)
            {
                gbRowName.Enabled = true;
            }
            else
                gbRowName.Enabled = false;
        }

        private void chWithDate_CheckedChanged(object sender, EventArgs e)
        {
            if(chWithDate.Checked)
            {
                gbDate.Enabled = true;
            }
            else
                gbDate.Enabled = false;
        }

        private void chDeleteAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chDeleteAll.Checked)
            {
                gbDeleteALl.Enabled = true;
            }
            else
                gbDeleteALl.Enabled = false;
        }
    }
}
