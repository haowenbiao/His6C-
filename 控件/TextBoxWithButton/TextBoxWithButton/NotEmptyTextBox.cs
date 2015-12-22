using System.ComponentModel;

namespace CustomTextBox
{
    public partial class NotEmptyTextBox : NextWhenEnterTextBox
    {
        public NotEmptyTextBox()
        {
            InitializeComponent();
        }

        protected override void OnValidating(CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Text))
            {
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
