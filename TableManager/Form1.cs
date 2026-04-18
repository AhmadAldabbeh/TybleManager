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
    }
}
