namespace AuthoritySet
{
    partial class FormChangePassWord
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOriginalPassWord = new System.Windows.Forms.TextBox();
            this.textBoxNewPassWord = new System.Windows.Forms.TextBox();
            this.textBoxConfirmPassWord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(178, 171);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "关闭(&ESC)";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(97, 171);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "保存(&S)";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(3, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 1);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "原密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "新密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "确认密码：";
            // 
            // textBoxOriginalPassWord
            // 
            this.textBoxOriginalPassWord.Location = new System.Drawing.Point(82, 63);
            this.textBoxOriginalPassWord.Name = "textBoxOriginalPassWord";
            this.textBoxOriginalPassWord.PasswordChar = '*';
            this.textBoxOriginalPassWord.Size = new System.Drawing.Size(162, 21);
            this.textBoxOriginalPassWord.TabIndex = 0;
            this.textBoxOriginalPassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassWord_KeyDown);
            this.textBoxOriginalPassWord.Enter += new System.EventHandler(this.textBoxPassWord_Enter);
            // 
            // textBoxNewPassWord
            // 
            this.textBoxNewPassWord.Location = new System.Drawing.Point(82, 93);
            this.textBoxNewPassWord.Name = "textBoxNewPassWord";
            this.textBoxNewPassWord.PasswordChar = '*';
            this.textBoxNewPassWord.Size = new System.Drawing.Size(162, 21);
            this.textBoxNewPassWord.TabIndex = 1;
            this.textBoxNewPassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassWord_KeyDown);
            this.textBoxNewPassWord.Enter += new System.EventHandler(this.textBoxPassWord_Enter);
            // 
            // textBoxConfirmPassWord
            // 
            this.textBoxConfirmPassWord.Location = new System.Drawing.Point(82, 123);
            this.textBoxConfirmPassWord.Name = "textBoxConfirmPassWord";
            this.textBoxConfirmPassWord.PasswordChar = '*';
            this.textBoxConfirmPassWord.Size = new System.Drawing.Size(162, 21);
            this.textBoxConfirmPassWord.TabIndex = 2;
            this.textBoxConfirmPassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassWord_KeyDown);
            this.textBoxConfirmPassWord.Enter += new System.EventHandler(this.textBoxPassWord_Enter);
            // 
            // FormChangePassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(265, 206);
            this.Controls.Add(this.textBoxNewPassWord);
            this.Controls.Add(this.textBoxConfirmPassWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOriginalPassWord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.HelpText = "注意：如果您的密码包含大写字母，您必须在每次登录时用同样的方式输入。";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChangePassWord";
            this.Text = "更改密码";
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.buttonOK, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textBoxOriginalPassWord, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBoxConfirmPassWord, 0);
            this.Controls.SetChildIndex(this.textBoxNewPassWord, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOriginalPassWord;
        private System.Windows.Forms.TextBox textBoxNewPassWord;
        private System.Windows.Forms.TextBox textBoxConfirmPassWord;
    }
}