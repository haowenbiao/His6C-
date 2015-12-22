using System.Windows.Forms;
using System.Data;
using ClassLibraryAbstractDataInformation;
using ClassLibraryDepartmentReassignment;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;
using ClassLibraryWorkerInformations;

namespace DepartmentReassignment.DataOperate
{
    public partial class FormReassignmentOut : CustomForm.FormCustomAuthoritied
    {
        private readonly long m_ID;

        public FormReassignmentOut(ClassLoginInformation valLoginInformation, long valID)
            : base(valLoginInformation, 83)
        {
            //if (!CanShow) return;
            InitializeComponent();
            m_ID = valID;


            ClassWorkerProperties tmpClassWorkerProperties = ClassDepartmentReassignmentPublic.LoadWorkerInformation(LoginInformation, valID);
            if (tmpClassWorkerProperties != null)
            {
                linkLabel1.Text = tmpClassWorkerProperties.姓名;
            }

            listBoxDepartmentsOfWorkerIn.DataSource = ClassDepartmentReassignmentPublic.LoadDepartmentsOfWorkerIn(LoginInformation.ConnectionString, valID);
            listBoxDepartmentsOfWorkerIn.DisplayMember = "部门名称";

            checkedListBoxDepartmentsOfWorkerIn.DataSource = ClassDepartmentReassignmentPublic.LoadDepartmentsOfWorkerIn(LoginInformation.ConnectionString, valID);
            checkedListBoxDepartmentsOfWorkerIn.ValueMember = "ID";
            checkedListBoxDepartmentsOfWorkerIn.DisplayMember = "部门名称";
        }

        private long ID
        {
            get
            {
                return m_ID;
            }
        }

        private void buttonClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void buttonNext_Click(object sender, System.EventArgs e)
        {
            if (tabControl1.TabPages.IndexOf(tabControl1.SelectedTab) == 1)
            {
                ClassDepartMentReassingmentOut departMentReassingmentOutData = new ClassDepartMentReassingmentOut
                                                                                   {备注 = textBox备注.Text.Trim()};
                for (int n = 0; n < checkedListBoxDepartmentsOfWorkerIn.CheckedItems.Count; n++)
                {
                    ClassDepartMentReassingmentInRecord reassingmentInRecord = new ClassDepartMentReassingmentInRecord
                                                                                 {
                                                                                     P_职工岗位调动记录_调入_ID =
                                                                                         (long)
                                                                                         ((DataRowView)
                                                                                          checkedListBoxDepartmentsOfWorkerIn
                                                                                              .CheckedItems[n])[0]
                                                                                 };
                    departMentReassingmentOutData.DepartmentReassingmentInRecords.Add(reassingmentInRecord);
                }
                ClassDataEditer dataEditer = new ClassDataEditer(LoginInformation, departMentReassingmentOutData, 83);
                dataEditer.ExecuteError += this_ExecuteError;
                dataEditer.ExecuteSucceed += this_ExecuteSucceed;
                dataEditer.execute();
                dataEditer.ExecuteError -= this_ExecuteError;
                dataEditer.ExecuteSucceed -= this_ExecuteSucceed;
            }

            if (tabControl1.TabPages.IndexOf(tabControl1.SelectedTab) < tabControl1.TabPages.Count - 1)
            {
                tabControl1.SelectTab(tabControl1.TabPages.IndexOf(tabControl1.SelectedTab) + 1);
            }
        }

        private void buttonPrevious_Click(object sender, System.EventArgs e)
        {
            if (tabControl1.TabPages.IndexOf(tabControl1.SelectedTab) > 0)
            {
                tabControl1.SelectTab(tabControl1.TabPages.IndexOf(tabControl1.SelectedTab) - 1);
            }
        }

        protected override void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            listBox1.DataSource = ClassDepartmentReassignmentPublic.LoadDepartmentsOfWorkerIn(LoginInformation.ConnectionString, ID);
            listBox1.DisplayMember = "部门名称";
            MessageBox.Show(@"调出成功！", @"部门调出");
           
            base.OnExecuteSucceed(e);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormWorkerInformationView tmpFormWorkerInformationView = new FormWorkerInformationView(LoginInformation, ID);
            tmpFormWorkerInformationView.ShowDialog();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 0 || e.TabPageIndex == 2)
            {
                buttonPrevious.Enabled = false;
            }
            if (e.TabPageIndex == 1)
            {
                buttonPrevious.Enabled = true;
                buttonNext.Enabled = true;
            }

            #region 如果可以调入的部门为零，则下一步按钮不可用。
            if (checkedListBoxDepartmentsOfWorkerIn.CheckedItems.Count == 0 && e.TabPageIndex == 1)
            {
                buttonNext.Enabled = false;
            }
            else
            {
                buttonNext.Enabled = true;
            }
            #endregion

            if (e.TabPageIndex == 2)
            {
                buttonNext.Enabled = false;
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                buttonNext.Enabled = true;
            }
            else
            {
                buttonNext.Enabled = ((CheckedListBox)sender).CheckedItems.Count - 1 > 0;
            }
        }
    }
}