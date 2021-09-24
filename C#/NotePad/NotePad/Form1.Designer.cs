
namespace NotePad
{
    partial class Form1
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSavAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditTest = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditCallTest = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewLower = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewUpper = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewHex = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewBack = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.sbLable1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.mnuEditCallTest_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 28);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.toolStripMenuItem1,
            this.mnuFileOpen,
            this.mnuFileSave,
            this.mnuFileSavAs,
            this.toolStripMenuItem2,
            this.mnuFilePrint,
            this.printPreviewToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(195, 26);
            this.mnuFileNew.Text = "New";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 6);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(195, 26);
            this.mnuFileOpen.Text = "Open";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(195, 26);
            this.mnuFileSave.Text = "Save";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // mnuFileSavAs
            // 
            this.mnuFileSavAs.Name = "mnuFileSavAs";
            this.mnuFileSavAs.Size = new System.Drawing.Size(195, 26);
            this.mnuFileSavAs.Text = "Save As ...";
            this.mnuFileSavAs.Click += new System.EventHandler(this.mnuFileSavAs_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(192, 6);
            // 
            // mnuFilePrint
            // 
            this.mnuFilePrint.Name = "mnuFilePrint";
            this.mnuFilePrint.Size = new System.Drawing.Size(195, 26);
            this.mnuFilePrint.Text = "Print";
            this.mnuFilePrint.Click += new System.EventHandler(this.mnuFilePrint_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.printPreviewToolStripMenuItem.Text = "Print Preview ...";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(192, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditTest,
            this.mnuEditCallTest,
            this.mnuEditCallTest_2});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // mnuEditTest
            // 
            this.mnuEditTest.Name = "mnuEditTest";
            this.mnuEditTest.Size = new System.Drawing.Size(224, 26);
            this.mnuEditTest.Text = "Test";
            this.mnuEditTest.Click += new System.EventHandler(this.mnuEditTest_Click);
            // 
            // mnuEditCallTest
            // 
            this.mnuEditCallTest.Name = "mnuEditCallTest";
            this.mnuEditCallTest.Size = new System.Drawing.Size(224, 26);
            this.mnuEditCallTest.Text = "Call Test";
            this.mnuEditCallTest.Click += new System.EventHandler(this.mnuEditCallTest_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewLower,
            this.mnuViewUpper,
            this.mnuViewHex,
            this.mnuViewBack});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // mnuViewLower
            // 
            this.mnuViewLower.Name = "mnuViewLower";
            this.mnuViewLower.Size = new System.Drawing.Size(180, 26);
            this.mnuViewLower.Text = "lower case ...";
            this.mnuViewLower.Click += new System.EventHandler(this.mnuViewLower_Click);
            // 
            // mnuViewUpper
            // 
            this.mnuViewUpper.Name = "mnuViewUpper";
            this.mnuViewUpper.Size = new System.Drawing.Size(180, 26);
            this.mnuViewUpper.Text = "upper case ...";
            this.mnuViewUpper.Click += new System.EventHandler(this.mnuViewUpper_Click);
            // 
            // mnuViewHex
            // 
            this.mnuViewHex.Name = "mnuViewHex";
            this.mnuViewHex.Size = new System.Drawing.Size(180, 26);
            this.mnuViewHex.Text = "hex mode";
            this.mnuViewHex.Click += new System.EventHandler(this.mnuViewHex_Click);
            // 
            // mnuViewBack
            // 
            this.mnuViewBack.Name = "mnuViewBack";
            this.mnuViewBack.Size = new System.Drawing.Size(180, 26);
            this.mnuViewBack.Text = "return back";
            this.mnuViewBack.Click += new System.EventHandler(this.mnuViewBack_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tbNote
            // 
            this.tbNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNote.Location = new System.Drawing.Point(0, 31);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNote.Size = new System.Drawing.Size(800, 390);
            this.tbNote.TabIndex = 1;
            this.tbNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNote_KeyDown);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbLable1,
            this.sbLabel2,
            this.toolStripProgressBar1});
            this.statusStrip.Location = new System.Drawing.Point(0, 424);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // sbLable1
            // 
            this.sbLable1.AutoSize = false;
            this.sbLable1.Name = "sbLable1";
            this.sbLable1.Size = new System.Drawing.Size(152, 20);
            // 
            // sbLabel2
            // 
            this.sbLabel2.AutoSize = false;
            this.sbLabel2.Name = "sbLabel2";
            this.sbLabel2.Size = new System.Drawing.Size(152, 20);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 18);
            // 
            // mnuEditCallTest_2
            // 
            this.mnuEditCallTest_2.Name = "mnuEditCallTest_2";
            this.mnuEditCallTest_2.Size = new System.Drawing.Size(224, 26);
            this.mnuEditCallTest_2.Text = "Call Test #2";
            this.mnuEditCallTest_2.Click += new System.EventHandler(this.mnuEditCallTest_2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.Text = "HB\'s Notepad v.1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSavAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrint;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuViewLower;
        private System.Windows.Forms.ToolStripMenuItem mnuViewUpper;
        private System.Windows.Forms.ToolStripMenuItem mnuViewHex;
        private System.Windows.Forms.ToolStripMenuItem mnuViewBack;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem mnuEditTest;
        private System.Windows.Forms.ToolStripMenuItem mnuEditCallTest;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel sbLable1;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem mnuEditCallTest_2;
    }
}

