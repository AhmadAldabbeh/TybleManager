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
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        private int lastSelectedRow = -1;

        private int lastClickedRow = -1;
        private int lastClickedColumn = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            _FillDataGridView();
        }

        private void _FillDataGridView()
        {
            //dt.Load(clsTableBussinus.GetAllTableDataWith_ID(1));
           
            DGWForm1.DataSource = clsTableBussinus.GetAllTableDataWith_ID(1);

            DGWForm1.ClearSelection();
        }

        private void addCulomnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCulomns frm = new frmAddCulomns(1);
            frm.ShowDialog();

            Form1_Load(null, null);
        }

        private void deleteCulomnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateDeleteCulomns frm = new frmUpdateDeleteCulomns();
            frm.ShowDialog();
            Form1_Load(null, null);
        }

        private void addRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int RowID = -1;
            string FieldName = "";

            if (DGWForm1.CurrentCell != null)
            {
                if (lastClickedRow != -1 && lastClickedColumn != -1)
                {
                    RowID = Convert.ToInt32(DGWForm1.Rows[lastClickedRow].Cells[0].Value);
                    FieldName = DGWForm1.Columns[lastClickedColumn].HeaderText;
                }
            }
            if (FieldName == "ID_R")
            {
                RowID = -1;
                FieldName = "";
            }




            frmAdd_UpdateRows frm = new frmAdd_UpdateRows(clsGlobal.TableID,RowID,FieldName);
            frm.ShowDialog();
            Form1_Load(null, null);

        }

        private void DGWForm1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
 
            if (e.RowIndex < 0) return;

            if (lastSelectedRow == e.RowIndex)
            {
                DGWForm1.ClearSelection();
                DGWForm1.CurrentCell = null;
                lastSelectedRow = -1;
                return;
            }

            lastSelectedRow = e.RowIndex;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = DGWForm1.HitTest(e.X, e.Y);

            DGWForm1.ClearSelection();
            if (hit.RowIndex >= 0 && hit.ColumnIndex >= 0)
            {
                lastClickedRow = hit.RowIndex;
                lastClickedColumn = hit.ColumnIndex;
            }
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int _RowID = Convert.ToInt32(DGWForm1.CurrentRow.Cells[0].Value);
            clsTableRows RowInfo = clsTableRows.Find(_RowID);

            if (MessageBox.Show("are you sure do you want to deleted ", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (RowInfo.DeleteTableRow(clsGlobal.TableID,_RowID))
                {
                    MessageBox.Show("Table is deleted Succesfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Table is not deleted Succesfully.", "Erroe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Form1_Load(null, null);
        }

        private void mathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFormula frm = new frmFormula();
            frm.ShowDialog();
            Form1_Load(null, null);
        }
    }
}
