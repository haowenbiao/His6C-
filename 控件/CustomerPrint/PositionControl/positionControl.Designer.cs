namespace PositionControl
{
    partial class positionControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_上 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_宽度 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_左 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_高度 = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_上)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_宽度)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_左)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_高度)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_上, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_宽度, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_左, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_高度, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(160, 64);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "上：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "左：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "宽度：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "高度：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_上
            // 
            this.numericUpDown_上.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_上.Location = new System.Drawing.Point(44, 5);
            this.numericUpDown_上.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_上.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numericUpDown_上.Name = "numericUpDown_上";
            this.numericUpDown_上.Size = new System.Drawing.Size(32, 21);
            this.numericUpDown_上.TabIndex = 4;
            this.numericUpDown_上.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDown_宽度
            // 
            this.numericUpDown_宽度.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_宽度.Location = new System.Drawing.Point(44, 37);
            this.numericUpDown_宽度.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_宽度.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numericUpDown_宽度.Name = "numericUpDown_宽度";
            this.numericUpDown_宽度.Size = new System.Drawing.Size(32, 21);
            this.numericUpDown_宽度.TabIndex = 5;
            this.numericUpDown_宽度.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDown_左
            // 
            this.numericUpDown_左.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_左.Location = new System.Drawing.Point(124, 5);
            this.numericUpDown_左.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_左.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numericUpDown_左.Name = "numericUpDown_左";
            this.numericUpDown_左.Size = new System.Drawing.Size(33, 21);
            this.numericUpDown_左.TabIndex = 6;
            this.numericUpDown_左.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDown_高度
            // 
            this.numericUpDown_高度.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_高度.Location = new System.Drawing.Point(124, 37);
            this.numericUpDown_高度.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_高度.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numericUpDown_高度.Name = "numericUpDown_高度";
            this.numericUpDown_高度.Size = new System.Drawing.Size(33, 21);
            this.numericUpDown_高度.TabIndex = 7;
            this.numericUpDown_高度.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // positionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "positionControl";
            this.Size = new System.Drawing.Size(160, 64);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_上)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_宽度)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_左)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_高度)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_上;
        private System.Windows.Forms.NumericUpDown numericUpDown_宽度;
        private System.Windows.Forms.NumericUpDown numericUpDown_左;
        private System.Windows.Forms.NumericUpDown numericUpDown_高度;
    }
}
