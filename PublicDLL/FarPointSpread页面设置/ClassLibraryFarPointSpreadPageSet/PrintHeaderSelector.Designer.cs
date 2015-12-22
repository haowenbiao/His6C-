namespace ClassLibraryFarPointSpreadPageSet
{
    partial class PrintHeaderSelector
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonShow = new System.Windows.Forms.RadioButton();
            this.radioButtonHide = new System.Windows.Forms.RadioButton();
            this.radioButtonInherit = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "是否显示标题";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.radioButtonInherit, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonShow, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonHide, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(162, 32);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // radioButtonShow
            // 
            this.radioButtonShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonShow.AutoSize = true;
            this.radioButtonShow.Checked = true;
            this.radioButtonShow.Location = new System.Drawing.Point(3, 8);
            this.radioButtonShow.Name = "radioButtonShow";
            this.radioButtonShow.Size = new System.Drawing.Size(47, 16);
            this.radioButtonShow.TabIndex = 0;
            this.radioButtonShow.TabStop = true;
            this.radioButtonShow.Text = "显示";
            this.radioButtonShow.UseVisualStyleBackColor = true;
            // 
            // radioButtonHide
            // 
            this.radioButtonHide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonHide.AutoSize = true;
            this.radioButtonHide.Location = new System.Drawing.Point(56, 8);
            this.radioButtonHide.Name = "radioButtonHide";
            this.radioButtonHide.Size = new System.Drawing.Size(47, 16);
            this.radioButtonHide.TabIndex = 1;
            this.radioButtonHide.TabStop = true;
            this.radioButtonHide.Text = "隐藏";
            this.radioButtonHide.UseVisualStyleBackColor = true;
            // 
            // radioButtonInherit
            // 
            this.radioButtonInherit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonInherit.AutoSize = true;
            this.radioButtonInherit.Location = new System.Drawing.Point(110, 8);
            this.radioButtonInherit.Name = "radioButtonInherit";
            this.radioButtonInherit.Size = new System.Drawing.Size(47, 16);
            this.radioButtonInherit.TabIndex = 2;
            this.radioButtonInherit.TabStop = true;
            this.radioButtonInherit.Text = "自动";
            this.radioButtonInherit.UseVisualStyleBackColor = true;
            // 
            // PrintHeaderSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "PrintHeaderSelector";
            this.Size = new System.Drawing.Size(168, 52);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButtonHide;
        private System.Windows.Forms.RadioButton radioButtonInherit;
        private System.Windows.Forms.RadioButton radioButtonShow;
    }
}
