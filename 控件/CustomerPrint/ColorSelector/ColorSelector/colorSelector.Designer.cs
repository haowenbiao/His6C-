namespace ColorSelector
{
    partial class colorSelector
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBarWithTextBox_R = new TrackBarWithTextBox.trackBarWithTextBox();
            this.trackBarWithTextBox_G = new TrackBarWithTextBox.trackBarWithTextBox();
            this.trackBarWithTextBox_B = new TrackBarWithTextBox.trackBarWithTextBox();
            this.trackBarWithTextBox_A = new TrackBarWithTextBox.trackBarWithTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.trackBarWithTextBox_R, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.trackBarWithTextBox_G, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.trackBarWithTextBox_B, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.trackBarWithTextBox_A, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 92);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "绿色：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "蓝色：";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "透明：";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "红色：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(190, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 4);
            this.pictureBox1.Size = new System.Drawing.Size(52, 82);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // trackBarWithTextBox_R
            // 
            this.trackBarWithTextBox_R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarWithTextBox_R.Location = new System.Drawing.Point(48, 0);
            this.trackBarWithTextBox_R.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarWithTextBox_R.Maximum = 255;
            this.trackBarWithTextBox_R.Name = "trackBarWithTextBox_R";
            this.trackBarWithTextBox_R.Size = new System.Drawing.Size(142, 23);
            this.trackBarWithTextBox_R.TabIndex = 10;
            this.trackBarWithTextBox_R.valueChanged += new TrackBarWithTextBox.valueChangedHandle(this.ColorChanged);
            // 
            // trackBarWithTextBox_G
            // 
            this.trackBarWithTextBox_G.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarWithTextBox_G.Location = new System.Drawing.Point(48, 23);
            this.trackBarWithTextBox_G.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarWithTextBox_G.Maximum = 255;
            this.trackBarWithTextBox_G.Name = "trackBarWithTextBox_G";
            this.trackBarWithTextBox_G.Size = new System.Drawing.Size(142, 23);
            this.trackBarWithTextBox_G.TabIndex = 11;
            this.trackBarWithTextBox_G.valueChanged += new TrackBarWithTextBox.valueChangedHandle(this.ColorChanged);
            // 
            // trackBarWithTextBox_B
            // 
            this.trackBarWithTextBox_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarWithTextBox_B.Location = new System.Drawing.Point(48, 46);
            this.trackBarWithTextBox_B.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarWithTextBox_B.Maximum = 255;
            this.trackBarWithTextBox_B.Name = "trackBarWithTextBox_B";
            this.trackBarWithTextBox_B.Size = new System.Drawing.Size(142, 23);
            this.trackBarWithTextBox_B.TabIndex = 12;
            this.trackBarWithTextBox_B.valueChanged += new TrackBarWithTextBox.valueChangedHandle(this.ColorChanged);
            // 
            // trackBarWithTextBox_A
            // 
            this.trackBarWithTextBox_A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarWithTextBox_A.Location = new System.Drawing.Point(48, 69);
            this.trackBarWithTextBox_A.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarWithTextBox_A.Maximum = 255;
            this.trackBarWithTextBox_A.Name = "trackBarWithTextBox_A";
            this.trackBarWithTextBox_A.Size = new System.Drawing.Size(142, 23);
            this.trackBarWithTextBox_A.TabIndex = 13;
            this.trackBarWithTextBox_A.valueChanged += new TrackBarWithTextBox.valueChangedHandle(this.ColorChanged);
            // 
            // colorSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "colorSelector";
            this.Size = new System.Drawing.Size(262, 92);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private TrackBarWithTextBox.trackBarWithTextBox trackBarWithTextBox_R;
        private TrackBarWithTextBox.trackBarWithTextBox trackBarWithTextBox_G;
        private TrackBarWithTextBox.trackBarWithTextBox trackBarWithTextBox_B;
        private TrackBarWithTextBox.trackBarWithTextBox trackBarWithTextBox_A;
    }
}
