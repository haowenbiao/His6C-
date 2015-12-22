namespace TestWorkerSelectorControl
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
            this.button1 = new System.Windows.Forms.Button();
            this.workerSelectorComboBoxWithDataGridView1 = new WorkerSelectorControl.WorkerSelectorComboBoxWithDataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // workerSelectorComboBoxWithDataGridView1
            // 
            this.workerSelectorComboBoxWithDataGridView1.AutoLoadDataAfterSetConnectionSqlString = true;
            this.workerSelectorComboBoxWithDataGridView1.ConnectionSqlString = null;
            this.workerSelectorComboBoxWithDataGridView1.DropDownAutoClosed = false;
            this.workerSelectorComboBoxWithDataGridView1.DropDownAutoSize = false;
            this.workerSelectorComboBoxWithDataGridView1.DropDownBackColor = System.Drawing.SystemColors.Control;
            this.workerSelectorComboBoxWithDataGridView1.DropDownHeight = 280;
            this.workerSelectorComboBoxWithDataGridView1.DropDownWidth = 250;
            this.workerSelectorComboBoxWithDataGridView1.FormattingEnabled = true;
            this.workerSelectorComboBoxWithDataGridView1.HelpText1ForeColor = System.Drawing.SystemColors.ControlText;
            this.workerSelectorComboBoxWithDataGridView1.HelpText2ForeColor = System.Drawing.SystemColors.ControlText;
            this.workerSelectorComboBoxWithDataGridView1.IntegralHeight = false;
            this.workerSelectorComboBoxWithDataGridView1.IsLoadWithAll = true;
            this.workerSelectorComboBoxWithDataGridView1.Location = new System.Drawing.Point(43, 29);
            this.workerSelectorComboBoxWithDataGridView1.Name = "workerSelectorComboBoxWithDataGridView1";
            this.workerSelectorComboBoxWithDataGridView1.Size = new System.Drawing.Size(121, 20);
            this.workerSelectorComboBoxWithDataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.workerSelectorComboBoxWithDataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WorkerSelectorControl.WorkerSelectorComboBoxWithDataGridView workerSelectorComboBoxWithDataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

