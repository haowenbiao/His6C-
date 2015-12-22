namespace ClassLibraryAbstractFormDataListBase
{
    partial class FormAbstractDataListUseFpSpreadBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbstractDataListUseFpSpreadBase));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStripOnListControl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripCommon = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOutput = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButtonPrint = new System.Windows.Forms.ToolStripDropDownButton();
            this.打印设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印预览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonListItemSet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSpecial = new System.Windows.Forms.ToolStrip();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStripCommon.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Location = new System.Drawing.Point(0, 264);
            this.panelButtons.Size = new System.Drawing.Size(463, 50);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(463, 214);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 50);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(463, 264);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripCommon);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripSpecial);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 214);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStripOnListControl;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(463, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // contextMenuStripOnListControl
            // 
            this.contextMenuStripOnListControl.Name = "contextMenuStripOnListControl";
            this.contextMenuStripOnListControl.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStripCommon
            // 
            this.toolStripCommon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripCommon.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripCommon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOutput,
            this.toolStripDropDownButtonPrint,
            this.toolStripButtonListItemSet,
            this.toolStripSeparator1,
            this.toolStripButtonRefresh,
            this.toolStripButtonClose});
            this.toolStripCommon.Location = new System.Drawing.Point(3, 0);
            this.toolStripCommon.Name = "toolStripCommon";
            this.toolStripCommon.Size = new System.Drawing.Size(270, 25);
            this.toolStripCommon.TabIndex = 0;
            // 
            // toolStripButtonOutput
            // 
            this.toolStripButtonOutput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonOutput.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOutput.Image")));
            this.toolStripButtonOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOutput.Name = "toolStripButtonOutput";
            this.toolStripButtonOutput.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonOutput.Text = "导出(&E)";
            this.toolStripButtonOutput.Click += new System.EventHandler(this.toolStripButtonOutput_Click);
            // 
            // toolStripDropDownButtonPrint
            // 
            this.toolStripDropDownButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonPrint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打印设置ToolStripMenuItem,
            this.打印预览ToolStripMenuItem,
            this.打印ToolStripMenuItem});
            this.toolStripDropDownButtonPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonPrint.Image")));
            this.toolStripDropDownButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonPrint.Name = "toolStripDropDownButtonPrint";
            this.toolStripDropDownButtonPrint.Size = new System.Drawing.Size(60, 22);
            this.toolStripDropDownButtonPrint.Text = "打印(&P)";
            // 
            // 打印设置ToolStripMenuItem
            // 
            this.打印设置ToolStripMenuItem.Name = "打印设置ToolStripMenuItem";
            this.打印设置ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.打印设置ToolStripMenuItem.Text = "打印设置";
            this.打印设置ToolStripMenuItem.Click += new System.EventHandler(this.打印设置ToolStripMenuItem_Click);
            // 
            // 打印预览ToolStripMenuItem
            // 
            this.打印预览ToolStripMenuItem.Name = "打印预览ToolStripMenuItem";
            this.打印预览ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.打印预览ToolStripMenuItem.Text = "打印预览";
            this.打印预览ToolStripMenuItem.Click += new System.EventHandler(this.打印预览ToolStripMenuItem_Click);
            // 
            // 打印ToolStripMenuItem
            // 
            this.打印ToolStripMenuItem.Name = "打印ToolStripMenuItem";
            this.打印ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.打印ToolStripMenuItem.Text = "打印";
            this.打印ToolStripMenuItem.Click += new System.EventHandler(this.打印ToolStripMenuItem_Click);
            // 
            // toolStripButtonListItemSet
            // 
            this.toolStripButtonListItemSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonListItemSet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonListItemSet.Image")));
            this.toolStripButtonListItemSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonListItemSet.Name = "toolStripButtonListItemSet";
            this.toolStripButtonListItemSet.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonListItemSet.Text = "显示设置";
            this.toolStripButtonListItemSet.Click += new System.EventHandler(this.toolStripButtonListItemSet_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRefresh.Image")));
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(33, 22);
            this.toolStripButtonRefresh.Text = "刷新";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // toolStripButtonClose
            // 
            this.toolStripButtonClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClose.Image")));
            this.toolStripButtonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonClose.Text = "关闭(&C)";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // toolStripSpecial
            // 
            this.toolStripSpecial.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripSpecial.Location = new System.Drawing.Point(3, 25);
            this.toolStripSpecial.Name = "toolStripSpecial";
            this.toolStripSpecial.Size = new System.Drawing.Size(111, 25);
            this.toolStripSpecial.TabIndex = 1;
            // 
            // FormAbstractDataListUseFpSpreadBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 314);
            this.Controls.Add(this.toolStripContainer1);
            this.MaxSize = new System.Drawing.Size(471, 348);
            this.MinSize = new System.Drawing.Size(471, 348);
            this.Name = "FormAbstractDataListUseFpSpreadBase";
            this.ShowButtonPanel = false;
            this.Text = "CustomFormDataListBase";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.toolStripContainer1, 0);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStripCommon.ResumeLayout(false);
            this.toolStripCommon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton toolStripButtonOutput;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonPrint;
        private System.Windows.Forms.ToolStripMenuItem 打印设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印预览ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印ToolStripMenuItem;
        public System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        protected System.Windows.Forms.ToolStrip toolStripCommon;
        protected System.Windows.Forms.ToolStrip toolStripSpecial;
        protected System.Windows.Forms.ContextMenuStrip contextMenuStripOnListControl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton toolStripButtonListItemSet;
    }
}