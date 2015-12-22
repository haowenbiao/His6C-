namespace TrueOrFalseSelectorControl
{
    partial class trueOrFalseSelectorControl
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
            this.radioButtonFalse = new System.Windows.Forms.RadioButton();
            this.radioButtonTrue = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFalse);
            this.groupBox1.Controls.Add(this.radioButtonTrue);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TrueOrFalse";
            // 
            // radioButtonFalse
            // 
            this.radioButtonFalse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.radioButtonFalse.AutoSize = true;
            this.radioButtonFalse.Location = new System.Drawing.Point(43, 20);
            this.radioButtonFalse.Name = "radioButtonFalse";
            this.radioButtonFalse.Size = new System.Drawing.Size(35, 16);
            this.radioButtonFalse.TabIndex = 0;
            this.radioButtonFalse.TabStop = true;
            this.radioButtonFalse.Text = "否";
            this.radioButtonFalse.UseVisualStyleBackColor = true;
            // 
            // radioButtonTrue
            // 
            this.radioButtonTrue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.radioButtonTrue.AutoSize = true;
            this.radioButtonTrue.Checked = true;
            this.radioButtonTrue.Location = new System.Drawing.Point(11, 20);
            this.radioButtonTrue.Name = "radioButtonTrue";
            this.radioButtonTrue.Size = new System.Drawing.Size(35, 16);
            this.radioButtonTrue.TabIndex = 0;
            this.radioButtonTrue.TabStop = true;
            this.radioButtonTrue.Text = "是";
            this.radioButtonTrue.UseVisualStyleBackColor = true;
            // 
            // trueOrFalseSelectorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "trueOrFalseSelectorControl";
            this.Size = new System.Drawing.Size(89, 45);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonTrue;
        private System.Windows.Forms.RadioButton radioButtonFalse;
    }
}
