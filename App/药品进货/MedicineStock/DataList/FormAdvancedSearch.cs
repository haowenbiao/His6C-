using System;
using System.ComponentModel;
using System.Windows.Forms;
using ClassLibraryAccountingPeriodInformation;
using ClassLibraryLoginInformation;
using ClassLibraryPublicEnum;
using CustomForm;
using DateSelectControl;

namespace MedicineStock.DataList
{
    internal partial class FormAdvancedSearch : FormCustomAuthoritied
    {
        public FormAdvancedSearch(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation, 0)
        {
            InitializeComponent();

            #region 初始化属性

            dateSelectControl1.ConnectionString = valLoginInformation.ConnectionString;
            medicineStoreHouseSelector1.ConnectionSqlString = valLoginInformation.ConnectionString;
            supplierSelectorComboBoxWithDataGridView1.ConnectionSqlString = valLoginInformation.ConnectionString;

            #endregion
        }

        protected override void OnLoad(EventArgs e)
        {
            HelpText = "当前会计期为" + CurrentAccountingPeriod.会计期String;
            base.OnLoad(e);
        }

        #region 属性

        public long MedicineStoreHouseID
        {
            get
            {
                long TmpId;
                try
                {
                    TmpId = (long)medicineStoreHouseSelector1.SelectedValue;
                }
                catch
                {
                    return 0L;
                }
                return TmpId;
            }
        }

        public long SupplierID
        {
            get
            {
                long TmpId;
                try
                {
                    TmpId = (long)supplierSelectorComboBoxWithDataGridView1.SelectedValue;
                }
                catch
                {
                    return 0L;
                }
                return TmpId;
            }
        }

        [Description("日期期间选择类型"), Browsable(false)]
        public EnumDatePeriodSelectType DatePeriodSelectType
        {
            get
            {
                return dateSelectControl1.DatePeriodSelectType;
            }
        }

        [Description("当前会计期"), Browsable(false)]
        public ClassAccountingPeriodInformationProperties CurrentAccountingPeriod
        {
            get
            {
                return dateSelectControl1.CurrentAccountingPeriod;
            }
        }

        [Description("开始会计期"), Browsable(false)]
        public ClassAccountingPeriodInformationProperties AccountPeriodStart
        {
            get
            {
                return dateSelectControl1.AccountPeriodStart;
            }
        }

        [Description("截止会计期"), Browsable(false)]
        public ClassAccountingPeriodInformationProperties AccountPeriodEnd
        {
            get
            {
                return dateSelectControl1.AccountPeriodEnd;
            }
        }

        [Description("自然日期期间"), Browsable(false)]
        public ClassNaturalDatePeriod NaturalPeriod
        {
            get
            {
                return dateSelectControl1.NaturalPeriod;
            }
        }

        public string SearchSqlString
        {
            get
            {
                string tmpSqlString = "WHERE";

                string tmpSqlStringYKGL_药库信息 = "";
                if (MedicineStoreHouseID != 0)
                {
                    tmpSqlStringYKGL_药库信息 = string.Format("(YKGL_药库信息_ID = {0})", MedicineStoreHouseID);
                }
                string tmpSqlStringYKGL_供货单位信息 = "";
                if (SupplierID != 0)
                {
                    tmpSqlStringYKGL_供货单位信息 = string.Format("(YKGL_供货单位信息_ID = {0})", SupplierID);
                }
                string tmpSqlStringDate = "";
                switch (DatePeriodSelectType)
                {
                    case EnumDatePeriodSelectType.本会计日:
                        tmpSqlStringDate = string.Format("(会计期 = {0})", CurrentAccountingPeriod.会计期);
                        break;
                    case EnumDatePeriodSelectType.本会计月:
                        ClassAccountingPeriodInformationProperties tmpAccountingPeriodStart =
                            new ClassAccountingPeriodInformationProperties
                            {
                                ID = CurrentAccountingPeriod.ID,
                                年份 = CurrentAccountingPeriod.年份,
                                月份 = CurrentAccountingPeriod.月份,
                                日份 = -1
                            };
                        ClassAccountingPeriodInformationProperties tmpAccountingPeriodEnd =
                            new ClassAccountingPeriodInformationProperties
                                {
                                    ID = CurrentAccountingPeriod.ID,
                                    年份 = CurrentAccountingPeriod.年份,
                                    月份 = CurrentAccountingPeriod.月份,
                                    日份 = 31
                                };
                        tmpSqlStringDate = string.Format("(会计期 BETWEEN {0} AND {1})",
                                                            tmpAccountingPeriodStart.会计期,
                                                            tmpAccountingPeriodEnd.会计期);
                        break;
                    case EnumDatePeriodSelectType.会计期间:
                        tmpSqlStringDate = string.Format("(会计期 BETWEEN {0} AND {1})",
                                                            AccountPeriodStart.会计期,
                                                            AccountPeriodEnd.会计期);
                        break;
                    case EnumDatePeriodSelectType.本自然日:
                        DateTime tmpDateTimeDayStart = DateTime.Today;
                        DateTime tmpDateTimeDayEnd = tmpDateTimeDayStart.AddDays(1);

                        tmpSqlStringDate = string.Format("(进货时间 >= '{0}' AND 进货时间 < '{1}')",
                                                         tmpDateTimeDayStart.ToShortDateString(),
                                                         tmpDateTimeDayEnd.ToShortDateString());
                        break;
                    case EnumDatePeriodSelectType.本自然月:
                        DateTime tmpDateTimeMonthStart = DateTime.Now.AddDays(-(DateTime.Now.Day - 1));
                        DateTime tmpDateTimeMonthEnd = tmpDateTimeMonthStart.AddMonths(1);
                        tmpSqlStringDate = string.Format("(进货时间 >= '{0}' AND 进货时间 < '{1}')",
                                                         tmpDateTimeMonthStart.ToShortDateString(),
                                                         tmpDateTimeMonthEnd.ToShortDateString());
                        break;
                    case EnumDatePeriodSelectType.自然期间:
                        tmpSqlStringDate = string.Format("(进货时间 >= '{0}' AND 进货时间 < '{1}')",
                                                         NaturalPeriod.Start.ToShortDateString(),
                                                         NaturalPeriod.End.AddDays(1).ToShortDateString());
                        break;
                }
                tmpSqlString += " " + tmpSqlStringDate;
                if (MedicineStoreHouseID != 0)
                {
                    tmpSqlString += " AND " + tmpSqlStringYKGL_药库信息;
                }
                if (SupplierID != 0)
                {
                    tmpSqlString += " AND " + tmpSqlStringYKGL_供货单位信息;
                }
                tmpSqlString += " ORDER BY ID";
                return tmpSqlString;
            }
        }

        #endregion

        private void control_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

    }
}
