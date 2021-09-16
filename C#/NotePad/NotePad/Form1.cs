using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
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
                    if (i % 16 == 15) s1 += "\r\n";
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

        // prototype    : string GetToken(int n, string str, char d);
        // Argument     :
        //      n       : n번째 item
        //     str      : 문자열
        //      d       : 구분자
        // 설명         : 문자열 str에 있는 데이터를 구분자 d를 통해 필드를 구분
        //                그 중 n 번째 데이터 반환
        //              ex) GetToken(1, "a,b,c,d", ",")  ===>  "b"
        //              ex2) GetToken(2, "app,bee,carrot,dark", ',')  ===>  "carrot"
        public string GetToken(int n, string str, char d)
        {
            int count = 0; string result = "";
            //char[] ch = str.ToCharArray();
            for (int i = 0; i <= str.Length; i++)
            {
                if (str[i] != d) continue;
                count++;
                if(n == count)
                {
                    for(int j=i+1; str[j] != d; j++)
                    {
                        result += str[j];
                    }
                    break;
                }
            }
            return result;
        }

        string GetToken_byLee(int n, string str, char d)
        {
            //// case 1
            //int i, j, k, n1, n2;        // n1 : start, n2 : end
            //for(i=j=k=n1=n2=0; i<str.Length; i++)
            //{
            //    if (str[i] == d) k++;
            //    if (k == n) n1 = i;
            //    if (k == n + 1) n2 = i;
            //}
            //if (n1 == 0) return "";
            //if (n2 == 0) n2 = str.Length;
            //return str.Substring(n1, n2 - n1);

            // case 2
            string[] sArr = str.Split(d);
            if (n < sArr.Length) return sArr[n];
            else return "";
        }

        private void mnuFilePrint_Click(object sender, EventArgs e)
        {
            
        }

        private void mnuEditTest_Click(object sender, EventArgs e)
        {
            tbNote.Text += GetToken(2, "app,bee,carrot,dark", ',') + "\r\n";
            tbNote.Text += $"{GetToken_byLee(3, "apple,banana,cake,doll", ',')}";
        }
    }
}
