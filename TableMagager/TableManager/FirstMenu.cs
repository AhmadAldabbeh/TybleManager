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
    public partial class FirstMenu : Form
    {
        public FirstMenu()
        {
            InitializeComponent();
        }


        private int _TableID = -1;
        private string _TableName = "";

        private clsTables _Tablesinfo;



        private void _LoadData()
        {
            DataTable dt = clsTables.GetAllTablesName();

            listBox1.Items.Clear();

            foreach (DataRow Row in dt.Rows)
            {
                listBox1.Items.Add(Row["TableName"].ToString());
            }

            

        }

        private void btnAddNewTable_Click(object sender, EventArgs e)
        {
            _Tablesinfo = new clsTables();

            string TabelName = "";

            Prompt frmprompt = new Prompt();

            if (frmprompt.DialogResult == DialogResult.OK)
            {
                TabelName = frmprompt.Name.Trim();
            }

            _Tablesinfo.TableName = TabelName;
            _Tablesinfo.CreatedByEmployee = clsGlobal.CreatedBYEmployeeId;
            if (_Tablesinfo.Save())
            {
                MessageBox.Show("Table is Added Successfully.","Saved",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Table is not Added Successfully ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            _TableName = listBox1.SelectedItems.ToString();

            _Tablesinfo = clsTables.Find(_TableName);

            string newTabelName = "";

            Prompt frmprompt = new Prompt();

            if (frmprompt.DialogResult == DialogResult.OK)
            {
                newTabelName = frmprompt.Name.Trim();
            }

            _Tablesinfo.TableName = newTabelName;
            _Tablesinfo.CreatedByEmployee = clsGlobal.CreatedBYEmployeeId;
            if (_Tablesinfo.Save())
            {
                MessageBox.Show("Table it has been Renamed Successfully.", "Saved", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Table it dos't been Renamed Successfully ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _TableName = listBox1.SelectedItems.ToString();

            _Tablesinfo = clsTables.Find(_TableName);

            if (MessageBox.Show("are you sure do you want to deleted ","Delete",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                if (_Tablesinfo.DeleteTable(_Tablesinfo.TableID))
                {
                    MessageBox.Show("Table is deleted Succesfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Table is not deleted Succesfully.", "Erroe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FirstMenu_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
