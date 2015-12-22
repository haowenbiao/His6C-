namespace CustomForm
{
    partial class FormCustomListItemAdd_Design
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.bindingSourceListItem = new System.Windows.Forms.BindingSource(this.components);
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceListItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonOK);
            this.panelButtons.Controls.Add(this.buttonClose);
            this.panelButtons.Location = new System.Drawing.Point(0, 216);
            this.panelButtons.Size = new System.Drawing.Size(292, 50);
            this.panelButtons.Controls.SetChildIndex(this.buttonClose, 0);
            this.panelButtons.Controls.SetChildIndex(this.buttonOK, 0);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(205, 8);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 34);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "关闭(ES&C)";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(124, 8);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 34);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "增加(&A)";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // FormCustomListItemAdd_Design
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.MaxSize = new System.Drawing.Size(300, 300);
            this.Name = "FormCustomListItemAdd_Design";
            this.Text = "FormCustomListItemAdd_Design";
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceListItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        protected System.Windows.Forms.Button buttonOK;
        protected System.Windows.Forms.BindingSource bindingSourceListItem;
    }
}