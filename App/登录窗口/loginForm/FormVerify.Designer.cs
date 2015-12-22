namespace loginForm
{
    partial class FormVerify
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
            this.verifyDifferSelector1 = new VerifyDifferSelector.VerifyDifferSelector();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWithButton备注 = new CustomTextBox.TextBoxWithButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxWithButton备注);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.verifyDifferSelector1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Size = new System.Drawing.Size(261, 152);
            this.groupBox1.Controls.SetChildIndex(this.label3, 0);
            this.groupBox1.Controls.SetChildIndex(this.verifyDifferSelector1, 0);
            this.groupBox1.Controls.SetChildIndex(this.label4, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBoxWithButton备注, 0);
            // 
            // panelButtons
            // 
            this.panelButtons.Location = new System.Drawing.Point(0, 232);
            // 
            // verifyDifferSelector1
            // 
            this.verifyDifferSelector1.ConnectionSqlString = null;
            this.verifyDifferSelector1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.verifyDifferSelector1.FormattingEnabled = true;
            this.verifyDifferSelector1.Location = new System.Drawing.Point(83, 88);
            this.verifyDifferSelector1.Name = "verifyDifferSelector1";
            this.verifyDifferSelector1.Size = new System.Drawing.Size(166, 20);
            this.verifyDifferSelector1.TabIndex = 2;
            this.verifyDifferSelector1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "审核意见：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "备注：";
            // 
            // textBoxWithButton备注
            // 
            this.textBoxWithButton备注.errorMessage = null;
            this.textBoxWithButton备注.FormAdvanceCaption = "详细内容";
            this.textBoxWithButton备注.Location = new System.Drawing.Point(83, 121);
            this.textBoxWithButton备注.Name = "textBoxWithButton备注";
            this.textBoxWithButton备注.Size = new System.Drawing.Size(166, 21);
            this.textBoxWithButton备注.TabIndex = 5;
            // 
            // FormVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 282);
            this.HelpText = "注意：尽量避免审核自己的行为，虽然系统允许这么做。";
            this.MaxSize = new System.Drawing.Size(291, 314);
            this.MinSize = new System.Drawing.Size(291, 314);
            this.Name = "FormVerify";
            this.Text = "FormVerify";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private VerifyDifferSelector.VerifyDifferSelector verifyDifferSelector1;
        private CustomTextBox.TextBoxWithButton textBoxWithButton备注;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}