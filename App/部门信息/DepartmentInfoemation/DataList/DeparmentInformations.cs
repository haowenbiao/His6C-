using System;
using System.Data;
using System.Windows.Forms;
using ClassLibraryAbstractDataInformation;
using ClassLibraryDepartmentInformation;
using ClassLibraryLoginInformation;
using DepartmentInformation.DataOperate;

namespace DepartmentInformation.DataList
{
    public partial class DeparmentInformations : FormDataListUseFpSpreadBaseFromAbstract
    {
        public DeparmentInformations()
        {
            InitializeComponent();
        }

        public DeparmentInformations(ClassLoginInformation valLoginInformation):base(valLoginInformation)
        {
            InitializeComponent();

            #region 定义工具栏

            AddItemOfToolStripToToolStripSpecial(toolStripTmp);
            AddItemOfcontextMenuStripTocontextMenuStripOnListControl(contextMenuStripTmp);

            #endregion
        }

        protected override void ListControlDoubleClick()
        {
            Edit();
            base.ListControlDoubleClick();
        }

        private void Add()
        {
            FormDepartmentInformationAdd f = new FormDepartmentInformationAdd(LoginInformation);
            f.ExecuteSucceed += this_ExecuteSucceed;
            f.ShowDialog(this);
            f.ExecuteSucceed -= this_ExecuteSucceed;
        }

        private void Edit()
        {
            DataRowView drv = Bmb.Current as DataRowView;
            if (drv != null)
            {
                long tmpID = (long) drv["ID"];
                FormDepartmentInformationEdit f = new FormDepartmentInformationEdit(LoginInformation, tmpID);
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
                if (MessageBox.Show(@"是否删除“" + drv["部门名称"] + @"”的信息？", @"提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
                long tmpID = (long)drv["ID"];
                ClassDataRemover<ClassDepartmentProperties> classDataRemover = new ClassDataRemover<ClassDepartmentProperties>(LoginInformation, tmpID, 75);
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

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }

    }
}