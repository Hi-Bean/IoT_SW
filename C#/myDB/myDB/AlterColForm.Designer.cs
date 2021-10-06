
namespace myDB
{
    partial class AlterColForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbMaxLen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnNULLno = new System.Windows.Forms.RadioButton();
            this.rbtnNULLyes = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "TYPE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "MAX LENGTH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "NULLABLE";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(160, 39);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(156, 23);
            this.cbType.TabIndex = 1;
            // 
            // tbMaxLen
            // 
            this.tbMaxLen.Location = new System.Drawing.Point(160, 83);
            this.tbMaxLen.Name = "tbMaxLen";
            this.tbMaxLen.Size = new System.Drawing.Size(157, 25);
            this.tbMaxLen.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnNULLno);
            this.groupBox1.Controls.Add(this.rbtnNULLyes);
            this.groupBox1.Location = new System.Drawing.Point(160, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 92);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rbtnNULLno
            // 
            this.rbtnNULLno.AutoSize = true;
            this.rbtnNULLno.Location = new System.Drawing.Point(20, 56);
            this.rbtnNULLno.Name = "rbtnNULLno";
            this.rbtnNULLno.Size = new System.Drawing.Size(49, 19);
            this.rbtnNULLno.TabIndex = 0;
            this.rbtnNULLno.Text = "NO";
            this.rbtnNULLno.UseVisualStyleBackColor = true;
            // 
            // rbtnNULLyes
            // 
            this.rbtnNULLyes.AutoSize = true;
            this.rbtnNULLyes.Checked = true;
            this.rbtnNULLyes.Location = new System.Drawing.Point(20, 22);
            this.rbtnNULLyes.Name = "rbtnNULLyes";
            this.rbtnNULLyes.Size = new System.Drawing.Size(55, 19);
            this.rbtnNULLyes.TabIndex = 0;
            this.rbtnNULLyes.TabStop = true;
            this.rbtnNULLyes.Text = "YES";
            this.rbtnNULLyes.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(85, 235);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 32);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Location = new System.Drawing.Point(200, 235);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(80, 32);
            this.btnCANCEL.TabIndex = 4;
            this.btnCANCEL.Text = "cancel";
            this.btnCANCEL.UseVisualStyleBackColor = true;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // AlterColForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCANCEL;
            this.ClientSize = new System.Drawing.Size(403, 292);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbMaxLen);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AlterColForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ALTER COLUMN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCANCEL;
        public System.Windows.Forms.ComboBox cbType;
        public System.Windows.Forms.TextBox tbMaxLen;
        public System.Windows.Forms.RadioButton rbtnNULLno;
        public System.Windows.Forms.RadioButton rbtnNULLyes;
        public System.Windows.Forms.Button btnOK;
    }
}