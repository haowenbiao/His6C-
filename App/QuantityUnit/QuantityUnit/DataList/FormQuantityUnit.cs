using System;
using System.Data;
using System.Windows.Forms;
using ClassLibraryAbstractDataInformation;
using ClassLibraryLoginInformation;
using ClassLibraryQuantityUnit;
using QuantityUnit.DataOperate;

namespace QuantityUnit.DataList
{
    public sealed partial class FormQuantityUnit : FormDataListUseDataGridViewBaseFromAbstract
    {
        public FormQuantityUnit(ClassLoginInformation valLoginInformation)
            : this(valLoginInformation, false)
        {
        }

        public FormQuantityUnit(ClassLoginInformation valLoginInformation, bool valCanInvokeDataListItemSelectedEvent)
            : base(valLoginInformation, valCanInvokeDataListItemSelectedEvent)
        {
            InitializeComponent();

            AddItemOfcontextMenuStripTocontextMenuStripOnListControl(contextMenuStripTmp);
        }

        protected override void ListControlDoubleClick()
        {
            Edit();
        }

        private void Add()
        {
            FormQuantityUnitAdd f = new FormQuantityUnitAdd(LoginInformation);
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
                FormQuantityUnitEdit f = new FormQuantityUnitEdit(LoginInformation, tmpID);
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
                if (MessageBox.Show(@"是否删除“" + drv["名称"] + @"”的信息？", @"提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
                long tmpID = (long)drv["ID"];

                ClassDataRemover<ClassQuantityUnitProperties> classDataRemover = new ClassDataRemover<ClassQuantityUnitProperties>(LoginInformation, tmpID, 53);
                classDataRemover.ExecuteSucceed += this_ExecuteSucceed;
                classDataRemover.ExecuteError += this_ExecuteError;
                if (classDataRemover.execute())
                {
                    MessageBox.Show(@"删除成功！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
