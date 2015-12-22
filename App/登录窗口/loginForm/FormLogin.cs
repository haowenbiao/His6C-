using System;
using System.Windows.Forms;
using ClassLibraryAuthoritySet;
using ClassLibraryLoginInformation;
using CustomForm;

namespace loginForm
{
    public partial class FormLogin : FormCustomAuthoritied
    {
        public FormLogin(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation, 0)
        {
            InitializeComponent();
            workerSelectorComboBoxWithDataGridView1.ConnectionSqlString = valLoginInformation.ConnectionString;
        }

        protected FormLogin()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ClassLoginInformation tmplLoginInformation = new ClassLoginInformation(LoginInformation.ConnectionString, workerSelectorComboBoxWithDataGridView1.ID);
            if (ClassAuthoritySetPublic.VerifyPassWord(tmplLoginInformation, textBox登录密码.Text))
            {
                raiseEventOfLoginSucceed(tmplLoginInformation);
                Close();
            }
            else
            {
                MessageBox.Show(@"密码不正确，请重新输入！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region 自定义事件

        public event EventHandler<EventArgsOfLoginSucceed> LoginSucceed;

        protected void raiseEventOfLoginSucceed(ClassLoginInformation vallLoginInformation)
        {
            eventArgsOfLoginSucceed = new EventArgsOfLoginSucceed
            {
                LoginInformation = vallLoginInformation,
            };
            setEventArgsOfLoginSucceed();
            OnLoginSucceed(eventArgsOfLoginSucceed);
        }

        internal virtual void setEventArgsOfLoginSucceed()
        {

        }

        public void OnLoginSucceed(EventArgsOfLoginSucceed e)
        {
            EventHandler<EventArgsOfLoginSucceed> handler = LoginSucceed;
            if (handler != null) handler(this, e);
        }
        
        internal EventArgsOfLoginSucceed eventArgsOfLoginSucceed { get; set; }

        #endregion

        internal void control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }

    public class EventArgsOfLoginSucceed : EventArgs
    {
        public ClassLoginInformation LoginInformation { get; set; }
    }


}
