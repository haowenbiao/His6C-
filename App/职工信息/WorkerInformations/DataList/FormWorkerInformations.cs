using System;
using System.Data;
using System.Windows.Forms;
using ClassLibraryAbstractDataInformation;
using ClassLibraryLoginInformation;
using ClassLibraryWorkerInformations;
using DepartmentReassignment.DataList;
using DepartmentReassignment.DataOperate;
using WorkerInformations.DataOperate;

namespace WorkerInformations.DataList
{
    public partial class FormWorkerInformations : FormDataListUseFpSpreadBaseFromAbstract
    {
        public FormWorkerInformations(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation)
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
            FormWorkerInformationAdd f = new FormWorkerInformationAdd(LoginInformation);
            f.ExecuteSucceed += this_ExecuteSucceed;
            f.Show(this);
            f.ExecuteSucceed -= this_ExecuteSucceed;
        }

        private void Edit()
        {
            if (Bmb.Position < 0) return;
            DataRowView drv = Bmb.Current as DataRowView;
            if (drv != null)
            {
                long tmpID = (long)drv["ID"];
                FormWorkerInformationEdit f = new FormWorkerInformationEdit(LoginInformation, tmpID);
                f.ExecuteSucceed += this_ExecuteSucceed;
                f.Show(this);
                f.ExecuteSucceed -= this_ExecuteSucceed;
            }
        }

        private void Remove()
        {
            if (Bmb.Position < 0) return;
            DataRowView drv = Bmb.Current as DataRowView;
            if (drv != null)
            {
                if (MessageBox.Show(@"是否删除“" + drv["姓名"] + @"”的信息？", @"提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                long tmpID = (long)drv["ID"];

                ClassDataRemover<ClassWorkerProperties> classDataRemover = new ClassDataRemover<ClassWorkerProperties>(LoginInformation, tmpID, 78);
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

        private void ShowWokerInformation()
        {
            if (Bmb.Position < 0) return;
            DataRowView drv = Bmb.Current as DataRowView;
            if (drv != null)
            {
                long tmpID = (long)drv["ID"];

                FormWorkerInformationView formWorkerInformationView = new FormWorkerInformationView(LoginInformation, tmpID);
                formWorkerInformationView.Show(this);
            }
        }

        private void ReassignIn()
        {
            DataRowView drv = Bmb.Current as DataRowView;
            if (drv != null)
            {
                long tmpID = (long)drv["ID"];
                FormReassignmentIn f = new FormReassignmentIn(LoginInformation, tmpID);
                f.ExecuteSucceed += this_ExecuteSucceed;
                f.Show(this);
            }
        }

        private void ReassignOut()
        {
            DataRowView drv = Bmb.Current as DataRowView;
            if (drv != null)
            {
                long tmpID = (long)drv["ID"];
                FormReassignmentOut f = new FormReassignmentOut(LoginInformation, tmpID);
                f.ExecuteSucceed += this_ExecuteSucceed;
                f.Show(this);
            }
        }

        private void ReassignRecords()
        {
            FormReassignmentRecords f = new FormReassignmentRecords(LoginInformation);
            f.ExecuteSucceed += this_ExecuteSucceed;
            f.Show(this);
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

        private void toolStripMenuItemReassignIn_Click(object sender, EventArgs e)
        {
            ReassignIn();
        }

        private void toolStripMenuItemReassignOut_Click(object sender, EventArgs e)
        {
            ReassignOut();
        }

        private void toolStripMenuItemReassignRecords_Click(object sender, EventArgs e)
        {
            ReassignRecords();
        }

        private void toolStripMenuItemWokerInformation_Click(object sender, EventArgs e)
        {
            ShowWokerInformation();
        }

    }
}
