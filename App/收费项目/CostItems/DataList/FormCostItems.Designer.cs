namespace CostItems.DataList
{
    partial class FormCostItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCostItems));
            this.contextMenuStripTmp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemTmpAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTmpEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTmpRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemTmpAdjustPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAdjustPriceRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTmp = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBoxSearchKeys = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAdjustPrice = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAdjustPriceRecords = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.SuspendLayout();
            this.contextMenuStripTmp.SuspendLayout();
            this.toolStripTmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(587, 164);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 75);
            this.toolStripContainer1.Size = new System.Drawing.Size(587, 239);
            this.toolStripContainer1.TopToolStripPanelVisible = true;
            // 
            // contextMenuStripTmp
            // 
            this.contextMenuStripTmp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTmpAdd,
            this.toolStripMenuItemTmpEdit,
            this.toolStripMenuItemTmpRemove,
            this.toolStripSeparator3,
            this.toolStripMenuItemTmpAdjustPrice,
            this.toolStripMenuItemAdjustPriceRecords});
            this.contextMenuStripTmp.Name = "contextMenuStripTmp";
            this.contextMenuStripTmp.Size = new System.Drawing.Size(143, 120);
            // 
            // toolStripMenuItemTmpAdd
            // 
            this.toolStripMenuItemTmpAdd.Name = "toolStripMenuItemTmpAdd";
            this.toolStripMenuItemTmpAdd.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItemTmpAdd.Text = "增加";
            this.toolStripMenuItemTmpAdd.Click += new System.EventHandler(this.toolStripMenuItemAdd_Click);
            // 
            // toolStripMenuItemTmpEdit
            // 
            this.toolStripMenuItemTmpEdit.Name = "toolStripMenuItemTmpEdit";
            this.toolStripMenuItemTmpEdit.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItemTmpEdit.Text = "修改";
            this.toolStripMenuItemTmpEdit.Click += new System.EventHandler(this.toolStripMenuItemEdit_Click);
            // 
            // toolStripMenuItemTmpRemove
            // 
            this.toolStripMenuItemTmpRemove.Name = "toolStripMenuItemTmpRemove";
            this.toolStripMenuItemTmpRemove.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItemTmpRemove.Text = "删除";
            this.toolStripMenuItemTmpRemove.Click += new System.EventHandler(this.toolStripMenuItemRemove_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(139, 6);
            // 
            // toolStripMenuItemTmpAdjustPrice
            // 
            this.toolStripMenuItemTmpAdjustPrice.Name = "toolStripMenuItemTmpAdjustPrice";
            this.toolStripMenuItemTmpAdjustPrice.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItemTmpAdjustPrice.Text = "调整价格";
            this.toolStripMenuItemTmpAdjustPrice.Click += new System.EventHandler(this.toolStripButtonAdjustPrice_Click);
            // 
            // toolStripMenuItemAdjustPriceRecords
            // 
            this.toolStripMenuItemAdjustPriceRecords.Name = "toolStripMenuItemAdjustPriceRecords";
            this.toolStripMenuItemAdjustPriceRecords.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItemAdjustPriceRecords.Text = "价格调整记录";
            this.toolStripMenuItemAdjustPriceRecords.Click += new System.EventHandler(this.toolStripButtonAdjustPriceRecords_Click);
            // 
            // toolStripTmp
            // 
            this.toolStripTmp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxSearchKeys,
            this.toolStripButtonSearch,
            this.toolStripSeparator1,
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripButtonRemove,
            this.toolStripSeparator2,
            this.toolStripButtonAdjustPrice,
            this.toolStripButtonAdjustPriceRecords});
            this.toolStripTmp.Location = new System.Drawing.Point(0, 50);
            this.toolStripTmp.Name = "toolStripTmp";
            this.toolStripTmp.Size = new System.Drawing.Size(587, 25);
            this.toolStripTmp.TabIndex = 4;
            this.toolStripTmp.Text = "toolStripTmp";
            this.toolStripTmp.Visible = false;
            // 
            // toolStripTextBoxSearchKeys
            // 
            this.toolStripTextBoxSearchKeys.Name = "toolStripTextBoxSearchKeys";
            this.toolStripTextBoxSearchKeys.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxSearchKeys.ToolTipText = "再次输入名称或拼音码";
            this.toolStripTextBoxSearchKeys.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBoxSearchKeys_KeyPress);
            this.toolStripTextBoxSearchKeys.TextChanged += new System.EventHandler(this.toolStripTextBoxSearchKeys_TextChanged);
            // 
            // toolStripButtonSearch
            // 
            this.toolStripButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearch.Image")));
            this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearch.Name = "toolStripButtonSearch";
            this.toolStripButtonSearch.Size = new System.Drawing.Size(49, 22);
            this.toolStripButtonSearch.Text = "查询";
            this.toolStripButtonSearch.Click += new System.EventHandler(this.toolStripButtonSearch_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonAdd.Text = "增加(&A)";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripMenuItemAdd_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdit.Image")));
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonEdit.Text = "修改(&E)";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripMenuItemEdit_Click);
            // 
            // toolStripButtonRemove
            // 
            this.toolStripButtonRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRemove.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRemove.Image")));
            this.toolStripButtonRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemove.Name = "toolStripButtonRemove";
            this.toolStripButtonRemove.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonRemove.Text = "删除(&R)";
            this.toolStripButtonRemove.Click += new System.EventHandler(this.toolStripMenuItemRemove_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonAdjustPrice
            // 
            this.toolStripButtonAdjustPrice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAdjustPrice.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdjustPrice.Image")));
            this.toolStripButtonAdjustPrice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdjustPrice.Name = "toolStripButtonAdjustPrice";
            this.toolStripButtonAdjustPrice.Size = new System.Drawing.Size(75, 22);
            this.toolStripButtonAdjustPrice.Text = "调整价格(&T)";
            this.toolStripButtonAdjustPrice.Click += new System.EventHandler(this.toolStripButtonAdjustPrice_Click);
            // 
            // toolStripButtonAdjustPriceRecords
            // 
            this.toolStripButtonAdjustPriceRecords.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAdjustPriceRecords.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdjustPriceRecords.Image")));
            this.toolStripButtonAdjustPriceRecords.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdjustPriceRecords.Name = "toolStripButtonAdjustPriceRecords";
            this.toolStripButtonAdjustPriceRecords.Size = new System.Drawing.Size(99, 22);
            this.toolStripButtonAdjustPriceRecords.Text = "价格调整记录(&L)";
            this.toolStripButtonAdjustPriceRecords.Click += new System.EventHandler(this.toolStripButtonAdjustPriceRecords_Click);
            // 
            // FormCostItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 314);
            this.Controls.Add(this.toolStripTmp);
            this.HelpText = "管理收费项目信息的增加、修改、删除（已使用的不可删除），并可进行收费项目的价格调整及查看收费项目的价格调整记录。";
            this.Name = "FormCostItems";
            this.Text = "收费项目";
            this.Controls.SetChildIndex(this.toolStripTmp, 0);
            this.Controls.SetChildIndex(this.toolStripContainer1, 0);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.contextMenuStripTmp.ResumeLayout(false);
            this.toolStripTmp.ResumeLayout(false);
            this.toolStripTmp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripTmp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTmpAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTmpEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTmpRemove;
        private System.Windows.Forms.ToolStrip toolStripTmp;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearchKeys;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdjustPrice;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdjustPriceRecords;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTmpAdjustPrice;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdjustPriceRecords;
    }
}