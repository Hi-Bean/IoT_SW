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

    public static class myClass         // static : 입력요소(컴포넌트)가 없는 경우
    {
        // prototype    : string GetToken(int n, string str, char d);
        // Argument     :
        //      n       : n번째 item
        //     str      : 문자열
        //      d       : 구분자
        // 설명         : 문자열 str에 있는 데이터를 구분자 d를 통해 필드를 구분
        //                그 중 n 번째 데이터 반환
        //              ex) GetToken(1, "a,b,c,d", ",")  ===>  "b"
        //              ex2) GetToken(2, "app,bee,carrot,dark", ',')  ===>  "carrot"
        public static string GetToken(int n, string str, char d)
        {
            int count = 0; string result = "";
            //char[] ch = str.ToCharArray();
            for (int i = 0; i <= str.Length; i++)
            {
                if (n == 0)
                {
                    result += str[i];
                    if (str[i + 1] == d) break;
                }
                else
                {
                    if (str[i] != d) continue;
                    count++;
                    if (n == count)
                    {
                        for (int j = i + 1; j < str.Length; j++)
                        {
                            if (str[j] == d) break;
                            result += str[j];
                        }
                        break;
                    }
                }
            }
            return result;
        }

        public static string GetToken_byLee(int n, string str, char d)
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

        public static string GetInput(string strpr)
        {
            frmInput fr = new frmInput(strpr);
            if (fr.ShowDialog() == DialogResult.OK)
                return fr.callTest2str;
            return "";
        }
    }

    /// <summary>
    /// 클래스명 : IniClass
    /// 클래스기능 : GetPrivateProfileString / WritePrivateProfileString 함수를
    ///             쉽게 사용할 수 있도록 중간 변환 해 주는 클래스
    /// 생성자 : IniClass(".ini file 경로")
    /// 주요 메소드 : GetString(string sec, string key);
    ///               WriteString(string sec, string key, string val);
    /// </summary>
    public class IniClass
    {
        public string IniPath = "";
        public string IniName = "";
        public IniClass()
        {
        }
        public IniClass(string path)
        {
            IniPath = path;
        }

        [DllImport("kernel32.dll")]
        static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder buf, int size, string Path);

        [DllImport("kernel32.dll")]
        static extern bool WritePrivateProfileString(string section, string key, string val, string Path);

        public string GetString(string sec, string key)
        {
            StringBuilder buf = new StringBuilder(500);
            GetPrivateProfileString(sec, key, "0", buf, 500, IniPath);
            return buf.ToString();
        }

        public string GetString(string sec, string key, string def)
        {
            StringBuilder buf = new StringBuilder(500);
            GetPrivateProfileString(sec, key, def, buf, 500, IniPath);
            return buf.ToString();
        }

        public bool WriteString(string sec, string key, string val)
        {
            return WritePrivateProfileString(sec, key, val, IniPath);
        }
    }
}
