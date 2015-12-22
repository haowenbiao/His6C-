using System;
using System.Data;
using System.Windows.Forms;
using ClassLibraryAbstractDataInformation;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;
using ClassLibraryMedicineKind;
using ClassLibraryPublicEnum;
using MedicineKindAdjustPrice.DataList;
using MedicineKindAdjustPrice.DataOperate;
using MedicineKinds.DataOperate;

namespace MedicineKinds.DataList
{
    public partial class FormMedicineKinds : FormDataListUseFpSpreadBaseAbstract
    {
        public FormMedicineKinds(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation)
        {
            InitializeComponent();

            #region 定义工具栏

            AddItemOfToolStripToToolStripSpecial(toolStripTmp);
            AddItemOfcontextMenuStripTocontextMenuStripOnListControl(contextMenuStripTmp);

            #endregion

            LoadDataThread();
        }

        protected override string LoadSqlString
        {
            get
            {
                //return "SELECT ID,SQLString,所在模块,备注 FROM dbo.P_SQLString";
                //return base.LoadSqlString;
                string tmpSQLString;
                if (string.IsNullOrEmpty(SearchKeys))
                {
                    //(36)SELECT * FROM dbo.YKGL_药品种类表_View
                    string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 36);
                    if (string.IsNullOrEmpty(tmpSQLString1))
                    {
                        return null;
                    }
                    tmpSQLString = tmpSQLString1;
                }
                else
                {
                    //(37)SELECT * FROM dbo.YKGL_药品种类表_View WHERE 通用名称 LIKE '{0}%' OR 通用名称_拼音码 LIKE '{0}%' OR 商品名称 LIKE '{0}%' OR 商品名称_拼音码 LIKE '{0}%'
                    string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 37);
                    if (string.IsNullOrEmpty(tmpSQLString1))
                    {
                        return null;
                    }
                    tmpSQLString = string.Format(tmpSQLString1, SearchKeys);
                }
                return tmpSQLString;
            }
        }

        protected override void ListControlDoubleClick()
        {
            Edit();
            base.ListControlDoubleClick();
        }

        #region 药品种类信息

        private void Add()
        {
            FormMedicineKindAdd f = new FormMedicineKindAdd(LoginInformation);
            f.ExecuteSucceed += this_ExecuteSucceed;
            f.ShowDialog(this);
            f.ExecuteSucceed -= this_ExecuteSucceed;
        }

        private void Edit()
        {
            if (Bmb.Position < 0) return;
            DataRowView drv = Bmb.Current as DataRowView;
            if (drv != null)
            {
                long tmpID = (long)drv["ID"];
                FormMedicineKindEdit f = new FormMedicineKindEdit(LoginInformation, tmpID);
                f.ExecuteSucceed += this_ExecuteSucceed;
                f.ShowDialog(this);
                f.ExecuteSucceed -= this_ExecuteSucceed;
            }
        }

        private void Remove()
        {
            if (Bmb.Position < 0) return;
            DataRowView drv = Bmb.Current as DataRowView;
            if (drv != null)
            {
                if (MessageBox.Show(string.Format("是否删除商品名称为“{0}”的信息？", drv["商品名称"]), @"提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
                long tmpID = (long)drv["ID"];

                ClassDataRemover<ClassMedicineKindProperties> classDataRemover = new ClassDataRemover<ClassMedicineKindProperties>(LoginInformation, tmpID, 26);
                classDataRemover.ExecuteSucceed += MedicineStateChange_ExecuteSucceed;
                classDataRemover.ExecuteError += this_ExecuteError;
                classDataRemover.execute();
                classDataRemover.ExecuteSucceed -= MedicineStateChange_ExecuteSucceed;
                classDataRemover.ExecuteError -= this_ExecuteError;
            }
        }

        private void toolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void toolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void toolStripMenuItemRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }

        #endregion

        #region 数据查询

        private string _SearchKeys;

        private string SearchKeys
        {
            get
            {
                return _SearchKeys;
            }
        }

        private void toolStripTextBoxSearchKeys_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoadDataThread();
            }
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            LoadDataThread();
        }

        private void toolStripTextBoxSearchKeys_TextChanged(object sender, EventArgs e)
        {
            _SearchKeys = toolStripTextBoxSearchKeys.Text.Trim();
        }

        #endregion

        #region 改变进货和销售状态

        //暂停进货
        private void toolStripMenuItemStopStock_Click(object sender, EventArgs e)
        {
            ChangeMedicineKindsState(EnumeMedicineKindStateType.进货状态, EnumeMedicineKindState.暂停);
        }

        //恢复进货
        private void toolStripMenuItemRecoverStock_Click(object sender, EventArgs e)
        {
            ChangeMedicineKindsState(EnumeMedicineKindStateType.进货状态, EnumeMedicineKindState.正常);
        }

        //暂停销售
        private void toolStripMenuItemStopSale_Click(object sender, EventArgs e)
        {
            ChangeMedicineKindsState(EnumeMedicineKindStateType.销售状态, EnumeMedicineKindState.暂停);
        }

        //恢复销售
        private void toolStripMenuItemRecoverSale_Click(object sender, EventArgs e)
        {
            ChangeMedicineKindsState(EnumeMedicineKindStateType.销售状态, EnumeMedicineKindState.正常);
        }

        private void MedicineStateChange_ExecuteSucceed(object sender, EventArgsOfExecuteSucceed e)
        {
            MessageBox.Show(@"操作成功！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataThread();
        }

        //protected void MedicineStateChange_ExecuteError(object sender,EventArgsOfError e)
        //{
        //    MessageBox.Show(e.CustomErrorMessage + Environment.NewLine + e.SystemErrorMessage, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}

        private void ChangeMedicineKindsState(EnumeMedicineKindStateType valStateType, EnumeMedicineKindState valState)
        {
            if (LoginInformation.OperaterID != 1)
            {
                MessageBox.Show(@"只有超级用户才可以进行此操作！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            long tmpID = GetCurrentID();
            if (tmpID != 0)
            {
                string tmpString = string.Format("是否改变商品名称为“{0}”的{1}为“{2}”", ((DataRowView) Bmb.Current)["商品名称"],
                                                 valStateType, valState);
                if (MessageBox.Show(tmpString, @"提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                ClassMedicineKindStateChange medicineKindStateChange = new ClassMedicineKindStateChange
                                                                           {
                                                                               ID = tmpID,
                                                                               药品状态类型 = valStateType,
                                                                               药品状态 = valState
                                                                           };
                ClassDataEditer dataEditer = new ClassDataEditer(LoginInformation, medicineKindStateChange, 91);
                dataEditer.ExecuteSucceed += MedicineStateChange_ExecuteSucceed;
                dataEditer.ExecuteError += this_ExecuteError;
                dataEditer.execute();
                dataEditer.ExecuteError -= this_ExecuteError;
                dataEditer.ExecuteSucceed -= MedicineStateChange_ExecuteSucceed;
            }
        }

        #endregion

        #region 药品调价

        private void AdjustPrice()
        {
            long tmpID = GetCurrentID();
            if (tmpID == 0) return;
            FormMedicineKindAdjustPriceEdit f = new FormMedicineKindAdjustPriceEdit(LoginInformation, tmpID);
            f.ExecuteSucceed += this_ExecuteSucceed;
            f.ShowDialog(this);
        }

        private void AdjustPriceRecords()
        {
            long tmpID = GetCurrentID();
            if (tmpID == 0) return;
            FormMedicineKindAdjustPriceRecords f = new FormMedicineKindAdjustPriceRecords(LoginInformation, tmpID);
            f.ShowDialog(this);
        }

        private void toolStripMenuItemAjustPrice_Click(object sender, EventArgs e)
        {
            AdjustPrice();
        }

        private void toolStripMenuItemAjustPriceRecord_Click(object sender, EventArgs e)
        {
            AdjustPriceRecords();
        }

        #endregion

    }
}