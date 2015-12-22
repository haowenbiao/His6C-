namespace CostItemAdjustPrice.DataList
{
    partial class FormCostItemAdjustPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCostItemAdjustPrice));
            this.toolStripTmp = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBoxCostItems = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripTmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(463, 189);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 50);
            this.toolStripContainer1.Size = new System.Drawing.Size(463, 264);
            this.toolStripContainer1.TopToolStripPanelVisible = true;
            // 
            // toolStripTmp
            // 
            this.toolStripTmp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxCostItems,
            this.toolStripButtonSearch});
            this.toolStripTmp.Location = new System.Drawing.Point(0, 44);
            this.toolStripTmp.Name = "toolStripTmp";
            this.toolStripTmp.Size = new System.Drawing.Size(463, 25);
            this.toolStripTmp.TabIndex = 3;
            this.toolStripTmp.Text = "toolStrip1";
            this.toolStripTmp.Visible = false;
            // 
            // toolStripComboBoxCostItems
            // 
            this.toolStripComboBoxCostItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxCostItems.Name = "toolStripComboBoxCostItems";
            this.toolStripComboBoxCostItems.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBoxCostItems.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxCostItems_SelectedIndexChanged);
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
            // FormCostItemAdjustPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 314);
            this.Controls.Add(this.toolStripTmp);
            this.HelpText = "查看收费项目的价格调整记录，通过选择下拉框中的收费项目，查看所有或个别收费项目的价格调整记录。";
            this.Name = "FormCostItemAdjustPrice";
            this.Text = "收费项目价格调整记录";
            this.Controls.SetChildIndex(this.toolStripTmp, 0);
            this.Controls.SetChildIndex(this.toolStripContainer1, 0);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripTmp.ResumeLayout(false);
            this.toolStripTmp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripTmp;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxCostItems;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
    }
}