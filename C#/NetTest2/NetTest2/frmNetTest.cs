using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetTest2
{
    public partial class frmNetTest : Form
    {
        public frmNetTest()
        {
            InitializeComponent();
        }

        delegate void CallBackAddText(string str);  // 함수의 포인터 역할(C#에선 포인터 없음)
        
        void AddText(string str)        // 문자열 str을 sbServer TextBox에 출력하는 함수
        {
            if (tbServer.InvokeRequired)     // 대리 호출이 필요한가?
            {
                CallBackAddText cb = new CallBackAddText(AddText);
                Invoke(cb, new object[] { str });        // Invoke의 인자는 object array를 받기 때문에 변환해준 것
            }
            else
                tbServer.Text += str;
        }
        Socket sock = null;
        TcpClient tcp = null;
        TcpListener listen = null;
        Thread threadServer = null;
        Thread threadRead = null;

        private void btnServerStart_Click(object sender, EventArgs e)
        {
            // 이미 연결이 되어있는 상태 => listen과 thread, tcp를 초기화 시켜야함!
            if(listen != null)
            {
                DialogResult ret = MessageBox.Show("현재의 연결이 끊어집니다.\r\n계속 하시겠습니까?", "", MessageBoxButtons.YesNo);
                if (ret == DialogResult.No) return;
                listen.Stop();  // 현재 오픈되어 있는 리스너를 중지
                threadServer.Abort();   // thread stop

                if (threadRead != null && threadRead.IsAlive) threadRead.Abort();
                if (tcp != null) tcp.Close();
            }
            listen = new TcpListener(int.Parse(tbServerPort.Text));
            listen.Start();

            //
            // Server Process : Waiting for Client Connect
            //

            // thread는 생성 후, start를 하지 않으면 동작하지 않음! -> 생성만 해놔도 상관 없다!
            threadServer = new Thread(ServerProcess);
            threadServer.Start();

            //  read process
            threadRead = new Thread(ReadProcess);

            tbServer.Text += $"Server port [{tbServerPort.Text}] started.\r\n";
            //timer1.Enabled = true;

            //tbServer.Text += "Client connected...\r\n";
        }

        void ServerProcess()    // call back : 객체 멤버 요소로 호출됨, thread를 argument로 사용하지 않음!
        {
            while (true)
            {
                if (listen.Pending())   // 현재 보류중인 요청이 있는가? 외부로부터의 접속 요청이 있는지 체크
                {
                    tcp = listen.AcceptTcpClient();   // blocking mode : 세션 수립
                    threadRead.Start();     // read process 동작
                    break;
                }
                Thread.Sleep(100);
            }
        }

        void ReadProcess()
        {
            // 2. Thread를 이용하는 경우

            NetworkStream ns = tcp.GetStream();
            byte[] bArr = new byte[512];
            while (true)
            {
                if (ns.DataAvailable)
                {
                    int n = ns.Read(bArr, 0, 512);  // networkstream이 읽어온 바이트 수
                    // thread가 tbServer에 직접 접근하는데 문제 발생
                    //      => Invoke로 해결 (대리호출을 의미함)
                    //          invoke를 사용할 때는 delegate 활용 (포인터처럼 사용할 수 있도록 해줌)
                    //tbServer.Text += Encoding.Default.GetString(bArr);
                    AddText(Encoding.Default.GetString(bArr, 0, n));
                }
                Thread.Sleep(100);
            }
        }

        private void frmNetTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadServer != null) threadServer.Abort();
            if (threadRead != null) threadRead.Abort();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //// 1. 일정시간마다 체크하는 경우 -> timer사용!
            ////      timer _ tick : 일정시간 간격으로 event 발생, ms(1/1000초)
            ////      주의) 타이머의 중복호출 방지를 위해 함수 내로 들어온 후에 타이머를 중지시킴

            //if (tcp == null) return;
            //timer1.Enabled = false;     // 중복호출 방지를 위해 타이머를 잠시 꺼둠

            //NetworkStream ns = tcp.GetStream();
            //byte[] bArr = new byte[512];
            //while (true)
            //{
            //    if (ns.DataAvailable)
            //    {
            //        ns.Read(bArr, 0, 512);
            //        tbServer.Text += Encoding.Default.GetString(bArr);
            //        break;
            //    }
            //}
            //timer1.Enabled = true;     // 작업 완료 후, 다시 타이머 작동
        }
        
    }
}
