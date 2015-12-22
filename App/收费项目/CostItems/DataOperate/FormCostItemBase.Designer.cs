namespace CostItems.DataOperate
{
    partial class FormCostItemBase
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.doubleTextBox单价 = new CustomTextBox.DoubleTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox计费类型 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox计量单位 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox拼音码 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox收费项目 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxWithButton备注 = new CustomTextBox.TextBoxWithButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.doubleTextBox单价);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox计费类型);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox计量单位);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox拼音码);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox收费项目);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // doubleTextBox单价
            // 
            this.doubleTextBox单价.errorMessage = null;
            this.doubleTextBox单价.Location = new System.Drawing.Point(89, 74);
            this.doubleTextBox单价.Name = "doubleTextBox单价";
            this.doubleTextBox单价.Size = new System.Drawing.Size(159, 21);
            this.doubleTextBox单价.TabIndex = 2;
            this.doubleTextBox单价.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "单价(元)：";
            // 
            // comboBox计费类型
            // 
            this.comboBox计费类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox计费类型.FormattingEnabled = true;
            this.comboBox计费类型.Location = new System.Drawing.Point(89, 127);
            this.comboBox计费类型.Name = "comboBox计费类型";
            this.comboBox计费类型.Size = new System.Drawing.Size(159, 20);
            this.comboBox计费类型.TabIndex = 4;
            this.comboBox计费类型.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "计费类型：";
            // 
            // comboBox计量单位
            // 
            this.comboBox计量单位.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox计量单位.FormattingEnabled = true;
            this.comboBox计量单位.Location = new System.Drawing.Point(89, 101);
            this.comboBox计量单位.Name = "comboBox计量单位";
            this.comboBox计量单位.Size = new System.Drawing.Size(159, 20);
            this.comboBox计量单位.TabIndex = 3;
            this.comboBox计量单位.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "计量单位：";
            // 
            // textBox拼音码
            // 
            this.textBox拼音码.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox拼音码.Location = new System.Drawing.Point(89, 47);
            this.textBox拼音码.Name = "textBox拼音码";
            this.textBox拼音码.Size = new System.Drawing.Size(159, 21);
            this.textBox拼音码.TabIndex = 1;
            this.textBox拼音码.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            this.textBox拼音码.Validating += new System.ComponentModel.CancelEventHandler(this.NoneNullabletextBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "拼音码：";
            // 
            // textBox收费项目
            // 
            this.textBox收费项目.Location = new System.Drawing.Point(89, 20);
            this.textBox收费项目.Name = "textBox收费项目";
            this.textBox收费项目.Size = new System.Drawing.Size(159, 21);
            this.textBox收费项目.TabIndex = 0;
            this.textBox收费项目.Validated += new System.EventHandler(this.textBox名称_Validated);
            this.textBox收费项目.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            this.textBox收费项目.Validating += new System.ComponentModel.CancelEventHandler(this.NoneNullabletextBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "收费项目：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxWithButton备注);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 53);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "附加信息";
            // 
            // textBoxWithButton备注
            // 
            this.textBoxWithButton备注.errorMessage = null;
            this.textBoxWithButton备注.FormAdvanceCaption = "详细内容";
            this.textBoxWithButton备注.Location = new System.Drawing.Point(89, 21);
            this.textBoxWithButton备注.Name = "textBoxWithButton备注";
            this.textBoxWithButton备注.Size = new System.Drawing.Size(159, 21);
            this.textBoxWithButton备注.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "备注：";
            // 
            // FormCostItemBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 331);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaxSize = new System.Drawing.Size(300, 365);
            this.MinSize = new System.Drawing.Size(300, 303);
            this.Name = "FormCostItemBase";
            this.Text = "FormCostItemBase";
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox计费类型;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox计量单位;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox拼音码;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox收费项目;
        private System.Windows.Forms.Label label1;
        private CustomTextBox.TextBoxWithButton textBoxWithButton备注;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private CustomTextBox.DoubleTextBox doubleTextBox单价;
    }
}