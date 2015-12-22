using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CustomTextBox
{
    public partial class CurrencyTextBox : NextWhenEnterTextBox
    {
        public CurrencyTextBox()
        {
            InitializeComponent();

            精度 = 2;
            Value = 0.00M;
            base.Text = "￥0.00";
        }

        private decimal _Value;
        [Description("值"), Category("正则"), Browsable(true), DefaultValue("0.00")]
        public decimal Value
        {
            get
            {
                string tmpValue = _Value.ToString("N" + 精度);
                _Value = decimal.Parse(tmpValue);
                return _Value;
            }
            set
            {
                _Value = value;
                if (Focused)
                {
                    base.Text = _Value.ToString();
                }
                else
                {
                    base.Text = base.Text = string.Format("{0:C" + 精度 + "}", Value);
                }
            }
        }

        private int _精度;
        [Description("精度,大于等于0，小于等于4的值。"), Category("正则"), Browsable(true),DefaultValue(2)]
        public int 精度
        {
            get
            {
                return _精度;
            }
            set
            {
                if (value < 0 || value > 4)
                {
                    return;
                }
                _精度 = value;
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == '￥' || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
            //不能有超过一个的‘.’存在。
            if (e.KeyChar == '.' && Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }
            
            base.OnKeyPress(e);
        }

        protected override void OnEnter(EventArgs e)
        {
            base.Text = Value.ToString();
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            decimal result;
            bool succeed = decimal.TryParse(Text, out result);
            if (succeed)
            {
                _Value = result;
            }
            base.Text = string.Format("{0:C" + 精度 + "}", Value);
            base.OnLeave(e);
        }

        private decimal ConvertToDecimal(string valString)
        {
            try
            {
                valString = valString.Replace("￥", "").Replace(",", "");
                decimal tmpDouble = decimal.Parse(valString);
                OnError(this, "");
                return tmpDouble;
            }
            catch
            {
                OnError(this, errorMessage);
                return 0M;
            }
        }

        //不引发 OnError 事件
        private decimal ConvertToDecimalA(string valString)
        {
            try
            {
                valString = valString.Replace("￥", "").Replace(",", "");
                decimal tmpDouble = decimal.Parse(valString);
                return tmpDouble;
            }
            catch
            {
                return 0M;
            }
        }

    }
}
