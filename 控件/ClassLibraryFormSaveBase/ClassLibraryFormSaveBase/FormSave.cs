using System;
using System.ComponentModel;
using System.Windows.Forms;
using ClassLibraryAbstractDataInformation;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;
using ClassLibraryPYM;

namespace ClassLibraryFormSaveBase
{
    public partial class FormSave : FormSaveBase
    {
        #region 构造器

        /// <summary>
        /// 默认构造器
        /// </summary>
        public FormSave()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 有权限的操作员和超级用户可以登录，如果AuthorityID小于等于0，则任何操作员都不可登录。
        /// </summary>
        /// <param name="valLoginInformation">登录信息</param>
        /// <param name="valAuthorityId">需要的权限ID</param>
        public FormSave(ClassLoginInformation valLoginInformation, long valAuthorityId)
            : base(valLoginInformation, valAuthorityId)
        {
            InitializeComponent();
        }

        /// <summary>
        /// 任何操作员都可登录
        /// </summary>
        /// <param name="valLoginInformation">登录信息</param>
        public FormSave(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation)
        {
            InitializeComponent();
        }

        #endregion

        /// <summary>
        /// 必须覆写，覆写时，简单写"buttonOK=valEnabled"，目的是为了不用记忆这么长的方法名称，设置当前窗体的ButtonOK按钮的Enable状态。
        /// </summary>
        /// <param name="valEnabled"></param>
        protected virtual void SetButtonOKEnableAttribute(bool valEnabled)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 不用覆写，简单调用基方法即可，回车移动焦点到下一控件。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        /// <summary>
        /// 不用覆写，简单调用基方法即可，回车移动焦点到下一控件。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void control_KeyUp(object sender,KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        #region 数据验证

        // 不用覆写，简单调用基方法即可，验证后，自动生成拼音码
        protected virtual void textBox名称_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t == null)
            {
                return;
            }
            TextBox textBox拼音码 = t.Tag as TextBox;
            if (textBox拼音码 == null)
            {
                return;
            }
            if (string.IsNullOrEmpty(textBox拼音码.Text))
                textBox拼音码.Text = PYM.transpy(t.Text);
        }

        // 不用覆写，简单调用基方法即可，验证非空输入框。
        protected virtual void NoneNullabletextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t != null) t.Text = t.Text.Replace(" ", "");

            if (t != null)
            {
                if (string.IsNullOrEmpty(t.Text))
                {
                    SetTextBoxError(sender, "此项不能为空！");
                }
                else
                {
                    SetTextBoxError(sender, "");
                }
            }
        }

        // 当输入框验证出错时，设置errorProvider。
        protected void SetTextBoxError(object sender, string valErrorMessage)
        {
            if (sender != null) errorProvider1.SetError(sender as Control, valErrorMessage);
        }

        #endregion

        //#region 数据绑定

        //protected ClassAbstractData Data { get; set; }

        //protected virtual void BindingData()
        //{

        //}

        //protected void ReBinding()
        //{
        //    BindingManagerBase bmb = BindingContext[Data];
        //    bmb.ResumeBinding();
        //}

        //#endregion

        /// <summary>
        /// 当在更改窗体中，加载错误时的委托方法。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void OnLoadError(object sender, EventArgsOfExecuteError e)
        {
            SetButtonOKEnableAttribute(false);
            MessageBox.Show(e.CustomErrorMessage + "\n" + e.SystemErrorMessage, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            CanShow = false;
        }
    }
}