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
using myLibrary;

namespace HALLOTALK
{
    public partial class frmServer : Form
    {
        public class TCPList
        {
            public TcpClient tcp = null;
            public string name = "";

            public TCPList(TcpClient t, string s)
            {
                tcp = t;
                name = s;
            }
        };

        public frmServer()
        {
            InitializeComponent();
        }

        TcpListener listen = null;
        //TcpClient[] tcp = new TcpClient[10];
        TcpClient t = null;
        List<TCPList> tcplist = new List<TCPList>();
        int currentClientNum = 0;

        Thread threadServer = null;
        Thread threadRead = null;

        string serverPort = "";
        private void mnuServerOpen_Click(object sender, EventArgs e)
        {
            serverPort = "9000";
            listen = new TcpListener(int.Parse(serverPort));
            listen.Start();

            threadServer = new Thread(ServerProcess);
            threadServer.Start();
            AddText($">> 서버가 [{serverPort}]에서 시작되었습니다.\r\n");
        }

        void ServerProcess()
        {
            while (true)
            {
                if(listen.Pending())
                {
                    //tcp[currentClientNum] = listen.AcceptTcpClient();
                    t = listen.AcceptTcpClient();
                    tcplist.Add( new TCPList(t, $"USER {currentClientNum}"));

                    AddText(">> USER CONNECTED\r\n");

                    if (threadRead == null)
                    {
                        threadRead = new Thread(ReadProcess);
                        threadRead.Start();
                    }

                    // 이미 입장한 사람들의 채팅 창에 새로운 유저 입장을 알려줌
                    messageAllClient($"USER{currentClientNum}님이 입장했습니다.\r\n");
                    currentClientNum++;
                }
                Thread.Sleep(100);
            }
        }
        
        void ReadProcess()
        {
            byte[] bArr = new byte[512];
            while(true)
            {
                for(int i=0; i<currentClientNum; i++)
                {
                    NetworkStream ns = tcplist[i].tcp.GetStream();
                    if (ns.DataAvailable)
                    {
                        int n = ns.Read(bArr, 0, 512);
                        string str = $"{tcplist[i].name} : " + Encoding.Default.GetString(bArr, 0, n) + "\r\n";
                        AddText("From Client) " + str);
                        messageAllClient(str);
                    }
                }
                Thread.Sleep(100);
            }
        }

        void messageAllClient(string str)
        {
            for (int i = 0; i < currentClientNum; i++)
            {
                tcplist[i].tcp.Client.Send(Encoding.Default.GetBytes(str));
            }
        }

        delegate void cbAddText(string str);
        void AddText(string str)
        {
            if (tbServer.InvokeRequired)
            {
                cbAddText cb = new cbAddText(AddText);
                Invoke(cb, new object[] { str });
            }
            else
            {
                tbServer.Text += str;
            }
        }

        private void frmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadServer != null) threadServer.Abort();
            if (threadRead != null) threadRead.Abort();
        }

        
    }
}
