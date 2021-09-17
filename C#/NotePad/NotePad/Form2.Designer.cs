
namespace NotePad
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnForm2OK = new System.Windows.Forms.Button();
            this.btnForm2Cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSpeed = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.rbCom1 = new System.Windows.Forms.RadioButton();
            this.rbCom2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDatabit = new System.Windows.Forms.ComboBox();
            this.cbStopbit = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnForm2OK
            // 
            this.btnForm2OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.btnForm2OK, "btnForm2OK");
            this.btnForm2OK.Name = "btnForm2OK";
            this.btnForm2OK.UseVisualStyleBackColor = true;
            // 
            // btnForm2Cancel
            // 
            this.btnForm2Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnForm2Cancel, "btnForm2Cancel");
            this.btnForm2Cancel.Name = "btnForm2Cancel";
            this.btnForm2Cancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cbSpeed
            // 
            this.cbSpeed.FormattingEnabled = true;
            this.cbSpeed.Items.AddRange(new object[] {
            resources.GetString("cbSpeed.Items"),
            resources.GetString("cbSpeed.Items1"),
            resources.GetString("cbSpeed.Items2")});
            resources.ApplyResources(this.cbSpeed, "cbSpeed");
            this.cbSpeed.Name = "cbSpeed";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            resources.GetString("cbParity.Items"),
            resources.GetString("cbParity.Items1"),
            resources.GetString("cbParity.Items2")});
            resources.ApplyResources(this.cbParity, "cbParity");
            this.cbParity.Name = "cbParity";
            // 
            // rbCom1
            // 
            resources.ApplyResources(this.rbCom1, "rbCom1");
            this.rbCom1.Checked = true;
            this.rbCom1.Name = "rbCom1";
            this.rbCom1.TabStop = true;
            this.rbCom1.UseVisualStyleBackColor = true;
            // 
            // rbCom2
            // 
            resources.ApplyResources(this.rbCom2, "rbCom2");
            this.rbCom2.Name = "rbCom2";
            this.rbCom2.TabStop = true;
            this.rbCom2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCom2);
            this.groupBox1.Controls.Add(this.rbCom1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // cbDatabit
            // 
            this.cbDatabit.FormattingEnabled = true;
            this.cbDatabit.Items.AddRange(new object[] {
            resources.GetString("cbDatabit.Items"),
            resources.GetString("cbDatabit.Items1")});
            resources.ApplyResources(this.cbDatabit, "cbDatabit");
            this.cbDatabit.Name = "cbDatabit";
            // 
            // cbStopbit
            // 
            this.cbStopbit.FormattingEnabled = true;
            resources.ApplyResources(this.cbStopbit, "cbStopbit");
            this.cbStopbit.Name = "cbStopbit";
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbStopbit);
            this.Controls.Add(this.cbParity);
            this.Controls.Add(this.cbDatabit);
            this.Controls.Add(this.cbSpeed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnForm2Cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnForm2OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnForm2OK;
        private System.Windows.Forms.Button btnForm2Cancel;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbSpeed;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbParity;
        public System.Windows.Forms.RadioButton rbCom1;
        public System.Windows.Forms.RadioButton rbCom2;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbDatabit;
        public System.Windows.Forms.ComboBox cbStopbit;
    }
}