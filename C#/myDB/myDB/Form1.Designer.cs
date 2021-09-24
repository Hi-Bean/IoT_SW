
namespace myDB
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
            this.components = new System.ComponentModel.Container();
            this.dbGrid = new System.Windows.Forms.DataGridView();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGo = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRowAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.PopupMenu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.popColAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.popRowAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileMigration = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).BeginInit();
            this.menuMain.SuspendLayout();
            this.PopupMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbGrid
            // 
            this.dbGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGrid.ContextMenuStrip = this.PopupMenu1;
            this.dbGrid.Location = new System.Drawing.Point(-1, 187);
            this.dbGrid.Name = "dbGrid";
            this.dbGrid.RowHeadersWidth = 51;
            this.dbGrid.Size = new System.Drawing.Size(803, 264);
            this.dbGrid.TabIndex = 0;
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(800, 28);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripMenuItem2,
            this.mnuFileMigration,
            this.toolStripMenuItem1,
            this.openToolStripMenuItem,
            this.mnuFileSave,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(224, 26);
            this.mnuFileSave.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(219, 60);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(97, 36);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(40, 64);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(168, 25);
            this.tbInput.TabIndex = 3;
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuColAdd,
            this.mnuRowAdd});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // mnuColAdd
            // 
            this.mnuColAdd.Name = "mnuColAdd";
            this.mnuColAdd.Size = new System.Drawing.Size(224, 26);
            this.mnuColAdd.Text = "Colunm 추가";
            this.mnuColAdd.Click += new System.EventHandler(this.mnuColAdd_Click);
            // 
            // mnuRowAdd
            // 
            this.mnuRowAdd.Name = "mnuRowAdd";
            this.mnuRowAdd.Size = new System.Drawing.Size(224, 26);
            this.mnuRowAdd.Text = "Row 추가";
            this.mnuRowAdd.Click += new System.EventHandler(this.mnuRowAdd_Click);
            // 
            // PopupMenu1
            // 
            this.PopupMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.PopupMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.popColAdd,
            this.popRowAdd});
            this.PopupMenu1.Name = "PopupMenu1";
            this.PopupMenu1.Size = new System.Drawing.Size(168, 52);
            // 
            // popColAdd
            // 
            this.popColAdd.Name = "popColAdd";
            this.popColAdd.Size = new System.Drawing.Size(167, 24);
            this.popColAdd.Text = "Column 추가";
            this.popColAdd.Click += new System.EventHandler(this.popColAdd_Click);
            // 
            // popRowAdd
            // 
            this.popRowAdd.Name = "popRowAdd";
            this.popRowAdd.Size = new System.Drawing.Size(167, 24);
            this.popRowAdd.Text = "Row 추가";
            this.popRowAdd.Click += new System.EventHandler(this.popRowAdd_Click);
            // 
            // mnuFileMigration
            // 
            this.mnuFileMigration.Name = "mnuFileMigration";
            this.mnuFileMigration.Size = new System.Drawing.Size(224, 26);
            this.mnuFileMigration.Text = "Migration";
            this.mnuFileMigration.Click += new System.EventHandler(this.mnuFileMigration_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.dbGrid);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).EndInit();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.PopupMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbGrid;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuColAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuRowAdd;
        private System.Windows.Forms.ContextMenuStrip PopupMenu1;
        private System.Windows.Forms.ToolStripMenuItem popColAdd;
        private System.Windows.Forms.ToolStripMenuItem popRowAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuFileMigration;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

