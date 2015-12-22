using ClassLibraryMedicineStock;
using CustomForm;

namespace MedicineStock.DataOperate
{
    partial class FormStockInformation
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
            System.Windows.Forms.Label 药库名称Label;
            System.Windows.Forms.Label 供货单位Label;
            System.Windows.Forms.Label 进货单总金额Label;
            System.Windows.Forms.Label 进货时间Label;
            System.Windows.Forms.Label 进货会计期Label;
            System.Windows.Forms.Label 采购员Label;
            System.Windows.Forms.Label 操作员Label;
            System.Windows.Forms.Label 备注Label;
            System.Windows.Forms.Label 审核人Label;
            System.Windows.Forms.Label 审核时间Label;
            System.Windows.Forms.Label 审核会计期Label;
            System.Windows.Forms.Label 审核备注Label;
            System.Windows.Forms.Label 审核状态Label;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.审核状态TextBox = new System.Windows.Forms.TextBox();
            this.classMedicineStockFullPropertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.审核备注TextBox = new System.Windows.Forms.TextBox();
            this.审核会计期TextBox = new System.Windows.Forms.TextBox();
            this.审核时间TextBox = new System.Windows.Forms.TextBox();
            this.审核人TextBox = new System.Windows.Forms.TextBox();
            this.备注TextBox = new System.Windows.Forms.TextBox();
            this.操作员TextBox = new System.Windows.Forms.TextBox();
            this.采购员TextBox = new System.Windows.Forms.TextBox();
            this.进货会计期TextBox = new System.Windows.Forms.TextBox();
            this.进货时间TextBox = new System.Windows.Forms.TextBox();
            this.进货单总金额TextBox = new System.Windows.Forms.TextBox();
            this.供货单位TextBox = new System.Windows.Forms.TextBox();
            this.药库名称TextBox = new System.Windows.Forms.TextBox();
            this.进货单编号TextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            进货单编号Label = new System.Windows.Forms.Label();
            药库名称Label = new System.Windows.Forms.Label();
            供货单位Label = new System.Windows.Forms.Label();
            进货单总金额Label = new System.Windows.Forms.Label();
            进货时间Label = new System.Windows.Forms.Label();
            进货会计期Label = new System.Windows.Forms.Label();
            采购员Label = new System.Windows.Forms.Label();
            操作员Label = new System.Windows.Forms.Label();
            备注Label = new System.Windows.Forms.Label();
            审核人Label = new System.Windows.Forms.Label();
            审核时间Label = new System.Windows.Forms.Label();
            审核会计期Label = new System.Windows.Forms.Label();
            审核备注Label = new System.Windows.Forms.Label();
            审核状态Label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classMedicineStockFullPropertiesBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Location = new System.Drawing.Point(0, 490);
            this.panelButtons.Size = new System.Drawing.Size(597, 50);
            // 
            // 进货单编号Label
            // 
            进货单编号Label.AutoSize = true;
            进货单编号Label.Location = new System.Drawing.Point(16, 17);
            进货单编号Label.Name = "进货单编号Label";
            进货单编号Label.Size = new System.Drawing.Size(71, 12);
            进货单编号Label.TabIndex = 0;
            进货单编号Label.Text = "进货单编号:";
            // 
            // 药库名称Label
            // 
            药库名称Label.AutoSize = true;
            药库名称Label.Location = new System.Drawing.Point(28, 39);
            药库名称Label.Name = "药库名称Label";
            药库名称Label.Size = new System.Drawing.Size(59, 12);
            药库名称Label.TabIndex = 2;
            药库名称Label.Text = "药库名称:";
            // 
            // 供货单位Label
            // 
            供货单位Label.AutoSize = true;
            供货单位Label.Location = new System.Drawing.Point(28, 61);
            供货单位Label.Name = "供货单位Label";
            供货单位Label.Size = new System.Drawing.Size(59, 12);
            供货单位Label.TabIndex = 4;
            供货单位Label.Text = "供货单位:";
            // 
            // 进货单总金额Label
            // 
            进货单总金额Label.AutoSize = true;
            进货单总金额Label.Location = new System.Drawing.Point(16, 83);
            进货单总金额Label.Name = "进货单总金额Label";
            进货单总金额Label.Size = new System.Drawing.Size(71, 12);
            进货单总金额Label.TabIndex = 6;
            进货单总金额Label.Text = "总金额(元):";
            // 
            // 进货时间Label
            // 
            进货时间Label.AutoSize = true;
            进货时间Label.Location = new System.Drawing.Point(212, 17);
            进货时间Label.Name = "进货时间Label";
            进货时间Label.Size = new System.Drawing.Size(59, 12);
            进货时间Label.TabIndex = 8;
            进货时间Label.Text = "进货时间:";
            // 
            // 进货会计期Label
            // 
            进货会计期Label.AutoSize = true;
            进货会计期Label.Location = new System.Drawing.Point(200, 39);
            进货会计期Label.Name = "进货会计期Label";
            进货会计期Label.Size = new System.Drawing.Size(71, 12);
            进货会计期Label.TabIndex = 10;
            进货会计期Label.Text = "进货会计期:";
            // 
            // 采购员Label
            // 
            采购员Label.AutoSize = true;
            采购员Label.Location = new System.Drawing.Point(224, 61);
            采购员Label.Name = "采购员Label";
            采购员Label.Size = new System.Drawing.Size(47, 12);
            采购员Label.TabIndex = 12;
            采购员Label.Text = "采购员:";
            // 
            // 操作员Label
            // 
            操作员Label.AutoSize = true;
            操作员Label.Location = new System.Drawing.Point(224, 83);
            操作员Label.Name = "操作员Label";
            操作员Label.Size = new System.Drawing.Size(47, 12);
            操作员Label.TabIndex = 14;
            操作员Label.Text = "操作员:";
            // 
            // 备注Label
            // 
            备注Label.AutoSize = true;
            备注Label.Location = new System.Drawing.Point(52, 106);
            备注Label.Name = "备注Label";
            备注Label.Size = new System.Drawing.Size(35, 12);
            备注Label.TabIndex = 16;
            备注Label.Text = "备注:";
            // 
            // 审核人Label
            // 
            审核人Label.AutoSize = true;
            审核人Label.Location = new System.Drawing.Point(410, 39);
            审核人Label.Name = "审核人Label";
            审核人Label.Size = new System.Drawing.Size(47, 12);
            审核人Label.TabIndex = 18;
            审核人Label.Text = "审核人:";
            // 
            // 审核时间Label
            // 
            审核时间Label.AutoSize = true;
            审核时间Label.Location = new System.Drawing.Point(398, 61);
            审核时间Label.Name = "审核时间Label";
            审核时间Label.Size = new System.Drawing.Size(59, 12);
            审核时间Label.TabIndex = 20;
            审核时间Label.Text = "审核时间:";
            // 
            // 审核会计期Label
            // 
            审核会计期Label.AutoSize = true;
            审核会计期Label.Location = new System.Drawing.Point(386, 83);
            审核会计期Label.Name = "审核会计期Label";
            审核会计期Label.Size = new System.Drawing.Size(71, 12);
            审核会计期Label.TabIndex = 22;
            审核会计期Label.Text = "审核会计期:";
            // 
            // 审核备注Label
            // 
            审核备注Label.AutoSize = true;
            审核备注Label.Location = new System.Drawing.Point(398, 106);
            审核备注Label.Name = "审核备注Label";
            审核备注Label.Size = new System.Drawing.Size(59, 12);
            审核备注Label.TabIndex = 24;
            审核备注Label.Text = "审核备注:";
            // 
            // 审核状态Label
            // 
            审核状态Label.AutoSize = true;
            审核状态Label.Location = new System.Drawing.Point(398, 17);
            审核状态Label.Name = "审核状态Label";
            审核状态Label.Size = new System.Drawing.Size(59, 12);
            审核状态Label.TabIndex = 26;
            审核状态Label.Text = "审核状态:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(审核状态Label);
            this.groupBox1.Controls.Add(this.审核状态TextBox);
            this.groupBox1.Controls.Add(审核备注Label);
            this.groupBox1.Controls.Add(this.审核备注TextBox);
            this.groupBox1.Controls.Add(审核会计期Label);
            this.groupBox1.Controls.Add(this.审核会计期TextBox);
            this.groupBox1.Controls.Add(审核时间Label);
            this.groupBox1.Controls.Add(this.审核时间TextBox);
            this.groupBox1.Controls.Add(审核人Label);
            this.groupBox1.Controls.Add(this.审核人TextBox);
            this.groupBox1.Controls.Add(备注Label);
            this.groupBox1.Controls.Add(this.备注TextBox);
            this.groupBox1.Controls.Add(操作员Label);
            this.groupBox1.Controls.Add(this.操作员TextBox);
            this.groupBox1.Controls.Add(采购员Label);
            this.groupBox1.Controls.Add(this.采购员TextBox);
            this.groupBox1.Controls.Add(进货会计期Label);
            this.groupBox1.Controls.Add(this.进货会计期TextBox);
            this.groupBox1.Controls.Add(进货时间Label);
            this.groupBox1.Controls.Add(this.进货时间TextBox);
            this.groupBox1.Controls.Add(进货单总金额Label);
            this.groupBox1.Controls.Add(this.进货单总金额TextBox);
            this.groupBox1.Controls.Add(供货单位Label);
            this.groupBox1.Controls.Add(this.供货单位TextBox);
            this.groupBox1.Controls.Add(药库名称Label);
            this.groupBox1.Controls.Add(this.药库名称TextBox);
            this.groupBox1.Controls.Add(进货单编号Label);
            this.groupBox1.Controls.Add(this.进货单编号TextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "进货单信息";
            // 
            // 审核状态TextBox
            // 
            this.审核状态TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classMedicineStockFullPropertiesBindingSource, "审核状态", true));
            this.审核状态TextBox.Location = new System.Drawing.Point(463, 14);
            this.审核状态TextBox.Name = "审核状态TextBox";
            this.审核状态TextBox.ReadOnly = true;
            this.审核状态TextBox.Size = new System.Drawing.Size(100, 21);
            this.审核状态TextBox.TabIndex = 27;
            // 
            // classMedicineStockFullPropertiesBindingSource
            // 
            this.classMedicineStockFullPropertiesBindingSource.DataSource = typeof(ClassLibraryMedicineStock.ClassMedicineStockFullProperties);
            // 
            // 审核备注TextBox
            // 
            this.审核备注TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classMedicineStockFullPropertiesBindingSource, "审核备注", true));
            this.审核备注TextBox.Location = new System.Drawing.Point(463, 103);
            this.审核备注TextBox.Name = "审核备注TextBox";
            this.审核备注TextBox.ReadOnly = true;
            this.审核备注TextBox.Size = new System.Drawing.Size(100, 21);
            this.审核备注TextBox.TabIndex = 25;
            // 
            // 审核会计期TextBox
            // 
            this.审核会计期TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classMedicineStockFullPropertiesBindingSource, "审核会计期", true));
            this.审核会计期TextBox.Location = new System.Drawing.Point(463, 80);
            this.审核会计期TextBox.Name = "审核会计期TextBox";
            this.审核会计期TextBox.ReadOnly = true;
            this.审核会计期TextBox.Size = new System.Drawing.Size(100, 21);
            this.审核会计期TextBox.TabIndex = 23;
            // 
            // 审核时间TextBox
            // 
            this.审核时间TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classMedicineStockFullPropertiesBindingSource, "审核时间", true));
            this.审核时间TextBox.Location = new System.Drawing.Point(463, 58);
            this.审核时间TextBox.Name = "审核时间TextBox";
            this.审核时间TextBox.ReadOnly = true;
            this.审核时间TextBox.Size = new System.Drawing.Size(100, 21);
            this.审核时间TextBox.TabIndex = 21;
            // 
            // 审核人TextBox
            // 
            this.审核人TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classMedicineStockFullPropertiesBindingSource, "审核人", true));
            this.审核人TextBox.Location = new System.Drawing.Point(463, 36);
            this.审核人TextBox.Name = "审核人TextBox";
            this.审核人TextBox.ReadOnly = true;
            this.审核人TextBox.Size = new System.Drawing.Size(100, 21);
            this.审核人TextBox.TabIndex = 19;
            // 
            // 备注TextBox
            // 
            this.备注TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classMedicineStockFullPropertiesBindingSource, "备注", true));
            this.备注TextBox.Location = new System.Drawing.Point(93, 103);
            this.备注TextBox.Name = "备注TextBox";
            this.备注TextBox.ReadOnly = true;
            this.备注TextBox.Size = new System.Drawing.Size(284, 21);
            this.备注TextBox.TabIndex = 17;
            // 
            // 操作员TextBox
            // 
            this.操作员TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classMedicineStockFullPropertiesBindingSource, "操作员", true));
            this.操作员TextBox.Location = new System.Drawing.Point(277, 80);
            this.操作员TextBox.Name = "操作员TextBox";
            this.操作员TextBox.ReadOnly = true;
            this.操作员TextBox.Size = new System.Drawing.Size(100, 21);
            this.操作员TextBox.TabIndex = 15;
            // 
            // 采购员TextBox
            // 
            this.采购员TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classMedicineStockFullPropertiesBindingSource, "采购员", true));
            this.采购员TextBox.Location = new System.Drawing.Point(277, 58);
            this.采购员TextBox.Name = "采购员TextBox";
            this.采购员TextBox.ReadOnly = true;
            this.采购员TextBox.Size = new System.Drawing.Size(100, 21);
            this.采购员TextBox.TabIndex = 13;
            // 
            // 进货会计期TextBox
            // 
            this.进货会计期TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classMedicineStockFullPropertiesBindingSource, "进货会计期", true));
            this.进货会计期TextBox.Location = new System.Drawing.Point(277, 36);
            this.进货会计期TextBox.Name = "进货会计期TextBox";
            this.进货会计期TextBox.ReadOnly = true;
            this.进货会计期TextBox.Size = new System.Drawing.Size(100, 21);
            this.进货会计期TextBox.TabIndex = 11;
            // 
            // 进货时间TextBox
            // 
            this.进货时间TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classMedicineStockFullPropertiesBindingSource, "进货时间", true));
            this.进货时间TextBox.Location = new System.Drawing.Point(277, 14);
            this.进货时间TextBox.Name = "进货时间TextBox";
            this.进货时间TextBox.ReadOnly = true;
            this.进货时间TextBox.Size = new System.Drawing.Size(100, 21);
            this.进货时间TextBox.TabIndex = 9;
            // 
            // 进货单总金额TextBox
            // 
            this.进货单总金额TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classMedicineStockFullPropertiesBindingSource, "进货单总金额", true));
            this.进货单总金额TextBox.Location = new System.Drawing.Point(93, 80);
            this.进货单总金额TextBox.Name = "进货单总金额TextBox";
            this.进货单总金额TextBox.ReadOnly = true;
            this.进货单总金额TextBox.Size = new System.Drawing.Size(100, 21);
            this.进货单总金额TextBox.TabIndex = 7;
            // 
            // 供货单位TextBox
            // 
            this.供货单位TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classMedicineStockFullPropertiesBindingSource, "供货单位", true));
            this.供货单位TextBox.Location = new System.Drawing.Point(93, 58);
            this.供货单位TextBox.Name = "供货单位TextBox";
            this.供货单位TextBox.ReadOnly = true;
            this.供货单位TextBox.Size = new System.Drawing.Size(100, 21);
            this.供货单位TextBox.TabIndex = 5;
            // 
            // 药库名称TextBox
            // 
            this.药库名称TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classMedicineStockFullPropertiesBindingSource, "药库名称", true));
            this.药库名称TextBox.Location = new System.Drawing.Point(93, 36);
            this.药库名称TextBox.Name = "药库名称TextBox";
            this.药库名称TextBox.ReadOnly = true;
            this.药库名称TextBox.Size = new System.Drawing.Size(100, 21);
            this.药库名称TextBox.TabIndex = 3;
            // 
            // 进货单编号TextBox
            // 
            this.进货单编号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classMedicineStockFullPropertiesBindingSource, "进货单编号", true));
            this.进货单编号TextBox.Location = new System.Drawing.Point(93, 14);
            this.进货单编号TextBox.Name = "进货单编号TextBox";
            this.进货单编号TextBox.ReadOnly = true;
            this.进货单编号TextBox.Size = new System.Drawing.Size(100, 21);
            this.进货单编号TextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 274);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "进货明细";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(557, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // FormStockInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = null;
            this.ClientSize = new System.Drawing.Size(597, 540);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaxSize = new System.Drawing.Size(605, 574);
            this.MinSize = new System.Drawing.Size(605, 574);
            this.Name = "FormStockInformation";
            this.ShowResizeButton = false;
            this.Text = "进货单详细信息";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classMedicineStockFullPropertiesBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox 进货单总金额TextBox;
        private System.Windows.Forms.TextBox 供货单位TextBox;
        private System.Windows.Forms.TextBox 药库名称TextBox;
        private System.Windows.Forms.TextBox 进货单编号TextBox;
        private System.Windows.Forms.TextBox 审核备注TextBox;
        private System.Windows.Forms.TextBox 审核会计期TextBox;
        private System.Windows.Forms.TextBox 审核时间TextBox;
        private System.Windows.Forms.TextBox 审核人TextBox;
        private System.Windows.Forms.TextBox 备注TextBox;
        private System.Windows.Forms.TextBox 操作员TextBox;
        private System.Windows.Forms.TextBox 采购员TextBox;
        private System.Windows.Forms.TextBox 进货会计期TextBox;
        private System.Windows.Forms.TextBox 进货时间TextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox 审核状态TextBox;
        internal System.Windows.Forms.BindingSource classMedicineStockFullPropertiesBindingSource;
        internal System.Windows.Forms.DataGridView dataGridView1;
    }
}