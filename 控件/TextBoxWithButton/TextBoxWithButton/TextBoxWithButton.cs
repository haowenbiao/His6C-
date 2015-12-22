using System;
using System.Windows.Forms;
using CustomTextBox;

namespace CustomTextBox
{
    public partial class TextBoxWithButton : NextWhenEnterTextBox
    {
        public TextBoxWithButton()
        {
            InitializeComponent();
            FormAdvanceCaption = "详细内容";
        }

        public string FormAdvanceCaption { get; set; }

        private void buttonAdvanced_Click(object sender, EventArgs e)
        {
            FormAdvanced fa = new FormAdvanced();
            fa.Text = FormAdvanceCaption;
            fa.Value = Text;
            if (fa.ShowDialog(this)==DialogResult.OK)
            {
                Text = fa.Value;
            }
        }
    }
}