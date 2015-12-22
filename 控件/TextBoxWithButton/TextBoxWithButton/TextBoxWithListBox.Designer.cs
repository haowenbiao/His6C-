namespace TextBoxWithListBox
{
    partial class TextBoxWithListBox
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
            if (toolStripDropDown!=null)
            {
                toolStripDropDown.Dispose();
                toolStripDropDown = null;
            }
            if (toolStripControlHost!=null)
            {
                toolStripControlHost.Dispose();
                toolStripControlHost = null;
            }
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.buttonDropDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Margin = new System.Windows.Forms.Padding(0);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 96);
            this.listBox.TabIndex = 0;
            this.listBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseClick);
            // 
            // buttonDropDown
            // 
            this.buttonDropDown.AutoEllipsis = true;
            this.buttonDropDown.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonDropDown.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDropDown.Font = new System.Drawing.Font("宋体", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDropDown.Location = new System.Drawing.Point(97, 0);
            this.buttonDropDown.Name = "buttonDropDown";
            this.buttonDropDown.Size = new System.Drawing.Size(20, 17);
            this.buttonDropDown.TabIndex = 0;
            this.buttonDropDown.TabStop = false;
            this.buttonDropDown.Text = "∨";
            this.buttonDropDown.UseVisualStyleBackColor = true;
            this.buttonDropDown.Click += new System.EventHandler(this.buttonDropDown_Click);
            // 
            // TextBoxWithListBox
            // 
            this.Controls.Add(this.buttonDropDown);
            this.Size = new System.Drawing.Size(121, 21);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDropDown;
        public System.Windows.Forms.ListBox listBox;





    }
}
