using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using CustomerPrintClassLibrary;
using System.Drawing.Imaging;

namespace CustomerPrintControl
{
    public partial class CustomerPrintControl : UserControl
    {
        public event ArrayListChangedHandle ArrayListOf图形Changed;
        public event ArrayListChangedHandle ArrayListOf标签Changed;
        public event ArrayListChangedHandle ArrayListOf数据Changed;

        protected 公共类 m_SelectedItem;
        protected 内容 m_Obj内容 = new 内容();
        protected bool m_显示为名称;

        public CustomerPrintControl()
        {
            InitializeComponent();
            
            //关联事件
            m_Obj内容.PagesettingChanged += EditPictureBoxSize;
            m_Obj内容.ArrayList图形Changed += RaiseArrayListOf图形ChangedEvent;
            m_Obj内容.ArrayList标签Changed += RaiseArrayListOf标签ChangedEvent;
            m_Obj内容.ArrayList数据Changed += RaiseArrayListOf数据ChangedEvent;
        }

        public 公共类 SelectedItem
        {
            set
            {
                if (m_SelectedItem != null)
                {
                    m_SelectedItem.Selected = false;
                }
                m_SelectedItem = value;
                if (m_SelectedItem != null)
                {
                    m_SelectedItem.Selected = true;
                }
            }
            get
            {
                return m_SelectedItem;
            }
        }

        public bool 显示为名称
        {
            get
            {
                return m_显示为名称;
            }
            set
            {
                m_显示为名称 = value;
            }
        }

        private void RaiseArrayListOf图形ChangedEvent()
        {
            ArrayListOf图形Changed();
            pictureBox1.Refresh();
        }

        private void RaiseArrayListOf标签ChangedEvent()
        {
            ArrayListOf标签Changed();
            pictureBox1.Refresh();
        }

        private void RaiseArrayListOf数据ChangedEvent()
        {
            ArrayListOf数据Changed();
            pictureBox1.Refresh();
        }

        private void EditPictureBoxSize()
        {
            pictureBox1.Height =
                Convert.ToInt32(((pictureBox1.Width * m_Obj内容.Obj页面设置.Obj纸张大小.高度) / m_Obj内容.Obj页面设置.Obj纸张大小.宽度));
        }

        private void CustomerPrintControl_Resize(object sender, EventArgs e)
        {
            if (m_Obj内容.Obj页面设置!=null)
            {
                Point tmpPoint = new Point(35, 35);
                pictureBox1.Location = tmpPoint;
                pictureBox1.Size = new Size(Size.Width - 70,Convert.ToInt32(((Size.Width - 70) * m_Obj内容.Obj页面设置.Obj纸张大小.高度)) / m_Obj内容.Obj页面设置.Obj纸张大小.宽度);
            }
            else
            {
                Point tmpPoint = new Point(35, 35);
                pictureBox1.Location = tmpPoint;
                pictureBox1.Size = new Size(Size.Width-70,Size.Height-70);
            }
        }

