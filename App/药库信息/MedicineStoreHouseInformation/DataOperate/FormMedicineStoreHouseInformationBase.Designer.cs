namespace MedicineStoreHouseInformation.DataOperate
{
    partial class FormMedicineStoreHouseInformationBase
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxWithButton备注 = new CustomTextBox.TextBoxWithButton();
            this.textBox负责人 = new System.Windows.Forms.TextBox();
            this.comboBox药库类型 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox拼音码 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox位置 = new System.Windows.Forms.TextBox();
            this.textBox药库名称 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Location = new System.Drawing.Point(0, 275);
            this.panelButtons.Size = new System.Drawing.Size(292, 50);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox药库类型);
            this.groupBox1.Controls.Add(this.textBox拼音码);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox药库名称);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // textBoxWithButton备注
            // 
            this.textBoxWithButton备注.errorMessage = null;
            this.textBoxWithButton备注.FormAdvanceCaption = "详细内容";
            this.textBoxWithButton备注.Location = new System.Drawing.Point(100, 67);
            this.textBoxWithButton备注.Name = "textBoxWithButton备注";
            this.textBoxWithButton备注.Size = new System.Drawing.Size(150, 21);
            this.textBoxWithButton备注.TabIndex = 5;
            // 
            // textBox负责人
            // 
            this.textBox负责人.Location = new System.Drawing.Point(100, 43);
            this.textBox负责人.Name = "textBox负责人";
            this.textBox负责人.Size = new System.Drawing.Size(150, 21);
            this.textBox负责人.TabIndex = 4;
            this.textBox负责人.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            // 
            // comboBox药库类型
            // 
            this.comboBox药库类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox药库类型.FormattingEnabled = true;
            this.comboBox药库类型.Location = new System.Drawing.Point(101, 69);
            this.comboBox药库类型.Name = "comboBox药库类型";
            this.comboBox药库类型.Size = new System.Drawing.Size(150, 20);
            this.comboBox药库类型.TabIndex = 2;
            this.toolTip1.SetToolTip(this.comboBox药库类型, "注意：药库类型不同的药库具有不同的要求：\r\n药库类型为“库房”的药库只能存放药品和调库，\r\n药库类型为“门诊药房”的药品只能进行门诊处方取药，\r\n药库类型为“住院" +
        "药房”的药库只能进行住院处方取药，\r\n药库类型为“门诊住院药房”的药库既可进行门诊处方取药，也可进行住院处方取药。");
            this.comboBox药库类型.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "药库位置：";
            // 
            // textBox拼音码
            // 
            this.textBox拼音码.Location = new System.Drawing.Point(101, 46);
            this.textBox拼音码.Name = "textBox拼音码";
            this.textBox拼音码.Size = new System.Drawing.Size(150, 21);
            this.textBox拼音码.TabIndex = 1;
            this.textBox拼音码.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            this.textBox拼音码.Validating += new System.ComponentModel.CancelEventHandler(this.NoneNullabletextBox_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "拼音码：";
            // 
            // textBox位置
            // 
            this.textBox位置.Location = new System.Drawing.Point(100, 20);
            this.textBox位置.Name = "textBox位置";
            this.textBox位置.Size = new System.Drawing.Size(150, 21);
            this.textBox位置.TabIndex = 3;
            this.textBox位置.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            // 
            // textBox药库名称
            // 
            this.textBox药库名称.Location = new System.Drawing.Point(101, 23);
            this.textBox药库名称.Name = "textBox药库名称";
            this.textBox药库名称.Size = new System.Drawing.Size(150, 21);
            this.textBox药库名称.TabIndex = 0;
            this.textBox药库名称.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            this.textBox药库名称.Validating += new System.ComponentModel.CancelEventHandler(this.NoneNullabletextBox_Validating);
            this.textBox药库名称.Validated += new System.EventHandler(this.textBox名称_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "备注：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "药库类型：";
            this.toolTip1.SetToolTip(this.label3, "注意：药库类型不同的药库具有不同的要求：\r\n药库类型为“库房”的药库只能存放药品和调库，\r\n药库类型为“门诊药房”的药品只能进行门诊处方取药，\r\n药库类型为“住院" +
        "药房”的药库只能进行住院处方取药，\r\n药库类型为“门诊住院药房”的药库既可进行门诊处方取药，也可进行住院处方取药。");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "药库负责人：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "药库名称：";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxWithButton备注);
            this.groupBox2.Controls.Add(this.textBox负责人);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox位置);
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "附加信息";
            // 
            // FormMedicineStoreHouseInformationBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 325);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.HelpText = "注意：药库类型不同的药库具有不同的功能和要求。";
            this.MaxSize = new System.Drawing.Size(300, 359);
            this.MinSize = new System.Drawing.Size(300, 258);
            this.Name = "FormMedicineStoreHouseInformationBase";
            this.Text = "FormMedicineStoreHouseInformationBase";
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox药库类型;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox拼音码;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox位置;
        private System.Windows.Forms.TextBox textBox药库名称;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox负责人;
        private CustomTextBox.TextBoxWithButton textBoxWithButton备注;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}