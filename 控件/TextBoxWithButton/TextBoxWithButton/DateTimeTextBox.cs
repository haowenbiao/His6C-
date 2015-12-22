using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CustomTextBox
{
    public partial class DateTimeTextBox : NextWhenEnterTextBox
    {
        public DateTimeTextBox()
        {
            InitializeComponent();
            Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        }
        
        #region 自定义事件

        public event EventHandler ValueChanged;

        protected virtual void OnValueChanged(EventArgs e)
        {
            EventHandler changed = ValueChanged;
            if (changed != null) changed(this, e);
        }
        
        #endregion

        #region 属性

        private DateTime _value;

        public DateTime Value
        {
            get
            {
                return _value;
            }
            set
            {
                //如果年月日都相等，则新值与旧值相等
                if (_value.Year == value.Year && _value.Month == value.Month && _value.Date == value.Date)
                {
                    return;
                }
                _value = value;
                base.Text = Focused ? _value.ToShortDateString() : _value.ToLongDateString();
                OnValueChanged(new EventArgs());
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

                    Value = Convert.ToDateTime(Convert.ToDateTime(value).ToShortDateString());
                }
                catch (Exception)
                {
                    return;
                }
                base.Text = Focused ? _value.ToShortDateString() : _value.ToLongDateString();
            }
        }

        #endregion

        protected override void OnTextChanged(EventArgs e)
        {
            if (base.Text.Length > 7)
            {
                DateTime tmpDateTime;
                bool TrySucceed = DateTime.TryParse(Text, out tmpDateTime);
                if (TrySucceed)
                {
                    Value = tmpDateTime;
                }
            }

            base.OnTextChanged(e);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.Text = Value.ToShortDateString();
            
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.Text = Value.ToLongDateString();
            
            base.OnLostFocus(e);
        }
    }
}
