using System.ComponentModel;
using System.Text.RegularExpressions;

namespace CustomTextBox
{
    public delegate void OnErrorHandle(object sender, string errorString);

    public partial class RegexTextBox : NextWhenEnterTextBox
    {
        public RegexTextBox()
        {
            InitializeComponent();
        }

        [Description("要匹配的正则表达式"), Category("正则"), Browsable(true)]
        public virtual string patterntString { get; set; }

        [Description("匹配出错时的错误信息"), Category("正则"), Browsable(true)]

        protected Match match(string valString)
        {
            //if (string.IsNullOrEmpty(patterntString))
            //{
            //    return null;
            //}
            try
            {
                Regex r = new Regex(patterntString);
                Match m = r.Match(valString);
                return m;
            }
            catch
            {
                return null;
            }
        }

        protected override void OnValidating(CancelEventArgs e)
        {
            Match m = match(Text);
            if (m==null || !m.Success)
            {
                Text = "";
                OnError(this, errorMessage);
            }
            else
            {
                OnError(this, "");
            }
            base.OnValidating(e);
        }
    }
}
