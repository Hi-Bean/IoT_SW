
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dbGrid = new System.Windows.Forms.DataGridView();
            this.PopupMenu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.popColAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.popRowAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.popColDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.popRowDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.popUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.popInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.popDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileMigration = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileImport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateTable = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateTable = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRowAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSqlExecute = new System.Windows.Forms.ToolStripMenuItem();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.popupMenu2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.popSelectedExecute = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.sbLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbLabel2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).BeginInit();
            this.PopupMenu1.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.popupMenu2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbGrid
            // 
            this.dbGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGrid.ContextMenuStrip = this.PopupMenu1;
            this.dbGrid.Location = new System.Drawing.Point(0, -1);
            this.dbGrid.Name = "dbGrid";
            this.dbGrid.RowHeadersWidth = 51;
            this.dbGrid.Size = new System.Drawing.Size(757, 191);
            this.dbGrid.TabIndex = 0;
            // 
            // PopupMenu1
            // 
            this.PopupMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.PopupMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.popColAdd,
            this.popRowAdd,
            this.popColDelete,
            this.popRowDelete,
            this.toolStripMenuItem3,
            this.popUpdate,
            this.popInsert,
            this.popDelete});
            this.PopupMenu1.Name = "PopupMenu1";
            this.PopupMenu1.Size = new System.Drawing.Size(168, 178);
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
            // popColDelete
            // 
            this.popColDelete.Name = "popColDelete";
            this.popColDelete.Size = new System.Drawing.Size(167, 24);
            this.popColDelete.Text = "Column 삭제";
            this.popColDelete.Click += new System.EventHandler(this.popColDelete_Click);
            // 
            // popRowDelete
            // 
            this.popRowDelete.Name = "popRowDelete";
            this.popRowDelete.Size = new System.Drawing.Size(167, 24);
            this.popRowDelete.Text = "Row 삭제";
            this.popRowDelete.Click += new System.EventHandler(this.popRowDelete_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(164, 6);
            // 
            // popUpdate
            // 
            this.popUpdate.Name = "popUpdate";
            this.popUpdate.Size = new System.Drawing.Size(167, 24);
            this.popUpdate.Text = "table update";
            this.popUpdate.Click += new System.EventHandler(this.popUpdate_Click);
            // 
            // popInsert
            // 
            this.popInsert.Name = "popInsert";
            this.popInsert.Size = new System.Drawing.Size(167, 24);
            this.popInsert.Text = "table insert";
            this.popInsert.Click += new System.EventHandler(this.popInsert_Click);
            // 
            // popDelete
            // 
            this.popDelete.Name = "popDelete";
            this.popDelete.Size = new System.Drawing.Size(167, 24);
            this.popDelete.Text = "레코드 삭제";
            this.popDelete.Click += new System.EventHandler(this.popDelete_Click);
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.sQLToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(757, 28);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.toolStripMenuItem2,
            this.mnuFileMigration,
            this.toolStripMenuItem1,
            this.mnuFileOpen,
            this.mnuUpdateTable,
            this.mnuCreateTable,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(224, 26);
            this.mnuFileNew.Text = "New";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuFileMigration
            // 
            this.mnuFileMigration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileImport,
            this.mnuFileExport});
            this.mnuFileMigration.Name = "mnuFileMigration";
            this.mnuFileMigration.Size = new System.Drawing.Size(224, 26);
            this.mnuFileMigration.Text = "Migration ... (.csv)";
            // 
            // mnuFileImport
            // 
            this.mnuFileImport.Name = "mnuFileImport";
            this.mnuFileImport.Size = new System.Drawing.Size(224, 26);
            this.mnuFileImport.Text = "Import";
            this.mnuFileImport.Click += new System.EventHandler(this.mnuFileImport_Click);
            // 
            // mnuFileExport
            // 
            this.mnuFileExport.Name = "mnuFileExport";
            this.mnuFileExport.Size = new System.Drawing.Size(224, 26);
            this.mnuFileExport.Text = "Export";
            this.mnuFileExport.Click += new System.EventHandler(this.mnuFileExport_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(224, 26);
            this.mnuFileOpen.Text = "Open";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuUpdateTable
            // 
            this.mnuUpdateTable.Name = "mnuUpdateTable";
            this.mnuUpdateTable.Size = new System.Drawing.Size(224, 26);
            this.mnuUpdateTable.Text = "Update table";
            // 
            // mnuCreateTable
            // 
            this.mnuCreateTable.Name = "mnuCreateTable";
            this.mnuCreateTable.Size = new System.Drawing.Size(224, 26);
            this.mnuCreateTable.Text = "Create table";
            this.mnuCreateTable.Click += new System.EventHandler(this.mnuCreateTable_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
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
            this.mnuColAdd.Size = new System.Drawing.Size(181, 26);
            this.mnuColAdd.Text = "Colunm 추가";
            this.mnuColAdd.Click += new System.EventHandler(this.mnuColAdd_Click);
            // 
            // mnuRowAdd
            // 
            this.mnuRowAdd.Name = "mnuRowAdd";
            this.mnuRowAdd.Size = new System.Drawing.Size(181, 26);
            this.mnuRowAdd.Text = "Row 추가";
            this.mnuRowAdd.Click += new System.EventHandler(this.mnuRowAdd_Click);
            // 
            // sQLToolStripMenuItem
            // 
            this.sQLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSqlExecute});
            this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.sQLToolStripMenuItem.Text = "SQL";
            // 
            // mnuSqlExecute
            // 
            this.mnuSqlExecute.Name = "mnuSqlExecute";
            this.mnuSqlExecute.Size = new System.Drawing.Size(144, 26);
            this.mnuSqlExecute.Text = "Execute";
            this.mnuSqlExecute.Click += new System.EventHandler(this.mnuSqlExecute_Click);
            // 
            // tbMemo
            // 
            this.tbMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMemo.ContextMenuStrip = this.popupMenu2;
            this.tbMemo.Location = new System.Drawing.Point(0, 0);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.Size = new System.Drawing.Size(754, 194);
            this.tbMemo.TabIndex = 3;
            this.tbMemo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMemo_KeyDown);
            // 
            // popupMenu2
            // 
            this.popupMenu2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.popupMenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.popSelectedExecute});
            this.popupMenu2.Name = "popupMenu2";
            this.popupMenu2.Size = new System.Drawing.Size(191, 28);
            // 
            // popSelectedExecute
            // 
            this.popSelectedExecute.Name = "popSelectedExecute";
            this.popSelectedExecute.Size = new System.Drawing.Size(190, 24);
            this.popSelectedExecute.Text = "selected execute";
            this.popSelectedExecute.Click += new System.EventHandler(this.popSelectedExecute_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 31);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbMemo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dbGrid);
            this.splitContainer1.Size = new System.Drawing.Size(757, 394);
            this.splitContainer1.SplitterDistance = 197;
            this.splitContainer1.TabIndex = 4;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbLabel1,
            this.sbLabel2});
            this.statusStrip.Location = new System.Drawing.Point(0, 424);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(757, 26);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // sbLabel1
            // 
            this.sbLabel1.Name = "sbLabel1";
            this.sbLabel1.Size = new System.Drawing.Size(68, 20);
            this.sbLabel1.Text = "sbLabel1";
            // 
            // sbLabel2
            // 
            this.sbLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sbLabel2.Image = ((System.Drawing.Image)(resources.GetObject("sbLabel2.Image")));
            this.sbLabel2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbLabel2.Name = "sbLabel2";
            this.sbLabel2.Size = new System.Drawing.Size(82, 24);
            this.sbLabel2.Text = "sbLabel2";
            this.sbLabel2.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.sbLabel2_DropDownItemClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).EndInit();
            this.PopupMenu1.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.popupMenu2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbGrid;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateTable;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateTable;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox tbMemo;
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel1;
        private System.Windows.Forms.ToolStripDropDownButton sbLabel2;
        private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSqlExecute;
        private System.Windows.Forms.ContextMenuStrip popupMenu2;
        private System.Windows.Forms.ToolStripMenuItem popSelectedExecute;
        private System.Windows.Forms.ToolStripMenuItem popUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem popInsert;
        private System.Windows.Forms.ToolStripMenuItem popDelete;
        private System.Windows.Forms.ToolStripMenuItem popColDelete;
        private System.Windows.Forms.ToolStripMenuItem popRowDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuFileImport;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

