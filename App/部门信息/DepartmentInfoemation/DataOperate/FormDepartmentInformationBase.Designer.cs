namespace DepartmentInformation.DataOperate
{
    partial class FormDepartmentInformationBase
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox名称 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox部门类型 = new System.Windows.Forms.ComboBox();
            this.textBox拼音码 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxWithButton备注 = new CustomTextBox.TextBoxWithButton();
            this.textBox负责人 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 258);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox名称);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox部门类型);
            this.groupBox1.Controls.Add(this.textBox拼音码);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // textBox名称
            // 
            this.textBox名称.Location = new System.Drawing.Point(81, 20);
            this.textBox名称.Name = "textBox名称";
            this.textBox名称.Size = new System.Drawing.Size(100, 21);
            this.textBox名称.TabIndex = 0;
            this.textBox名称.Validated += new System.EventHandler(this.textBox名称_Validated);
            this.textBox名称.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            this.textBox名称.Validating += new System.ComponentModel.CancelEventHandler(this.NoneNullabletextBox_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "名称：";
            // 
            // comboBox部门类型
            // 
            this.comboBox部门类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox部门类型.FormattingEnabled = true;
            this.comboBox部门类型.Location = new System.Drawing.Point(81, 74);
            this.comboBox部门类型.Name = "comboBox部门类型";
            this.comboBox部门类型.Size = new System.Drawing.Size(100, 20);
            this.comboBox部门类型.TabIndex = 2;
            this.comboBox部门类型.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            // 
            // textBox拼音码
            // 
            this.textBox拼音码.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox拼音码.Location = new System.Drawing.Point(81, 47);
            this.textBox拼音码.Name = "textBox拼音码";
            this.textBox拼音码.Size = new System.Drawing.Size(100, 21);
            this.textBox拼音码.TabIndex = 1;
            this.textBox拼音码.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            this.textBox拼音码.Validating += new System.ComponentModel.CancelEventHandler(this.NoneNullabletextBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "部门类型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "拼音码：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxWithButton备注);
            this.groupBox2.Controls.Add(this.textBox负责人);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(14, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "附加信息";
            // 
            // textBoxWithButton备注
            // 
            this.textBoxWithButton备注.errorMessage = null;
            this.textBoxWithButton备注.FormAdvanceCaption = "备注";
            this.textBoxWithButton备注.Location = new System.Drawing.Point(81, 47);
            this.textBoxWithButton备注.Name = "textBoxWithButton备注";
            this.textBoxWithButton备注.Size = new System.Drawing.Size(100, 21);
            this.textBoxWithButton备注.TabIndex = 4;
            // 
            // textBox负责人
            // 
            this.textBox负责人.Location = new System.Drawing.Point(81, 20);
            this.textBox负责人.Name = "textBox负责人";
            this.textBox负责人.Size = new System.Drawing.Size(100, 21);
            this.textBox负责人.TabIndex = 3;
            this.textBox负责人.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "备注：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "负责人：";
            // 
            // FormDepartmentInformationBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 302);
            this.Controls.Add(this.panel2);
            this.HelpText = "提示：基本信息为必填项目。使用Tab键可以在输入框之间快速切换。单击...按钮显示高级信息。";
            this.MaximizeBox = false;
            this.MaxSize = new System.Drawing.Size(238, 336);
            this.MinimizeBox = false;
            this.MinSize = new System.Drawing.Size(238, 249);
            this.Name = "FormDepartmentInformationBase";
            this.Text = "部门信息";
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox部门类型;
        private System.Windows.Forms.TextBox textBox拼音码;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private CustomTextBox.TextBoxWithButton textBoxWithButton备注;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox名称;
        private System.Windows.Forms.TextBox textBox负责人;
    }
}