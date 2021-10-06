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
                // UTF8 옵션이 체크돼있으면 ec=UTF8 / 그렇지 않으면 default로
                Encoding ec = (mnuTextUTF8.Checked) ? Encoding.UTF8 : Encoding.Default;
                StreamReader sr = new StreamReader(openFileDialog.FileName, ec, true);
                // Encoding.Default = ANSI 라고 이해하자
                //byte[] bb1 = Encoding.Convert(Encoding.ASCII, Encoding.Default, Encoding.Default.GetBytes(buf));
                //string bb2 = Encoding.Default.GetString(bb1);

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
            try
            {
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
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
                return -1;
            }
        
        }

        public string RunSQL_NoEcho(string sql)    // 모든 sql 명령어 처리 -> 조회결과를 문자열로 반환
        {
            //sqlCmd.CommandText = $"select * from {e.ClickedItem.Text}";
            try
            {
                sqlCmd.CommandText = sql;
                string sqlStr = sql.Trim().Split(' ')[0];
                if (sqlStr.ToLower() == "select")
                {
                    int n1 = sql.ToLower().IndexOf("from");
                    string s1 = sql.Substring(n1 + 4).Trim();
                    CurrentTable = s1.Split(ca)[0];
                    //sbLabel2.Text = CurrentTable;

                    SqlDataReader sdr = sqlCmd.ExecuteReader();     // return값이 있어 출력
                    string sRet = sdr.GetName(0);
                    for (int i = 1; i < sdr.FieldCount; i++)
                    {
                        sRet += $", {sdr.GetName(i)}";
                    }
                    sRet += "\r\n";

                    for (int i = 0; sdr.Read(); i++)
                    {
                        sRet += sdr.GetValue(0).ToString();
                        for (int j = 1; j < sdr.FieldCount; j++)
                        {
                            sRet += $", {sdr.GetValue(j)}";
                        }
                    }
                    sdr.Close();
                    return sRet;
                }
                else
                {
                    return $"{sqlCmd.ExecuteNonQuery()}";           // return 값이 없는 경우
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return "-1";
            }

        }

        private void mnuSqlExecute_Click(object sender, EventArgs e)
        {
            if (mnuEchoOptionGrid.Checked) RunSQL(tbMemo.Text);
            else RunSQL_NoEcho(tbMemo.Text);
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
            if (mnuEchoOptionGrid.Checked) RunSQL(tbMemo.SelectedText);
            else RunSQL_NoEcho(tbMemo.SelectedText);
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
            string sql = $"update {CurrentTable} set {s1}=N'{s2}' where {o1}=N'{o2}'";
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
            //mnuFileMigration_Click(sender, e);
            //Low level 코딩을 위해

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Encoding enc;
                if (mnuTextUTF8.Checked)
                    enc = Encoding.UTF8;
                else
                    enc = Encoding.Default;

                // 모든 정보를 '바이너리'로 읽어와 byte array에 저장
                byte[] bArrOrg = File.ReadAllBytes(openFileDialog.FileName);    //  raw data: low level data
                byte[] bArr = Encoding.Convert(enc, Encoding.Default, bArrOrg); // conversion
                string str = Encoding.Default.GetString(bArr);      // All Text

                tbMemo.Text = str;
                string[] splitStr = str.Split(ca);      // ca는 white space array
                string[] Value = splitStr[0].Trim().Split(',');

                for(int i=0; i<Value.Length; i++)
                {
                    dbGrid.Columns.Add(Value[i], Value[i]);
                }

                for(int i=2; i<splitStr.Length; i+=2)
                {
                    Value = splitStr[i].Split(',');
                    dbGrid.Rows.Add(Value);
                }
            }
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
                    s2 += $"N'{dbGrid.Rows[nRow].Cells[i].Value}'";
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
                //sql += ")";
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
                //string type = myClass.GetInput("타입");
                
                sql += $"{filed_name} varchar(10)";
                if (i == 0) sql += " not null";
                if (i != count - 1) sql += ", ";
            }
            sql += ")";
            RunSQL(sql);
            CurrentTable = table_name;

            for (int i = 0; i < dbGrid.RowCount; i++)
                Insert_Proc(i);
        }

        private void mnuTextUTF8_Click(object sender, EventArgs e)
        {
            mnuTextUTF8.Checked = true;
            mnuTextAnsi.Checked = false;
        }

        private void mnuTextAnsi_Click(object sender, EventArgs e)
        {
            mnuTextUTF8.Checked = false;
            mnuTextAnsi.Checked = true;
        }


        //select * from information_schema.tables   : DB의 테이블 정보들이 나옴
        //select data_type, character_maximum_length, is_nullable from information_schema.columns where column_name='code'
        private void popCOLInfo_Click(object sender, EventArgs e)
        {
            int nCol = dbGrid.SelectedCells[0].ColumnIndex;
            string sCol = dbGrid.Columns[nCol].HeaderText;
            tbMemo.Text += RunSQL_NoEcho($"select table_name, column_name, data_type, character_maximum_length, is_nullable from information_schema.columns where column_name='{sCol}' and table_name = '{CurrentTable}'");
        }

        private void mnuEchoOptionText_Click(object sender, EventArgs e)
        {
            mnuEchoOptionGrid.Checked = false;
            mnuEchoOptionText.Checked = true;
        }

        private void mnuEchoOptionGrid_Click(object sender, EventArgs e)
        {
            mnuEchoOptionGrid.Checked = true;
            mnuEchoOptionText.Checked = false;
        }

        private void popAlterCol_Click(object sender, EventArgs e)
        {
            // ALTER TABLE [Table]
            // ALTER COLUMN [column] [type] [nullable]          // MSSQL <-> MySQL (명령어가 조금 다름)
            // Form을 신규 생성 : 컬럼 type, Max Length, nullable 선택

            // 현재 선택된 셀의 col이름을 가져오는 과정
            int nCol = dbGrid.SelectedCells[0].ColumnIndex;
            string sCol = dbGrid.Columns[nCol].HeaderText;

            string str = RunSQL_NoEcho("select Table_name,column_name,data_type,character_maximum_length,is_nullable " +
                          " from information_schema.columns " +
                          $" where column_name = '{sCol}' and table_name='{CurrentTable}'");
            
            try
            {
                string temp = str.Split('\n')[1];
                string[] sInfo = temp.Trim().Split(',');  // col 정보 : table_name, column_name, data_type, character_maximum_length, is_nullable

                AlterColForm af = new AlterColForm(sInfo[1], sInfo[2], int.Parse(sInfo[3]));
                if (af.ShowDialog() == DialogResult.OK)
                {
                    string strNullable = "";
                    if (af.rbtnNULLyes.Checked)
                        strNullable = "NULL";
                    else
                        strNullable = "NOT NULL";
                    string sql = $"ALTER TABLE {sInfo[0]} ALTER COLUMN {sInfo[1]} {af.cbType.Text}({af.tbMaxLen.Text}) {strNullable}";
                    RunSQL(sql);
                }
                af.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
    }
}
