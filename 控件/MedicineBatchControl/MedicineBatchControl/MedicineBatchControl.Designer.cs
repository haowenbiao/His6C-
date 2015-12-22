namespace MedicineBatchControl
{
    partial class MedicineBatchControl
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeTextBox有效期至 = new CustomTextBox.DateTimeTextBox();
            this.classMedicineProductionBatchPropertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeTextBox生产日期 = new CustomTextBox.DateTimeTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox生产批号 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classMedicineProductionBatchPropertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "生产批号";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimeTextBox有效期至, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimeTextBox生产日期, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox生产批号, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(217, 83);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "生产批号：";
            // 
            // dateTimeTextBox有效期至
            // 
            this.dateTimeTextBox有效期至.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeTextBox有效期至.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.classMedicineProductionBatchPropertiesBindingSource, "有效期至", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.dateTimeTextBox有效期至.errorMessage = null;
            this.dateTimeTextBox有效期至.Location = new System.Drawing.Point(74, 53);
            this.dateTimeTextBox有效期至.Margin = new System.Windows.Forms.Padding(3, 3, 28, 3);
            this.dateTimeTextBox有效期至.Name = "dateTimeTextBox有效期至";
            this.dateTimeTextBox有效期至.Size = new System.Drawing.Size(115, 21);
            this.dateTimeTextBox有效期至.TabIndex = 2;
            this.dateTimeTextBox有效期至.Text = "2009年10月11日";
            this.dateTimeTextBox有效期至.Value = new System.DateTime(2009, 10, 11, 0, 0, 0, 0);
            this.dateTimeTextBox有效期至.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimeTextBox_Validating);
            this.dateTimeTextBox有效期至.Validated += new System.EventHandler(this.dateTimeTextBox_Validated);
            // 
            // classMedicineProductionBatchPropertiesBindingSource
            // 
            this.classMedicineProductionBatchPropertiesBindingSource.DataSource = typeof(ClassLibraryMedicineProductionBatch.ClassMedicineProductionBatchProperties);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "生产日期：";
            // 
            // dateTimeTextBox生产日期
            // 
            this.dateTimeTextBox生产日期.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeTextBox生产日期.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.classMedicineProductionBatchPropertiesBindingSource, "生产日期", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.dateTimeTextBox生产日期.errorMessage = null;
            this.dateTimeTextBox生产日期.Location = new System.Drawing.Point(74, 28);
            this.dateTimeTextBox生产日期.Margin = new System.Windows.Forms.Padding(3, 3, 28, 3);
            this.dateTimeTextBox生产日期.Name = "dateTimeTextBox生产日期";
            this.dateTimeTextBox生产日期.Size = new System.Drawing.Size(115, 21);
            this.dateTimeTextBox生产日期.TabIndex = 1;
            this.dateTimeTextBox生产日期.Text = "2009年10月11日";
            this.dateTimeTextBox生产日期.Value = new System.DateTime(2009, 10, 11, 0, 0, 0, 0);
            this.dateTimeTextBox生产日期.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimeTextBox_Validating);
            this.dateTimeTextBox生产日期.Validated += new System.EventHandler(this.dateTimeTextBox_Validated);
            this.dateTimeTextBox生产日期.ValueChanged += new System.EventHandler(this.dateTimeTextBox生产日期_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "有效期至：";
            // 
            // textBox生产批号
            // 
            this.textBox生产批号.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox生产批号.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classMedicineProductionBatchPropertiesBindingSource, "生产批号", true));
            this.textBox生产批号.Location = new System.Drawing.Point(74, 3);
            this.textBox生产批号.Margin = new System.Windows.Forms.Padding(3, 3, 28, 3);
            this.textBox生产批号.Name = "textBox生产批号";
            this.textBox生产批号.Size = new System.Drawing.Size(115, 21);
            this.textBox生产批号.TabIndex = 0;
            this.textBox生产批号.Validated += new System.EventHandler(this.textBox生产批号_Validated);
            this.textBox生产批号.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MedicineBatchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "MedicineBatchControl";
            this.Size = new System.Drawing.Size(223, 103);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classMedicineProductionBatchPropertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox生产批号;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource classMedicineProductionBatchPropertiesBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private CustomTextBox.DateTimeTextBox dateTimeTextBox有效期至;
        private CustomTextBox.DateTimeTextBox dateTimeTextBox生产日期;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
