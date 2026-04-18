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
    public partial class Prompt : Form
    {

        public string NewName { get; set; }
        public Prompt()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NewName = txtPrompt.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Prompt_Load(object sender, EventArgs e)
        {
            txtPrompt.Text = "";
        }
    }
}
