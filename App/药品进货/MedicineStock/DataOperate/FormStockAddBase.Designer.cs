namespace MedicineStock.DataOperate
{
    partial class FormStockAddBase
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
            System.Windows.Forms.Label 进货单编号Label;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label 金额Label;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.金额TextBox = new System.Windows.Forms.TextBox();
            this.classMedicineStockPropertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerSelectorComboBoxWithDataGridView1 = new WorkerSelectorControl.WorkerSelectorComboBoxWithDataGridView();
            this.textBoxWithButton1 = new CustomTextBox.TextBoxWithButton();
            this.supplierSelectorComboBoxWithDataGridView1 = new SupplierSelectorlControl.SupplierSelectorComboBoxWithDataGridView();
            this.medicineStoreHouseSelector1 = new MedicineStoreHouseSelector.MedicineStoreHouseSelector();
            this.进货单编号TextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.medicineStockListDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineStockListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            进货单编号Label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            金额Label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classMedicineStockPropertiesBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineStockListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineStockListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // 进货单编号Label
            // 
            进货单编号Label.AutoSize = true;
            进货单编号Label.Location = new System.Drawing.Point(11, 28);
            进货单编号Label.Name = "进货单编号Label";
            进货单编号Label.Size = new System.Drawing.Size(77, 12);
            进货单编号Label.TabIndex = 0;
            进货单编号Label.Text = "进货单编号：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(47, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 12);
            label1.TabIndex = 3;
            label1.Text = "药库：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(241, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 12);
            label2.TabIndex = 5;
            label2.Text = "供货商：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(47, 81);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 12);
            label3.TabIndex = 7;
            label3.Text = "备注：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(446, 54);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(53, 12);
            label5.TabIndex = 8;
            label5.Text = "采购员：";
            // 
            // 金额Label
            // 
            金额Label.AutoSize = true;
            金额Label.Location = new System.Drawing.Point(217, 22);
            金额Label.Name = "金额Label";
            金额Label.Size = new System.Drawing.Size(77, 12);
            金额Label.TabIndex = 10;
            金额Label.Text = "总金额(元)：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.金额TextBox);
            this.groupBox1.Controls.Add(金额Label);
            this.groupBox1.Controls.Add(this.workerSelectorComboBoxWithDataGridView1);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.textBoxWithButton1);
            this.groupBox1.Controls.Add(this.supplierSelectorComboBoxWithDataGridView1);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.medicineStoreHouseSelector1);
            this.groupBox1.Controls.Add(进货单编号Label);
            this.groupBox1.Controls.Add(this.进货单编号TextBox);
            this.groupBox1.Location = new System.Drawing.Point(11, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "进货单信息";
            // 
            // 金额TextBox
            // 
            this.金额TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classMedicineStockPropertiesBindingSource, "金额", true));
            this.金额TextBox.Location = new System.Drawing.Point(294, 19);
            this.金额TextBox.Name = "金额TextBox";
            this.金额TextBox.ReadOnly = true;
            this.金额TextBox.Size = new System.Drawing.Size(121, 21);
            this.金额TextBox.TabIndex = 12;
            this.金额TextBox.TabStop = false;
            // 
            // classMedicineStockPropertiesBindingSource
            // 
            this.classMedicineStockPropertiesBindingSource.DataSource = typeof(ClassLibraryMedicineStock.ClassMedicineStockProperties);
            // 
            // workerSelectorComboBoxWithDataGridView1
            // 
            this.workerSelectorComboBoxWithDataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.classMedicineStockPropertiesBindingSource, "P_采购员_ID", true));
            this.workerSelectorComboBoxWithDataGridView1.FormattingEnabled = true;
            this.workerSelectorComboBoxWithDataGridView1.IntegralHeight = false;
            this.workerSelectorComboBoxWithDataGridView1.Location = new System.Drawing.Point(500, 46);
            this.workerSelectorComboBoxWithDataGridView1.Name = "workerSelectorComboBoxWithDataGridView1";
            this.workerSelectorComboBoxWithDataGridView1.Size = new System.Drawing.Size(121, 20);
            this.workerSelectorComboBoxWithDataGridView1.TabIndex = 3;
            this.workerSelectorComboBoxWithDataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            // 
            // textBoxWithButton1
            // 
            this.textBoxWithButton1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classMedicineStockPropertiesBindingSource, "备注", true));
            this.textBoxWithButton1.errorMessage = null;
            this.textBoxWithButton1.FormAdvanceCaption = "详细内容";
            this.textBoxWithButton1.Location = new System.Drawing.Point(88, 72);
            this.textBoxWithButton1.Name = "textBoxWithButton1";
            this.textBoxWithButton1.Size = new System.Drawing.Size(533, 21);
            this.textBoxWithButton1.TabIndex = 4;
            // 
            // supplierSelectorComboBoxWithDataGridView1
            // 
            this.supplierSelectorComboBoxWithDataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.classMedicineStockPropertiesBindingSource, "YKGL_供货单位信息_ID", true));
            this.supplierSelectorComboBoxWithDataGridView1.FormattingEnabled = true;
            this.supplierSelectorComboBoxWithDataGridView1.IntegralHeight = false;
            this.supplierSelectorComboBoxWithDataGridView1.Location = new System.Drawing.Point(294, 46);
            this.supplierSelectorComboBoxWithDataGridView1.Name = "supplierSelectorComboBoxWithDataGridView1";
            this.supplierSelectorComboBoxWithDataGridView1.Size = new System.Drawing.Size(121, 20);
            this.supplierSelectorComboBoxWithDataGridView1.TabIndex = 2;
            this.supplierSelectorComboBoxWithDataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            // 
            // medicineStoreHouseSelector1
            // 
            this.medicineStoreHouseSelector1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.classMedicineStockPropertiesBindingSource, "YKGL_药库信息_ID", true));
            this.medicineStoreHouseSelector1.FormattingEnabled = true;
            this.medicineStoreHouseSelector1.IntegralHeight = false;
            this.medicineStoreHouseSelector1.Location = new System.Drawing.Point(88, 46);
            this.medicineStoreHouseSelector1.Name = "medicineStoreHouseSelector1";
            this.medicineStoreHouseSelector1.Size = new System.Drawing.Size(121, 20);
            this.medicineStoreHouseSelector1.TabIndex = 1;
            this.medicineStoreHouseSelector1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            // 
            // 进货单编号TextBox
            // 
            this.进货单编号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classMedicineStockPropertiesBindingSource, "进货单编号", true));
            this.进货单编号TextBox.Location = new System.Drawing.Point(88, 19);
            this.进货单编号TextBox.Name = "进货单编号TextBox";
            this.进货单编号TextBox.ReadOnly = true;
            this.进货单编号TextBox.Size = new System.Drawing.Size(121, 21);
            this.进货单编号TextBox.TabIndex = 0;
            this.进货单编号TextBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRemove);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Controls.Add(this.medicineStockListDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(11, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 275);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "进货单明细";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(94, 21);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "删除(&R)";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(13, 21);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "增加(&A)";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label32.Enabled = false;
            this.label32.Location = new System.Drawing.Point(6, 47);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(657, 1);
            this.label32.TabIndex = 15;
            this.label32.Text = "label32";
            // 
            // medicineStockListDataGridView
            // 
            this.medicineStockListDataGridView.AllowUserToAddRows = false;
            this.medicineStockListDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.medicineStockListDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.medicineStockListDataGridView.AutoGenerateColumns = false;
            this.medicineStockListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicineStockListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.金额,
            this.dataGridViewTextBoxColumn8});
            this.medicineStockListDataGridView.DataSource = this.medicineStockListBindingSource;
            this.medicineStockListDataGridView.Location = new System.Drawing.Point(6, 55);
            this.medicineStockListDataGridView.Name = "medicineStockListDataGridView";
            this.medicineStockListDataGridView.ReadOnly = true;
            this.medicineStockListDataGridView.RowTemplate.Height = 23;
            this.medicineStockListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medicineStockListDataGridView.Size = new System.Drawing.Size(657, 220);
            this.medicineStockListDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "YKGL_药品生产批号_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "YKGL_药品生产批号_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "药品通用名称";
            this.dataGridViewTextBoxColumn2.HeaderText = "药品通用名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "药品商品名称";
            this.dataGridViewTextBoxColumn3.HeaderText = "药品商品名称";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "生产批号";
            this.dataGridViewTextBoxColumn4.HeaderText = "生产批号";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "计量单位";
            this.dataGridViewTextBoxColumn5.HeaderText = "计量单位";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "数量";
            this.dataGridViewTextBoxColumn6.HeaderText = "数量";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "单价";
            this.dataGridViewTextBoxColumn7.HeaderText = "单价(元)";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // 金额
            // 
            this.金额.DataPropertyName = "金额";
            this.金额.HeaderText = "金额(元)";
            this.金额.Name = "金额";
            this.金额.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "备注";
            this.dataGridViewTextBoxColumn8.HeaderText = "备注";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // medicineStockListBindingSource
            // 
            this.medicineStockListBindingSource.DataSource = typeof(ClassLibraryMedicineStock.ClassMedicineStockListItem);
            // 
            // FormStockAddBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaxSize = new System.Drawing.Size(700, 533);
            this.Name = "FormStockAddBase";
            this.Text = "FormStockBase";
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classMedicineStockPropertiesBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicineStockListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineStockListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView medicineStockListDataGridView;
        private System.Windows.Forms.BindingSource medicineStockListBindingSource;
        private CustomTextBox.TextBoxWithButton textBoxWithButton1;
        private SupplierSelectorlControl.SupplierSelectorComboBoxWithDataGridView supplierSelectorComboBoxWithDataGridView1;
        private MedicineStoreHouseSelector.MedicineStoreHouseSelector medicineStoreHouseSelector1;
        private System.Windows.Forms.TextBox 进货单编号TextBox;
        private System.Windows.Forms.BindingSource classMedicineStockPropertiesBindingSource;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label32;
        private WorkerSelectorControl.WorkerSelectorComboBoxWithDataGridView workerSelectorComboBoxWithDataGridView1;
        private System.Windows.Forms.TextBox 金额TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn 金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}