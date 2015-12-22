using System;
using System.ComponentModel;
using System.Windows.Forms;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;


namespace CustomForm
{
    [Obsolete("The Class is time out!")]
    public partial class FormCustomBase : Form
    {
        public event ExecuteSucceedHandler ExecuteSucceed;
        public event ExecuteErrorHandler ExecuteError;

        private bool m_ShowHelpText = true;

        #region 构造器

        /// <summary>
        /// 默认构造器
        /// </summary>
        public FormCustomBase()
        {
            InitializeComponent();
            CanShow = true;
        }


        /// <summary>
        /// 有权限的操作员和超级用户可以登录，如果AuthorityID小于等于0，则任何操作员都不可登录。
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valAuthorityID"></param>
        public FormCustomBase(ClassLoginInformation valLoginInformation, long valAuthorityID)
            : this()
        {
            LoginInformation = valLoginInformation;
            AuthorityID = valAuthorityID;
            ////超级用户可以登录
            //if (LoginInformation.OperaterID == 1) return;
            ////如果是超级权限，则只有超级用户可以登录
            //bool tmpIsSuperAuthority = ClassAuthoritySetPublic.GetIsSuperAuhority(LoginInformation.ConnectionString,
            //                                                                      AuthorityID);
            //if (tmpIsSuperAuthority && LoginInformation.OperaterID != 1)
            //{
            //    CanShow = false;
            //    OnError(new EventArgsOfExecuteError("", "注意：只有超级用户才能进行此操作！"));
            //    Width = 0;
            //    Height = 0;
            //    return;
            //}
            ////没有权限的操作员不可登录
            //if (valAuthorityID <= 0 || !ClassAuthoritySetPublic.VerifyAuthority(LoginInformation, valAuthorityID))
            //{
            //    CanShow = false;
            //    OnError(new EventArgsOfExecuteError("", "注意：当前用户没有进行此操作的权限！"));
            //    Width = 0;
            //    Height = 0;
            //}
        }

        /// <summary>
        /// 任何操作员都可登录
        /// </summary>
        /// <param name="valLoginInformation"></param>
        public FormCustomBase(ClassLoginInformation valLoginInformation)
            : this()
        {
            LoginInformation = valLoginInformation;
        }

        #endregion

        #region 权限

        //操作员登录信息
        protected ClassLoginInformation LoginInformation { get; set; }
        //权限ID
        protected long AuthorityID { get; set; }
        //该窗体能否显示
        protected bool CanShow { get; set; }

        protected override void OnShown(EventArgs e)
        {
            if (!CanShow)
            {
                Close();
                return;
            }
            base.OnShown(e);
        }

        #endregion

        #region 帮助栏

        ///// <summary>
        ///// 设置帮助栏的帮助信息
        ///// </summary>
        ///// <param name="valHelpText"></param>
        //protected internal void setHelpText(object valHelpText)
        //{
        //    if (InvokeRequired)
        //    {
        //        callBackOneParameterHandle c = setHelpText;
        //        Invoke(c, new[] { valHelpText });
        //    }
        //    else
        //    {
        //        HelpText = valHelpText as string;
        //    }
        //}

        #region 自定义属性

        [Description("显示在窗体上部的帮助文字"), DefaultValue(""), Category("杂项"), Browsable(true)]
        public string HelpText
        {
            get
            {
                return labelHelpText.Text;
            }
            set
            {
                labelHelpText.Text = value;
                labelHelpText.Refresh();
            }
        }

        [Description("显示帮助栏"), DefaultValue(true), Category("杂项"), Browsable(true)]
        public bool ShowHelpText
        {
            get
            {
                return m_ShowHelpText;
            }
            set
            {
                m_ShowHelpText = value;
                panel1.Visible = m_ShowHelpText;
            }
        }

        #endregion

        #endregion

        #region 公共方法

        //protected internal void SetControlEnabled(object valControl, object valBool)
        //{

        //    if (((Control)valControl).InvokeRequired)
        //    {
        //        callBackTowParameterHandle c = SetControlEnabled;
        //        Invoke(c, new[] { valControl, valBool });
        //    }
        //    else
        //    {
        //        ((Control)valControl).Enabled = (bool)valBool;
        //    }
        //}

        ///// <summary>
        ///// 设置控件为焦点控件
        ///// </summary>
        ///// <param name="sender"></param>
        //protected internal void SetControlFocus(object sender)
        //{
        //    Control tmpControl = sender as Control;
        //    if (tmpControl != null)
        //        if (tmpControl.InvokeRequired)
        //        {
        //            callBackOneParameterHandle c = SetControlFocus;
        //            Invoke(c, new[] { sender });
        //        }
        //        else
        //        {
        //            tmpControl.Focus();
        //        }
        //}

        #endregion

        #region 自定义公共事件

        protected void this_Error(object sender, EventArgsOfExecuteError e)
        {
            OnError(e);
        }

        protected void this_ExecuteSucceed(object sender, EventArgsOfExecuteSucceed e)
        {
            OnExecuteSucceed(e);
        }

        protected virtual void OnError(EventArgsOfExecuteError e)
        {
            MessageBox.Show(e.CustomErrorMessage + "\n" + e.SystemErrorMessage, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            CanShow=false;
            ExecuteErrorHandler Error1 = ExecuteError;
            if (Error1 != null) Error1(this, e);
        }

        protected virtual void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            ExecuteSucceedHandler ExecuteSucceed1 = ExecuteSucceed;
            if (ExecuteSucceed1 != null) ExecuteSucceed1(this, e);
        }

        #endregion
    }
}
