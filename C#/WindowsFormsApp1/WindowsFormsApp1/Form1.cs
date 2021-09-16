using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;
        private void btTest_Click(object sender, EventArgs e)
        {
            string str = "안녕하세요. 반갑습니다. 날씨 참 좋네요";

            tbTest.Text += str + " [" + i++ + "]\r\n";
        }

        private void btType_Click(object sender, EventArgs e)
        {
            string s1 = tbInput.Text;
            string s2 = cbType.Text;

            try
            {
                if (s2[0] == '1')    // int
                {
                    int n = int.Parse(s1);
                    tbTest.Text += "Int.Parse() 결과 : " + " [" + n + "]\r\n";
                }
                else if (s2[0] == '2')    // double
                {
                    double n = double.Parse(s1);
                    tbTest.Text += "double.Parse() 결과 : " + " [" + n + "]\r\n";
                }
                else if (s2[0] == '3')    // string
                {
                    tbTest.Text += "입력 string : " + " [" + s1 + "]\r\n";
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
    }
}
