namespace CustomForm
{
    partial class FormCustomHelped
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
            this.panelHelp = new System.Windows.Forms.Panel();
            this.labelHelpText = new System.Windows.Forms.Label();
            this.panelHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHelp
            // 
            this.panelHelp.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelHelp.Controls.Add(this.labelHelpText);
            this.panelHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHelp.Location = new System.Drawing.Point(0, 0);
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.Size = new System.Drawing.Size(442, 50);
            this.panelHelp.TabIndex = 1;
            // 
            // labelHelpText
            // 
            this.labelHelpText.BackColor = System.Drawing.Color.SteelBlue;
            this.labelHelpText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHelpText.ForeColor = System.Drawing.Color.White;
            this.labelHelpText.Location = new System.Drawing.Point(0, 0);
            this.labelHelpText.Name = "labelHelpText";
            this.labelHelpText.Size = new System.Drawing.Size(442, 50);
            this.labelHelpText.TabIndex = 0;
            this.labelHelpText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormCustomHelped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 266);
            this.Controls.Add(this.panelHelp);
            this.Name = "FormCustomHelped";
            this.Text = "FormCustomHelped";
            this.panelHelp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHelp;
        private System.Windows.Forms.Label labelHelpText;
    }
}