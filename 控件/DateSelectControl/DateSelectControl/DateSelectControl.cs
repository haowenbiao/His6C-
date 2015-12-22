using System;
using System.ComponentModel;
using System.Windows.Forms;
using ClassLibraryAccountingPeriodInformation;
using ClassLibraryPublicEnum;

namespace DateSelectControl
{

    public partial class DateSelectControl : UserControl
    {
        public DateSelectControl()
        {
            InitializeComponent();

            #region 初始化属性
            ClassNaturalDatePeriod tmpNaturalDatePeriod=new ClassNaturalDatePeriod();
            classNaturalDatePeriodBindingSource.DataSource = tmpNaturalDatePeriod;
            DatePeriodSelectType = EnumDatePeriodSelectType.本会计日;
            #endregion
        }

        #region 属性

        private string _ConnectionString;
        /// <summary>
        /// 连接至数据库的连接字符串。
        /// </summary>
        public string ConnectionString
        {
            get
            {
                return _ConnectionString;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _ConnectionString = value;
                    LoadCurrentAccountingPeriod(_ConnectionString);
                }
            }
        }

        [Description("日期期间选择类型"), Browsable(false)]
        public EnumDatePeriodSelectType DatePeriodSelectType { get; set; }

        private ClassAccountingPeriodInformationProperties _CurrentAccountingPeriod;
        [Description("当前会计期"), Browsable(false)]
        public ClassAccountingPeriodInformationProperties CurrentAccountingPeriod
        {
            get
            {
                return _CurrentAccountingPeriod;
            }
        }
        
        [Description("开始会计期"), Browsable(false)]
        public ClassAccountingPeriodInformationProperties AccountPeriodStart
        {
            get
            {
                return
                    classAccountingPeriodInformationPropertiesBindingSourceStart.DataSource as
                    ClassAccountingPeriodInformationProperties;
            }
        }
        
        [Description("截止会计期"), Browsable(false)]
        public ClassAccountingPeriodInformationProperties AccountPeriodEnd
        {
            get
            {
                return
                    classAccountingPeriodInformationPropertiesBindingSourceEnd.DataSource as
                    ClassAccountingPeriodInformationProperties;
            }
        }
        
        [Description("自然日期期间"), Browsable(false)]
        public ClassNaturalDatePeriod NaturalPeriod
        {
            get
            {
                return classNaturalDatePeriodBindingSource.DataSource as ClassNaturalDatePeriod;
            }
        }

        #endregion

        #region 控件事件

        private void LoadCurrentAccountingPeriod(string valConnectionString)
        {
            long tmpCurrentAccountingPeriodID = ClassLibraryAccountingPeriodPublic.GetCurrentAccountingPeriod(valConnectionString);
            _CurrentAccountingPeriod = new ClassAccountingPeriodInformationProperties { ID = tmpCurrentAccountingPeriodID };
            _CurrentAccountingPeriod.Load(valConnectionString);
            
            ClassAccountingPeriodInformationProperties AccountingPeriodInformationPropertiesStart =
                new ClassAccountingPeriodInformationProperties
                {
                        ID = tmpCurrentAccountingPeriodID,
                        年份 = _CurrentAccountingPeriod.年份,
                        月份 = _CurrentAccountingPeriod.月份,
                        日份 = _CurrentAccountingPeriod.日份
                    };
            classAccountingPeriodInformationPropertiesBindingSourceStart.DataSource =
                AccountingPeriodInformationPropertiesStart;
            numericUpDownStartDateDayPreviousValue = AccountingPeriodInformationPropertiesStart.日份;

            ClassAccountingPeriodInformationProperties AccountingPeriodInformationPropertiesEnd =
                new ClassAccountingPeriodInformationProperties
                    {
                        ID = tmpCurrentAccountingPeriodID,
                        年份 = _CurrentAccountingPeriod.年份,
                        月份 = _CurrentAccountingPeriod.月份,
                        日份 = _CurrentAccountingPeriod.日份
                    };
            classAccountingPeriodInformationPropertiesBindingSourceEnd.DataSource =
                AccountingPeriodInformationPropertiesEnd;
            numericUpDownEndDateDayPreviousValue = AccountingPeriodInformationPropertiesEnd.日份;
        }

