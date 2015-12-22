/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2010-3-15
 * Time: 12:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MedicineStock.DataOperate
{
	partial class FormStockVerifyAndWareHousing
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonOK);
            this.panelButtons.Location = new System.Drawing.Point(0, 490);
            this.panelButtons.Size = new System.Drawing.Size(597, 50);
            this.panelButtons.Controls.SetChildIndex(this.buttonOK, 0);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(422, 8);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 34);
            this.buttonOK.TabIndex = 21;
            this.buttonOK.Text = "审核(&S)";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormStockVerifyAndWareHousing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 540);
            this.MaxSize = new System.Drawing.Size(605, 574);
            this.MinSize = new System.Drawing.Size(605, 574);
            this.Name = "FormStockVerifyAndWareHousing";
            this.Text = "进货单审核";
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button buttonOK;
	}
}
