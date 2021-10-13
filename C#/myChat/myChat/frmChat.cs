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

namespace myChat
{
    public partial class frmChat : Form
    {
        public frmChat()
        {
            InitializeComponent();
            statusLabel1.Text = "";
            statusLabel2.Text = "";
        }

        Socket sock = null;
        TcpListener listen = null;

        //TcpClient tcp = null;                 // 1 : 1 통신
        TcpClient[] tcp = new TcpClient[10];    // 1 : n 통신을 위해 배열 사용 (10개 채널)
        int CurrentClientNum = 0;
        
        Thread threadServer = null;        // Connect 요구 처리 쓰레드
        Thread threadRead = null;          // 입력 문자열 처리 쓰레드
        
        private void btnServerStart_Click(object sender, EventArgs e)
        {
            if(listen != null)
            {
                DialogResult ret = MessageBox.Show("현재의 연결이 끊어집니다.\r\n계속 하시겠습니까?", "",MessageBoxButtons.YesNo);
                if (ret == DialogResult.No) return;

                listen.Stop();
                threadServer.Abort();

                //if (threadRead != null && threadRead.IsAlive) threadRead.Abort();
                if (threadRead != null) threadRead.Abort();
                //if (tcp != null) tcp.Close();
            }

            listen = new TcpListener(int.Parse(tbServerPort.Text));         // port 정보를 argument로 가짐
            listen.Start();
            
            threadServer = new Thread(ServerProcess);
            threadServer.Start();
            AddText($"서버가 [{tbServerPort.Text}]에서 시작되었습니다.\r\n", 1);
            statusLabel1.Text = $"Server Port : {tbServerPort.Text}";
        }

        void ServerProcess()
        {
            while (true)
            {
                if (listen.Pending())
                {
                    //if (tcp != null) 
                    //{
                    //    tcp.Close();
                    //    threadRead.Abort();
                    //}

                    if (CurrentClientNum == 9) break;

                    tcp[CurrentClientNum] = listen.AcceptTcpClient();     // 보류 중인 연결 요청 수락
                    
                    AddText($"Client [{tcp[CurrentClientNum].Client.RemoteEndPoint.ToString()}]로부터 접속되었습니다.\r\n", 1);

                    //statusLabel2.Text = $"{tbConnectIP.Text}";
                    statusLabel2.Text = $"{tcp[CurrentClientNum].Client.RemoteEndPoint.ToString()}";

                    // thread 오류 발생  =>> invoke 활용
                    //sbClientList.DropDownItems.Add(tcp[CurrentClientNum - 1].Client.RemoteEndPoint.ToString());
                    AddText(tcp[CurrentClientNum].Client.RemoteEndPoint.ToString(), 3);


                    if(threadRead == null)
                    {
                        threadRead = new Thread(ReadProcess);
                        threadRead.Start();
                    }
                    CurrentClientNum++;
                }
                Thread.Sleep(100);
            }
        }

        void ReadProcess()
        {
            byte[] bArr = new byte[512];

            while(true)
            {
                for (int i = 0; i < CurrentClientNum; i++)
                {
                    NetworkStream ns = tcp[i].GetStream();
                    if (ns.DataAvailable)
                    {
                        int n = ns.Read(bArr, 0, 512);
                        AddText(Encoding.Default.GetString(bArr, 0, n), 1);
                    }
                }
                Thread.Sleep(100);
            }
        }

        delegate void CallBackAddText(string str, int i);

        void AddText(string str, int i)
        {
            if (tbServer.InvokeRequired || tbClient.InvokeRequired || statusStrip1.InvokeRequired)
            {
                CallBackAddText cb = new CallBackAddText(AddText);
                Invoke(cb, new object[] { str, i });
            }
            else
            {
                if (i == 1)
                    tbServer.Text += str;
                else if (i == 2)
                    tbClient.Text += str;
                else if (i == 3)
                    sbClientList.DropDownItems.Add(str);
            }
        }

        private void frmChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadServer != null) threadServer.Abort();
            if (threadRead != null) threadRead.Abort();
            if (threadClientRead != null) threadClientRead.Abort();
        }

        Thread threadClientRead = null;
        private void btnClientConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (sock != null && sock.Connected)
                {
                    DialogResult ret = MessageBox.Show("현재의 연결을 끊고 새로운 연결이 수립됩니다.\r\n", "", MessageBoxButtons.OKCancel);
                    if (ret == DialogResult.OK)
                    {
                        sock.Close();
                        threadClientRead.Abort();
                    }
                }

                sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sock.Connect(tbConnectIP.Text, int.Parse(tbConnectPort.Text));      // Connection 수립 요청 - 대기 (blocking)
                AddText($"Server [{tbConnectIP.Text}:{tbConnectPort.Text}] Connected OK.\r\n", 2);
                threadClientRead = new Thread(ClientReadProcess);
                threadClientRead.Start();
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        void ClientReadProcess()
        {
            byte[] bArr = new byte[512];
            while (true)
            {
                if (sock.Available > 0)
                {
                    int n = sock.Receive(bArr, 512, SocketFlags.None);
                    AddText($"{Encoding.Default.GetString(bArr, 0, n)}", 2);
                }
                Thread.Sleep(100);
            }
        }

        private void pmnuSendText_Click(object sender, EventArgs e)
        {
            string str = (tbClient.SelectedText == "") ? tbClient.Text : tbClient.SelectedText;
            byte[] bArr = Encoding.Default.GetBytes(str);
            sock.Send(bArr);
        }

        int GetTcpIndex()       // Tcp List 중 선택되어 있는 리스트 인덱스 반환
        {
            for (int i = 0; i < CurrentClientNum; i++)
            {
                if (tcp[i].Client.RemoteEndPoint.ToString() == sbClientList.Text)
                {
                    return i;
                }
            }

            return -1;
        }

        private void pmnuServerSendText_Click(object sender, EventArgs e)
        {
            
            string str = (tbServer.SelectedText == "") ? tbServer.Text : tbServer.SelectedText;
            byte[] bArr = Encoding.Default.GetBytes(str);
            //tcp.Client.Send(bArr);              // 서버에서 클라이언트에게 보낼 때

            int cnum = GetTcpIndex();
            if(cnum != -1)
                tcp[cnum].Client.Send(bArr);
            
        }

        private void sbClientList_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            sbClientList.Text = e.ClickedItem.Text;
        }
    }
}
