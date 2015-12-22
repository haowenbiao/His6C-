using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CustomerPrint
{
    public partial class GraphForm : Form
    {
        private bool printPreviewControlPressShiftKey = false;
        public GraphForm()
        {
            InitializeComponent();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //DashStyleComboList tmpDashStyleComboList;
            //tmpDashStyleComboList =(DashStyleComboList)groupBox3.Controls["DashStyleComboList1"];
            //MessageBox.Show(tmpDashStyleComboList.SelectedItem.ToString());
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
        private void GraphForm_Load(object sender, EventArgs e)
        {
            DashStyleComboList DashStyleComboList1=new DashStyleComboList();
            DashStyleComboList1.Name="DashStyleComboList1";
            DashStyleComboList1.Dock = DockStyle.Top;
            groupBox3.Controls.Add(DashStyleComboList1);
            DashStyleComboList1.SelectedIndexChanged += DashStyleComboList1_SelectedIndexChanged;
            //PreviewPrintController p = new PreviewPrintController();
            //printDocument1.PrintController = new myPrintControler();
            //printDocument1.PrintController = new PreviewPrintController();
            //printDocument1.PrintController = new StandardPrintController();
            //printDocument1.PrintController = new PrintControllerWithStatusDialog(printDocument1.PrintController, "hell");
            printPreviewControl1.Document = printDocument1;
        }
        public void DashStyleComboList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void ScrollBar_Changed(object sender, EventArgs e)
        {
            ScrollBar tmpScrollBar = (ScrollBar)sender;
            switch(tmpScrollBar.Name)
            {
                case "hScrollBar1":
                    label5.Text = tmpScrollBar.Value.ToString();
                    break;
                case "hScrollBar2":
                    label6.Text = tmpScrollBar.Value.ToString();
                    break;
                case "hScrollBar3":
                    label7.Text = tmpScrollBar.Value.ToString();
                    break;
                case "hScrollBar4":
                    label8.Text = tmpScrollBar.Value.ToString();
                    break;
            }
            pictureBox1.Refresh();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
            Rectangle tmpRectangle = e.ClipRectangle;
            byte tmpR=Convert.ToByte(label5.Text);
            byte tmpG= Convert.ToByte(label6.Text);
            byte tmpB= Convert.ToByte(label7.Text);
            byte tmpA= Convert.ToByte(label8.Text);
            Color tmpColor = Color.FromArgb(tmpA,tmpR,tmpG,tmpB);
            SolidBrush tmpSolidBrush=new SolidBrush(tmpColor);
            e.Graphics.FillRectangle(tmpSolidBrush, tmpRectangle);

            tmpSolidBrush.Dispose();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Color.FromArgb(Convert.ToByte(label8.Text), Convert.ToByte(label5.Text), Convert.ToByte(label6.Text), Convert.ToByte(label7.Text));
            if (colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                hScrollBar1.Value = colorDialog1.Color.R;
                hScrollBar2.Value = colorDialog1.Color.G;
                hScrollBar3.Value = colorDialog1.Color.B;
                hScrollBar4.Value = colorDialog1.Color.A;
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //e.PageSettings.PaperSize.Height;
            //e.PageSettings.PaperSize.Width;
            
            drawToGraghics(e.Graphics);
        }
        public void drawToGraghics(Graphics g)
        {
            byte tmpR = Convert.ToByte(label5.Text);
            byte tmpG = Convert.ToByte(label6.Text);
            byte tmpB = Convert.ToByte(label7.Text);
            byte tmpA = Convert.ToByte(label8.Text);
            Color tmpColor = Color.FromArgb(tmpA, tmpR, tmpG, tmpB);

            SolidBrush tmpSolidBrush = new SolidBrush(tmpColor);
            Pen tmpPen = new Pen(tmpSolidBrush);
            tmpPen.Width =Convert.ToSingle(numericUpDownPenWidth.Value);

            DashStyleComboList tmpDashStyleComboList;
            tmpDashStyleComboList =(DashStyleComboList)groupBox3.Controls["DashStyleComboList1"];

            tmpPen.DashStyle =(DashStyle)Enum.Parse(typeof(DashStyle),tmpDashStyleComboList.SelectedItem.ToString());
            Rectangle tmpRectangle = new Rectangle();
            g.PageUnit = GraphicsUnit.Millimeter;
            tmpRectangle.X = Convert.ToInt32(leftNumericUpDown.Value);
            tmpRectangle.Y = Convert.ToInt32(topNumericUpDown.Value);
            tmpRectangle.Width = Convert.ToInt32(rightNumericUpDown.Value) - Convert.ToInt32(leftNumericUpDown.Value);
            tmpRectangle.Height = Convert.ToInt32(bottomNumericUpDown.Value) - Convert.ToInt32(topNumericUpDown.Value);

            g.DrawEllipse(tmpPen, tmpRectangle);

            tmpPen.Dispose();
            tmpSolidBrush.Dispose();
        }
        public static void DrawRoundRectangle(Graphics g, Pen pen, Rectangle rect, int cornerRadius)
        {
            using (GraphicsPath path = CreateRoundedRectanglePath(rect, cornerRadius))
            {
                g.DrawPath(pen, path);
            }
        }
        internal static GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int cornerRadius)
        {
            GraphicsPath roundedRect = new GraphicsPath();
            roundedRect.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            roundedRect.AddLine(rect.X + cornerRadius, rect.Y, rect.Right - cornerRadius * 2, rect.Y);
            roundedRect.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            roundedRect.AddLine(rect.Right, rect.Y + cornerRadius * 2, rect.Right, rect.Y + rect.Height - cornerRadius * 2);
            roundedRect.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y + rect.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            roundedRect.AddLine(rect.Right - cornerRadius * 2, rect.Bottom, rect.X + cornerRadius * 2, rect.Bottom);
            roundedRect.AddArc(rect.X, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            roundedRect.AddLine(rect.X, rect.Bottom - cornerRadius * 2, rect.X, rect.Y + cornerRadius * 2);
            roundedRect.CloseFigure();
            return roundedRect;
        }
        private void RefreashPrintPreview(object sender, EventArgs e)
        {
            printPreviewControl1.Zoom = 0.5;
            printPreviewControl1.InvalidatePreview();
            //toolStripStatusLabel1.Text = printDocument1.PrintController.GetType() + "|" + printDocument1.PrintController.IsPreview;
            //printDocument1.Print();
        }

        private void Condensation(object sender, EventArgs e)
        {
            if (printPreviewControlPressShiftKey)
            {
                printPreviewControl1.Zoom /= 2;
            }
            else
            {
                printPreviewControl1.Zoom *= 2;
            }
        }
        private void printPreviewControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)
            {
                printPreviewControlPressShiftKey = true;
            }
            toolStripStatusLabel1.Text = e.Shift.ToString();
            toolStripStatusLabel1.Text = e.KeyCode.ToString();
        }

        private void printPreviewControl1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Shift)
            {
                printPreviewControlPressShiftKey = false;
            }
            toolStripStatusLabel1.Text = e.Shift.ToString();
            toolStripStatusLabel1.Text = e.KeyCode.ToString();
        }

    }
}