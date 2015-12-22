namespace MedicineStock.DataList
{
    internal partial class FormAdvancedSearch
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateSelectControl1 = new DateSelectControl.DateSelectControl();
            this.supplierSelectorComboBoxWithDataGridView1 = new SupplierSelectorlControl.SupplierSelectorComboBoxWithDataGridView();
            this.medicineStoreHouseSelector1 = new MedicineStoreHouseSelector.MedicineStoreHouseSelector();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelButtons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonCancel);
            this.panelButtons.Controls.Add(this.buttonOK);
            this.panelButtons.Location = new System.Drawing.Point(0, 317);
            this.panelButtons.Size = new System.Drawing.Size(344, 50);
            this.panelButtons.Controls.SetChildIndex(this.buttonOK, 0);
            this.panelButtons.Controls.SetChildIndex(this.buttonCancel, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateSelectControl1);
            this.groupBox1.Controls.Add(this.supplierSelectorComboBoxWithDataGridView1);
            this.groupBox1.Controls.Add(this.medicineStoreHouseSelector1);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "供货商：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "药库：";
            // 
            // dateSelectControl1
            // 
            this.dateSelectControl1.ConnectionString = null;
            this.dateSelectControl1.DatePeriodSelectType = ClassLibraryPublicEnum.EnumDatePeriodSelectType.本会计日;
            this.dateSelectControl1.Location = new System.Drawing.Point(12, 45);
            this.dateSelectControl1.Name = "dateSelectControl1";
            this.dateSelectControl1.Size = new System.Drawing.Size(297, 201);
            this.dateSelectControl1.TabIndex = 2;
            // 
            // supplierSelectorComboBoxWithDataGridView1
            // 
            this.supplierSelectorComboBoxWithDataGridView1.ConnectionSqlString = null;
            this.supplierSelectorComboBoxWithDataGridView1.DropDownBackColor = System.Drawing.SystemColors.HighlightText;
            this.supplierSelectorComboBoxWithDataGridView1.FormattingEnabled = true;
            this.supplierSelectorComboBoxWithDataGridView1.HelpText2 = "使用说明：输入供货商拼音码 或 供货商名称均可进行供货商的模糊查询。";
            this.supplierSelectorComboBoxWithDataGridView1.IntegralHeight = false;
            this.supplierSelectorComboBoxWithDataGridView1.IsLoadWithAll = true;
            this.supplierSelectorComboBoxWithDataGridView1.Location = new System.Drawing.Point(215, 19);
            this.supplierSelectorComboBoxWithDataGridView1.Name = "supplierSelectorComboBoxWithDataGridView1";
            this.supplierSelectorComboBoxWithDataGridView1.Size = new System.Drawing.Size(94, 20);
            this.supplierSelectorComboBoxWithDataGridView1.TabIndex = 1;
            this.supplierSelectorComboBoxWithDataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.control_KeyUp);
            // 
            // medicineStoreHouseSelector1
            // 
            this.medicineStoreHouseSelector1.DropDownBackColor = System.Drawing.SystemColors.HighlightText;
            this.medicineStoreHouseSelector1.FormattingEnabled = true;
            this.medicineStoreHouseSelector1.HelpText2 = "使用说明：输入“药库拼音码” 或 “药库名称”均可进行药库的模糊查询。";
            this.medicineStoreHouseSelector1.IntegralHeight = false;
            this.medicineStoreHouseSelector1.LoadStoreHouseInformationType = ClassLibraryPublicEnum.EnumLoadStoreHouseInformationType.AllWithAll;
            this.medicineStoreHouseSelector1.Location = new System.Drawing.Point(55, 19);
            this.medicineStoreHouseSelector1.Name = "medicineStoreHouseSelector1";
            this.medicineStoreHouseSelector1.Size = new System.Drawing.Size(94, 20);
            this.medicineStoreHouseSelector1.TabIndex = 0;
            this.medicineStoreHouseSelector1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.control_KeyUp);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(174, 8);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 34);
            this.buttonOK.TabIndex = 15;
            this.buttonOK.Text = "查询(&S)";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(257, 8);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 34);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "关闭(Esc)";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormAdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(344, 367);
            this.Controls.Add(this.groupBox1);
            this.MaxSize = new System.Drawing.Size(352, 401);
            this.MinSize = new System.Drawing.Size(352, 401);
            this.Name = "FormAdvancedSearch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowResizeButton = false;
            this.Text = "高级查询";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.panelButtons.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MedicineStoreHouseSelector.MedicineStoreHouseSelector medicineStoreHouseSelector1;
        private DateSelectControl.DateSelectControl dateSelectControl1;
        private SupplierSelectorlControl.SupplierSelectorComboBoxWithDataGridView supplierSelectorComboBoxWithDataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}