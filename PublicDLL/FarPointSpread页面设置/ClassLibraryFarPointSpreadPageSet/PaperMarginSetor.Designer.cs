namespace ClassLibraryFarPointSpreadPageSet
{
    partial class PaperMarginSetor
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
            FarPoint.Win.Input.LineBorder lineBorder1 = new FarPoint.Win.Input.LineBorder(System.Drawing.SystemColors.InactiveCaption);
            FarPoint.Win.Input.LineBorder lineBorder2 = new FarPoint.Win.Input.LineBorder(System.Drawing.SystemColors.InactiveCaption);
            FarPoint.Win.Input.LineBorder lineBorder3 = new FarPoint.Win.Input.LineBorder(System.Drawing.SystemColors.InactiveCaption);
            FarPoint.Win.Input.LineBorder lineBorder4 = new FarPoint.Win.Input.LineBorder(System.Drawing.SystemColors.InactiveCaption);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fpIntegerRight = new FarPoint.Win.Input.FpInteger();
            this.fpIntegerBottom = new FarPoint.Win.Input.FpInteger();
            this.fpIntegerLeft = new FarPoint.Win.Input.FpInteger();
            this.fpIntegerTop = new FarPoint.Win.Input.FpInteger();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fpIntegerRight);
            this.groupBox1.Controls.Add(this.fpIntegerBottom);
            this.groupBox1.Controls.Add(this.fpIntegerLeft);
            this.groupBox1.Controls.Add(this.fpIntegerTop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "页边距(毫米)";
            // 
            // fpIntegerRight
            // 
            this.fpIntegerRight.AllowClipboardKeys = true;
            this.fpIntegerRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fpIntegerRight.AutoHeight = false;
            this.fpIntegerRight.Border = lineBorder1;
            this.fpIntegerRight.ButtonMarginColor = System.Drawing.SystemColors.Control;
            this.fpIntegerRight.ButtonStyle = FarPoint.Win.Input.ButtonStyle.Spin;
            this.fpIntegerRight.Location = new System.Drawing.Point(136, 52);
            this.fpIntegerRight.MinValue = 0;
            this.fpIntegerRight.Name = "fpIntegerRight";
            this.fpIntegerRight.Size = new System.Drawing.Size(62, 20);
            this.fpIntegerRight.TabIndex = 3;
            this.fpIntegerRight.Text = "0";
            this.fpIntegerRight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlOnKeyDown);
            // 
            // fpIntegerBottom
            // 
            this.fpIntegerBottom.AllowClipboardKeys = true;
            this.fpIntegerBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fpIntegerBottom.AutoHeight = false;
            this.fpIntegerBottom.Border = lineBorder2;
            this.fpIntegerBottom.ButtonMarginColor = System.Drawing.SystemColors.Control;
            this.fpIntegerBottom.ButtonStyle = FarPoint.Win.Input.ButtonStyle.Spin;
            this.fpIntegerBottom.Location = new System.Drawing.Point(136, 26);
            this.fpIntegerBottom.MinValue = 0;
            this.fpIntegerBottom.Name = "fpIntegerBottom";
            this.fpIntegerBottom.Size = new System.Drawing.Size(62, 20);
            this.fpIntegerBottom.TabIndex = 1;
            this.fpIntegerBottom.Text = "0";
            this.fpIntegerBottom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlOnKeyDown);
            // 
            // fpIntegerLeft
            // 
            this.fpIntegerLeft.AllowClipboardKeys = true;
            this.fpIntegerLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fpIntegerLeft.AutoHeight = false;
            this.fpIntegerLeft.Border = lineBorder3;
            this.fpIntegerLeft.ButtonMarginColor = System.Drawing.SystemColors.Control;
            this.fpIntegerLeft.ButtonStyle = FarPoint.Win.Input.ButtonStyle.Spin;
            this.fpIntegerLeft.Location = new System.Drawing.Point(38, 52);
            this.fpIntegerLeft.MinValue = 0;
            this.fpIntegerLeft.Name = "fpIntegerLeft";
            this.fpIntegerLeft.Size = new System.Drawing.Size(62, 20);
            this.fpIntegerLeft.TabIndex = 2;
            this.fpIntegerLeft.Text = "0";
            this.fpIntegerLeft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlOnKeyDown);
            // 
            // fpIntegerTop
            // 
            this.fpIntegerTop.AllowClipboardKeys = true;
            this.fpIntegerTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fpIntegerTop.AutoHeight = false;
            this.fpIntegerTop.Border = lineBorder4;
            this.fpIntegerTop.ButtonMarginColor = System.Drawing.SystemColors.Control;
            this.fpIntegerTop.ButtonStyle = FarPoint.Win.Input.ButtonStyle.Spin;
            this.fpIntegerTop.Location = new System.Drawing.Point(38, 26);
            this.fpIntegerTop.MinValue = 0;
            this.fpIntegerTop.Name = "fpIntegerTop";
            this.fpIntegerTop.Size = new System.Drawing.Size(62, 20);
            this.fpIntegerTop.TabIndex = 0;
            this.fpIntegerTop.Text = "0";
            this.fpIntegerTop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlOnKeyDown);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "左：";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "右：";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "下：";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "上：";
            // 
            // PaperMarginSetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "PaperMarginSetor";
            this.Size = new System.Drawing.Size(212, 87);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FarPoint.Win.Input.FpInteger fpIntegerRight;
        private FarPoint.Win.Input.FpInteger fpIntegerBottom;
        private FarPoint.Win.Input.FpInteger fpIntegerLeft;
        private FarPoint.Win.Input.FpInteger fpIntegerTop;

    }
}