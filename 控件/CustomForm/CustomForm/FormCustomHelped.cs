using System.ComponentModel;
using System.Windows.Forms;
using ClassLibraryLoginInformation;

namespace CustomForm
{
    public partial class FormCustomHelped : Form
    {
        #region 构造器

        protected FormCustomHelped()
        {
            InitializeComponent();
        }

        #endregion

        [Description("显示在窗体上部的帮助文字"), DefaultValue(""), Category("杂项"), Browsable(true)]
        public string HelpText
        {
            get { return labelHelpText.Text; }
            set { labelHelpText.Text = value; }
        }

        private bool m_ShowHelp = true;
        [Description("是否显示在窗体上部的帮助文字"), DefaultValue(true), Category("杂项"), Browsable(true)]
        public bool ShowHelp
        {
            get
            {
                return m_ShowHelp;
            }
            set
            {
                m_ShowHelp = value;
                panelHelp.Visible = value;
            }
        }

        private delegate void SetHelpTextHandler(string valHelpText);
        /// <summary>
        /// 设置帮助栏的帮助信息
        /// </summary>
        /// <param name="valHelpText">帮助信息</param>
        protected void SetHelpText(string valHelpText)
        {
            if (InvokeRequired)
            {
                SetHelpTextHandler c = SetHelpText;
                Invoke(c, new[] { valHelpText });
            }
            else
            {
                HelpText = valHelpText;
            }
        }

        #region 公共方法

        private delegate void SetControlEnabledHandler(object valControl, object valBool);
        /// <summary>
        /// 设置控件的Enable状态。
        /// </summary>
        /// <param name="valControl"></param>
        /// <param name="valBool"></param>
        protected internal void SetControlEnabled(object valControl, object valBool)
        {
            try
            {
                if (((Control)valControl).InvokeRequired)
                {
                    SetControlEnabledHandler c = SetControlEnabled;
                    Invoke(c, new[] { valControl, valBool });
                }
                else
                {
                    ((Control)valControl).Enabled = (bool)valBool;
                }
            }
            catch
            {
                return;
            }

        }

        private delegate void SetControlFocusedHandler(object sender);
        /// <summary>
        /// 设置控件为焦点控件
        /// </summary>
        /// <param name="sender"></param>
        protected internal void SetControlFocused(object sender)
        {
            try
            {
                Control tmpControl = sender as Control;
                if (tmpControl != null)
                    if (tmpControl.InvokeRequired)
                    {
                        SetControlFocusedHandler c = SetControlFocused;
                        Invoke(c, new[] { sender });
                    }
                    else
                    {
                        tmpControl.Focus();
                    }
            }
            catch
            {
                return;
            }
        }

        #endregion
    }
}
