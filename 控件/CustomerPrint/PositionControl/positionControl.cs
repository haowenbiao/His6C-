using System;
using System.Drawing;
using System.Windows.Forms;

namespace PositionControl
{
    public delegate void positionChangedHandl(object sender, EventArgs e);
    
    public partial class positionControl : UserControl
    {
        public event positionChangedHandl positionChanged;

        protected Rectangle m_rectangle;

        public positionControl()
        {
            InitializeComponent();
        }

        public Rectangle rectangle
        {
            get
            {
                return m_rectangle;
            }
            set
            {
                //m_rectangle = value;
                numericUpDown_左.Value = value.X;
                numericUpDown_上.Value = value.Y;
                numericUpDown_宽度.Value = value.Width;
                numericUpDown_高度.Value = value.Height;
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Rectangle tmpRectangle =
                new Rectangle(Convert.ToInt32(numericUpDown_左.Value), 
                Convert.ToInt32(numericUpDown_上.Value),
                Convert.ToInt32(numericUpDown_宽度.Value),
                Convert.ToInt32(numericUpDown_高度.Value));
            m_rectangle = tmpRectangle;
            if (positionChanged!=null)
            {
                positionChanged(this, e);
            }
        }

    }
}