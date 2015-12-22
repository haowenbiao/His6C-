using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClassLibraryAccountingPeriodInformation;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;
using MedicineStock.DataOperate;

namespace MedicineStock.DataList
{
    public partial class FormMedicineStockRecords : FormDataListUseUseFpSpreadFromAbstract
    {
        public FormMedicineStockRecords(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation)
        {
            InitializeComponent();

            #region 定义工具栏

            AddItemOfToolStripToToolStripSpecial(toolStripTmp);
            //AddItemOfcontextMenuStripTocontextMenuStripOnListControl(contextMenuStripTmp);

            #endregion

            AdvanceSearch = true;
            AdvanceSearchSqlString = InitAdvanceSearchSqlString();
            LoadDataThread();
        }

        #region 高级查询

        //是否高级查询。
        private bool AdvanceSearch { get; set; }

        private string AdvanceSearchSqlString { get; set; }

        //初始化高级查询
        private string InitAdvanceSearchSqlString()
        {
            //(107)SELECT ID,进货单编号,药库名称,总金额,进货时间,进货会计期,供货单位,备注,操作员 FROM dbo.YKGL_进货记录表_View WHERE P_会计期_ID = {0}
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 107);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return null;
            }
            long tmpCurrentAccountPeriod =
                ClassLibraryAccountingPeriodPublic.GetCurrentAccountingPeriod(LoginInformation.ConnectionString);

            string tmpSQLString = string.Format(tmpSQLString1, tmpCurrentAccountPeriod);
            return tmpSQLString;
        }

        #endregion

        protected override string LoadSqlString
        {
            get
            {
                if (AdvanceSearch)
                {
                    return AdvanceSearchSqlString;
                }

                //(103)SELECT ID,进货单编号,药库名称,总金额,进货时间,进货会计期,供货单位,备注,操作员 FROM dbo.YKGL_进货记录表_View WHERE 进货单编号 = '{0}'
                string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 103);
                if (string.IsNullOrEmpty(tmpSQLString1))
                {
                    return null;
                }
                string tmpSQLString = string.Format(tmpSQLString1,toolStripTextBoxStockNumber.Text.Trim());
                return tmpSQLString;
            }
        }

        private void toolStripButtonAdvancedSearch_Click(object sender, EventArgs e)
        {
            FormAdvancedSearch f = new FormAdvancedSearch(LoginInformation);
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 97);
                if (string.IsNullOrEmpty(tmpSQLString1))
                {
                    return;
                }
                AdvanceSearch = true;
                AdvanceSearchSqlString = tmpSQLString1 + " " + f.SearchSqlString;
                LoadDataThread();
            }
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            AdvanceSearch = false;
            LoadDataThread();
        }

        private void toolStripTextBoxStockNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(toolStripTextBoxStockNumber.Text))
            {
                toolStripTextBoxStockNumber.ForeColor = Color.FromKnownColor(KnownColor.GrayText);
                toolStripTextBoxStockNumber.Text = @"请输入进货单编号";
            }
        }

        private void toolStripTextBoxStockNumber_Enter(object sender, EventArgs e)
        {
            if (toolStripTextBoxStockNumber.Text == @"请输入进货单编号")
            {
                toolStripTextBoxStockNumber.Text = "";
                toolStripTextBoxStockNumber.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
            }
        }

        private void toolStripButtonStock_Click(object sender, EventArgs e)
        {
            FormStockAdd f = new FormStockAdd(LoginInformation);
            f.ExecuteSucceed += this_ExecuteSucceed;
            f.ShowDialog(this);
            f.ExecuteSucceed += this_ExecuteSucceed;
        }

        private void toolStripButtonStockDetail_Click(object sender, EventArgs e)
        {
            ViewStockInformation();
        }

        protected override void ListControlDoubleClick()
        {
            ViewStockInformation();
            base.ListControlDoubleClick();
        }

        private void ViewStockInformation()
        {
            if (Bmb.Position < 0) return;
            DataRowView drv = Bmb.Current as DataRowView;
            if (drv != null)
            {
                long tmpID = (long)drv["ID"];
                FormStockInformation f = new FormStockInformation(LoginInformation, tmpID);
                f.ShowDialog(this);
            }
        }

        /// <summary>
        /// 入库审核
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonVerifyAndWareHousing_Click(object sender, EventArgs e)
        {
            if (Bmb.Position < 0) return;
            DataRowView drv = Bmb.Current as DataRowView;
            if (drv != null)
            {
                long tmpID = (long)drv["ID"];
                FormStockVerifyAndWareHousing stockVerifyAndWareHousing = new FormStockVerifyAndWareHousing(LoginInformation, tmpID);
                stockVerifyAndWareHousing.ExecuteSucceed += this_ExecuteSucceed;
                stockVerifyAndWareHousing.ShowDialog(this);
                stockVerifyAndWareHousing.ExecuteSucceed += this_ExecuteSucceed;
                //stockVerifyAndWareHousing.ExecuteSucceed -= this_ExecuteSucceed;
            }
        }
    }
}
