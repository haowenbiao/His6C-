namespace SupplierInformations.DataOperate
{
    partial class FormSupplierInformationBase
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
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox拼音码 = new System.Windows.Forms.TextBox();
            this.textBox名称 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxWithButton备注 = new CustomTextBox.TextBoxWithButton();
            this.textBox传真 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox联系电话 = new System.Windows.Forms.TextBox();
            this.textBox邮编 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox地址 = new System.Windows.Forms.TextBox();
            this.textBox负责人 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Location = new System.Drawing.Point(0, 356);
            this.panelButtons.Size = new System.Drawing.Size(292, 50);
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label32.Enabled = false;
            this.label32.Location = new System.Drawing.Point(6, 358);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(280, 1);
            this.label32.TabIndex = 43;
            this.label32.Text = "label32";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox拼音码);
            this.groupBox1.Controls.Add(this.textBox名称);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // textBox拼音码
            // 
            this.textBox拼音码.Location = new System.Drawing.Point(77, 44);
            this.textBox拼音码.Name = "textBox拼音码";
            this.textBox拼音码.Size = new System.Drawing.Size(174, 21);
            this.textBox拼音码.TabIndex = 1;
            this.textBox拼音码.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            this.textBox拼音码.Validating += new System.ComponentModel.CancelEventHandler(this.NoneNullabletextBox_Validating);
            // 
            // textBox名称
            // 
            this.textBox名称.Location = new System.Drawing.Point(77, 17);
            this.textBox名称.Name = "textBox名称";
            this.textBox名称.Size = new System.Drawing.Size(174, 21);
            this.textBox名称.TabIndex = 0;
            this.textBox名称.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            this.textBox名称.Validating += new System.ComponentModel.CancelEventHandler(this.NoneNullabletextBox_Validating);
            this.textBox名称.Validated += new System.EventHandler(this.textBox名称_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "拼音码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxWithButton备注);
            this.groupBox2.Controls.Add(this.textBox传真);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox联系电话);
            this.groupBox2.Controls.Add(this.textBox邮编);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox地址);
            this.groupBox2.Controls.Add(this.textBox负责人);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 184);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "附加信息";
            // 
            // textBoxWithButton备注
            // 
            this.textBoxWithButton备注.errorMessage = null;
            this.textBoxWithButton备注.FormAdvanceCaption = "详细内容";
            this.textBoxWithButton备注.Location = new System.Drawing.Point(77, 155);
            this.textBoxWithButton备注.Name = "textBoxWithButton备注";
            this.textBoxWithButton备注.Size = new System.Drawing.Size(174, 21);
            this.textBoxWithButton备注.TabIndex = 14;
            // 
            // textBox传真
            // 
            this.textBox传真.Location = new System.Drawing.Point(77, 127);
            this.textBox传真.Name = "textBox传真";
            this.textBox传真.Size = new System.Drawing.Size(174, 21);
            this.textBox传真.TabIndex = 4;
            this.textBox传真.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "备注：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "传真：";
            // 
            // textBox联系电话
            // 
            this.textBox联系电话.Location = new System.Drawing.Point(77, 100);
            this.textBox联系电话.Name = "textBox联系电话";
            this.textBox联系电话.Size = new System.Drawing.Size(174, 21);
            this.textBox联系电话.TabIndex = 3;
            this.textBox联系电话.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            // 
            // textBox邮编
            // 
            this.textBox邮编.Location = new System.Drawing.Point(77, 73);
            this.textBox邮编.Name = "textBox邮编";
            this.textBox邮编.Size = new System.Drawing.Size(174, 21);
            this.textBox邮编.TabIndex = 2;
            this.textBox邮编.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "联系电话：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "邮编：";
            // 
            // textBox地址
            // 
            this.textBox地址.Location = new System.Drawing.Point(77, 46);
            this.textBox地址.Name = "textBox地址";
            this.textBox地址.Size = new System.Drawing.Size(174, 21);
            this.textBox地址.TabIndex = 1;
            this.textBox地址.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            // 
            // textBox负责人
            // 
            this.textBox负责人.Location = new System.Drawing.Point(77, 19);
            this.textBox负责人.Name = "textBox负责人";
            this.textBox负责人.Size = new System.Drawing.Size(174, 21);
            this.textBox负责人.TabIndex = 0;
            this.textBox负责人.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "地址：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "负责人：";
            // 
            // FormSupplierInformationBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = null;
            this.ClientSize = new System.Drawing.Size(292, 406);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.groupBox2);
            this.HelpText = "提示：基本信息为必填项目。使用Tab键可以在输入框之间快速切换。单击...按钮显示高级信息。";
            this.MaxSize = new System.Drawing.Size(300, 440);
            this.MinSize = new System.Drawing.Size(300, 234);
            this.Name = "FormSupplierInformationBase";
            this.Text = "FormSupplierInformationsBase";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.label32, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox名称;
        private System.Windows.Forms.TextBox textBox拼音码;
        private System.Windows.Forms.TextBox textBox传真;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox联系电话;
        private System.Windows.Forms.TextBox textBox邮编;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox地址;
        private System.Windows.Forms.TextBox textBox负责人;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustomTextBox.TextBoxWithButton textBoxWithButton备注;
    }
}