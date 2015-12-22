using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CustomTextBox
{
    public partial class NumberTextBox : NextWhenEnterTextBox
    {
        public NumberTextBox()
        {
            InitializeComponent();
            _value = 0;
            base.Text = "0";
            CanNegative = false;
        }

        private long _value;

        [Description("值"), Category("杂项"), Browsable(true), DefaultValue(0D)]
        public long Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                base.Text = _value.ToString();
            }
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                try
                {
                    _value = Convert.ToInt64(value);
                }
                catch (Exception)
                {
                    return;
                }
                base.Text = _value.ToString();
            }
        }

        [Description("是否可以为负数"), Category("杂项"), Browsable(true), DefaultValue(false)]
        public bool CanNegative { get; set; }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            TextBox textBox = this;
            string text = textBox.Text;

            if (!(key == (char)13 || key == (char)8))
            {
                if (key < '0' &&  key != '-' || key > '9' && key != '-' ||  text.IndexOf('-') >= 0 && key == '-')
                {
                    e.Handled = true;
                }
                //判断负号
                else if (!CanNegative && key == '-')
                {
                    e.Handled = true;
                }
                else if (CanNegative && textBox.SelectionStart > 0 && key == '-')
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }


            base.OnKeyPress(e);
        }

        protected override void OnValidating(CancelEventArgs e)
        {
            try
            {
                Value = Convert.ToInt64(Text);
                Text = Value.ToString();
            }
            catch (Exception)
            {
                Text = Value.ToString();
            }
            base.OnValidating(e);
        }
    }
}
