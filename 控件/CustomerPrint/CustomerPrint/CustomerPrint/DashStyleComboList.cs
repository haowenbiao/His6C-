using System.Drawing;
using System.Windows.Forms;

namespace CustomerPrint
{
    class DashStyleComboList:ComboBox
    {
        public DashStyleComboList()
        {
            //base.Items.Clear();
            //base.Items.Add("Solid");
            //base.Items.Add("Dot");
            //base.Items.Add("Dash");
            //base.Items.Add("DashDot");
            //base.Items.Add("DashDotDot");
            //base.SelectedIndex = 0;
            base.DrawMode = DrawMode.OwnerDrawFixed;
            base.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            // Set the DrawMode property to draw fixed sized items.
            //listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            // Draw the background of the ListBox control for each item.
            
            e.DrawBackground();
            // Define the default color of the brush as black.

            // Determine the color of the brush to draw each item based on the index of the item to draw.
            Brush tmpBrush = Brushes.Black;
            Pen tmpPen = new Pen(tmpBrush);

            tmpPen.Width = 2;
            switch (e.Index)
            {
                case 0:
                    tmpPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    break;
                case 1:
                    tmpPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    break;
                case 2:
                    tmpPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    break;
                case 3:
                    tmpPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                    break;
                case 4:
                    tmpPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
                    break;
            }

            // Draw the current item text based on the current Font and the custom brush settings.

            //下面这一行是我注释的
            //e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, tmpBrush, e.Bounds, StringFormat.GenericDefault);

            //这是我添加的,在Item上画样式。
            Rectangle tmpRectengle;
            tmpRectengle = e.Bounds;
            e.Graphics.DrawLine(tmpPen, tmpRectengle.X, tmpRectengle.Y + tmpRectengle.Height / 2, tmpRectengle.Width, tmpRectengle.Y + tmpRectengle.Height / 2);
            //这是我添加的

            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle(); 
            //tmpBrush.Dispose();
            tmpPen.Dispose();
            //base.OnDrawItem(e);
        }
    }
}
