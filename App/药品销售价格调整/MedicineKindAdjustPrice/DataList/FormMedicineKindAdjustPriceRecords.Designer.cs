namespace MedicineKindAdjustPrice.DataList
{
    partial class FormMedicineKindAdjustPriceRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedicineKindAdjustPriceRecords));
            this.toolStripTmp = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.comboBoxWithListBoxMedicineKinds = new CustomTextBox.ComboBoxWithListBox();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripTmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(463, 195);
            this.toolStripContainer1.TopToolStripPanelVisible = true;
            // 
            // toolStripTmp
            // 
            this.toolStripTmp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSearch});
            this.toolStripTmp.Location = new System.Drawing.Point(0, 44);
            this.toolStripTmp.Name = "toolStripTmp";
            this.toolStripTmp.Size = new System.Drawing.Size(463, 25);
            this.toolStripTmp.TabIndex = 3;
            this.toolStripTmp.Text = "toolStrip1";
            this.toolStripTmp.Visible = false;
            // 
            // toolStripButtonSearch
            // 
            this.toolStripButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearch.Image")));
            this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearch.Name = "toolStripButtonSearch";
            this.toolStripButtonSearch.Size = new System.Drawing.Size(67, 22);
            this.toolStripButtonSearch.Text = "查找(&F)";
            this.toolStripButtonSearch.Click += new System.EventHandler(this.toolStripButtonSearch_Click);
            // 
            // comboBoxWithListBoxMedicineKinds
            // 
            this.comboBoxWithListBoxMedicineKinds.FormattingEnabled = true;
            this.comboBoxWithListBoxMedicineKinds.Location = new System.Drawing.Point(296, 0);
            this.comboBoxWithListBoxMedicineKinds.Name = "comboBoxWithListBoxMedicineKinds";
            this.comboBoxWithListBoxMedicineKinds.Size = new System.Drawing.Size(121, 20);
            this.comboBoxWithListBoxMedicineKinds.TabIndex = 4;
            this.comboBoxWithListBoxMedicineKinds.AfterSelector += new System.EventHandler(this.comboBoxWithListBoxMedicineKinds_AfterSelector);
            this.comboBoxWithListBoxMedicineKinds.TextChanged += new System.EventHandler(this.comboBoxWithListBoxMedicineKinds_TextChanged);
            // 
            // FormMedicineKindAdjustPriceRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 314);
            this.Controls.Add(this.comboBoxWithListBoxMedicineKinds);
            this.Controls.Add(this.toolStripTmp);
            this.HelpText = "查看药品的价格调整记录。通过选择下拉框中的药品种类，查看所有或个别收费项目的价格调整记录。提示：在输入框中输入药品的“商品名称拼音码”、“商品名称”、“通用名称拼" +
                "音码”或“通用名称”任意一种查询关键字，均可进行模糊查询。";
            this.Name = "FormMedicineKindAdjustPriceRecords";
            this.Text = "药品价格调整记录记录";
            this.Controls.SetChildIndex(this.toolStripTmp, 0);
            this.Controls.SetChildIndex(this.comboBoxWithListBoxMedicineKinds, 0);
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
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private CustomTextBox.ComboBoxWithListBox comboBoxWithListBoxMedicineKinds;
    }
}