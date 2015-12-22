namespace PaperSizeSelector
{
    partial class PaperSizeSelector
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fpIntegerHeight = new FarPoint.Win.Input.FpInteger();
            this.fpIntegerWidth = new FarPoint.Win.Input.FpInteger();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fpIntegerHeight);
            this.groupBox1.Controls.Add(this.fpIntegerWidth);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "纸张大小";
            // 
            // fpIntegerHeight
            // 
            this.fpIntegerHeight.AllowClipboardKeys = true;
            this.fpIntegerHeight.AutoHeight = false;
            this.fpIntegerHeight.Border = lineBorder1;
            this.fpIntegerHeight.ButtonMarginColor = System.Drawing.SystemColors.Control;
            this.fpIntegerHeight.Location = new System.Drawing.Point(98, 78);
            this.fpIntegerHeight.MinValue = 0;
            this.fpIntegerHeight.Name = "fpIntegerHeight";
            this.fpIntegerHeight.Size = new System.Drawing.Size(62, 20);
            this.fpIntegerHeight.TabIndex = 2;
            this.fpIntegerHeight.Text = "0";
            this.fpIntegerHeight.ValueChanged += new System.EventHandler(this.fpIntegerHeight_ValueChanged);
            this.fpIntegerHeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlOnKeyDown);
            // 
            // fpIntegerWidth
            // 
            this.fpIntegerWidth.AllowClipboardKeys = true;
            this.fpIntegerWidth.AutoHeight = false;
            this.fpIntegerWidth.Border = lineBorder2;
            this.fpIntegerWidth.ButtonMarginColor = System.Drawing.SystemColors.Control;
            this.fpIntegerWidth.Location = new System.Drawing.Point(98, 50);
            this.fpIntegerWidth.MinValue = 0;
            this.fpIntegerWidth.Name = "fpIntegerWidth";
            this.fpIntegerWidth.Size = new System.Drawing.Size(62, 20);
            this.fpIntegerWidth.TabIndex = 1;
            this.fpIntegerWidth.Text = "0";
            this.fpIntegerWidth.ValueChanged += new System.EventHandler(this.fpIntegerWidth_ValueChanged);
            this.fpIntegerWidth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlOnKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "高度（毫米）：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "宽度（毫米）：";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlOnKeyDown);
            // 
            // PaperSizeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "PaperSizeSelector";
            this.Size = new System.Drawing.Size(170, 117);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private FarPoint.Win.Input.FpInteger fpIntegerWidth;
        private FarPoint.Win.Input.FpInteger fpIntegerHeight;
    }
}
