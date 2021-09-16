
namespace WindowsFormsApp1
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTest = new System.Windows.Forms.TextBox();
            this.btType = new System.Windows.Forms.Button();
            this.btTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(98, 101);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(140, 25);
            this.tbInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "1. int",
            "2. double",
            "3. string"});
            this.cbType.Location = new System.Drawing.Point(351, 101);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(124, 23);
            this.cbType.TabIndex = 2;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "type";
            // 
            // tbTest
            // 
            this.tbTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTest.Location = new System.Drawing.Point(-2, 142);
            this.tbTest.Multiline = true;
            this.tbTest.Name = "tbTest";
            this.tbTest.Size = new System.Drawing.Size(721, 309);
            this.tbTest.TabIndex = 3;
            // 
            // btType
            // 
            this.btType.Location = new System.Drawing.Point(529, 100);
            this.btType.Name = "btType";
            this.btType.Size = new System.Drawing.Size(117, 25);
            this.btType.TabIndex = 4;
            this.btType.Text = "PARSE";
            this.btType.UseVisualStyleBackColor = true;
            this.btType.Click += new System.EventHandler(this.btType_Click);
            // 
            // btTest
            // 
            this.btTest.Location = new System.Drawing.Point(12, 12);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(117, 25);
            this.btTest.TabIndex = 4;
            this.btTest.Text = "TEST";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.btTest);
            this.Controls.Add(this.btType);
            this.Controls.Add(this.tbTest);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTest;
        private System.Windows.Forms.Button btType;
        private System.Windows.Forms.Button btTest;
    }
}

