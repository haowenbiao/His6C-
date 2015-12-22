namespace DateSelectControl
{
    partial class DateSelectControl
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonUseNaturalDate = new System.Windows.Forms.RadioButton();
            this.radioButtonUseAccountingDate = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxNaturalDate = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimeTextBoxEnd = new CustomTextBox.DateTimeTextBox();
            this.classNaturalDatePeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimeTextBoxStart = new CustomTextBox.DateTimeTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.radioButtonNaturalDatePeriod = new System.Windows.Forms.RadioButton();
            this.radioButtonNaturalDateMonth = new System.Windows.Forms.RadioButton();
            this.radioButtonNaturalDateDay = new System.Windows.Forms.RadioButton();
            this.groupBoxAccountingDate = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownEndDateDay = new System.Windows.Forms.NumericUpDown();
            this.classAccountingPeriodInformationPropertiesBindingSourceEnd = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownEndDateMonth = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownEndDateYear = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownStartDateDay = new System.Windows.Forms.NumericUpDown();
            this.classAccountingPeriodInformationPropertiesBindingSourceStart = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownStartDateMonth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownStartDateYear = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonAccountingDatePeriod = new System.Windows.Forms.RadioButton();
            this.radioButtonAccountingDateCurrentMonth = new System.Windows.Forms.RadioButton();
            this.radioButtonAccountingDateCurrentDay = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxNaturalDate.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classNaturalDatePeriodBindingSource)).BeginInit();
            this.groupBoxAccountingDate.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndDateDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classAccountingPeriodInformationPropertiesBindingSourceEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndDateMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndDateYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartDateDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classAccountingPeriodInformationPropertiesBindingSourceStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartDateMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartDateYear)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "日期";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(291, 181);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 43);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonUseNaturalDate);
            this.groupBox2.Controls.Add(this.radioButtonUseAccountingDate);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 43);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选择日期类型";
            // 
            // radioButtonUseNaturalDate
            // 
            this.radioButtonUseNaturalDate.AutoSize = true;
            this.radioButtonUseNaturalDate.Location = new System.Drawing.Point(124, 21);
            this.radioButtonUseNaturalDate.Name = "radioButtonUseNaturalDate";
            this.radioButtonUseNaturalDate.Size = new System.Drawing.Size(95, 16);
            this.radioButtonUseNaturalDate.TabIndex = 1;
            this.radioButtonUseNaturalDate.Text = "使用自然日期";
            this.radioButtonUseNaturalDate.UseVisualStyleBackColor = true;
            // 
            // radioButtonUseAccountingDate
            // 
            this.radioButtonUseAccountingDate.AutoSize = true;
            this.radioButtonUseAccountingDate.Checked = true;
            this.radioButtonUseAccountingDate.Location = new System.Drawing.Point(7, 21);
            this.radioButtonUseAccountingDate.Name = "radioButtonUseAccountingDate";
            this.radioButtonUseAccountingDate.Size = new System.Drawing.Size(95, 16);
            this.radioButtonUseAccountingDate.TabIndex = 0;
            this.radioButtonUseAccountingDate.TabStop = true;
            this.radioButtonUseAccountingDate.Text = "使用会计日期";
            this.radioButtonUseAccountingDate.UseVisualStyleBackColor = true;
            this.radioButtonUseAccountingDate.CheckedChanged += new System.EventHandler(this.DateType_Changed);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxAccountingDate);
            this.panel2.Controls.Add(this.groupBoxNaturalDate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 126);
            this.panel2.TabIndex = 2;
            // 
            // groupBoxNaturalDate
            // 
            this.groupBoxNaturalDate.Controls.Add(this.panel4);
            this.groupBoxNaturalDate.Controls.Add(this.radioButtonNaturalDatePeriod);
            this.groupBoxNaturalDate.Controls.Add(this.radioButtonNaturalDateMonth);
            this.groupBoxNaturalDate.Controls.Add(this.radioButtonNaturalDateDay);
            this.groupBoxNaturalDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxNaturalDate.Location = new System.Drawing.Point(0, 0);
            this.groupBoxNaturalDate.Name = "groupBoxNaturalDate";
            this.groupBoxNaturalDate.Size = new System.Drawing.Size(285, 126);
            this.groupBoxNaturalDate.TabIndex = 2;
            this.groupBoxNaturalDate.TabStop = false;
            this.groupBoxNaturalDate.Text = "自然日期";
            this.groupBoxNaturalDate.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dateTimeTextBoxEnd);
            this.panel4.Controls.Add(this.dateTimeTextBoxStart);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(21, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(156, 56);
            this.panel4.TabIndex = 4;
            // 
            // dateTimeTextBoxEnd
            // 
            this.dateTimeTextBoxEnd.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.classNaturalDatePeriodBindingSource, "End", true));
            this.dateTimeTextBoxEnd.errorMessage = null;
            this.dateTimeTextBoxEnd.Location = new System.Drawing.Point(45, 30);
            this.dateTimeTextBoxEnd.Name = "dateTimeTextBoxEnd";
            this.dateTimeTextBoxEnd.Size = new System.Drawing.Size(100, 21);
            this.dateTimeTextBoxEnd.TabIndex = 9;
            this.dateTimeTextBoxEnd.Text = "2009年10月20日";
            this.dateTimeTextBoxEnd.Value = new System.DateTime(2009, 10, 20, 0, 0, 0, 0);
            // 
            // classNaturalDatePeriodBindingSource
            // 
            this.classNaturalDatePeriodBindingSource.DataSource = typeof(ClassNaturalDatePeriod);
            // 
            // dateTimeTextBoxStart
            // 
            this.dateTimeTextBoxStart.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.classNaturalDatePeriodBindingSource, "Start", true));
            this.dateTimeTextBoxStart.errorMessage = null;
            this.dateTimeTextBoxStart.Location = new System.Drawing.Point(45, 3);
            this.dateTimeTextBoxStart.Name = "dateTimeTextBoxStart";
            this.dateTimeTextBoxStart.Size = new System.Drawing.Size(100, 21);
            this.dateTimeTextBoxStart.TabIndex = 8;
            this.dateTimeTextBoxStart.Text = "2009年10月20日";
            this.dateTimeTextBoxStart.Value = new System.DateTime(2009, 10, 20, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 7;
            this.label12.Text = "截止：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "起始：";
            // 
            // radioButtonNaturalDatePeriod
            // 
            this.radioButtonNaturalDatePeriod.AutoSize = true;
            this.radioButtonNaturalDatePeriod.Location = new System.Drawing.Point(7, 42);
            this.radioButtonNaturalDatePeriod.Name = "radioButtonNaturalDatePeriod";
            this.radioButtonNaturalDatePeriod.Size = new System.Drawing.Size(47, 16);
            this.radioButtonNaturalDatePeriod.TabIndex = 2;
            this.radioButtonNaturalDatePeriod.Text = "期间";
            this.radioButtonNaturalDatePeriod.UseVisualStyleBackColor = true;
            this.radioButtonNaturalDatePeriod.CheckedChanged += new System.EventHandler(this.radioButtonNaturalDatePeriod_CheckedChanged);
            // 
            // radioButtonNaturalDateMonth
            // 
            this.radioButtonNaturalDateMonth.AutoSize = true;
            this.radioButtonNaturalDateMonth.Location = new System.Drawing.Point(124, 20);
            this.radioButtonNaturalDateMonth.Name = "radioButtonNaturalDateMonth";
            this.radioButtonNaturalDateMonth.Size = new System.Drawing.Size(71, 16);
            this.radioButtonNaturalDateMonth.TabIndex = 1;
            this.radioButtonNaturalDateMonth.Text = "本自然月";
            this.radioButtonNaturalDateMonth.UseVisualStyleBackColor = true;
            this.radioButtonNaturalDateMonth.CheckedChanged += new System.EventHandler(this.DatePeriodType_Changed);
            // 
            // radioButtonNaturalDateDay
            // 
            this.radioButtonNaturalDateDay.AutoSize = true;
            this.radioButtonNaturalDateDay.Checked = true;
            this.radioButtonNaturalDateDay.Location = new System.Drawing.Point(7, 20);
            this.radioButtonNaturalDateDay.Name = "radioButtonNaturalDateDay";
            this.radioButtonNaturalDateDay.Size = new System.Drawing.Size(71, 16);
            this.radioButtonNaturalDateDay.TabIndex = 0;
            this.radioButtonNaturalDateDay.TabStop = true;
            this.radioButtonNaturalDateDay.Text = "本自然日";
            this.radioButtonNaturalDateDay.UseVisualStyleBackColor = true;
            this.radioButtonNaturalDateDay.CheckedChanged += new System.EventHandler(this.DatePeriodType_Changed);
            // 
            // groupBoxAccountingDate
            // 
            this.groupBoxAccountingDate.Controls.Add(this.panel3);
            this.groupBoxAccountingDate.Controls.Add(this.radioButtonAccountingDatePeriod);
            this.groupBoxAccountingDate.Controls.Add(this.radioButtonAccountingDateCurrentMonth);
            this.groupBoxAccountingDate.Controls.Add(this.radioButtonAccountingDateCurrentDay);
            this.groupBoxAccountingDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAccountingDate.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAccountingDate.Name = "groupBoxAccountingDate";
            this.groupBoxAccountingDate.Size = new System.Drawing.Size(285, 126);
            this.groupBoxAccountingDate.TabIndex = 1;
            this.groupBoxAccountingDate.TabStop = false;
            this.groupBoxAccountingDate.Text = "会计日期";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.numericUpDownEndDateDay);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.numericUpDownEndDateMonth);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.numericUpDownEndDateYear);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.numericUpDownStartDateDay);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.numericUpDownStartDateMonth);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.numericUpDownStartDateYear);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(21, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 56);
            this.panel3.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "日";
            // 
            // numericUpDownEndDateDay
            // 
            this.numericUpDownEndDateDay.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.classAccountingPeriodInformationPropertiesBindingSourceEnd, "日份", true));
            this.numericUpDownEndDateDay.Location = new System.Drawing.Point(188, 30);
            this.numericUpDownEndDateDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownEndDateDay.Minimum = new decimal(new int[] {
            31,
            0,
            0,
            -2147483648});
            this.numericUpDownEndDateDay.Name = "numericUpDownEndDateDay";
            this.numericUpDownEndDateDay.Size = new System.Drawing.Size(51, 21);
            this.numericUpDownEndDateDay.TabIndex = 12;
            this.numericUpDownEndDateDay.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownEndDateDay.ValueChanged += new System.EventHandler(this.numericUpDownEndDateDay_ValueChanged);
            this.numericUpDownEndDateDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            this.numericUpDownEndDateDay.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // classAccountingPeriodInformationPropertiesBindingSourceEnd
            // 
            this.classAccountingPeriodInformationPropertiesBindingSourceEnd.DataSource = typeof(ClassLibraryAccountingPeriodInformation.ClassAccountingPeriodInformationProperties);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "月";
            // 
            // numericUpDownEndDateMonth
            // 
            this.numericUpDownEndDateMonth.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.classAccountingPeriodInformationPropertiesBindingSourceEnd, "月份", true));
            this.numericUpDownEndDateMonth.Location = new System.Drawing.Point(114, 30);
            this.numericUpDownEndDateMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownEndDateMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEndDateMonth.Name = "numericUpDownEndDateMonth";
            this.numericUpDownEndDateMonth.Size = new System.Drawing.Size(51, 21);
            this.numericUpDownEndDateMonth.TabIndex = 10;
            this.numericUpDownEndDateMonth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownEndDateMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            this.numericUpDownEndDateMonth.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "年";
            // 
            // numericUpDownEndDateYear
            // 
            this.numericUpDownEndDateYear.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.classAccountingPeriodInformationPropertiesBindingSourceEnd, "年份", true));
            this.numericUpDownEndDateYear.Location = new System.Drawing.Point(40, 30);
            this.numericUpDownEndDateYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownEndDateYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownEndDateYear.Name = "numericUpDownEndDateYear";
            this.numericUpDownEndDateYear.Size = new System.Drawing.Size(51, 21);
            this.numericUpDownEndDateYear.TabIndex = 8;
            this.numericUpDownEndDateYear.Value = new decimal(new int[] {
            2009,
            0,
            0,
            0});
            this.numericUpDownEndDateYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            this.numericUpDownEndDateYear.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "截止：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "日";
            // 
            // numericUpDownStartDateDay
            // 
            this.numericUpDownStartDateDay.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.classAccountingPeriodInformationPropertiesBindingSourceStart, "日份", true));
            this.numericUpDownStartDateDay.Location = new System.Drawing.Point(188, 3);
            this.numericUpDownStartDateDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownStartDateDay.Minimum = new decimal(new int[] {
            31,
            0,
            0,
            -2147483648});
            this.numericUpDownStartDateDay.Name = "numericUpDownStartDateDay";
            this.numericUpDownStartDateDay.Size = new System.Drawing.Size(51, 21);
            this.numericUpDownStartDateDay.TabIndex = 5;
            this.numericUpDownStartDateDay.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownStartDateDay.ValueChanged += new System.EventHandler(this.numericUpDownStartDateDay_ValueChanged);
            this.numericUpDownStartDateDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            this.numericUpDownStartDateDay.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // classAccountingPeriodInformationPropertiesBindingSourceStart
            // 
            this.classAccountingPeriodInformationPropertiesBindingSourceStart.DataSource = typeof(ClassLibraryAccountingPeriodInformation.ClassAccountingPeriodInformationProperties);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "月";
            // 
            // numericUpDownStartDateMonth
            // 
            this.numericUpDownStartDateMonth.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.classAccountingPeriodInformationPropertiesBindingSourceStart, "月份", true));
            this.numericUpDownStartDateMonth.Location = new System.Drawing.Point(114, 3);
            this.numericUpDownStartDateMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownStartDateMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStartDateMonth.Name = "numericUpDownStartDateMonth";
            this.numericUpDownStartDateMonth.Size = new System.Drawing.Size(51, 21);
            this.numericUpDownStartDateMonth.TabIndex = 3;
            this.numericUpDownStartDateMonth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownStartDateMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            this.numericUpDownStartDateMonth.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "年";
            // 
            // numericUpDownStartDateYear
            // 
            this.numericUpDownStartDateYear.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.classAccountingPeriodInformationPropertiesBindingSourceStart, "年份", true));
            this.numericUpDownStartDateYear.Location = new System.Drawing.Point(40, 3);
            this.numericUpDownStartDateYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownStartDateYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownStartDateYear.Name = "numericUpDownStartDateYear";
            this.numericUpDownStartDateYear.Size = new System.Drawing.Size(51, 21);
            this.numericUpDownStartDateYear.TabIndex = 1;
            this.numericUpDownStartDateYear.Value = new decimal(new int[] {
            2009,
            0,
            0,
            0});
            this.numericUpDownStartDateYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.control_KeyPress);
            this.numericUpDownStartDateYear.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "起始：";
            // 
            // radioButtonAccountingDatePeriod
            // 
            this.radioButtonAccountingDatePeriod.AutoSize = true;
            this.radioButtonAccountingDatePeriod.Location = new System.Drawing.Point(7, 42);
            this.radioButtonAccountingDatePeriod.Name = "radioButtonAccountingDatePeriod";
            this.radioButtonAccountingDatePeriod.Size = new System.Drawing.Size(47, 16);
            this.radioButtonAccountingDatePeriod.TabIndex = 2;
            this.radioButtonAccountingDatePeriod.Text = "期间";
            this.radioButtonAccountingDatePeriod.UseVisualStyleBackColor = true;
            this.radioButtonAccountingDatePeriod.CheckedChanged += new System.EventHandler(this.radioButtonAccountingDatePeriod_CheckedChanged);
            // 
            // radioButtonAccountingDateCurrentMonth
            // 
            this.radioButtonAccountingDateCurrentMonth.AutoSize = true;
            this.radioButtonAccountingDateCurrentMonth.Location = new System.Drawing.Point(124, 20);
            this.radioButtonAccountingDateCurrentMonth.Name = "radioButtonAccountingDateCurrentMonth";
            this.radioButtonAccountingDateCurrentMonth.Size = new System.Drawing.Size(71, 16);
            this.radioButtonAccountingDateCurrentMonth.TabIndex = 1;
            this.radioButtonAccountingDateCurrentMonth.Text = "本会计月";
            this.radioButtonAccountingDateCurrentMonth.UseVisualStyleBackColor = true;
            this.radioButtonAccountingDateCurrentMonth.CheckedChanged += new System.EventHandler(this.DatePeriodType_Changed);
            // 
            // radioButtonAccountingDateCurrentDay
            // 
            this.radioButtonAccountingDateCurrentDay.AutoSize = true;
            this.radioButtonAccountingDateCurrentDay.Checked = true;
            this.radioButtonAccountingDateCurrentDay.Location = new System.Drawing.Point(7, 20);
            this.radioButtonAccountingDateCurrentDay.Name = "radioButtonAccountingDateCurrentDay";
            this.radioButtonAccountingDateCurrentDay.Size = new System.Drawing.Size(71, 16);
            this.radioButtonAccountingDateCurrentDay.TabIndex = 0;
            this.radioButtonAccountingDateCurrentDay.TabStop = true;
            this.radioButtonAccountingDateCurrentDay.Text = "本会计日";
            this.radioButtonAccountingDateCurrentDay.UseVisualStyleBackColor = true;
            this.radioButtonAccountingDateCurrentDay.CheckedChanged += new System.EventHandler(this.DatePeriodType_Changed);
            // 
            // DateSelectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "DateSelectControl";
            this.Size = new System.Drawing.Size(297, 201);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBoxNaturalDate.ResumeLayout(false);
            this.groupBoxNaturalDate.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classNaturalDatePeriodBindingSource)).EndInit();
            this.groupBoxAccountingDate.ResumeLayout(false);
            this.groupBoxAccountingDate.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndDateDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classAccountingPeriodInformationPropertiesBindingSourceEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndDateMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndDateYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartDateDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classAccountingPeriodInformationPropertiesBindingSourceStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartDateMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartDateYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonUseNaturalDate;
        private System.Windows.Forms.RadioButton radioButtonUseAccountingDate;
        private System.Windows.Forms.GroupBox groupBoxAccountingDate;
        private System.Windows.Forms.RadioButton radioButtonAccountingDatePeriod;
        private System.Windows.Forms.RadioButton radioButtonAccountingDateCurrentMonth;
        private System.Windows.Forms.RadioButton radioButtonAccountingDateCurrentDay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownStartDateYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownEndDateDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownEndDateMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownEndDateYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownStartDateDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownStartDateMonth;
        private System.Windows.Forms.GroupBox groupBoxNaturalDate;
        private System.Windows.Forms.Panel panel4;
        private CustomTextBox.DateTimeTextBox dateTimeTextBoxStart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton radioButtonNaturalDatePeriod;
        private System.Windows.Forms.RadioButton radioButtonNaturalDateMonth;
        private System.Windows.Forms.RadioButton radioButtonNaturalDateDay;
        private CustomTextBox.DateTimeTextBox dateTimeTextBoxEnd;
        private System.Windows.Forms.BindingSource classAccountingPeriodInformationPropertiesBindingSourceStart;
        private System.Windows.Forms.BindingSource classAccountingPeriodInformationPropertiesBindingSourceEnd;
        private System.Windows.Forms.BindingSource classNaturalDatePeriodBindingSource;
    }
}
