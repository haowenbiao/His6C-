namespace CostItemAdjustPrice.DataOperate
{
    partial class FormCostItemAdjustPriceBase
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
            this.currencyTextBox当前单价 = new CustomTextBox.CurrencyTextBox();
            this.textBox计量单位 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxWithButton备注 = new CustomTextBox.TextBoxWithButton();
            this.doubleTextBox调整后单价 = new CustomTextBox.DoubleTextBox();
            this.textBox收费项目名称 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currencyTextBox当前单价);
            this.groupBox1.Controls.Add(this.textBox计量单位);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxWithButton备注);
            this.groupBox1.Controls.Add(this.doubleTextBox调整后单价);
            this.groupBox1.Controls.Add(this.textBox收费项目名称);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // currencyTextBox当前单价
            // 
            this.currencyTextBox当前单价.errorMessage = null;
            this.currencyTextBox当前单价.Location = new System.Drawing.Point(109, 73);
            this.currencyTextBox当前单价.Name = "currencyTextBox当前单价";
            this.currencyTextBox当前单价.ReadOnly = true;
            this.currencyTextBox当前单价.Size = new System.Drawing.Size(149, 21);
            this.currencyTextBox当前单价.TabIndex = 6;
            this.currencyTextBox当前单价.TabStop = false;
            this.currencyTextBox当前单价.Text = "￥0.00";
            this.currencyTextBox当前单价.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.currencyTextBox当前单价.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // textBox计量单位
            // 
            this.textBox计量单位.Location = new System.Drawing.Point(109, 48);
            this.textBox计量单位.Name = "textBox计量单位";
            this.textBox计量单位.ReadOnly = true;
            this.textBox计量单位.Size = new System.Drawing.Size(149, 21);
            this.textBox计量单位.TabIndex = 5;
            this.textBox计量单位.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "计量单位：";
            // 
            // textBoxWithButton备注
            // 
            this.textBoxWithButton备注.errorMessage = null;
            this.textBoxWithButton备注.FormAdvanceCaption = "详细内容";
            this.textBoxWithButton备注.Location = new System.Drawing.Point(109, 123);
            this.textBoxWithButton备注.Name = "textBoxWithButton备注";
            this.textBoxWithButton备注.Size = new System.Drawing.Size(150, 21);
            this.textBoxWithButton备注.TabIndex = 1;
            // 
            // doubleTextBox调整后单价
            // 
            this.doubleTextBox调整后单价.errorMessage = null;
            this.doubleTextBox调整后单价.Location = new System.Drawing.Point(109, 98);
            this.doubleTextBox调整后单价.Name = "doubleTextBox调整后单价";
            this.doubleTextBox调整后单价.Size = new System.Drawing.Size(150, 21);
            this.doubleTextBox调整后单价.TabIndex = 0;
            this.doubleTextBox调整后单价.Text = "0";
            // 
            // textBox收费项目名称
            // 
            this.textBox收费项目名称.Location = new System.Drawing.Point(109, 23);
            this.textBox收费项目名称.Name = "textBox收费项目名称";
            this.textBox收费项目名称.ReadOnly = true;
            this.textBox收费项目名称.Size = new System.Drawing.Size(150, 21);
            this.textBox收费项目名称.TabIndex = 0;
            this.textBox收费项目名称.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "备注：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "调整后单价：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "当前单价(元)：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "收费项目名称：";
            // 
            // FormCostItemAdjustPriceBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.groupBox1);
            this.HelpText = "调整收费项目的当前收费价格。";
            this.MaxSize = new System.Drawing.Size(300, 307);
            this.MinSize = new System.Drawing.Size(300, 307);
            this.Name = "FormCostItemAdjustPriceBase";
            this.Text = "收费项目价格调整";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomTextBox.TextBoxWithButton textBoxWithButton备注;
        private CustomTextBox.DoubleTextBox doubleTextBox调整后单价;
        private System.Windows.Forms.TextBox textBox收费项目名称;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox计量单位;
        private System.Windows.Forms.Label label5;
        private CustomTextBox.CurrencyTextBox currencyTextBox当前单价;
    }
}