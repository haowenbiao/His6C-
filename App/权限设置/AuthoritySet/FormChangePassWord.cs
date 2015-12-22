using System;
using System.Windows.Forms;
using ClassLibraryAuthoritySet;
using ClassLibraryEventArgs;
using ClassLibraryLoginInformation;

namespace AuthoritySet
{
    public partial class FormChangePassWord : CustomForm.FormCustomBase
    {
        private readonly long m_WorkerID;

        public FormChangePassWord(ClassLoginInformation valLoginInformation, long valWorkerID)
        {
            InitializeComponent();
            LoginInformation = valLoginInformation;
            m_WorkerID = valWorkerID;
            ClassLoginInformation tmpLoginInformation = new ClassLoginInformation(valLoginInformation.ConnectionString,
                                                                                  valWorkerID);
            Text += string.Format("-{0}", ClassAuthoritySetPublic.GetWorkerName(tmpLoginInformation));
        }

        private long WorkerID
        {
            get { return m_WorkerID; }
        }

        private void textBoxPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxConfirmPassWord.Text !=textBoxNewPassWord.Text)
            {
                OnError(this, new EventArgsOfError(null, "新密码和确认密码不一致，请重新输入！"));
                return;
            }
            ClassLoginInformation tmpLoginInformation = new ClassLoginInformation(LoginInformation.ConnectionString,
                                                                                  WorkerID);
            ClassAuthoritySetChangePassWord tmpClassAuthoritySetChangePassWord =
                new ClassAuthoritySetChangePassWord(tmpLoginInformation, textBoxOriginalPassWord.Text,
                                                    textBoxNewPassWord.Text);
            tmpClassAuthoritySetChangePassWord.ExecuteSucceed += OnChangeSucceed;
            tmpClassAuthoritySetChangePassWord.Error += OnError;
            tmpClassAuthoritySetChangePassWord.Change();
        }

        private void OnChangeSucceed(object sender,EventArgsOfExecuteSucceed e)
        {
            MessageBox.Show(@"密码更改成功！", @"更改密码", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void OnError(object sender,EventArgsOfError e)
        {
            MessageBox.Show(e.CustomErrorMessage, @"更改密码", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxOriginalPassWord.Focus();
        }

        private void textBoxPassWord_Enter(object sender, EventArgs e)
        {
            ((TextBox) sender).SelectAll();
        }

    }
}
