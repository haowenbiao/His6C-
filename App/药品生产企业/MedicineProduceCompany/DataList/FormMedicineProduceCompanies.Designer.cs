namespace MedicineProduceCompany.DataList
{
    partial class FormMedicineProduceCompanies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedicineProduceCompanies));
            this.toolStripTmp = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBoxCompanyNameOrPYM = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemove = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStripTmp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(463, 170);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 69);
            this.toolStripContainer1.Size = new System.Drawing.Size(463, 245);
            this.toolStripContainer1.TopToolStripPanelVisible = true;
            // 
            // toolStripTmp
            // 
            this.toolStripTmp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxCompanyNameOrPYM,
            this.toolStripButtonSearch,
            this.toolStripSeparator1,
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripButtonRemove});
            this.toolStripTmp.Location = new System.Drawing.Point(0, 44);
            this.toolStripTmp.Name = "toolStripTmp";
            this.toolStripTmp.Size = new System.Drawing.Size(463, 25);
            this.toolStripTmp.TabIndex = 3;
            this.toolStripTmp.Text = "toolStripTmp";
            this.toolStripTmp.Visible = false;
            // 
            // toolStripTextBoxCompanyNameOrPYM
            // 
            this.toolStripTextBoxCompanyNameOrPYM.Name = "toolStripTextBoxCompanyNameOrPYM";
            this.toolStripTextBoxCompanyNameOrPYM.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxCompanyNameOrPYM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxCompanyNameOrPYM_KeyUp);
            // 
            // toolStripButtonSearch
            // 
            this.toolStripButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearch.Image")));
            this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearch.Name = "toolStripButtonSearch";
            this.toolStripButtonSearch.Size = new System.Drawing.Size(33, 22);
            this.toolStripButtonSearch.Text = "查找";
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
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdit.Image")));
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonEdit.Text = "修改(&S)";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripButtonRemove
            // 
            this.toolStripButtonRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRemove.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRemove.Image")));
            this.toolStripButtonRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemove.Name = "toolStripButtonRemove";
            this.toolStripButtonRemove.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonRemove.Text = "删除(&D)";
            this.toolStripButtonRemove.Click += new System.EventHandler(this.toolStripButtonRemove_Click);
            // 
            // contextMenuStripTmp
            // 
            this.contextMenuStripTmp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdd,
            this.toolStripMenuItemEdit,
            this.toolStripMenuItemRemove});
            this.contextMenuStripTmp.Name = "contextMenuStripTmp";
            this.contextMenuStripTmp.Size = new System.Drawing.Size(95, 70);
            // 
            // toolStripMenuItemAdd
            // 
            this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            this.toolStripMenuItemAdd.Size = new System.Drawing.Size(94, 22);
            this.toolStripMenuItemAdd.Text = "增加";
            this.toolStripMenuItemAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(94, 22);
            this.toolStripMenuItemEdit.Text = "修改";
            this.toolStripMenuItemEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripMenuItemRemove
            // 
            this.toolStripMenuItemRemove.Name = "toolStripMenuItemRemove";
            this.toolStripMenuItemRemove.Size = new System.Drawing.Size(94, 22);
            this.toolStripMenuItemRemove.Text = "删除";
            this.toolStripMenuItemRemove.Click += new System.EventHandler(this.toolStripButtonRemove_Click);
            // 
            // FormMedicineProduceCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 314);
            this.Controls.Add(this.toolStripTmp);
            this.Name = "FormMedicineProduceCompanies";
            this.Text = "FormMedicineProductCompanys";
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
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemove;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTmp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemove;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxCompanyNameOrPYM;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}