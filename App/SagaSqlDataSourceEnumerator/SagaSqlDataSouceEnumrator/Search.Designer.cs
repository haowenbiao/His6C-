namespace SagaSqlDataSouceEnumrator
{
    partial class Search
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonBegin = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(145, 79);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(65, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "关闭";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.close_Click);
            // 
            // buttonBegin
            // 
            this.buttonBegin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBegin.Location = new System.Drawing.Point(145, 41);
            this.buttonBegin.Name = "buttonBegin";
            this.buttonBegin.Size = new System.Drawing.Size(65, 23);
            this.buttonBegin.TabIndex = 2;
            this.buttonBegin.Text = "搜索";
            this.buttonBegin.UseVisualStyleBackColor = true;
            this.buttonBegin.Click += new System.EventHandler(this.buttonBegin_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 52);
            this.listBox1.TabIndex = 4;
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(67, 79);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(65, 23);
            this.buttonChoose.TabIndex = 5;
            this.buttonChoose.Text = "选取";
            this.buttonChoose.UseVisualStyleBackColor = true;
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(145, 12);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(65, 23);
            this.buttonTest.TabIndex = 6;
            this.buttonTest.Text = "测试连接";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // Search
            // 
            this.AcceptButton = this.buttonChoose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(222, 114);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonBegin);
            this.Controls.Add(this.buttonClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search";
            this.Text = "寻找本地网络数据库服务器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Search_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonBegin;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonChoose;
        public System.Windows.Forms.Button buttonTest;
    }
}

