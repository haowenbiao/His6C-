using System;
using System.Data;
using System.Windows.Forms;
using ClassLibraryAbstractDataInformation;
using ClassLibraryCostItemUnit;
using ClassLibraryLoginInformation;
using CostItemUnit.DataOperate;

namespace CostItemUnit.DataList
{
    public partial class FormCostItemUnit : FormDataListUseDataGridViewBaseFromAbstract
    {
        #region 构造器

        public FormCostItemUnit(ClassLoginInformation valLoginInformation)
            : this(valLoginInformation, false)
        {
            InitializeComponent();
        }

        public FormCostItemUnit(ClassLoginInformation valLoginInformation, bool valCanInvokeDataListItemSelectedEvent)
            : base(valLoginInformation, valCanInvokeDataListItemSelectedEvent)
        {
            InitializeComponent();
            AddItemOfcontextMenuStripTocontextMenuStripOnListControl(contextMenuStripTmp);
        }

        #endregion

        protected override void ListControlDoubleClick()
        {
            Edit();
        }

        private void Add()
        {
            FormCostItemUnitAdd f = new FormCostItemUnitAdd(LoginInformation);
            f.ExecuteSucceed += this_ExecuteSucceed;
            f.Show(this);
        }

        private void Edit()
        {
            if (Bmb.Position < 0) return;
            DataRowView drv = Bmb.Current as DataRowView;
            if (drv != null)
            {
                long tmpID = (long)drv["ID"];
                FormCostItemUnitEdit f = new FormCostItemUnitEdit(LoginInformation, tmpID);
                f.ExecuteSucceed += this_ExecuteSucceed;
                f.Show(this);
            }
        }

        private void Remove()
        {
            if (Bmb.Position < 0) return;
            DataRowView drv = Bmb.Current as DataRowView;
            if (drv != null)
            {
                if (MessageBox.Show(@"是否删除“" + drv["单位名称"] + @"”的信息？", @"提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                long tmpID = (long)drv["ID"];

                ClassDataRemover<ClassCostItemUnitProperties> classDataRemover = new ClassDataRemover<ClassCostItemUnitProperties>(LoginInformation, tmpID, 63);
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

        protected override void buttonAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        protected override void buttonEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        protected override void buttonRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }
    }
}
