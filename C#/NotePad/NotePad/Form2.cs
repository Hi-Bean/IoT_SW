using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            cbStopbit.Items.Add("1");
            cbStopbit.Items.Add("2");
        }

        [DllImport("kernel32.dll")]
        static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder buf, int size, string Path);

        [DllImport("kernel32.dll")]
        static extern bool WritePrivateProfileString(string section, string key, string val, string Path);


        string inipath = ".\\NotePad.ini";   // .ini파일의 전체 경로
        private void Form2_Load(object sender, EventArgs e)
        {
            StringBuilder buf = new StringBuilder(500);


            GetPrivateProfileString("Form2", "LocationX", "0", buf, 500, inipath);
            int x = int.Parse(buf.ToString());

            GetPrivateProfileString("Form2", "LocationY", "0", buf, 500, inipath);
            int y = int.Parse(buf.ToString());

            Location = new Point(x, y);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            WritePrivateProfileString("Form2", "LocationX", $"{Location.X}", inipath);
            WritePrivateProfileString("Form2", "LocationY", $"{Location.Y}", inipath);
        }
    }
}
