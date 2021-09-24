using myLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class Form1 : Form
    {
        public string filePath;     // 파일 경로
        public string filename;     // 파일명
        public Form1()
        {
            InitializeComponent();
        }

        
        void AddLine(string str)
        {
            tbNote.Text += str + "\r\n";
        }

        string strOrg = "";
        int viewState = 0;        // 0:Normal    1:Lower    2:Upper    3:Hexa 
        private void mnuViewLower_Click(object sender, EventArgs e)
        {
            if(viewState != 1)
            {
                if (strOrg == "") strOrg = tbNote.Text;
                tbNote.Text = strOrg.ToLower();
                tbNote.ReadOnly = true;
                viewState = 1;
            }
        }

        private void mnuViewUpper_Click(object sender, EventArgs e)
        {
            if (viewState != 2)
            {
                if (strOrg == "") strOrg = tbNote.Text;
                tbNote.Text = strOrg.ToUpper();
                tbNote.ReadOnly = true;
                viewState = 2;
            }
        }

        private void mnuViewHex_Click(object sender, EventArgs e)
        {
            if (viewState != 3)
            {
                if (strOrg == "") strOrg = tbNote.Text;
                tbNote.Text = "";

                string s1;
                char[] chr = strOrg.ToCharArray();
                byte[] bArr = Encoding.Default.GetBytes(chr);

                for(int i=0; i<bArr.GetLength(0); i++)
                {
                    //s1 = string.Format(" {0:X2}", bArr[i]);   // printf(" %x ", n);
                    s1 = $" {bArr[i]:X2}";
                    if (i % 16 == 15) AddLine(s1);
                    tbNote.Text += s1;
                }

                //////위의 결과와 같음 (foreach문 사용한 경우)
                ////tbMemo.Text += "\r\n==========================================\r\n";
                ////int count = 0;
                //////  for (int i = 0; i < strOrg.Length; i++)
                ////foreach (byte c in bArr)
                ////{
                ////    s1 = $" {c:X2}";              //   string.Format(" {0:d} ", chr[i]);   // printf(" %x ", n);
                ////    if (count++ % 16 == 15) s1 += "\r\n";
                ////    tbMemo.Text += s1;
                ////    //count++;
                ////}

                tbNote.ReadOnly = true;
                viewState = 3;
            }
            }

        private void mnuViewBack_Click(object sender, EventArgs e)
        {
            if(strOrg != "")
            {
                tbNote.Text = strOrg;
                strOrg = "";
                tbNote.ReadOnly = false;
                viewState = 0;
            }
        }

        private void tbNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                mnuViewBack_Click(sender, e);
        }

        //Menu - File - NEW
        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            string str = Application.ExecutablePath;
            Process.Start(str);

            //// 외부프로그램 종료
            //foreach(Process p in Process.GetProcesses())
            //{
            //    if (p.ProcessName.StartsWith("myNotepad"))
            //        p.Kill();
            //}
        }

        //Menu - File - Open
        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Text file(.txt)|*.txt|C#(.cs)|*.cs|All files|*.*";
            openFileDialog.FilterIndex = 3;
            //tbMemo.Text += openFileDialog.FileName;      // filename 불러오기

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 파일 경로 & 파일 경로에서 파일명 추출
                filePath = openFileDialog.FileName;
                filename = filePath.Substring(filePath.LastIndexOf("\\") + 1);
                //filename = Path.GetFileName(filePath);

                // streamreader 열어서 파일 불러오기
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                tbNote.Text = sr.ReadToEnd();
                sr.Close();     // stream 사용 후엔 항상 닫아주기!

                // 메모장 창에 파일 이름 띄우기
                Text = filename;
            }
        }

        // Menu - File - Save
        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Text file(.txt)|*.txt|C#(.cs)|*.cs|All files|*.*";
            saveFileDialog.FilterIndex = 1;

            if (filename != "") // open으로 파일을 불러왔을 경우
            {
                // file경로는 open으로 불러온 경로
                saveFileDialog.FileName = filePath;
                StreamWriter sw = new StreamWriter(filePath);
                sw.Write(tbNote.Text);
                sw.Close();
            }
            else
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 경로와 파일명 재설정
                    filePath = saveFileDialog.FileName;
                    filename = Path.GetFileName(filePath);

                    // 파일 저장
                    StreamWriter sw = new StreamWriter(filePath);
                    sw.Write(tbNote.Text);
                    sw.Close();
                }
            }
            // 창에 파일명 띄우기
            Text = filename;
        }

        // Menu - File - Save As
        private void mnuFileSavAs_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Text file(.txt)|*.txt|C#(.cs)|*.cs|All files|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.FileName = filename;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 경로와 파일명 재설정
                filePath = saveFileDialog.FileName;
                filename = Path.GetFileName(filePath);

                // 파일 저장
                StreamWriter sw = new StreamWriter(filePath);
                sw.Write(tbNote.Text);
                sw.Close();

                // 창에 파일명 띄우기
                Text = filename;
            }
        }

        
        private void mnuFilePrint_Click(object sender, EventArgs e)
        {
            
        }
        //myClass mc = new myClass();       // static으로 선언한 경우에는 다르게 사용
                                            // static class library는 변수 선언 필요 없음
        private void mnuEditTest_Click(object sender, EventArgs e)
        {
            tbNote.Text += myClass.GetToken(2, "app,bee,carrot,dark", ',') + "\r\n";
            tbNote.Text += $"{myClass.GetToken_byLee(3, "apple,banana,cake,doll", ',')}";
        }

        Point p;
        private void mnuEditCallTest_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();
            dlg.Location = p;

            // Call Test로 port를 선택했었다면
            if (sbLable1.Text != "")
            {
                string temp = myClass.GetToken_byLee(0, sbLable1.Text, ':');
                // temp ==>> COM1:9600,N81
                if (temp == "COM1")
                    dlg.rbCom1.Checked = true;
                else if(temp == "COM2")
                    dlg.rbCom2.Checked = true;

                //speed
                string temp2 = sbLable1.Text.Remove(0, 5);
                // temp2 ==>> 9600,N81
                dlg.cbSpeed.Text = myClass.GetToken(0, temp2, ',');

                //parity + databit + startbit
                string temp3 = myClass.GetToken(1, temp2, ',');
                if (temp3[0] == 'N') dlg.cbParity.Text = dlg.cbParity.Items[0].ToString();
                else if(temp3[0] == 'O') dlg.cbParity.SelectedIndex = 1;
                else if (temp3[0] == 'E') dlg.cbParity.Text = dlg.cbParity.Items[2].ToString();

                dlg.cbDatabit.Text = $"{temp3[1]}";
                dlg.cbStopbit.Text = $"{temp3[2]}";
                //dlg.cbDatabit.Text = temp3[1].ToString();           // 좌변은 string, temp3[1]은 char형이므로 ToString()처리
                //dlg.cbStopbit.Text = temp3[2].ToString();
            }

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // string str = ((dlg.rbCom1.Checked) ? "COM1 : " : "COM2 : ");    // 삼항연산자사용
                // 예제가 세개인 경우? false의 경우에 삼항연산문을 넣어 비교가능
                string str = (dlg.rbCom1.Checked) ? "COM1:" :
                             (dlg.rbCom2.Checked) ? "COM2:" : "XXX:";
                ////if (dlg.rbCom1.Checked)
                ////    str += "COM1 : ";
                ////else if (dlg.rbCom2.Checked)
                ////    str += "COM2 : ";
                ////else
                ////    str += "XXX : ";

                str += dlg.cbSpeed.Text + "," + dlg.cbParity.Text.Trim(' ').ToUpper()[0] +  dlg.cbDatabit.Text + dlg.cbStopbit.Text;
                //AddLine(str);
                sbLable1.Text = str;        // status bar에 출력
                
            }
            p = dlg.Location;
            sbLabel2.Text = dlg.Location.ToString();
        }


       static string inipath = ".\\NotePad.ini";   // .ini파일의 전체 경로
       IniClass ic = new IniClass(inipath);
        private void Form1_Load(object sender, EventArgs e)
        {
            //StringBuilder buf = new StringBuilder(500);
            //GetPrivateProfileString("Form1", "LocationX", "0", buf, 500, inipath);
            //int x = int.Parse(buf.ToString());

            string t = ic.GetString("Form1", "LocationX", "0");
            int x = int.Parse(t);

            //GetPrivateProfileString("Form1", "LocationY", "0", buf, 500, inipath);
            //int y = int.Parse(buf.ToString());

            t = ic.GetString("Form1", "LocationY","0");
            int y = int.Parse(t.ToString());

            Location = new Point(x, y);

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ic.WriteString("Form1", "LocationX", $"{Location.X}");
            ic.WriteString("Form1", "LocationY", $"{Location.Y}");
            //WritePrivateProfileString("Form1", "LocationX", $"{Location.X}", inipath);
            //WritePrivateProfileString("Form1", "LocationY", $"{Location.Y}", inipath);
        }

        private void mnuEditCallTest_2_Click(object sender, EventArgs e)
        {
            frmInput frm = new frmInput("문자열 입력 테스트");
            frm.ShowDialog();

            if(frm.ShowDialog() == DialogResult.OK)
            {
                AddLine(frm.callTest2str);
            }
        }
    }
}
