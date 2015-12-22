namespace MedicineKinds.DataList
{
    partial class FormMedicineKinds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedicineKinds));
            this.toolStripTmp = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBoxSearchKeys = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButtonMedicineKindsInformation = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonStockAndSaleState = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemStopStock = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRecoverStock = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemStopSale = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRecoverSale = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonMedicineAjustPrice = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemAjustPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAjustPriceRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripTmp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemTmpAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTmpEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTmpRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemTmpStopStock = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTmpRecoverStock = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemTmpStopSale = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTmpRecoverSale = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemTmpAjustPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTmpAjustPriceRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripTmp.SuspendLayout();
            this.contextMenuStripTmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(735, 383);
            this.toolStripContainer1.Size = new System.Drawing.Size(735, 458);
            this.toolStripContainer1.TopToolStripPanelVisible = true;
            // 
            // toolStripTmp
            // 
            this.toolStripTmp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxSearchKeys,
            this.toolStripButtonSearch,
            this.toolStripSeparator1,
            this.toolStripDropDownButtonMedicineKindsInformation,
            this.toolStripDropDownButtonStockAndSaleState,
            this.toolStripDropDownButtonMedicineAjustPrice});
            this.toolStripTmp.Location = new System.Drawing.Point(0, 44);
            this.toolStripTmp.Name = "toolStripTmp";
            this.toolStripTmp.Size = new System.Drawing.Size(735, 25);
            this.toolStripTmp.TabIndex = 3;
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
            // toolStripDropDownButtonMedicineKindsInformation
            // 
            this.toolStripDropDownButtonMedicineKindsInformation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonMedicineKindsInformation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdd,
            this.toolStripMenuItemEdit,
            this.toolStripMenuItemRemove});
            this.toolStripDropDownButtonMedicineKindsInformation.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonMedicineKindsInformation.Image")));
            this.toolStripDropDownButtonMedicineKindsInformation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonMedicineKindsInformation.Name = "toolStripDropDownButtonMedicineKindsInformation";
            this.toolStripDropDownButtonMedicineKindsInformation.Size = new System.Drawing.Size(66, 22);
            this.toolStripDropDownButtonMedicineKindsInformation.Text = "药品信息";
            // 
            // toolStripMenuItemAdd
            // 
            this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            this.toolStripMenuItemAdd.ShortcutKeyDisplayString = "Ctrl+A";
            this.toolStripMenuItemAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.toolStripMenuItemAdd.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemAdd.Text = "增加";
            this.toolStripMenuItemAdd.Click += new System.EventHandler(this.toolStripMenuItemAdd_Click);
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.ShortcutKeyDisplayString = "Ctrl+E";
            this.toolStripMenuItemEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemEdit.Text = "修改";
            this.toolStripMenuItemEdit.Click += new System.EventHandler(this.toolStripMenuItemEdit_Click);
            // 
            // toolStripMenuItemRemove
            // 
            this.toolStripMenuItemRemove.Name = "toolStripMenuItemRemove";
            this.toolStripMenuItemRemove.ShortcutKeyDisplayString = "Ctrl+R";
            this.toolStripMenuItemRemove.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.toolStripMenuItemRemove.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemRemove.Text = "删除";
            this.toolStripMenuItemRemove.Click += new System.EventHandler(this.toolStripMenuItemRemove_Click);
            // 
            // toolStripDropDownButtonStockAndSaleState
            // 
            this.toolStripDropDownButtonStockAndSaleState.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonStockAndSaleState.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemStopStock,
            this.toolStripMenuItemRecoverStock,
            this.toolStripSeparator2,
            this.toolStripMenuItemStopSale,
            this.toolStripMenuItemRecoverSale});
            this.toolStripDropDownButtonStockAndSaleState.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonStockAndSaleState.Image")));
            this.toolStripDropDownButtonStockAndSaleState.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonStockAndSaleState.Name = "toolStripDropDownButtonStockAndSaleState";
            this.toolStripDropDownButtonStockAndSaleState.Size = new System.Drawing.Size(102, 22);
            this.toolStripDropDownButtonStockAndSaleState.Text = "进货和销售状态";
            // 
            // toolStripMenuItemStopStock
            // 
            this.toolStripMenuItemStopStock.Name = "toolStripMenuItemStopStock";
            this.toolStripMenuItemStopStock.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItemStopStock.Text = "暂停进货";
            this.toolStripMenuItemStopStock.Click += new System.EventHandler(this.toolStripMenuItemStopStock_Click);
            // 
            // toolStripMenuItemRecoverStock
            // 
            this.toolStripMenuItemRecoverStock.Name = "toolStripMenuItemRecoverStock";
            this.toolStripMenuItemRecoverStock.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItemRecoverStock.Text = "恢复进货";
            this.toolStripMenuItemRecoverStock.Click += new System.EventHandler(this.toolStripMenuItemRecoverStock_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(115, 6);
            // 
            // toolStripMenuItemStopSale
            // 
            this.toolStripMenuItemStopSale.Name = "toolStripMenuItemStopSale";
            this.toolStripMenuItemStopSale.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItemStopSale.Text = "暂停销售";
            this.toolStripMenuItemStopSale.Click += new System.EventHandler(this.toolStripMenuItemStopSale_Click);
            // 
            // toolStripMenuItemRecoverSale
            // 
            this.toolStripMenuItemRecoverSale.Name = "toolStripMenuItemRecoverSale";
            this.toolStripMenuItemRecoverSale.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItemRecoverSale.Text = "恢复销售";
            this.toolStripMenuItemRecoverSale.Click += new System.EventHandler(this.toolStripMenuItemRecoverSale_Click);
            // 
            // toolStripDropDownButtonMedicineAjustPrice
            // 
            this.toolStripDropDownButtonMedicineAjustPrice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonMedicineAjustPrice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAjustPrice,
            this.toolStripMenuItemAjustPriceRecord});
            this.toolStripDropDownButtonMedicineAjustPrice.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonMedicineAjustPrice.Image")));
            this.toolStripDropDownButtonMedicineAjustPrice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonMedicineAjustPrice.Name = "toolStripDropDownButtonMedicineAjustPrice";
            this.toolStripDropDownButtonMedicineAjustPrice.Size = new System.Drawing.Size(66, 22);
            this.toolStripDropDownButtonMedicineAjustPrice.Text = "药品调价";
            // 
            // toolStripMenuItemAjustPrice
            // 
            this.toolStripMenuItemAjustPrice.Name = "toolStripMenuItemAjustPrice";
            this.toolStripMenuItemAjustPrice.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemAjustPrice.Text = "调价";
            this.toolStripMenuItemAjustPrice.Click += new System.EventHandler(this.toolStripMenuItemAjustPrice_Click);
            // 
            // toolStripMenuItemAjustPriceRecord
            // 
            this.toolStripMenuItemAjustPriceRecord.Name = "toolStripMenuItemAjustPriceRecord";
            this.toolStripMenuItemAjustPriceRecord.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemAjustPriceRecord.Text = "调价记录";
            this.toolStripMenuItemAjustPriceRecord.Click += new System.EventHandler(this.toolStripMenuItemAjustPriceRecord_Click);
            // 
            // contextMenuStripTmp
            // 
            this.contextMenuStripTmp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTmpAdd,
            this.toolStripMenuItemTmpEdit,
            this.toolStripMenuItemTmpRemove,
            this.toolStripSeparator3,
            this.toolStripMenuItemTmpStopStock,
            this.toolStripMenuItemTmpRecoverStock,
            this.toolStripSeparator4,
            this.toolStripMenuItemTmpStopSale,
            this.toolStripMenuItemTmpRecoverSale,
            this.toolStripSeparator5,
            this.toolStripMenuItemTmpAjustPrice,
            this.toolStripMenuItemTmpAjustPriceRecord});
            this.contextMenuStripTmp.Name = "contextMenuStripTmp";
            this.contextMenuStripTmp.Size = new System.Drawing.Size(119, 220);
            // 
            // toolStripMenuItemTmpAdd
            // 
            this.toolStripMenuItemTmpAdd.Name = "toolStripMenuItemTmpAdd";
            this.toolStripMenuItemTmpAdd.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItemTmpAdd.Text = "增加";
            this.toolStripMenuItemTmpAdd.Click += new System.EventHandler(this.toolStripMenuItemAdd_Click);
            // 
            // toolStripMenuItemTmpEdit
            // 
            this.toolStripMenuItemTmpEdit.Name = "toolStripMenuItemTmpEdit";
            this.toolStripMenuItemTmpEdit.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItemTmpEdit.Text = "修改";
            this.toolStripMenuItemTmpEdit.Click += new System.EventHandler(this.toolStripMenuItemEdit_Click);
            // 
            // toolStripMenuItemTmpRemove
            // 
            this.toolStripMenuItemTmpRemove.Name = "toolStripMenuItemTmpRemove";
            this.toolStripMenuItemTmpRemove.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItemTmpRemove.Text = "删除";
            this.toolStripMenuItemTmpRemove.Click += new System.EventHandler(this.toolStripMenuItemRemove_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(115, 6);
            // 
            // toolStripMenuItemTmpStopStock
            // 
            this.toolStripMenuItemTmpStopStock.Name = "toolStripMenuItemTmpStopStock";
            this.toolStripMenuItemTmpStopStock.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItemTmpStopStock.Text = "暂停进货";
            this.toolStripMenuItemTmpStopStock.Click += new System.EventHandler(this.toolStripMenuItemStopStock_Click);
            // 
            // toolStripMenuItemTmpRecoverStock
            // 
            this.toolStripMenuItemTmpRecoverStock.Name = "toolStripMenuItemTmpRecoverStock";
            this.toolStripMenuItemTmpRecoverStock.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItemTmpRecoverStock.Text = "恢复进货";
            this.toolStripMenuItemTmpRecoverStock.Click += new System.EventHandler(this.toolStripMenuItemRecoverStock_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(115, 6);
            // 
            // toolStripMenuItemTmpStopSale
            // 
            this.toolStripMenuItemTmpStopSale.Name = "toolStripMenuItemTmpStopSale";
            this.toolStripMenuItemTmpStopSale.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItemTmpStopSale.Text = "暂停销售";
            this.toolStripMenuItemTmpStopSale.Click += new System.EventHandler(this.toolStripMenuItemStopSale_Click);
            // 
            // toolStripMenuItemTmpRecoverSale
            // 
            this.toolStripMenuItemTmpRecoverSale.Name = "toolStripMenuItemTmpRecoverSale";
            this.toolStripMenuItemTmpRecoverSale.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItemTmpRecoverSale.Text = "恢复销售";
            this.toolStripMenuItemTmpRecoverSale.Click += new System.EventHandler(this.toolStripMenuItemRecoverSale_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(115, 6);
            // 
            // toolStripMenuItemTmpAjustPrice
            // 
            this.toolStripMenuItemTmpAjustPrice.Name = "toolStripMenuItemTmpAjustPrice";
            this.toolStripMenuItemTmpAjustPrice.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItemTmpAjustPrice.Text = "调价";
            this.toolStripMenuItemTmpAjustPrice.Click += new System.EventHandler(this.toolStripMenuItemAjustPrice_Click);
            // 
            // toolStripMenuItemTmpAjustPriceRecord
            // 
            this.toolStripMenuItemTmpAjustPriceRecord.Name = "toolStripMenuItemTmpAjustPriceRecord";
            this.toolStripMenuItemTmpAjustPriceRecord.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItemTmpAjustPriceRecord.Text = "调价记录";
            this.toolStripMenuItemTmpAjustPriceRecord.Click += new System.EventHandler(this.toolStripMenuItemAjustPriceRecord_Click);
            // 
            // FormMedicineKinds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 502);
            this.Controls.Add(this.toolStripTmp);
            this.HelpText = "管理药品种类信息，对药品种类信息增加、修改、删除（已使用过的药品信息不可删除），药品的进货和销售状态的改变。";
            this.Name = "FormMedicineKinds";
            this.Text = "药品种类";
            this.Controls.SetChildIndex(this.toolStripTmp, 0);
            this.Controls.SetChildIndex(this.toolStripContainer1, 0);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripTmp.ResumeLayout(false);
            this.toolStripTmp.PerformLayout();
            this.contextMenuStripTmp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripTmp;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearchKeys;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonStockAndSaleState;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStopStock;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRecoverStock;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStopSale;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRecoverSale;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonMedicineKindsInformation;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemove;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTmp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTmpAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTmpEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTmpRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTmpStopStock;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTmpRecoverStock;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTmpStopSale;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTmpRecoverSale;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonMedicineAjustPrice;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAjustPrice;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAjustPriceRecord;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTmpAjustPrice;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTmpAjustPriceRecord;
    }
}