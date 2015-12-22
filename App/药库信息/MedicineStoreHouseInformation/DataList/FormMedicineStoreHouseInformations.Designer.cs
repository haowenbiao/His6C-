namespace MedicineStoreHouseInformation.DataList
{
    partial class FormMedicineStoreHouseInformations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedicineStoreHouseInformations));
            this.toolStripTmp = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemove = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStripTmp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemTmpAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTmpEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTmpRemove = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(463, 195);
            this.toolStripContainer1.TopToolStripPanelVisible = true;
            // 
            // toolStripTmp
            // 
            this.toolStripTmp.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTmp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripButtonRemove});
            this.toolStripTmp.Location = new System.Drawing.Point(3, 50);
            this.toolStripTmp.Name = "toolStripTmp";
            this.toolStripTmp.Size = new System.Drawing.Size(165, 25);
            this.toolStripTmp.TabIndex = 2;
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonAdd.Text = "增加(&A)";
            this.toolStripButtonAdd.ToolTipText = "增加药库信息";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdit.Image")));
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonEdit.Text = "修改(&D)";
            this.toolStripButtonEdit.ToolTipText = "修改药库信息";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripButtonRemove
            // 
            this.toolStripButtonRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRemove.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRemove.Image")));
            this.toolStripButtonRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemove.Name = "toolStripButtonRemove";
            this.toolStripButtonRemove.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonRemove.Text = "删除(&R)";
            this.toolStripButtonRemove.ToolTipText = "删除药库信息";
            this.toolStripButtonRemove.Click += new System.EventHandler(this.toolStripButtonRemove_Click);
            // 
            // contextMenuStripTmp
            // 
            this.contextMenuStripTmp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTmpAdd,
            this.toolStripMenuItemTmpEdit,
            this.toolStripMenuItemTmpRemove});
            this.contextMenuStripTmp.Name = "contextMenuStrip1";
            this.contextMenuStripTmp.Size = new System.Drawing.Size(136, 70);
            // 
            // toolStripMenuItemTmpAdd
            // 
            this.toolStripMenuItemTmpAdd.Name = "toolStripMenuItemTmpAdd";
            this.toolStripMenuItemTmpAdd.ShortcutKeyDisplayString = "Ctrl+A";
            this.toolStripMenuItemTmpAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.toolStripMenuItemTmpAdd.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemTmpAdd.Text = "增加";
            this.toolStripMenuItemTmpAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripMenuItemTmpEdit
            // 
            this.toolStripMenuItemTmpEdit.Name = "toolStripMenuItemTmpEdit";
            this.toolStripMenuItemTmpEdit.ShortcutKeyDisplayString = "Ctrl+E";
            this.toolStripMenuItemTmpEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.toolStripMenuItemTmpEdit.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemTmpEdit.Text = "修改";
            this.toolStripMenuItemTmpEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripMenuItemTmpRemove
            // 
            this.toolStripMenuItemTmpRemove.Name = "toolStripMenuItemTmpRemove";
            this.toolStripMenuItemTmpRemove.ShortcutKeyDisplayString = "Ctrl+R";
            this.toolStripMenuItemTmpRemove.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.toolStripMenuItemTmpRemove.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemTmpRemove.Text = "删除";
            this.toolStripMenuItemTmpRemove.Click += new System.EventHandler(this.toolStripButtonRemove_Click);
            // 
            // FormMedicineStoreHouseInformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 314);
            this.HelpText = "药库信息增加、修改、删除。注意：已使用过的药库信息不可删除。";
            this.Name = "FormMedicineStoreHouseInformations";
            this.Text = "药库信息";
            this.Controls.SetChildIndex(this.toolStripContainer1, 0);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripTmp.ResumeLayout(false);
            this.toolStripTmp.PerformLayout();
            this.contextMenuStripTmp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripTmp;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemove;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTmp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTmpAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTmpEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTmpRemove;
    }
}