using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FarPoint.Win.Spread;

namespace ClassLibraryFarPointSpreadPageSet
{
    public partial class PrintHeaderSelector : UserControl
    {
        public PrintHeaderSelector()
        {
            InitializeComponent();
        }

        [Description("设置标题"), Category("我的分类"), Browsable(true)]
        public string 标题
        {
            get
            {
                return groupBox1.Text;
            }
            set
            {
                groupBox1.Text = value;
            }
        }

        public PrintHeader Value
        {
            get
            {
                if (radioButtonInherit.Checked)
                {
                    return PrintHeader.Inherit;
                }
                if (radioButtonShow.Checked)
                {
                    return PrintHeader.Show;
                }
                if (radioButtonHide.Checked)
                {
                    return PrintHeader.Hide;
                }
                return PrintHeader.Show;
            }
            set
            {
                switch (value)
                {
                    case PrintHeader.Show:
                        radioButtonInherit.Checked = false;
                        radioButtonHide.Checked = false;
                        radioButtonShow.Checked = true;
                        break;
                    case PrintHeader.Hide:
                        radioButtonInherit.Checked = false;
                        radioButtonHide.Checked = true; ;
                        radioButtonShow.Checked = false;
                        break;
                    case PrintHeader.Inherit:
                        radioButtonInherit.Checked = true;
                        radioButtonHide.Checked = false;
                        radioButtonShow.Checked = false;
                        break;
                }
            }
        }
    }
}
