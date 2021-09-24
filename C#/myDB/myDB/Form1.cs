using myLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            dbGrid.Columns.Add(tbInput.Text, tbInput.Text);
        }

        private void mnuColAdd_Click(object sender, EventArgs e)
        {
            string str = myClass.GetInput("컬럼명");
            dbGrid.Columns.Add(str,str);
        }

        private void popColAdd_Click(object sender, EventArgs e)
        {
            mnuColAdd_Click(sender, e);
            //string str = myClass.GetInput("컬럼명");
            //dbGrid.Columns.Add(str, str);
        }

        IniClass ini = new IniClass(".\\myDB.ini");
        private void Form1_Load(object sender, EventArgs e)
        {
            int x = int.Parse(ini.GetString("Position", "LocationX", "0"));
            int y = int.Parse(ini.GetString("Position", "LocationY", "0"));

            Location = new Point(x, y);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ini.WriteString("Position", "LocationX", $"{Location.X}");
            ini.WriteString("Position", "LocationY", $"{Location.Y}");
        }

        private void mnuRowAdd_Click(object sender, EventArgs e)
        {
            if(dbGrid.Columns.Count > 0)
                dbGrid.Rows.Add();
        }

        private void popRowAdd_Click(object sender, EventArgs e)
        {
            mnuRowAdd_Click(sender, e);
        }

        //public string filepath = "";
        //public string filename = "";
        private void mnuFileMigration_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dbGrid.Rows.Clear();
                dbGrid.Columns.Clear();
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                
                // col 이름 넣기
                string str = sr.ReadLine();
                string[] colValue = str.Split(',');
                
                for (int i = 0; i < colValue.Length; i++)
                {
                    dbGrid.Columns.Add(colValue[i], colValue[i]);
                }
                
                while (!sr.EndOfStream)
                {
                    str = sr.ReadLine();

                    //배열에 한줄을 읽어와 각 요소 저장
                    colValue = str.Split(',');

                    ////행에 데이터를 저장
                    //dbGrid.Rows.Add(colValue[0], colValue[1], colValue[2], colValue[3]);
                    
                    dbGrid.Rows.Add(colValue);            // 이것도 가능함

                    //int rIdx = dbGrid.Rows.Add();
                    //for(int i=0; i<colValue.Length; i++)
                    //{
                    //    dbGrid.Rows[rIdx].Cells[i].Value = colValue[i];
                    //}

                }

                sr.Close();
            }
        }
    }
}
