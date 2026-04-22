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

            if (DGWForm1.SelectedRows.Count != 0)
            {
                 RowID = Convert.ToInt32(DGWForm1.SelectedRows[0].Cells[0].Value); ;
               
            }


            frmAdd_UpdateRows frm = new frmAdd_UpdateRows(clsGlobal.TableID,RowID);
            frm.ShowDialog();
            Form1_Load(null, null);

        }

        private void DGWForm1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // إذا ضغطت على نفس الصف → شيل التحديد
            if (lastSelectedRow == e.RowIndex)
            {
                DGWForm1.ClearSelection();
                DGWForm1.CurrentCell = null; // مهم جداً
                lastSelectedRow = -1;
                return;
            }

            // تحديد الصف الجديد
            DGWForm1.ClearSelection();
            DGWForm1.Rows[e.RowIndex].Selected = true;
            lastSelectedRow = e.RowIndex;
        }
    }
}
