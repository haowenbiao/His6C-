namespace CustomTextBox
{
    partial class ComboBoxWithDateGridView
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
            if (disposing)
            {
                if (toolStripDropDown != null)
                {
                    toolStripDropDown.Dispose();
                    toolStripDropDown = null;
                }
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this.labelHelp = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this._dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this._dataGridView.BackgroundColor = System.Drawing.Color.White;
            this._dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this._dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridView.Location = new System.Drawing.Point(3, 3);
            this._dataGridView.MultiSelect = false;
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 7F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this._dataGridView.RowTemplate.Height = 23;
            this._dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataGridView.Size = new System.Drawing.Size(194, 82);
            this._dataGridView.TabIndex = 0;
            this._dataGridView.TabStop = false;
            this._dataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this._dataGridView_MouseClick);
            this._dataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this._dataGridView_MouseDoubleClick);
            this._dataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this._dataGridView_RowPostPaint);
            this._dataGridView.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this._dataGridView_PreviewKeyDown);
            this._dataGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this._dataGridView_KeyUp);
            // 
            // labelHelp
            // 
            this.labelHelp.AutoSize = true;
            this.labelHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHelp.ForeColor = System.Drawing.Color.Red;
            this.labelHelp.Location = new System.Drawing.Point(3, 88);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(194, 12);
            this.labelHelp.TabIndex = 0;
            this.labelHelp.Text = "使用说明：";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._dataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelHelp, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ComboBoxWithDateGridView
            // 
            this.ItemHeight = 12;
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelHelp;

    }
}