        public 内容 Obj内容
        {
            get
            {
                return m_Obj内容;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

             //printDocument1.PrinterSettings.PaperSizes.
            if (m_Obj内容 != null)
            {
                if ((m_Obj内容.ObjArrayList图形 != null) || (m_Obj内容.ObjArrayList标签 !=null) || (m_Obj内容.ObjArrayList数据!=null))
                {
                    Metafile tmpMetaFile = CreateMetaFileObj(true);
                    if (tmpMetaFile != null)
                    {
                        e.Graphics.DrawImage(tmpMetaFile,0,0, pictureBox1.ClientSize.Width,pictureBox1.ClientSize.Height);
                        tmpMetaFile.Dispose();
                    }
                }
            }
        }
        
        private Metafile CreateMetaFileObj(bool valPrintPreview)
        {
            Bitmap bmp = new Bitmap(300, 300);
            Graphics g = Graphics.FromImage(bmp);
            IntPtr hdc = g.GetHdc();
            Metafile tmpMetafile;
            try
            {
                Rectangle tmpRectamgle =new Rectangle(0,0,m_Obj内容.Obj页面设置.Obj纸张大小.宽度 + 1 ,m_Obj内容.Obj页面设置.Obj纸张大小.高度 + 1);
                tmpMetafile = new Metafile(hdc, tmpRectamgle,MetafileFrameUnit.Pixel,EmfType.EmfPlusOnly);
            }
            catch (Exception e)
            {
                g.ReleaseHdc(hdc);
                g.Dispose();
                MessageBox.Show("Soure:" + e.Source + "\n" + e.Message);
                return null;
            }
            Graphics tmpG = Graphics.FromImage(tmpMetafile);
            tmpG.PageUnit = GraphicsUnit.Pixel;
            if (valPrintPreview)
            {
                DrawOnMetaFileObject(tmpG);
            }
            else
            {
                DrawOnMetaFileObjectThatWillBePrintToPrinter(tmpG);
            }
            tmpG.Save();
            tmpG.Dispose();//没有此项下一句就会提示“参数无效”错误

            g.ReleaseHdc(hdc);
            g.Dispose();
            bmp.Dispose();

            return tmpMetafile;
        }

        private void DrawOnMetaFileObject(Graphics g)
        {
            if (m_Obj内容 != null)
            {
                if (m_Obj内容.ObjArrayList图形 != null)
                {
                    if (m_Obj内容.ObjArrayList图形!=null)
                    {
                        图形 tmpObj图形;
                        for (int i = 0; i < m_Obj内容.ObjArrayList图形.Count; ++i)
                        {
                            tmpObj图形 = (图形)m_Obj内容.ObjArrayList图形[i];
                            tmpObj图形.绘制(g,true);
                        }
                    }
                    if (m_Obj内容.ObjArrayList标签!=null)
                    {
                        标签 tmpObj标签;
                        for (int i = 0; i < m_Obj内容.ObjArrayList标签.Count; ++i)
                        {
                            tmpObj标签 = (标签) m_Obj内容.ObjArrayList标签[i];
                            if (m_显示为名称)
                            {
                                tmpObj标签.绘制(g, true, true);
                                    
                            }
                            else
                            {
                                tmpObj标签.绘制(g, false, true);
                            }
                        }
                    }
                    if (m_Obj内容.ObjArrayList数据!=null)
                    {
                        数据 tmpObj数据;
                        for (int i = 0; i < m_Obj内容.ObjArrayList数据.Count; ++i)
                        {
                            tmpObj数据 = (数据)m_Obj内容.ObjArrayList数据[i];
                            if (m_显示为名称)
                            {
                                tmpObj数据.绘制(g, true, true);
                            }
                            else
                            {
                                tmpObj数据.绘制(g, false, true);
                            }
                        }
                    }
                }
            }
        }

        private void DrawOnMetaFileObjectThatWillBePrintToPrinter(Graphics g)
        {
            if (m_Obj内容 != null)
            {
                if (m_Obj内容.ObjArrayList图形 != null)
                {
                    图形 tmpObj图形;
                    for (int i = 0; i < m_Obj内容.ObjArrayList图形.Count; ++i)
                    {
                        tmpObj图形 = (图形)m_Obj内容.ObjArrayList图形[i];
                        if (tmpObj图形.是否打印)
                        {
                            tmpObj图形.绘制(g,false);
                        }
                    }
                }
                if (m_Obj内容.ObjArrayList标签 != null)
                {
                    标签 tmpObj标签;
                    for (int i = 0; i < m_Obj内容.ObjArrayList标签.Count; ++i)
                    {
                        tmpObj标签 = (标签)m_Obj内容.ObjArrayList标签[i];
                        if (tmpObj标签.是否打印)
                        {
                            if (m_显示为名称)
                            {
                                tmpObj标签.绘制(g, true, false);
                            }
                            else
                            {
                                tmpObj标签.绘制(g, false, false);
                            }
                            
                        }
                    }
                }
                if (m_Obj内容.ObjArrayList数据 != null)
                {
                    数据 tmpObj数据;
                    for (int i = 0; i < m_Obj内容.ObjArrayList数据.Count; ++i)
                    {
                        tmpObj数据 = (数据)m_Obj内容.ObjArrayList数据[i];
                        if (tmpObj数据.是否打印)
                        {
                            if (m_显示为名称)
                            {
                                tmpObj数据.绘制(g, true, false);
                            }
                            else
                            {
                                tmpObj数据.绘制(g, false, false);
                            }
                            
                        }
                    }
                }
            }
        }


        public void 放大()
        {
            if (m_Obj内容!=null)
            {
                Resize -= CustomerPrintControl_Resize;
                pictureBox1.Width = Convert.ToInt32(pictureBox1.Width*1.5);
                pictureBox1.Height =
                    Convert.ToInt32(((pictureBox1.Width*m_Obj内容.Obj页面设置.Obj纸张大小.高度)/m_Obj内容.Obj页面设置.Obj纸张大小.宽度));
                pictureBox1.Refresh();
                Resize += CustomerPrintControl_Resize;
            }
        }

        public void 缩小()
        {
            if (m_Obj内容 != null)
            {
                pictureBox1.Width = Convert.ToInt32(pictureBox1.Width/1.5);
                pictureBox1.Height =
                    Convert.ToInt32(((pictureBox1.Width*m_Obj内容.Obj页面设置.Obj纸张大小.高度)/m_Obj内容.Obj页面设置.Obj纸张大小.宽度));
                pictureBox1.Refresh();
            }
        }

        public void 打印()
        {
            if (m_Obj内容 != null)
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += printDocument1_PrintPage;
                int tmpHeight = Convert.ToInt32(m_Obj内容.Obj页面设置.Obj纸张大小.高度 * 3.937);
                int tmpWidth = Convert.ToInt32(m_Obj内容.Obj页面设置.Obj纸张大小.宽度 * 3.937);
                PaperSize tmpPaperSize = new PaperSize("myPaperSize", tmpWidth, tmpHeight);
                PageSettings tmpPageSettings = new PageSettings();
                tmpPageSettings.PaperSize = tmpPaperSize;
                pd.DefaultPageSettings.PaperSize = tmpPaperSize;

                pd.Print();

                //PrintPreviewDialog ppd = new PrintPreviewDialog();
                //PageSetupDialog psd = new PageSetupDialog();
                
                //ppd.Document = pd;
                //psd.Document = pd;
                
                ////psd.ShowDialog();
                //ppd.ShowDialog();
                //pd.Print();
                //psd.Dispose();
                //ppd.Dispose();
                //pd.Dispose();
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (m_Obj内容 != null)
            {
                if ((m_Obj内容.ObjArrayList图形 != null) || (m_Obj内容.ObjArrayList标签 != null) || (m_Obj内容.ObjArrayList数据 != null))
                {
                    Metafile tmpMetaFile = CreateMetaFileObj(false);
                    if (tmpMetaFile != null)
                    {
                        e.Graphics.DrawImage(tmpMetaFile, e.PageBounds);
                        tmpMetaFile.Dispose();
                    }
                }
                MessageBox.Show(e.PageSettings.PaperSize.PaperName + ";width:" + e.PageSettings.PaperSize.Width + ";height:" + e.PageSettings.PaperSize.Height);
            }
        }
    }
}