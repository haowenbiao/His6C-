namespace MedicineStock.DataOperate
{
    partial class FormStockDetail
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
            this.textBox计量单位 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWithButton备注 = new CustomTextBox.TextBoxWithButton();
            this.label3 = new System.Windows.Forms.Label();
            this.currencyTextBox进货单价 = new CustomTextBox.CurrencyTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numberTextBox进货数量 = new CustomTextBox.NumberTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.medicineKindSelectControl1 = new MedicineKindSelectControl.MedicineKindSelectControl();
            this.medicineBatchControl1 = new MedicineBatchControl.MedicineBatchControl();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceListItem)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox计量单位);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxWithButton备注);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.currencyTextBox进货单价);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numberTextBox进货数量);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.medicineKindSelectControl1);
            this.groupBox1.Controls.Add(this.medicineBatchControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "进货明细信息";
            // 
            // textBox计量单位
            // 
            this.textBox计量单位.Location = new System.Drawing.Point(87, 155);
            this.textBox计量单位.Name = "textBox计量单位";
            this.textBox计量单位.ReadOnly = true;
            this.textBox计量单位.Size = new System.Drawing.Size(114, 21);
            this.textBox计量单位.TabIndex = 2;
            this.textBox计量单位.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "计量单位：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "备注：";
            // 
            // textBoxWithButton备注
            // 
            this.textBoxWithButton备注.errorMessage = null;
            this.textBoxWithButton备注.FormAdvanceCaption = "详细内容";
            this.textBoxWithButton备注.Location = new System.Drawing.Point(87, 233);
            this.textBoxWithButton备注.Name = "textBoxWithButton备注";
            this.textBoxWithButton备注.Size = new System.Drawing.Size(114, 21);
            this.textBoxWithButton备注.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "进货单价：";
            // 
            // currencyTextBox进货单价
            // 
            this.currencyTextBox进货单价.errorMessage = null;
            this.currencyTextBox进货单价.Location = new System.Drawing.Point(87, 207);
            this.currencyTextBox进货单价.Name = "currencyTextBox进货单价";
            this.currencyTextBox进货单价.Size = new System.Drawing.Size(114, 21);
            this.currencyTextBox进货单价.TabIndex = 4;
            this.currencyTextBox进货单价.Text = "￥0.00";
            this.currencyTextBox进货单价.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.currencyTextBox进货单价.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "进货数量：";
            // 
            // numberTextBox进货数量
            // 
            this.numberTextBox进货数量.errorMessage = null;
            this.numberTextBox进货数量.Location = new System.Drawing.Point(87, 181);
            this.numberTextBox进货数量.Name = "numberTextBox进货数量";
            this.numberTextBox进货数量.Size = new System.Drawing.Size(114, 21);
            this.numberTextBox进货数量.TabIndex = 3;
            this.numberTextBox进货数量.Text = "0";
            this.numberTextBox进货数量.Value = ((long)(0));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "药品名称：";
            // 
            // medicineKindSelectControl1
            // 
            this.medicineKindSelectControl1.FormattingEnabled = true;
            this.medicineKindSelectControl1.IntegralHeight = false;
            this.medicineKindSelectControl1.Location = new System.Drawing.Point(87, 17);
            this.medicineKindSelectControl1.Name = "medicineKindSelectControl1";
            this.medicineKindSelectControl1.Size = new System.Drawing.Size(114, 20);
            this.medicineKindSelectControl1.TabIndex = 0;
            this.medicineKindSelectControl1.SelectedValueChanged += new System.EventHandler(this.medicineKindSelectControl1_SelectedValueChanged);
            this.medicineKindSelectControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            // 
            // medicineBatchControl1
            // 
            this.medicineBatchControl1.Enabled = false;
            this.medicineBatchControl1.Location = new System.Drawing.Point(10, 43);
            this.medicineBatchControl1.LoginInformation = null;
            this.medicineBatchControl1.Name = "medicineBatchControl1";
            this.medicineBatchControl1.Size = new System.Drawing.Size(224, 103);
            this.medicineBatchControl1.TabIndex = 1;
            // 
            // FormStockDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 384);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaxSize = new System.Drawing.Size(270, 416);
            this.MinimizeBox = false;
            this.MinSize = new System.Drawing.Size(270, 416);
            this.Name = "FormStockDetail";
            this.ShowResizeButton = false;
            this.Text = "增加进货明细";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceListItem)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private MedicineKindSelectControl.MedicineKindSelectControl medicineKindSelectControl1;
        private MedicineBatchControl.MedicineBatchControl medicineBatchControl1;
        private System.Windows.Forms.Label label2;
        private CustomTextBox.NumberTextBox numberTextBox进货数量;
        private System.Windows.Forms.Label label4;
        private CustomTextBox.TextBoxWithButton textBoxWithButton备注;
        private System.Windows.Forms.Label label3;
        private CustomTextBox.CurrencyTextBox currencyTextBox进货单价;
        private System.Windows.Forms.TextBox textBox计量单位;
        private System.Windows.Forms.Label label6;
    }
}