namespace MedicineStock.DataOperate
{
    partial class FormStockVerify
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
            this.workerSelectorComboBoxWithDataGridView1 = new WorkerSelectorControl.WorkerSelectorComboBoxWithDataGridView();
            this.textBox登录密码 = new System.Windows.Forms.TextBox();
            this.textBoxWithButton备注 = new CustomTextBox.TextBoxWithButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelButtons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonClose);
            this.panelButtons.Controls.Add(this.buttonOK);
            this.panelButtons.Location = new System.Drawing.Point(0, 206);
            this.panelButtons.Size = new System.Drawing.Size(285, 50);
            this.panelButtons.TabIndex = 1;
            this.panelButtons.Controls.SetChildIndex(this.buttonOK, 0);
            this.panelButtons.Controls.SetChildIndex(this.buttonClose, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.workerSelectorComboBoxWithDataGridView1);
            this.groupBox1.Controls.Add(this.textBox登录密码);
            this.groupBox1.Controls.Add(this.textBoxWithButton备注);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "审核人信息";
            // 
            // workerSelectorComboBoxWithDataGridView1
            // 
            this.workerSelectorComboBoxWithDataGridView1.FormattingEnabled = true;
            this.workerSelectorComboBoxWithDataGridView1.Location = new System.Drawing.Point(83, 21);
            this.workerSelectorComboBoxWithDataGridView1.Name = "workerSelectorComboBoxWithDataGridView1";
            this.workerSelectorComboBoxWithDataGridView1.Size = new System.Drawing.Size(166, 20);
            this.workerSelectorComboBoxWithDataGridView1.TabIndex = 0;
            this.workerSelectorComboBoxWithDataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            // 
            // textBox登录密码
            // 
            this.textBox登录密码.Location = new System.Drawing.Point(83, 54);
            this.textBox登录密码.Name = "textBox登录密码";
            this.textBox登录密码.Size = new System.Drawing.Size(166, 21);
            this.textBox登录密码.TabIndex = 1;
            this.textBox登录密码.UseSystemPasswordChar = true;
            this.textBox登录密码.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            // 
            // textBoxWithButton备注
            // 
            this.textBoxWithButton备注.errorMessage = null;
            this.textBoxWithButton备注.FormAdvanceCaption = "详细内容";
            this.textBoxWithButton备注.Location = new System.Drawing.Point(83, 90);
            this.textBoxWithButton备注.Name = "textBoxWithButton备注";
            this.textBoxWithButton备注.Size = new System.Drawing.Size(166, 21);
            this.textBoxWithButton备注.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "备注：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "登录密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "审核人：";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(58, 8);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 34);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "确定(&A)";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(151, 8);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 34);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "取消(ES&C)";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormStockVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(285, 256);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpText = "注意：尽量避免审核自己的入库行为，虽然系统允许这么做。";
            this.MaximizeBox = false;
            this.MaxSize = new System.Drawing.Size(291, 288);
            this.MinimizeBox = false;
            this.MinSize = new System.Drawing.Size(291, 288);
            this.Name = "FormStockVerify";
            this.ShowResizeButton = false;
            this.Text = "审核";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.panelButtons.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox登录密码;
        private CustomTextBox.TextBoxWithButton textBoxWithButton备注;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOK;
        private WorkerSelectorControl.WorkerSelectorComboBoxWithDataGridView workerSelectorComboBoxWithDataGridView1;
    }
}