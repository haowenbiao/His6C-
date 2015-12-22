namespace TestTextBoxWithButton
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxWithControlDataGridView2 = new CustomTextBox.ComboBoxWithControlDataGridView();
            this.comboBoxWithControlDataGridView1 = new CustomTextBox.ComboBoxWithControlDataGridView();
            this.currencyTextBox2 = new CustomTextBox.CurrencyTextBox();
            this.currencyTextBox1 = new CustomTextBox.CurrencyTextBox();
            this.dateTimeTextBox1 = new CustomTextBox.DateTimeTextBox();
            this.SuspendLayout();
            // 
            // comboBoxWithControlDataGridView2
            // 
            this.comboBoxWithControlDataGridView2.DropDownAutoClosed = false;
            this.comboBoxWithControlDataGridView2.DropDownBackColor = System.Drawing.SystemColors.Control;
            this.comboBoxWithControlDataGridView2.FormattingEnabled = true;
            this.comboBoxWithControlDataGridView2.Location = new System.Drawing.Point(285, 129);
            this.comboBoxWithControlDataGridView2.Name = "comboBoxWithControlDataGridView2";
            this.comboBoxWithControlDataGridView2.Size = new System.Drawing.Size(121, 20);
            this.comboBoxWithControlDataGridView2.TabIndex = 3;
            // 
            // comboBoxWithControlDataGridView1
            // 
            this.comboBoxWithControlDataGridView1.DropDownAutoClosed = false;
            this.comboBoxWithControlDataGridView1.DropDownBackColor = System.Drawing.SystemColors.Control;
            this.comboBoxWithControlDataGridView1.FormattingEnabled = true;
            this.comboBoxWithControlDataGridView1.Location = new System.Drawing.Point(73, 130);
            this.comboBoxWithControlDataGridView1.Name = "comboBoxWithControlDataGridView1";
            this.comboBoxWithControlDataGridView1.Size = new System.Drawing.Size(121, 20);
            this.comboBoxWithControlDataGridView1.TabIndex = 2;
            // 
            // currencyTextBox2
            // 
            this.currencyTextBox2.errorMessage = null;
            this.currencyTextBox2.Location = new System.Drawing.Point(97, 91);
            this.currencyTextBox2.Name = "currencyTextBox2";
            this.currencyTextBox2.Size = new System.Drawing.Size(100, 21);
            this.currencyTextBox2.TabIndex = 1;
            this.currencyTextBox2.Text = "￥0.00";
            this.currencyTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.currencyTextBox2.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // currencyTextBox1
            // 
            this.currencyTextBox1.errorMessage = null;
            this.currencyTextBox1.Location = new System.Drawing.Point(97, 44);
            this.currencyTextBox1.Name = "currencyTextBox1";
            this.currencyTextBox1.Size = new System.Drawing.Size(100, 21);
            this.currencyTextBox1.TabIndex = 0;
            this.currencyTextBox1.Text = "￥0.00";
            this.currencyTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.currencyTextBox1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // dateTimeTextBox1
            // 
            this.dateTimeTextBox1.errorMessage = null;
            this.dateTimeTextBox1.Location = new System.Drawing.Point(169, 181);
            this.dateTimeTextBox1.Name = "dateTimeTextBox1";
            this.dateTimeTextBox1.Size = new System.Drawing.Size(100, 21);
            this.dateTimeTextBox1.TabIndex = 4;
            this.dateTimeTextBox1.Text = "2010年3月3日星期三";
            this.dateTimeTextBox1.Value = new System.DateTime(2010, 3, 3, 0, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 266);
            this.Controls.Add(this.dateTimeTextBox1);
            this.Controls.Add(this.comboBoxWithControlDataGridView2);
            this.Controls.Add(this.comboBoxWithControlDataGridView1);
            this.Controls.Add(this.currencyTextBox2);
            this.Controls.Add(this.currencyTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomTextBox.CurrencyTextBox currencyTextBox1;
        private CustomTextBox.CurrencyTextBox currencyTextBox2;
        private CustomTextBox.ComboBoxWithControlDataGridView comboBoxWithControlDataGridView1;
        private CustomTextBox.ComboBoxWithControlDataGridView comboBoxWithControlDataGridView2;
        private CustomTextBox.DateTimeTextBox dateTimeTextBox1;




    }
}

