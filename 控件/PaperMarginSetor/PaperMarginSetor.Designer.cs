namespace PaperMarginSetor
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
            FarPoint.Win.Input.LineBorder lineBorder3 = new FarPoint.Win.Input.LineBorder(System.Drawing.SystemColors.InactiveCaption);
            FarPoint.Win.Input.LineBorder lineBorder4 = new FarPoint.Win.Input.LineBorder(System.Drawing.SystemColors.InactiveCaption);
            FarPoint.Win.Input.LineBorder lineBorder5 = new FarPoint.Win.Input.LineBorder(System.Drawing.SystemColors.InactiveCaption);
            FarPoint.Win.Input.LineBorder lineBorder6 = new FarPoint.Win.Input.LineBorder(System.Drawing.SystemColors.InactiveCaption);
            FarPoint.Win.Input.LineBorder lineBorder2 = new FarPoint.Win.Input.LineBorder(System.Drawing.SystemColors.InactiveCaption);
            FarPoint.Win.Input.LineBorder lineBorder1 = new FarPoint.Win.Input.LineBorder(System.Drawing.SystemColors.InactiveCaption);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fpIntegerRight = new FarPoint.Win.Input.FpInteger();
            this.fpIntegerBottom = new FarPoint.Win.Input.FpInteger();
            this.fpIntegerLeft = new FarPoint.Win.Input.FpInteger();
            this.fpIntegerTop = new FarPoint.Win.Input.FpInteger();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fpIntegerHeader = new FarPoint.Win.Input.FpInteger();
            this.fpIntegerFooter = new FarPoint.Win.Input.FpInteger();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fpIntegerFooter);
            this.groupBox1.Controls.Add(this.fpIntegerHeader);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
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
            this.groupBox1.Size = new System.Drawing.Size(212, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "页边距(毫米)";
            // 
            // fpIntegerRight
            // 
            this.fpIntegerRight.AllowClipboardKeys = true;
            this.fpIntegerRight.AutoHeight = false;
            this.fpIntegerRight.Border = lineBorder3;
            this.fpIntegerRight.ButtonMarginColor = System.Drawing.SystemColors.Control;
            this.fpIntegerRight.Location = new System.Drawing.Point(142, 50);
            this.fpIntegerRight.MinValue = 0;
            this.fpIntegerRight.Name = "fpIntegerRight";
            this.fpIntegerRight.Size = new System.Drawing.Size(62, 20);
            this.fpIntegerRight.TabIndex = 7;
            this.fpIntegerRight.Text = "0";
            // 
            // fpIntegerBottom
            // 
            this.fpIntegerBottom.AllowClipboardKeys = true;
            this.fpIntegerBottom.AutoHeight = false;
            this.fpIntegerBottom.Border = lineBorder4;
            this.fpIntegerBottom.ButtonMarginColor = System.Drawing.SystemColors.Control;
            this.fpIntegerBottom.Location = new System.Drawing.Point(142, 24);
            this.fpIntegerBottom.MinValue = 0;
            this.fpIntegerBottom.Name = "fpIntegerBottom";
            this.fpIntegerBottom.Size = new System.Drawing.Size(62, 20);
            this.fpIntegerBottom.TabIndex = 6;
            this.fpIntegerBottom.Text = "0";
            // 
            // fpIntegerLeft
            // 
            this.fpIntegerLeft.AllowClipboardKeys = true;
            this.fpIntegerLeft.AutoHeight = false;
            this.fpIntegerLeft.Border = lineBorder5;
            this.fpIntegerLeft.ButtonMarginColor = System.Drawing.SystemColors.Control;
            this.fpIntegerLeft.Location = new System.Drawing.Point(44, 50);
            this.fpIntegerLeft.MinValue = 0;
            this.fpIntegerLeft.Name = "fpIntegerLeft";
            this.fpIntegerLeft.Size = new System.Drawing.Size(62, 20);
            this.fpIntegerLeft.TabIndex = 5;
            this.fpIntegerLeft.Text = "0";
            // 
            // fpIntegerTop
            // 
            this.fpIntegerTop.AllowClipboardKeys = true;
            this.fpIntegerTop.AutoHeight = false;
            this.fpIntegerTop.Border = lineBorder6;
            this.fpIntegerTop.ButtonMarginColor = System.Drawing.SystemColors.Control;
            this.fpIntegerTop.Location = new System.Drawing.Point(44, 24);
            this.fpIntegerTop.MinValue = 0;
            this.fpIntegerTop.Name = "fpIntegerTop";
            this.fpIntegerTop.Size = new System.Drawing.Size(62, 20);
            this.fpIntegerTop.TabIndex = 4;
            this.fpIntegerTop.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "左：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "右：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "下：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "上：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "页眉：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "页脚：";
            // 
            // fpIntegerHeader
            // 
            this.fpIntegerHeader.AllowClipboardKeys = true;
            this.fpIntegerHeader.AutoHeight = false;
            this.fpIntegerHeader.Border = lineBorder2;
            this.fpIntegerHeader.ButtonMarginColor = System.Drawing.SystemColors.Control;
            this.fpIntegerHeader.Location = new System.Drawing.Point(44, 76);
            this.fpIntegerHeader.MinValue = 0;
            this.fpIntegerHeader.Name = "fpIntegerHeader";
            this.fpIntegerHeader.Size = new System.Drawing.Size(62, 20);
            this.fpIntegerHeader.TabIndex = 10;
            this.fpIntegerHeader.Text = "0";
            // 
            // fpIntegerFooter
            // 
            this.fpIntegerFooter.AllowClipboardKeys = true;
            this.fpIntegerFooter.AutoHeight = false;
            this.fpIntegerFooter.Border = lineBorder1;
            this.fpIntegerFooter.ButtonMarginColor = System.Drawing.SystemColors.Control;
            this.fpIntegerFooter.Location = new System.Drawing.Point(142, 76);
            this.fpIntegerFooter.MinValue = 0;
            this.fpIntegerFooter.Name = "fpIntegerFooter";
            this.fpIntegerFooter.Size = new System.Drawing.Size(62, 20);
            this.fpIntegerFooter.TabIndex = 11;
            this.fpIntegerFooter.Text = "0";
            // 
            // PaperMarginSetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "PaperMarginSetor";
            this.Size = new System.Drawing.Size(212, 113);
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
        private FarPoint.Win.Input.FpInteger fpIntegerFooter;
        private FarPoint.Win.Input.FpInteger fpIntegerHeader;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;

    }
}
