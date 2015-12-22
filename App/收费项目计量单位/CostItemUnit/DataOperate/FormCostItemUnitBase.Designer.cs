namespace CostItemUnit.DataOperate
{
    partial class FormCostItemUnitBase
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox单位名称 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Location = new System.Drawing.Point(0, 136);
            this.panelButtons.Size = new System.Drawing.Size(245, 50);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox单位名称);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基础信息";
            // 
            // textBox单位名称
            // 
            this.textBox单位名称.Location = new System.Drawing.Point(79, 20);
            this.textBox单位名称.Name = "textBox单位名称";
            this.textBox单位名称.Size = new System.Drawing.Size(116, 21);
            this.textBox单位名称.TabIndex = 0;
            this.textBox单位名称.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            this.textBox单位名称.Validating += new System.ComponentModel.CancelEventHandler(this.NoneNullabletextBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "计费类型：";
            // 
            // FormCostItemUnitBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 186);
            this.Controls.Add(this.groupBox1);
            this.MaxSize = new System.Drawing.Size(253, 220);
            this.MinSize = new System.Drawing.Size(253, 220);
            this.Name = "FormCostItemUnitBase";
            this.ShowResizeButton = false;
            this.Text = "FormCostItemUnitBase";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox单位名称;
        private System.Windows.Forms.Label label1;

    }
}