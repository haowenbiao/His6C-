namespace ClassLibraryFarPointSpreadPageSet
{
    partial class FormFarPointSpreadPageSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFarPointSpreadPageSet));
            this.trueOrFalseSelectorControlShowBorder = new TrueOrFalseSelectorControl.trueOrFalseSelectorControl();
            this.trueOrFalseSelectorControlShowColor = new TrueOrFalseSelectorControl.trueOrFalseSelectorControl();
            this.trueOrFalseSelectorControlShowGrid = new TrueOrFalseSelectorControl.trueOrFalseSelectorControl();
            this.trueOrFalseSelectorControlShowShadow = new TrueOrFalseSelectorControl.trueOrFalseSelectorControl();
            this.paperMarginSetor1 = new ClassLibraryFarPointSpreadPageSet.PaperMarginSetor();
            this.paperSizeSelector1 = new PaperSizeSelector.PaperSizeSelector();
            this.printHeaderSelectorRowHead = new ClassLibraryFarPointSpreadPageSet.PrintHeaderSelector();
            this.printHeaderSelectorColumHead = new ClassLibraryFarPointSpreadPageSet.PrintHeaderSelector();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trueOrFalseSelectorControlShowBorder
            // 
            this.trueOrFalseSelectorControlShowBorder.Location = new System.Drawing.Point(12, 12);
            this.trueOrFalseSelectorControlShowBorder.Name = "trueOrFalseSelectorControlShowBorder";
            this.trueOrFalseSelectorControlShowBorder.Size = new System.Drawing.Size(104, 50);
            this.trueOrFalseSelectorControlShowBorder.TabIndex = 0;
            this.trueOrFalseSelectorControlShowBorder.Value = true;
            this.trueOrFalseSelectorControlShowBorder.标题 = "打印边框";
            // 
            // trueOrFalseSelectorControlShowColor
            // 
            this.trueOrFalseSelectorControlShowColor.Location = new System.Drawing.Point(122, 12);
            this.trueOrFalseSelectorControlShowColor.Name = "trueOrFalseSelectorControlShowColor";
            this.trueOrFalseSelectorControlShowColor.Size = new System.Drawing.Size(104, 50);
            this.trueOrFalseSelectorControlShowColor.TabIndex = 1;
            this.trueOrFalseSelectorControlShowColor.Value = true;
            this.trueOrFalseSelectorControlShowColor.标题 = "彩色打印";
            // 
            // trueOrFalseSelectorControlShowGrid
            // 
            this.trueOrFalseSelectorControlShowGrid.Location = new System.Drawing.Point(12, 68);
            this.trueOrFalseSelectorControlShowGrid.Name = "trueOrFalseSelectorControlShowGrid";
            this.trueOrFalseSelectorControlShowGrid.Size = new System.Drawing.Size(104, 50);
            this.trueOrFalseSelectorControlShowGrid.TabIndex = 2;
            this.trueOrFalseSelectorControlShowGrid.Value = true;
            this.trueOrFalseSelectorControlShowGrid.标题 = "打印表格";
            // 
            // trueOrFalseSelectorControlShowShadow
            // 
            this.trueOrFalseSelectorControlShowShadow.Location = new System.Drawing.Point(122, 68);
            this.trueOrFalseSelectorControlShowShadow.Name = "trueOrFalseSelectorControlShowShadow";
            this.trueOrFalseSelectorControlShowShadow.Size = new System.Drawing.Size(104, 50);
            this.trueOrFalseSelectorControlShowShadow.TabIndex = 3;
            this.trueOrFalseSelectorControlShowShadow.Value = true;
            this.trueOrFalseSelectorControlShowShadow.标题 = "打印页眉阴影";
            // 
            // paperMarginSetor1
            // 
            this.paperMarginSetor1.Location = new System.Drawing.Point(232, 129);
            this.paperMarginSetor1.Name = "paperMarginSetor1";
            this.paperMarginSetor1.Size = new System.Drawing.Size(214, 108);
            this.paperMarginSetor1.TabIndex = 7;
            this.paperMarginSetor1.Value = ((FarPoint.Win.Spread.PrintMargin)(resources.GetObject("paperMarginSetor1.Value")));
            // 
            // paperSizeSelector1
            // 
            this.paperSizeSelector1.Location = new System.Drawing.Point(12, 124);
            this.paperSizeSelector1.Name = "paperSizeSelector1";
            this.paperSizeSelector1.Size = new System.Drawing.Size(214, 113);
            this.paperSizeSelector1.TabIndex = 6;
            this.paperSizeSelector1.Value = ((System.Drawing.Printing.PaperSize)(resources.GetObject("paperSizeSelector1.Value")));
            // 
            // printHeaderSelectorRowHead
            // 
            this.printHeaderSelectorRowHead.Location = new System.Drawing.Point(232, 71);
            this.printHeaderSelectorRowHead.Name = "printHeaderSelectorRowHead";
            this.printHeaderSelectorRowHead.Size = new System.Drawing.Size(214, 52);
            this.printHeaderSelectorRowHead.TabIndex = 5;
            this.printHeaderSelectorRowHead.Value = FarPoint.Win.Spread.PrintHeader.Show;
            this.printHeaderSelectorRowHead.标题 = "是否显示行标题";
            // 
            // printHeaderSelectorColumHead
            // 
            this.printHeaderSelectorColumHead.Location = new System.Drawing.Point(232, 12);
            this.printHeaderSelectorColumHead.Name = "printHeaderSelectorColumHead";
            this.printHeaderSelectorColumHead.Size = new System.Drawing.Size(214, 52);
            this.printHeaderSelectorColumHead.TabIndex = 4;
            this.printHeaderSelectorColumHead.Value = FarPoint.Win.Spread.PrintHeader.Show;
            this.printHeaderSelectorColumHead.标题 = "是否显示列标题";
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(357, 24);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "关闭(Esc)";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(276, 24);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "保存(&S)";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonClose);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Location = new System.Drawing.Point(-1, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 60);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // FormFarPointSpreadPageSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(460, 302);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.paperMarginSetor1);
            this.Controls.Add(this.paperSizeSelector1);
            this.Controls.Add(this.printHeaderSelectorRowHead);
            this.Controls.Add(this.printHeaderSelectorColumHead);
            this.Controls.Add(this.trueOrFalseSelectorControlShowShadow);
            this.Controls.Add(this.trueOrFalseSelectorControlShowGrid);
            this.Controls.Add(this.trueOrFalseSelectorControlShowColor);
            this.Controls.Add(this.trueOrFalseSelectorControlShowBorder);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFarPointSpreadPageSet";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打印设置";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TrueOrFalseSelectorControl.trueOrFalseSelectorControl trueOrFalseSelectorControlShowBorder;
        private TrueOrFalseSelectorControl.trueOrFalseSelectorControl trueOrFalseSelectorControlShowColor;
        private TrueOrFalseSelectorControl.trueOrFalseSelectorControl trueOrFalseSelectorControlShowGrid;
        private TrueOrFalseSelectorControl.trueOrFalseSelectorControl trueOrFalseSelectorControlShowShadow;
        private PrintHeaderSelector printHeaderSelectorColumHead;
        private PrintHeaderSelector printHeaderSelectorRowHead;
        private PaperSizeSelector.PaperSizeSelector paperSizeSelector1;
        private PaperMarginSetor paperMarginSetor1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}