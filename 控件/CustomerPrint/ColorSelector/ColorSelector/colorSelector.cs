using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorSelector
{
    public delegate void colorChangedHandle(object sender);

    public partial class colorSelector : UserControl
    {
        public event colorChangedHandle colorChanged;

        protected Color m_color = Color.FromArgb(0, 0, 0);

        public colorSelector()
        {
            InitializeComponent();
        }

        public Color color
        {
            get
            {
                return m_color;
            }
            set
            {
                m_color = value;
                trackBarWithTextBox_A.Value = m_color.A;
                trackBarWithTextBox_R.Value = m_color.R;
                trackBarWithTextBox_G.Value = m_color.G;
                trackBarWithTextBox_B.Value = m_color.B;
                pictureBox1.Refresh();
                //colorChanged(this);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush tmpSolidBrush = new SolidBrush(color);
            e.Graphics.FillRectangle(tmpSolidBrush, pictureBox1.ClientRectangle);

            tmpSolidBrush.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                color = colorDialog1.Color;
            }
        }

        private void ColorChanged(object sender, EventArgs e)
        {
            int R = trackBarWithTextBox_R.Value;
            int G = trackBarWithTextBox_G.Value;
            int B = trackBarWithTextBox_B.Value;
            int A = trackBarWithTextBox_A.Value;

            m_color = Color.FromArgb(A, R, G, B);
            pictureBox1.Refresh();
            if (colorChanged!=null)
            {
                colorChanged(this);
            }
        }



    }
}
