using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FarPoint.Win.Input;

namespace CustomFarPointInput
{
    public partial class MyFpInteger : FpInteger
    {
        public MyFpInteger()
        {
            InitializeComponent();
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
            base.OnKeyDown(e);
        }
    }
}
