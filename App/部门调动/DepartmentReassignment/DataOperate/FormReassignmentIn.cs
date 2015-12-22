using System;
using System.Windows.Forms;
using ClassLibraryAbstractDataInformation;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;
using ClassLibraryWorkerInformations;
using ClassLibraryDepartmentReassignment;

namespace DepartmentReassignment.DataOperate
{
    public partial class FormReassignmentIn : CustomForm.FormCustomAuthoritied
    {
        private readonly long m_ID;

        /// <summary>
        /// 超级用户才可登录
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valID"></param>
        public FormReassignmentIn(ClassLoginInformation valLoginInformation, long valID)
            : base(valLoginInformation, 83)
        {
            InitializeComponent();
            m_ID = valID;

            ClassWorkerProperties tmpClassWorkerProperties = ClassDepartmentReassignmentPublic.LoadWorkerInformation(LoginInformation, valID);
            if (tmpClassWorkerProperties != null)
            {
                linkLabel1.Text = tmpClassWorkerProperties.姓名;
            }

            listBoxDepartmentsOfWorkerIn.DataSource = ClassDepartmentReassignmentPublic.LoadDepartmentsOfWorkerIn(LoginInformation.ConnectionString, valID);
            listBoxDepartmentsOfWorkerIn.DisplayMember = "部门名称";

            comboBoxDepartmentsOfWorkerNotIn.DataSource = ClassDepartmentReassignmentPublic.LoadDepartmentsOfWorkerNotIn(LoginInformation.ConnectionString, valID);
            comboBoxDepartmentsOfWorkerNotIn.ValueMember = "ID";
            comboBoxDepartmentsOfWorkerNotIn.DisplayMember = "部门名称";
        }

        private long ID
        {
            get
            {
                return m_ID;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.IndexOf(tabControl1.SelectedTab) == 1)
            {
                long tmpDepartmentID = (long)comboBoxDepartmentsOfWorkerNotIn.SelectedValue;
                ClassDepartMentReassingmentIn departMentReassingmentInData=new ClassDepartMentReassingmentIn
                                                                               {
                                                                                   P_职工信息_ID = ID,
                                                                                   P_部门信息_ID = tmpDepartmentID,
                                                                                   备注 = textBox备注.Text.Trim()
                                                                               };
                ClassDataEditer dataEditer = new ClassDataEditer(LoginInformation, departMentReassingmentInData, 83);
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

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.IndexOf(tabControl1.SelectedTab) > 0)
            {
                tabControl1.SelectTab(tabControl1.TabPages.IndexOf(tabControl1.SelectedTab) - 1);
            }
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
            if (comboBoxDepartmentsOfWorkerNotIn.Items.Count == 0 && e.TabPageIndex == 1)
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

        protected override void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            listBox1.DataSource = ClassDepartmentReassignmentPublic.LoadDepartmentsOfWorkerIn(LoginInformation.ConnectionString, ID);
            listBox1.DisplayMember = "部门名称";
            MessageBox.Show(@"调入成功！", @"部门调入");
            base.OnExecuteSucceed(e);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormWorkerInformationView tmpFormWorkerInformationView = new FormWorkerInformationView(LoginInformation, ID);
            tmpFormWorkerInformationView.ShowDialog();
        }

    }
}