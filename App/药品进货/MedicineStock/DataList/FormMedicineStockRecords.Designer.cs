namespace MedicineStock.DataList
{
    partial class FormMedicineStockRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedicineStockRecords));
            this.toolStripTmp = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBoxStockNumber = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAdvancedSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonStockDetail = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonStock = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonVerifyAndWareHousing = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripTmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(577, 197);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 50);
            this.toolStripContainer1.Size = new System.Drawing.Size(577, 272);
            this.toolStripContainer1.TopToolStripPanelVisible = true;
            // 
            // toolStripTmp
            // 
            this.toolStripTmp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxStockNumber,
            this.toolStripButtonSearch,
            this.toolStripButtonAdvancedSearch,
            this.toolStripSeparator1,
            this.toolStripButtonStockDetail,
            this.toolStripSeparator2,
            this.toolStripButtonStock,
            this.toolStripButtonVerifyAndWareHousing});
            this.toolStripTmp.Location = new System.Drawing.Point(0, 50);
            this.toolStripTmp.Name = "toolStripTmp";
            this.toolStripTmp.Size = new System.Drawing.Size(577, 25);
            this.toolStripTmp.TabIndex = 3;
            this.toolStripTmp.Text = "toolStrip1";
            this.toolStripTmp.Visible = false;
            // 
            // toolStripTextBoxStockNumber
            // 
            this.toolStripTextBoxStockNumber.ForeColor = System.Drawing.SystemColors.GrayText;
            this.toolStripTextBoxStockNumber.Name = "toolStripTextBoxStockNumber";
            this.toolStripTextBoxStockNumber.Size = new System.Drawing.Size(118, 25);
            this.toolStripTextBoxStockNumber.Text = "请输入进货单编号";
            this.toolStripTextBoxStockNumber.Enter += new System.EventHandler(this.toolStripTextBoxStockNumber_Enter);
            this.toolStripTextBoxStockNumber.Leave += new System.EventHandler(this.toolStripTextBoxStockNumber_Leave);
            // 
            // toolStripButtonSearch
            // 
            this.toolStripButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearch.Image")));
            this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearch.Name = "toolStripButtonSearch";
            this.toolStripButtonSearch.Size = new System.Drawing.Size(33, 22);
            this.toolStripButtonSearch.Text = "查询";
            this.toolStripButtonSearch.Click += new System.EventHandler(this.toolStripButtonSearch_Click);
            // 
            // toolStripButtonAdvancedSearch
            // 
            this.toolStripButtonAdvancedSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAdvancedSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdvancedSearch.Image")));
            this.toolStripButtonAdvancedSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdvancedSearch.Name = "toolStripButtonAdvancedSearch";
            this.toolStripButtonAdvancedSearch.Size = new System.Drawing.Size(75, 22);
            this.toolStripButtonAdvancedSearch.Text = "高级查询(&A)";
            this.toolStripButtonAdvancedSearch.Click += new System.EventHandler(this.toolStripButtonAdvancedSearch_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonStockDetail
            // 
            this.toolStripButtonStockDetail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonStockDetail.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStockDetail.Image")));
            this.toolStripButtonStockDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStockDetail.Name = "toolStripButtonStockDetail";
            this.toolStripButtonStockDetail.Size = new System.Drawing.Size(93, 22);
            this.toolStripButtonStockDetail.Text = "进货单详细信息";
            this.toolStripButtonStockDetail.Click += new System.EventHandler(this.toolStripButtonStockDetail_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonStock
            // 
            this.toolStripButtonStock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonStock.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStock.Image")));
            this.toolStripButtonStock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStock.Name = "toolStripButtonStock";
            this.toolStripButtonStock.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonStock.Text = "进货(&S)";
            this.toolStripButtonStock.Click += new System.EventHandler(this.toolStripButtonStock_Click);
            // 
            // toolStripButtonVerifyAndWareHousing
            // 
            this.toolStripButtonVerifyAndWareHousing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonVerifyAndWareHousing.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonVerifyAndWareHousing.Image")));
            this.toolStripButtonVerifyAndWareHousing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonVerifyAndWareHousing.Name = "toolStripButtonVerifyAndWareHousing";
            this.toolStripButtonVerifyAndWareHousing.Size = new System.Drawing.Size(75, 22);
            this.toolStripButtonVerifyAndWareHousing.Text = "审核入库(&V)";
            this.toolStripButtonVerifyAndWareHousing.Click += new System.EventHandler(this.toolStripButtonVerifyAndWareHousing_Click);
            // 
            // FormMedicineStockRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 322);
            this.Controls.Add(this.toolStripTmp);
            this.HelpText = "本窗口默认显示本会计日所有库房、所有供货商的进货记录。";
            this.Name = "FormMedicineStockRecords";
            this.Text = "FormMedicineStockRecords";
            this.Controls.SetChildIndex(this.toolStripTmp, 0);
            this.Controls.SetChildIndex(this.toolStripContainer1, 0);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripTmp.ResumeLayout(false);
            this.toolStripTmp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.ToolStripButton toolStripButtonVerifyAndWareHousing;

        #endregion

        private System.Windows.Forms.ToolStrip toolStripTmp;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxStockNumber;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdvancedSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonStock;
        private System.Windows.Forms.ToolStripButton toolStripButtonStockDetail;

    }
}