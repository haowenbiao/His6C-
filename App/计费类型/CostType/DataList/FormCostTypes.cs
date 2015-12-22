using System;
using System.Data;
using System.Windows.Forms;
using ClassLibraryAbstractDataInformation;
using ClassLibraryCostType;
using ClassLibraryLoginInformation;
using CostType.DataOperate;

namespace CostType.DataList
{
    public partial class FormCostTypes : FormDataListUseDataGridViewBaseFromAbstract
    {
        #region 构造器

        public FormCostTypes(ClassLoginInformation valLoginInformation)
            : this(valLoginInformation, false)
        {
            
        }

        public FormCostTypes(ClassLoginInformation valLoginInformation, bool valCanInvokeDataListItemSelectedEvent)
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
            FormCostTypeAdd f = new FormCostTypeAdd(LoginInformation);
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
                FormCostTypeEdit f = new FormCostTypeEdit(LoginInformation, tmpID);
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
                if (MessageBox.Show(@"是否删除“" + drv["计费类型"] + @"”的信息？", @"提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
                long tmpID = (long)drv["ID"];

                ClassDataRemover<ClassCostTypeProperties> classDataRemover = new ClassDataRemover<ClassCostTypeProperties>(LoginInformation, tmpID, 70);
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
