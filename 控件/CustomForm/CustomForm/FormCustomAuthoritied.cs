using System;
using System.Windows.Forms;
using ClassLibraryAbstractDataInformation;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;

namespace CustomForm
{
    public partial class FormCustomAuthoritied : FormCustomAutoSized
    {

        #region 构造器

        /// <summary>
        /// 默认构造器
        /// </summary>
        protected FormCustomAuthoritied()
        {
            InitializeComponent();
            CanShow = true;
        }
        
        /// <summary>
        /// 有权限的操作员和超级用户可以登录，如果AuthorityID小于等于0，则任何操作员都可登录。
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valAuthorityID"></param>
        protected FormCustomAuthoritied(ClassLoginInformation valLoginInformation, long valAuthorityID)
            : this()
        {
            LoginInformation = valLoginInformation;
            AuthorityID = valAuthorityID;
            
            ////如果AuthorityID小于等于0，则任何操作员都可登录。
            //if (valAuthorityID <= 0)
            //{
            //    return;
            //}
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
            //if (!ClassAuthoritySetPublic.VerifyAuthority(LoginInformation, valAuthorityID))
            //{
            //    CanShow = false;
            //    OnError(new EventArgsOfExecuteError("当前操作员需要“" + ClassAuthoritySetPublic.GetAuthorityName(LoginInformation, valAuthorityID)+"”的权限！", "注意：当前用户没有进行此操作的权限！"));
            //    Width = 0;
            //    Height = 0;
            //}
        }

        /// <summary>
        /// 任何操作员都可登录
        /// </summary>
        /// <param name="valLoginInformation"></param>
        protected FormCustomAuthoritied(ClassLoginInformation valLoginInformation)
            : this(valLoginInformation,0)
        {
            LoginInformation = valLoginInformation;
        }

        #endregion

        protected override void OnLoad(EventArgs e)
        {
            if (!DesignMode)
            {
                CanShow = AuthorityVerify();
            }
            base.OnLoad(e);
        }

        #region 数据

        protected ClassAbstractData Data { get; set; }

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

        /// <summary>
        /// 验证权限
        /// </summary>
        /// <returns></returns>
        protected bool AuthorityVerify()
        {
            ClassAuthorityVerification AuthorityVerification = new ClassAuthorityVerification(LoginInformation, AuthorityID, Data);

            bool tmpSucceed = AuthorityVerification.VerifyAuthority();

            return tmpSucceed;
        }

        #endregion

        #region 自定义公共事件

        public event ExecuteSucceedHandler ExecuteSucceed;
        public event ExecuteErrorHandler ExecuteError;

        protected void this_ExecuteError(object sender, EventArgsOfExecuteError e)
        {
            OnExecuteError(e);
        }

        protected void this_ExecuteSucceed(object sender, EventArgsOfExecuteSucceed e)
        {
            OnExecuteSucceed(e);
        }

        protected virtual void OnExecuteError(EventArgsOfExecuteError e)
        {
            MessageBox.Show(e.CustomErrorMessage + "\n" + e.SystemErrorMessage, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
