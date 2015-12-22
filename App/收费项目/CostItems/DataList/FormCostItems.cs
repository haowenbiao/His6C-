using System;
using System.Data;
using System.Windows.Forms;
using ClassLibraryAbstractDataInformation;
using ClassLibraryCostItems;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;
using CostItemAdjustPrice.DataList;
using CostItemAdjustPrice.DataOperate;
using CostItems.DataOperate;

namespace CostItems.DataList
{
    public partial class FormCostItems : FormDataListUseUseFpSpreadFromAbstract
    {
        public FormCostItems(ClassLoginInformation valLoginInformation)
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
                string tmpSQLString;
                if (string.IsNullOrEmpty(SearchKeys))
                {
                    //(59)SELECT * FROM dbo.P_收费项目表_View
                    string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 59);
                    if (string.IsNullOrEmpty(tmpSQLString1))
                    {
                        return null;
                    }
                    tmpSQLString = tmpSQLString1;
                }
                else
                {
                    //(56)SELECT * FROM dbo.P_收费项目表_View WHERE 单位名称 LIKE '{0}%' OR 拼音码 LIKE '{0}%'
                    string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 56);
                    if (string.IsNullOrEmpty(tmpSQLString1))
                    {
                        return null;
                    }
                    tmpSQLString = string.Format(tmpSQLString1, SearchKeys);
                }
                return tmpSQLString;
            }
        }

        private string _SearchKeys;

        private string SearchKeys
        {
            get
            {
                return _SearchKeys;
            }
        }

        private void toolStripTextBoxSearchKeys_TextChanged(object sender, EventArgs e)
        {
            _SearchKeys = toolStripTextBoxSearchKeys.Text.Trim();
        }

        protected override void ListControlDoubleClick()
        {
            Edit();
            base.ListControlDoubleClick();
        }

        private void Add()
        {
            FormCostItemAdd f = new FormCostItemAdd(LoginInformation);
            f.ExecuteSucceed += this_ExecuteSucceed;
            f.ShowDialog(this);
        }

        private void Edit()
        {
            long tmpID = GetCurrentID();
            if (tmpID == 0) return;
            FormCostItemEdit f = new FormCostItemEdit(LoginInformation, tmpID);
            f.ExecuteSucceed += this_ExecuteSucceed;
            f.ShowDialog(this);
        }

        private void Remove()
        {
            if (Bmb.Position < 0) return;
            DataRowView drv = Bmb.Current as DataRowView;
            if (drv != null)
            {
                if (MessageBox.Show(string.Format("是否删除收费项目为“{0}”的信息？", drv["收费项目"]), @"提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
                long tmpID = (long)drv["ID"];

                ClassDataRemover<ClassCostItemProperties> classDataRemover = new ClassDataRemover<ClassCostItemProperties>(LoginInformation, tmpID, 58);
                classDataRemover.ExecuteSucceed += this_ExecuteSucceed;
                classDataRemover.ExecuteError += this_ExecuteError;
                if (classDataRemover.execute())
                {
                    MessageBox.Show(@"删除成功！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                classDataRemover.ExecuteSucceed -= this_ExecuteSucceed;
                classDataRemover.ExecuteError -= this_ExecuteError;
            }
        }

        private void AdjustPrice()
        {
            long tmpID = GetCurrentID();
            if (tmpID == 0) return;
            FormCostItemAdjustPriceEdit f = new FormCostItemAdjustPriceEdit(LoginInformation, tmpID);
            f.ExecuteSucceed += this_ExecuteSucceed;
            f.ShowDialog(this);
        }

        private void AdjustPriceRecords()
        {
            long tmpID = GetCurrentID();
            if (tmpID == 0) return;
            FormCostItemAdjustPrice f = new FormCostItemAdjustPrice(LoginInformation, tmpID);
            f.ShowDialog(this);
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

        private void toolStripButtonAdjustPrice_Click(object sender, EventArgs e)
        {
            AdjustPrice();
        }

        private void toolStripButtonAdjustPriceRecords_Click(object sender, EventArgs e)
        {
            AdjustPriceRecords();
        }

    }
}
