using myLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            dbGrid.Columns.Add(tbMemo.Text, tbMemo.Text);
        }

        private void mnuColAdd_Click(object sender, EventArgs e)
        {
            string str = myClass.GetInput("컬럼명");
            dbGrid.Columns.Add(str, str);
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
            if (dbGrid.Columns.Count > 0)
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

        SqlConnection sqlConn = new SqlConnection();
        SqlCommand sqlCmd = new SqlCommand();
        string ConnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Source\Repos\IoT225\C#\myDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        string CurrentTable = "";
        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            bool vn = openFileDialog.ValidateNames;
            try
            {
                openFileDialog.ValidateNames = false;
                if (openFileDialog.ShowDialog() != DialogResult.OK) return;

                string[] sArr = ConnString.Split(';');
                ConnString = $"{sArr[0]};{sArr[1].Replace(sArr[1].Split('=')[1], openFileDialog.FileName)};{sArr[2]};{sArr[3]}";
                //sArr[1] = "AttachDbFilename=" + openFileDialog.FileName;
                //ConnString = "";
                //for (int i = 0; i < sArr.Length; i++)
                //{
                //    ConnString += sArr[i];
                //    ConnString += ';';
                //}

                sqlConn.ConnectionString = ConnString;
                sqlConn.Open();
                sqlCmd.Connection = sqlConn;

                sbLabel1.Text = openFileDialog.SafeFileName; // file name only
                sbLabel1.BackColor = Color.Aqua;

                DataTable dt = sqlConn.GetSchema("Tables");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sbLabel2.DropDownItems.Add(dt.Rows[i].ItemArray[2].ToString());
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                openFileDialog.ValidateNames = vn;
            }
        }

        private void sbLabel2_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            sbLabel2.Text = e.ClickedItem.Text;
            RunSQL($"select * from {e.ClickedItem.Text}");
        }
        char[] ca = { ' ', '\t', '\r', '\n' };  // white space array
        public int RunSQL(string sql)
        {
            //sqlCmd.CommandText = $"select * from {e.ClickedItem.Text}";
            sqlCmd.CommandText = sql;
            string sqlStr = sql.Trim().Split(' ')[0];
            if (sqlStr.ToLower() == "select")
            {
                int n1 = sql.ToLower().IndexOf("from");
                string s1 = sql.Substring(n1 + 4).Trim();
                CurrentTable = s1.Split(ca)[0];
                sbLabel2.Text = CurrentTable;

                SqlDataReader sdr = sqlCmd.ExecuteReader();     // return값이 있어 출력
                dbGrid.Rows.Clear();
                dbGrid.Columns.Clear();
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    string s = sdr.GetName(i);
                    dbGrid.Columns.Add(s, s);
                }
                for (int i = 0; sdr.Read(); i++)
                {
                    int rIdx = dbGrid.Rows.Add();
                    for (int j = 0; j < sdr.FieldCount; j++)
                    {
                        object obj = sdr.GetValue(j);
                        dbGrid.Rows[rIdx].Cells[j].Value = obj;
                    }
                }
                sdr.Close();

                
                return 0;
            }
            else
            {
                return sqlCmd.ExecuteNonQuery();           // return 값이 없는 경우
            }
        }

        private void mnuSqlExecute_Click(object sender, EventArgs e)
        {
            RunSQL(tbMemo.Text);
        }

        
        private void tbMemo_KeyDown(object sender, KeyEventArgs e)
        {
            // shift + enter
            if (e.Shift && e.KeyCode == Keys.Enter)
            {
                mnuSqlExecute_Click(sender, e);
            }
            
        }

        // 선택 구문 sql 실행
        private void popSelectedExecute_Click(object sender, EventArgs e)
        {
            RunSQL(tbMemo.SelectedText);
        }

        private void popUpdate_Click(object sender, EventArgs e)
        {
            //update [table] set [col=value, , ,] where [option]
            int x = dbGrid.SelectedCells[0].ColumnIndex;
            int y = dbGrid.SelectedCells[0].RowIndex;
            string s1 = dbGrid.Columns[x].HeaderText;
            object s2 = dbGrid.SelectedCells[0].Value;
            string o1 = dbGrid.Columns[0].HeaderText;
            object o2 = dbGrid.Rows[y].Cells[0].Value;
            string sql = $"update {CurrentTable} set {s1}='{s2}' where {o1}='{o2}'";
            RunSQL(sql);
        }

        private void popInsert_Click(object sender, EventArgs e)
        {
            Insert_Proc(dbGrid.SelectedRows[0].Index);
        }

        private void popDelete_Click(object sender, EventArgs e)
        {
            // DELETE student WHERE code=4 AND name=‘사번’ AND kor=50
            string sql = $"DELETE {CurrentTable} WHERE ";
            try
            {
                for (int i = 0; i < dbGrid.ColumnCount; i++)
                {
                    if (dbGrid.SelectedRows[0].Cells[i].Value == null ||
                       dbGrid.SelectedRows[0].Cells[i].Value.ToString() == "") continue;
                    if (i != 0) sql += " AND ";
                    sql += $"{dbGrid.Columns[i].HeaderText}='{dbGrid.SelectedRows[0].Cells[i].Value}'";
                }
                RunSQL(sql);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void popColDelete_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Really?", "컬럼 삭제", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
                dbGrid.Columns.RemoveAt(dbGrid.SelectedCells[0].ColumnIndex);
        }

        private void popRowDelete_Click(object sender, EventArgs e)
        {
            try
            { 
                DialogResult ret = MessageBox.Show("Really?", "레코드 삭제", MessageBoxButtons.OKCancel);
                if (ret == DialogResult.OK)
                    dbGrid.Rows.Remove(dbGrid.SelectedRows[0]);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }    
        }

        private void mnuFileImport_Click(object sender, EventArgs e)
        {
            mnuFileMigration_Click(sender, e);
        }

        private void mnuFileExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                string sbuf = "";
                for (int i = 0; i < dbGrid.ColumnCount; i++)
                {
                    if (i != 0) sbuf += ",";
                    sbuf += dbGrid.Columns[i].HeaderText;
                }
                sw.WriteLine(sbuf);

                for (int j = 0; j < dbGrid.RowCount - 1; j++)
                {
                    sbuf = "";
                    for (int i = 0; i < dbGrid.ColumnCount; i++)
                    {
                        if (i != 0) sbuf += ",";
                        string s1 = "";
                        if (dbGrid.Rows[j].Cells[i].Value != null)
                            s1 = dbGrid.Rows[j].Cells[i].Value.ToString().Trim();

                        sbuf += s1;
                    }
                    sw.WriteLine(sbuf);
                }
                sw.Close();
            }
        }

        public void Insert_Proc(int nRow)
        {
            // 1 : insert into [table] values(v1,v2,...)
            // 2 : insert into [table] (field1, field2,...) values (v1, v2, ...)
            try
            {
                string s1 = "(";
                string s2 = "(";
                for (int i = 0; i < dbGrid.ColumnCount; i++)
                {
                    if (i != 0) { s1 += ","; s2 += ","; }
                    s1 += $"{dbGrid.Columns[i].HeaderText}";
                    s2 += $"'{dbGrid.Rows[nRow].Cells[i].Value}'";
                }
                s1 += ")"; s2 += ")";
                string sql = $"insert into {CurrentTable} {s1} values {s2}";


                //string sql = $"insert into {CurrentTable} (";
                //for (int i = 0; i < dbGrid.ColumnCount; i++)
                //{
                //    if (i != 0) sql += ",";
                //    sql += $"{dbGrid.Columns[i].HeaderText}";
                //}

                //sql += ") values (";
                //for (int i = 0; i < dbGrid.ColumnCount; i++)
                //{
                //    if (i != 0) sql += ",";
                //    sql += $"'{dbGrid.SelectedRows[0].Cells[i].Value}'";
                //}
                sql += ")";
                RunSQL(sql);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void mnuCreateTable_Click(object sender, EventArgs e)
        {// create table [Table] ([field] [type] [not null] ,,, )

            string sql = $"create table ";
            string table_name = myClass.GetInput("테이블 명");

            if (table_name == "") return;

            int count = int.Parse(myClass.GetInput("개수"));
            sql += $"{table_name} (";

            for (int i = 0; i < count; i++)
            {
                string filed_name = myClass.GetInput("필드 이름");
                string type = myClass.GetInput("타입");
                
                sql += $"{filed_name} {type}";
                if (i == 0) sql += " not null";
                if (i != count - 1) sql += ", ";
            }
            sql += ")";
            RunSQL(sql);
            CurrentTable = table_name;

            for (int i = 0; i < dbGrid.RowCount; i++)
                Insert_Proc(i);
        }
    }
}
