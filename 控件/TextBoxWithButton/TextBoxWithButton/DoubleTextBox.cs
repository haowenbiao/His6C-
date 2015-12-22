using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CustomTextBox
{
    public partial class DoubleTextBox : NextWhenEnterTextBox
    {
        public DoubleTextBox()
        {
            InitializeComponent();
            _value = 0;
            Text = "0";
            DecimalPlaces = 2;
            CanNegative = false;
        }

        private double _value;

        [Description("值"), Category("杂项"), Browsable(true), DefaultValue(0D)]
        public double Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                Text = _value.ToString();
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
                    _value = Convert.ToDouble(value);
                }
                catch (Exception)
                {
                    return;
                }
                base.Text = _value.ToString();
            }
        }

        [Description("小数位数"), Category("杂项"), Browsable(true), DefaultValue(2)]
        public int DecimalPlaces { get; set; }

        [Description("是否可以为负数"), Category("杂项"), Browsable(true), DefaultValue(false)]
        public bool CanNegative { get; set; }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            TextBox textBox = ((TextBox)this);
            string text = textBox.Text;

            if (!(key == (char)13 || key == (char)8))
            {
                if (key < '0' && key != '.' && key != '-' || key > '9' && key != '.' && key != '-' || text.IndexOf('.') >= 0 && key == '.' || text.IndexOf('-') >= 0 && key == '-')
                {
                    e.Handled = true;
                }
                //判断小数点
                else if (text.Length - textBox.SelectionStart > DecimalPlaces && key == '.')
                {
                    e.Handled = true;
                }
                else if (text.Length - text.IndexOf('.') > DecimalPlaces && text.IndexOf('.') >= 0 && textBox.SelectionStart > text.IndexOf('.'))
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
                Value = Convert.ToDouble(Text);
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
