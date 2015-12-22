namespace QuantityUnit.DataOperate
{
    partial class FormQuantityUnitBase
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
            this.textBox名称 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Location = new System.Drawing.Point(0, 145);
            this.panelButtons.Size = new System.Drawing.Size(235, 50);
            // 
            // textBox名称
            // 
            this.textBox名称.Location = new System.Drawing.Point(104, 20);
            this.textBox名称.Name = "textBox名称";
            this.textBox名称.Size = new System.Drawing.Size(100, 21);
            this.textBox名称.TabIndex = 0;
            this.textBox名称.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "计量单位名称：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox名称);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 59);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // FormQuantityUnitBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 195);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpText = "药品计量单位信息";
            this.MaximizeBox = false;
            this.MaxSize = new System.Drawing.Size(241, 227);
            this.MinimizeBox = false;
            this.MinSize = new System.Drawing.Size(241, 227);
            this.Name = "FormQuantityUnitBase";
            this.ShowResizeButton = false;
            this.Text = "计量单位";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox名称;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}