        private void DateType_Changed(object sender, EventArgs e)
        {
            DatePeriodType_Changed(sender, e);
            groupBoxAccountingDate.Visible = radioButtonUseAccountingDate.Checked;
            groupBoxNaturalDate.Visible = !radioButtonUseAccountingDate.Checked;
        }

        private void DatePeriodType_Changed(object sender, EventArgs e)
        {
            if (radioButtonUseAccountingDate.Checked)
            {
                if (radioButtonAccountingDateCurrentDay.Checked)
                {
                    DatePeriodSelectType = EnumDatePeriodSelectType.本会计日;
                }
                if (radioButtonAccountingDateCurrentMonth.Checked)
                {
                    DatePeriodSelectType = EnumDatePeriodSelectType.本会计月;
                }
                if (radioButtonAccountingDatePeriod.Checked)
                {
                    DatePeriodSelectType = EnumDatePeriodSelectType.会计期间;
                }
            }
            else
            {
                if (radioButtonNaturalDateDay.Checked)
                {
                    DatePeriodSelectType = EnumDatePeriodSelectType.本自然日;
                }
                if (radioButtonNaturalDateMonth.Checked)
                {
                    DatePeriodSelectType = EnumDatePeriodSelectType.本自然月;
                }
                if (radioButtonNaturalDatePeriod.Checked)
                {
                    DatePeriodSelectType = EnumDatePeriodSelectType.自然期间;
                }
            }
        }

        private void radioButtonAccountingDatePeriod_CheckedChanged(object sender, EventArgs e)
        {

            panel3.Enabled = radioButtonAccountingDatePeriod.Checked;
        }

        private void radioButtonNaturalDatePeriod_CheckedChanged(object sender, EventArgs e)
        {

            panel4.Enabled = radioButtonNaturalDatePeriod.Checked;
        }

        protected void control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void numericUpDown_Enter(object sender, EventArgs e)
        {
            NumericUpDown tmpNumericUpDown = sender as NumericUpDown;
            if (tmpNumericUpDown != null) tmpNumericUpDown.Select(0, tmpNumericUpDown.Text.Length);
        }

        #endregion

        //记录前一个会计日
        private long numericUpDownStartDateDayPreviousValue = 31;
        private void numericUpDownStartDateDay_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownStartDateDayPreviousValue <= 0 && numericUpDownStartDateDay.Value == 0)
            {
                numericUpDownStartDateDay.Value = 1;
            }

            if (numericUpDownStartDateDayPreviousValue >= 0 && numericUpDownStartDateDay.Value == 0)
            {
                numericUpDownStartDateDay.Value = -1;
            }
            numericUpDownStartDateDayPreviousValue = (long)numericUpDownStartDateDay.Value;
        }

        //记录前一个会计日
        private long numericUpDownEndDateDayPreviousValue = 31;
        private void numericUpDownEndDateDay_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownEndDateDayPreviousValue <= 0 && numericUpDownEndDateDay.Value == 0)
            {
                numericUpDownEndDateDay.Value = 1;
            }

            if (numericUpDownEndDateDayPreviousValue >= 0 && numericUpDownEndDateDay.Value == 0)
            {
                numericUpDownEndDateDay.Value = -1;
            }
            numericUpDownEndDateDayPreviousValue = (long)numericUpDownEndDateDay.Value;
        }
    }

    public class ClassNaturalDatePeriod
    {
        public ClassNaturalDatePeriod()
        {
            Start = DateTime.Today;
            End = DateTime.Today;
        }
        #region 属性

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        #endregion
    }
}
