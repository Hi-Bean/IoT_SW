
namespace myChat
{
    partial class frmChat
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChat));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.popupClient = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pmnuSendText = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClientConnect = new System.Windows.Forms.Button();
            this.tbConnectPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbConnectIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnServerStart = new System.Windows.Forms.Button();
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.popupServer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pmnuServerSendText = new System.Windows.Forms.ToolStripMenuItem();
            this.sbClientList = new System.Windows.Forms.ToolStripDropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.popupClient.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.popupServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 494);
            this.splitContainer1.SplitterDistance = 688;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tbServer);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tbClient);
            this.splitContainer2.Size = new System.Drawing.Size(688, 494);
            this.splitContainer2.SplitterDistance = 214;
            this.splitContainer2.TabIndex = 0;
            // 
            // tbServer
            // 
            this.tbServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbServer.ContextMenuStrip = this.popupServer;
            this.tbServer.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbServer.Location = new System.Drawing.Point(3, 3);
            this.tbServer.Multiline = true;
            this.tbServer.Name = "tbServer";
            this.tbServer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbServer.Size = new System.Drawing.Size(685, 208);
            this.tbServer.TabIndex = 0;
            // 
            // tbClient
            // 
            this.tbClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClient.ContextMenuStrip = this.popupClient;
            this.tbClient.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClient.Location = new System.Drawing.Point(3, 3);
            this.tbClient.Multiline = true;
            this.tbClient.Name = "tbClient";
            this.tbClient.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbClient.Size = new System.Drawing.Size(682, 244);
            this.tbClient.TabIndex = 0;
            // 
            // popupClient
            // 
            this.popupClient.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.popupClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pmnuSendText});
            this.popupClient.Name = "popupClient";
            this.popupClient.Size = new System.Drawing.Size(141, 28);
            // 
            // pmnuSendText
            // 
            this.pmnuSendText.Name = "pmnuSendText";
            this.pmnuSendText.Size = new System.Drawing.Size(140, 24);
            this.pmnuSendText.Text = "send text";
            this.pmnuSendText.Click += new System.EventHandler(this.pmnuSendText_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClientConnect);
            this.groupBox2.Controls.Add(this.tbConnectPort);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbConnectIP);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 189);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
            // 
            // btnClientConnect
            // 
            this.btnClientConnect.Location = new System.Drawing.Point(120, 134);
            this.btnClientConnect.Name = "btnClientConnect";
            this.btnClientConnect.Size = new System.Drawing.Size(107, 27);
            this.btnClientConnect.TabIndex = 2;
            this.btnClientConnect.Text = "CONNECT";
            this.btnClientConnect.UseVisualStyleBackColor = true;
            this.btnClientConnect.Click += new System.EventHandler(this.btnClientConnect_Click);
            // 
            // tbConnectPort
            // 
            this.tbConnectPort.Location = new System.Drawing.Point(120, 69);
            this.tbConnectPort.Name = "tbConnectPort";
            this.tbConnectPort.Size = new System.Drawing.Size(115, 26);
            this.tbConnectPort.TabIndex = 1;
            this.tbConnectPort.Text = "9000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Port";
            // 
            // tbConnectIP
            // 
            this.tbConnectIP.Location = new System.Drawing.Point(120, 37);
            this.tbConnectIP.Name = "tbConnectIP";
            this.tbConnectIP.Size = new System.Drawing.Size(115, 26);
            this.tbConnectIP.TabIndex = 1;
            this.tbConnectIP.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Connect IP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnServerStart);
            this.groupBox1.Controls.Add(this.tbServerPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 155);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // btnServerStart
            // 
            this.btnServerStart.Location = new System.Drawing.Point(127, 100);
            this.btnServerStart.Name = "btnServerStart";
            this.btnServerStart.Size = new System.Drawing.Size(107, 27);
            this.btnServerStart.TabIndex = 2;
            this.btnServerStart.Text = "START";
            this.btnServerStart.UseVisualStyleBackColor = true;
            this.btnServerStart.Click += new System.EventHandler(this.btnServerStart_Click);
            // 
            // tbServerPort
            // 
            this.tbServerPort.Location = new System.Drawing.Point(120, 37);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Size = new System.Drawing.Size(115, 26);
            this.tbServerPort.TabIndex = 1;
            this.tbServerPort.Text = "9000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Port";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel1,
            this.statusLabel2,
            this.sbClientList});
            this.statusStrip1.Location = new System.Drawing.Point(0, 468);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel1
            // 
            this.statusLabel1.AutoSize = false;
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(150, 20);
            this.statusLabel1.Text = "label1";
            // 
            // statusLabel2
            // 
            this.statusLabel2.AutoSize = false;
            this.statusLabel2.Name = "statusLabel2";
            this.statusLabel2.Size = new System.Drawing.Size(150, 20);
            this.statusLabel2.Text = "label2";
            // 
            // popupServer
            // 
            this.popupServer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.popupServer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pmnuServerSendText});
            this.popupServer.Name = "popupServer";
            this.popupServer.Size = new System.Drawing.Size(146, 28);
            // 
            // pmnuServerSendText
            // 
            this.pmnuServerSendText.Name = "pmnuServerSendText";
            this.pmnuServerSendText.Size = new System.Drawing.Size(145, 24);
            this.pmnuServerSendText.Text = "Send Text";
            this.pmnuServerSendText.Click += new System.EventHandler(this.pmnuServerSendText_Click);
            // 
            // sbClientList
            // 
            this.sbClientList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sbClientList.Image = ((System.Drawing.Image)(resources.GetObject("sbClientList.Image")));
            this.sbClientList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbClientList.Name = "sbClientList";
            this.sbClientList.Size = new System.Drawing.Size(90, 24);
            this.sbClientList.Text = "Client List";
            this.sbClientList.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.sbClientList_DropDownItemClicked);
            // 
            // frmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 494);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmChat";
            this.Text = "myChat ver.1.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChat_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.popupClient.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.popupServer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.TextBox tbClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnServerStart;
        private System.Windows.Forms.TextBox tbServerPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClientConnect;
        private System.Windows.Forms.TextBox tbConnectPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbConnectIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip popupClient;
        private System.Windows.Forms.ToolStripMenuItem pmnuSendText;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel2;
        private System.Windows.Forms.ContextMenuStrip popupServer;
        private System.Windows.Forms.ToolStripMenuItem pmnuServerSendText;
        private System.Windows.Forms.ToolStripDropDownButton sbClientList;
    }
}

