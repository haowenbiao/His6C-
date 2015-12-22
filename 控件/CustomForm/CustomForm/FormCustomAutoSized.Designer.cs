
namespace CustomForm
{
	partial class FormCustomAutoSized
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonResize = new System.Windows.Forms.Button();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelButtons.Controls.Add(this.buttonResize);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 216);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(292, 50);
            this.panelButtons.TabIndex = 2;
            // 
            // buttonResize
            // 
            this.buttonResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonResize.Location = new System.Drawing.Point(12, 8);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(34, 34);
            this.buttonResize.TabIndex = 0;
            this.buttonResize.Text = "...";
            this.buttonResize.UseVisualStyleBackColor = true;
            this.buttonResize.Click += new System.EventHandler(this.buttonResize_Click);
            // 
            // FormCustomAutoSized
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.panelButtons);
            this.Name = "FormCustomAutoSized";
            this.Text = "FormCustomAutoSize";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonResize;
	}
}
