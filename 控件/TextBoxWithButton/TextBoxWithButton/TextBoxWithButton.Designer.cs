namespace CustomTextBox
{
    partial class TextBoxWithButton
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
            this.buttonAdvanced = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdvanced
            // 
            this.buttonAdvanced.AutoEllipsis = true;
            this.buttonAdvanced.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAdvanced.Font = new System.Drawing.Font("Arial Black", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdvanced.Location = new System.Drawing.Point(76, 0);
            this.buttonAdvanced.Name = "buttonAdvanced";
            this.buttonAdvanced.Size = new System.Drawing.Size(20, 17);
            this.buttonAdvanced.TabIndex = 0;
            this.buttonAdvanced.TabStop = false;
            this.buttonAdvanced.Text = "…";
            this.buttonAdvanced.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdvanced.UseVisualStyleBackColor = true;
            this.buttonAdvanced.Click += new System.EventHandler(this.buttonAdvanced_Click);
            // 
            // TextBoxWithButton
            // 
            this.Controls.Add(this.buttonAdvanced);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdvanced;
    }
}