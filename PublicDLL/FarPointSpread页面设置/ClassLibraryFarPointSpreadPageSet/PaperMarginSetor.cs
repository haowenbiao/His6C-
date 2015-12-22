using System.Windows.Forms;
using FarPoint.Win.Spread;


namespace ClassLibraryFarPointSpreadPageSet
{
    public partial class PaperMarginSetor : UserControl
    {
        public PaperMarginSetor()
        {
            InitializeComponent();
            fpIntegerTop.DataBindings.Add("Value", m_PrintMargin, "Top");
            fpIntegerBottom.DataBindings.Add("Value", m_PrintMargin, "Bottom");
            fpIntegerLeft.DataBindings.Add("Value", m_PrintMargin, "Left");
            fpIntegerRight.DataBindings.Add("Value", m_PrintMargin, "Right");
        }

        private PrintMargin m_PrintMargin = new PrintMargin();

        public PrintMargin Value
        {
            get
            {
                return m_PrintMargin;
            }
            set
            {
                if (value != null)
                {
                    m_PrintMargin.Top = value.Top;
                    m_PrintMargin.Bottom = value.Bottom;
                    m_PrintMargin.Left = value.Left;
                    m_PrintMargin.Right = value.Right;
                }
            }
        }

        private void ControlOnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
            base.OnKeyDown(e);
        }
    }
}