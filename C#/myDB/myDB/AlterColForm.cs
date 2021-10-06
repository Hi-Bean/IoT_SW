using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myDB
{
    public partial class AlterColForm : Form
    {
        string ColName, strType;
        int strLen;

        public AlterColForm(string cName, string str = "", int size=10)
        {
            InitializeComponent();
            ColName = cName;
            strType = str;
            strLen = size;

            this.Text = $"{ColName} - Alter Column";
            cbType.Items.Add("nchar");
            cbType.Items.Add("varchar");
            cbType.Items.Add("nvarchar");
            cbType.Text = strType;
            tbMaxLen.Text = $"{strLen}";
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            
            //strType = cbType.Text;
            //strLen = int.Parse(tbMaxLen.Text);
            //if (rbtnNULLyes.Checked)
            //    strNullable = "YES";
            //else
            //    strNullable = "NO";
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            
        }
    }
}
