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
    public partial class frmFormula : Form
    {
        public frmFormula()
        {
            InitializeComponent();
        }

        private void frmFormula_Load(object sender, EventArgs e)
        {

        }





        private string _DataTypeName()
        {
            string DataType = "";

            switch (comDataType.SelectedItem.ToString())
            {
                case "Whole Number":
                    DataType = "int";
                    break;

                case "Small Number":
                    DataType = "short";
                    break;

                case "Decimal Number":
                    DataType = "float";
                    break;

                case "Precise Decimal":
                    DataType = "double";
                    break;

                case "Text":
                    DataType = "string";
                    break;

                case "Date & Time":
                    DataType = "DataTime";
                    break;

            }
            return DataType;
        }


    }
}
