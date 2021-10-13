using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace myLibrary
{
    public partial class frmInput: Form     // UserControl or Form etc.
    {
        public frmInput()
        {
            InitializeComponent();
        }

        public frmInput(string str)
        {
            InitializeComponent();
            Prompt.Text = str;
            Prompt.Visible = true;
        }

        public string callTest2str = "";
        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)        // [enter] key - 입력된 값을 반환, dialog close
            {
                callTest2str = tbInput.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

    }
}
