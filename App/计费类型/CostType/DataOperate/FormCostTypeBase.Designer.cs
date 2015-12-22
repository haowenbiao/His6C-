namespace CostType.DataOperate
{
    partial class FormCostTypeBase
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
            this.textBox拼音码 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox计费类型 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxWithButton备注 = new CustomTextBox.TextBoxWithButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox拼音码);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox计费类型);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基础信息";
            // 
            // textBox拼音码
            // 
            this.textBox拼音码.Location = new System.Drawing.Point(79, 47);
            this.textBox拼音码.Name = "textBox拼音码";
            this.textBox拼音码.Size = new System.Drawing.Size(116, 21);
            this.textBox拼音码.TabIndex = 3;
            this.textBox拼音码.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            this.textBox拼音码.Validating += new System.ComponentModel.CancelEventHandler(this.NoneNullabletextBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "拼音码：";
            // 
            // textBox计费类型
            // 
            this.textBox计费类型.Location = new System.Drawing.Point(79, 20);
            this.textBox计费类型.Name = "textBox计费类型";
            this.textBox计费类型.Size = new System.Drawing.Size(116, 21);
            this.textBox计费类型.TabIndex = 1;
            this.textBox计费类型.Validated += new System.EventHandler(this.textBox名称_Validated);
            this.textBox计费类型.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            this.textBox计费类型.Validating += new System.ComponentModel.CancelEventHandler(this.NoneNullabletextBox_Validating);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxWithButton备注);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 56);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "附加信息";
            // 
            // textBoxWithButton备注
            // 
            this.textBoxWithButton备注.errorMessage = null;
            this.textBoxWithButton备注.FormAdvanceCaption = "详细内容";
            this.textBoxWithButton备注.Location = new System.Drawing.Point(79, 19);
            this.textBoxWithButton备注.Name = "textBoxWithButton备注";
            this.textBoxWithButton备注.Size = new System.Drawing.Size(116, 21);
            this.textBoxWithButton备注.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "备注：";
            // 
            // FormCostTypeBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 263);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.HelpText = "提示：基本信息为必填项目。使用Tab键可以在输入框之间快速切换。单击...按钮显示高级信息。";
            this.MaxSize = new System.Drawing.Size(253, 297);
            this.MinSize = new System.Drawing.Size(253, 238);
            this.Name = "FormCostTypeBase";
            this.Text = "FormCostTypeBase";
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox拼音码;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox计费类型;
        private System.Windows.Forms.Label label1;
        private CustomTextBox.TextBoxWithButton textBoxWithButton备注;
        private System.Windows.Forms.Label label3;
    }
}