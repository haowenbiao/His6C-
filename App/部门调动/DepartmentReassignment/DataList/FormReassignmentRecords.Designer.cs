namespace DepartmentReassignment.DataList
{
    partial class FormReassignmentRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReassignmentRecords));
            this.toolStripTmp = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBoxWorker = new System.Windows.Forms.ToolStripComboBox();
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
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(629, 212);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 69);
            this.toolStripContainer1.Size = new System.Drawing.Size(629, 287);
            this.toolStripContainer1.TopToolStripPanelVisible = true;
            // 
            // toolStripTmp
            // 
            this.toolStripTmp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxWorker,
            this.toolStripButtonSearch});
            this.toolStripTmp.Location = new System.Drawing.Point(0, 44);
            this.toolStripTmp.Name = "toolStripTmp";
            this.toolStripTmp.Size = new System.Drawing.Size(629, 25);
            this.toolStripTmp.TabIndex = 3;
            this.toolStripTmp.Text = "toolStrip1";
            this.toolStripTmp.Visible = false;
            // 
            // toolStripComboBoxWorker
            // 
            this.toolStripComboBoxWorker.Name = "toolStripComboBoxWorker";
            this.toolStripComboBoxWorker.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBoxWorker.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripComboBoxWorker_KeyUp);
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
            // FormReassignmentRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 356);
            this.Controls.Add(this.toolStripTmp);
            this.HelpText = "提示：在查询框中输入要查询的职工的姓名或其姓名拼音码，即可查询某个人的调动情况记录。";
            this.Name = "FormReassignmentRecords";
            this.Text = "调动记录";
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
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxWorker;

    }
}