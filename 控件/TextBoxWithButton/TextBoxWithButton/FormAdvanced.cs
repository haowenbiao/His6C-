using System;
using System.Windows.Forms;

namespace CustomTextBox
{
    public partial class FormAdvanced : Form
    {
        public FormAdvanced()
        {
            InitializeComponent();
        }

        public string Value { get; set; }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Value = textBoxAdvanced.Text;
            Close();
        }

        private void FormAdvanced_Load(object sender, EventArgs e)
        {
            textBoxAdvanced.Text = Value;
        }
    }
}
