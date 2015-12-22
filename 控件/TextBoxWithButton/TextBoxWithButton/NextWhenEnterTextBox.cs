using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CustomTextBox
{
    public partial class NextWhenEnterTextBox : TextBox
    {
        public event OnErrorHandle Error;
        
        public NextWhenEnterTextBox()
        {
            InitializeComponent();
        }

        [Description("出错时显示的错误消息"), Category("正则"), Browsable(true)]
        public string errorMessage { get; set; }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
            base.OnKeyPress(e);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            SelectAll();
            base.OnGotFocus(e);
        }

        public virtual void OnError(object sender,string errorString)
        {
            if (Error!=null)
            {
                Error(sender, errorString);
            }
        }
    }
}
