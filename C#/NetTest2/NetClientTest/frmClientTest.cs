using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetClientTest
{
    public partial class frmClientTest : Form
    {
        public frmClientTest()
        {
            InitializeComponent();
        }

        Socket sock = null;
        private void btnClientConnect_Click(object sender, EventArgs e)
        {
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Connect(tbClientIP.Text, int.Parse(tbClientPort.Text));
            tbClient.Text += "Connection OK.\r\n";
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            sock.Close();
            tbClient.Text += "Connection closed.\r\n";
        }

        private void pmnuSendText_Click(object sender, EventArgs e)
        {
            if (sock != null)
            {
                string str;
                if (tbClient.SelectedText == "") str = tbClient.Text;
                else str = tbClient.SelectedText;

                sock.Send(Encoding.Default.GetBytes(str));
            }
        }
    }
}
