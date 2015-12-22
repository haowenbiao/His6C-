using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FarPoint.Win.Spread;


namespace PaperMarginSetor
{
    public partial class PaperMarginSetor : UserControl
    {
        public PaperMarginSetor()
        {
            InitializeComponent();
        }

        public PrintMargin PrintMargin
        {
            get;
            set;
        }
    }
}
