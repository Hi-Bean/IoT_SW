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

namespace ClientChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string cIP, cPort;
        Socket sock = null;
        Thread threadClientRead = null;

        private void mnuConnect_Click(object sender, EventArgs e)
        {
            try
            {
                cIP = "127.0.0.1";
                cPort = "9000";

                sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sock.Connect(cIP, int.Parse(cPort));

                tbMainChat.Text += "채팅방에 입장하였습니다.\r\n";
                threadClientRead = new Thread(ClientReadProcess);
                threadClientRead.Start();
            }
            catch (Exception e1)
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
                    AddText($"{Encoding.Default.GetString(bArr, 0, n)}", 1);
                    //AddText($"{Encoding.Default.GetString(bArr, 0, n).Trim().Split(':')[0]}", 2);
                }
                Thread.Sleep(100);
            }
        }

        delegate void cbAddText(string str, int i);
        void AddText(string str, int i)
        {
            if (tbMainChat.InvokeRequired)
            {
                cbAddText cb = new cbAddText(AddText);
                Invoke(cb, new object[] { str, i });
            }
            else
            {
                if (i == 1)
                    tbMainChat.Text += str;
                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            byte[] bArr = Encoding.Default.GetBytes("Leave");
            sock.Send(bArr);
            if (threadClientRead != null) threadClientRead.Abort();

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string str = "" + tbInput.Text;
            byte[] bArr = Encoding.Default.GetBytes(str);
            sock.Send(bArr);
            tbInput.Text = "";
        }
    }
}
