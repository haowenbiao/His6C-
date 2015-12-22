using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Xml;

namespace CustomerPrintClassLibrary
{
    public delegate void PageSettingsChangedHandle();
    public delegate void ArrayListChangedHandle();

    public enum enumCollectionType
    {
        图形 = 0,
        标签,
        数据
    } 

    public enum enumShapeType
    {
        直线 = 0,
        矩形,
        椭圆
    } 

    public enum enum数据来源类型
    {
        文本 = 0,
        数值
    } 

    public enum enum水平对齐
    {
        左对齐 = StringAlignment.Near,
        居中 = StringAlignment.Center,
        右对齐 = StringAlignment.Far
    } 

    public enum enum垂直对齐
    {
        上对齐 = StringAlignment.Near,
        居中 = StringAlignment.Center,
        下对齐 = StringAlignment.Far
    } 

    class MyListObj : Object
    {
        string m_objKey, m_objName;
        public override string ToString()
        {
            //return base.ToString();
            return m_objName;
        }
        public MyListObj(string tmpName, string tmpKey)
        {
            m_objName = tmpName;
            m_objKey = tmpKey;
        }
        public string objKey
        {
            set
            {
                m_objKey = value;
            }
            get
            {
                return m_objKey;
            }
        }
        public string objName
        {
            set
            {
                m_objName = value;
            }
            get
            {
                return m_objName;
            }
        }
    }

    public class 纸张大小类
    {

        protected XmlNode m_ObjXmlNode = null;
        protected int m_宽度;
        protected int m_高度;

        public 纸张大小类(XmlNode objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
            m_宽度 = xml宽度;
            m_高度 = xml高度;
        }
        
        public int 宽度
        {
            set
            {
                m_宽度 = value;
                xml宽度 = m_宽度;
            }
            get
            {
                return m_宽度;
            }
        }

        private int xml宽度
        {
            set
            {
                if (m_ObjXmlNode != null)
                {
                    m_ObjXmlNode.SelectSingleNode("宽度").InnerText = Convert.ToString(value);
                }
            }
            get
            {
                if (m_ObjXmlNode != null)
                {
                    int tmpX = Convert.ToInt32(m_ObjXmlNode.SelectSingleNode("宽度").InnerText == "" ? "210" : m_ObjXmlNode.SelectSingleNode("宽度").InnerText);
                    return tmpX;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int 高度
        {
            set
            {
                m_高度 = value;
                xml高度 = m_高度;
            }
            get
            {
                return m_高度;
            }
        }

        private int xml高度
        {
            set
            {
                if (m_ObjXmlNode != null)
                {
                    m_ObjXmlNode.SelectSingleNode("高度").InnerText = Convert.ToString(value);
                }
            }
            get
            {
                if (m_ObjXmlNode != null)
                {
                    int tmpX = Convert.ToInt32(m_ObjXmlNode.SelectSingleNode("高度").InnerText == "" ? "297" : m_ObjXmlNode.SelectSingleNode("高度").InnerText);
                    return tmpX;
                }
                else
                {
                    return 0;
                }
            }
        }
    }

    public class 移动类
    {
        protected XmlNode m_ObjXmlNode = null;
        protected Point m_移动;

        public 移动类(XmlNode objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
            m_移动 = xml移动;
        }

        public Point 移动
        {
            set
            {
                m_移动 = value;
                xml移动 = m_移动;
            }
            get
            {
                return m_移动;
            }
        }

        private Point xml移动
        {
            set
            {
                if (m_ObjXmlNode != null)
                {
                    m_ObjXmlNode.SelectSingleNode("x").InnerText = Convert.ToString(value.X);
                    m_ObjXmlNode.SelectSingleNode("y").InnerText = Convert.ToString(value.Y);
                }
            }
            get
            {
                if (m_ObjXmlNode != null)
                {
                    int tmpX = Convert.ToInt32(m_ObjXmlNode.SelectSingleNode("x").InnerText == "" ? "0" : m_ObjXmlNode.SelectSingleNode("x").InnerText);
                    int tmpY = Convert.ToInt32(m_ObjXmlNode.SelectSingleNode("y").InnerText == "" ? "0" : m_ObjXmlNode.SelectSingleNode("y").InnerText);
                    return new Point(tmpX,tmpY);
                }
                else
                {
                    return new Point(0,0);
                }
            }
        }
    }

    public class 页面设置
    {
        protected XmlNode m_ObjXmlNode = null;
        protected 纸张大小类 m_Obj纸张大小;
        protected 移动类 m_移动;

        public 页面设置(XmlNode objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
            m_Obj纸张大小 = xmlObj纸张大小;
            m_移动 = xml移动;
        }

        public 纸张大小类 Obj纸张大小
        {
            get
            {
                return m_Obj纸张大小;
            }
        }

        private 纸张大小类 xmlObj纸张大小
        {
            get
            {
                XmlNode tmpXmlNode = m_ObjXmlNode.SelectSingleNode("纸张大小");
                纸张大小类 tmpObj纸张大小 = new 纸张大小类(tmpXmlNode);
                return tmpObj纸张大小;
            }
        }

        public 移动类 移动
        {
            get
            {
                return m_移动;
            }
        }

        private 移动类 xml移动
        {
            get
            {
                XmlNode tmpXmlNode = m_ObjXmlNode.SelectSingleNode("移动");
                移动类 tmpObj移动 = new 移动类(tmpXmlNode);
                return tmpObj移动;
            }
        }
    }

    public class 位置类
    {
        protected XmlNode m_ObjXmlNode = null;
        protected Rectangle m_位置;

        /// <summary>
        /// 新建位置类，并把其中生成的XmlNode对象加入到父节点objAddToXmlNode
        /// </summary>
        /// <param name="xmlDocument">用于创建节点的根节点</param>
        /// <param name="valRectangle"></param>
        public 位置类(XmlDocument xmlDocument, Rectangle valRectangle)
        {
            m_ObjXmlNode = xmlDocument.CreateElement("位置");

            XmlElement x = xmlDocument.CreateElement("x");
            XmlElement y = xmlDocument.CreateElement("y");
            XmlElement width = xmlDocument.CreateElement("width");
            XmlElement height = xmlDocument.CreateElement("height");

            x.InnerText = valRectangle.X.ToString();
            y.InnerText = valRectangle.Y.ToString();
            width.InnerText = valRectangle.Width.ToString();
            height.InnerText = valRectangle.Height.ToString();

            m_ObjXmlNode.AppendChild(x);
            m_ObjXmlNode.AppendChild(y);
            m_ObjXmlNode.AppendChild(width);
            m_ObjXmlNode.AppendChild(height);

            m_位置 = valRectangle;
            //添加至父节点
            //objParentXmlNode.AppendChild(m_ObjXmlNode);
        }

        /// <summary>
        /// 根据XmlNode对象构建位置类
        /// </summary>
        /// <param name="objXmlNode"></param>
        public 位置类(XmlNode objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
            m_位置 = xml位置;
        }

        /// <summary>
        /// 获取XmlNode对象
        /// </summary>
        public XmlNode ObjXmlNode
        {
            get
            {
                return m_ObjXmlNode;
            }
            //set
            //{
            //    m_ObjXmlNode = value;
            //}
        }

        public Rectangle 位置
        {
            set
            {
                m_位置 = value;
                xml位置 = m_位置;
            }
            get
            {
                return m_位置;
            }
        }

        /// <summary>
        /// 获取或设置位置
        /// </summary>
        private Rectangle xml位置
        {
            set
            {
                if (m_ObjXmlNode != null)
                {
                    m_ObjXmlNode.SelectSingleNode("x").InnerText = Convert.ToString(value.X);
                    m_ObjXmlNode.SelectSingleNode("y").InnerText = Convert.ToString(value.Y);
                    m_ObjXmlNode.SelectSingleNode("width").InnerText = Convert.ToString(value.Width);
                    m_ObjXmlNode.SelectSingleNode("height").InnerText = Convert.ToString(value.Height);
                }
            }
            get
            {
                if (ObjXmlNode != null)
                {
                    int tmpX = Convert.ToInt32(m_ObjXmlNode.SelectSingleNode("x").InnerText == "" ? "0" : m_ObjXmlNode.SelectSingleNode("x").InnerText);
                    int tmpY = Convert.ToInt32(m_ObjXmlNode.SelectSingleNode("y").InnerText == "" ? "0" : m_ObjXmlNode.SelectSingleNode("y").InnerText);
                    int tmpWidth = Convert.ToInt32(m_ObjXmlNode.SelectSingleNode("width").InnerText == "" ? "0" : m_ObjXmlNode.SelectSingleNode("width").InnerText);
                    int tmpHeight = Convert.ToInt32(m_ObjXmlNode.SelectSingleNode("height").InnerText == "" ? "0" : m_ObjXmlNode.SelectSingleNode("height").InnerText);
                    Rectangle tmpRectangle = new Rectangle(tmpX, tmpY, tmpWidth, tmpHeight);
                    return tmpRectangle;
                }
                else
                {
                    return new Rectangle(0, 0, 0, 0);
                }
            }
        }

        public void 向左移动(int val步长)
        {
            int tmpX = 位置.X;
            tmpX = tmpX - val步长 < -999 ? -999 : tmpX - val步长;
            Rectangle tmpRecrangle = new Rectangle(tmpX, 位置.Y, 位置.Width, 位置.Height);
            位置 = tmpRecrangle;
        }

        public void 向右移动(int val步长)
        {
            int tmpX = 位置.X;
            tmpX = tmpX + val步长 > 999 ? 999 : tmpX + val步长;
            Rectangle tmpRecrangle = new Rectangle(tmpX, 位置.Y, 位置.Width, 位置.Height);
            位置 = tmpRecrangle;
        }

        public void 向上移动(int val步长)
        {
            int tmpY = 位置.Y;
            tmpY = tmpY - val步长 < -999 ? -999 : tmpY - val步长;
            Rectangle tmpRectangle = new Rectangle(位置.X, tmpY, 位置.Width, 位置.Height);
            位置 = tmpRectangle;
        }

        public void 向下移动(int val步长)
        {
            int tmpY = 位置.Y;
            tmpY = tmpY + val步长 > 999 ? 999 : tmpY + val步长;
            Rectangle tmpRectangle = new Rectangle(位置.X, tmpY, 位置.Width, 位置.Height);
            位置 = tmpRectangle;
        }
    }

    public class 颜色类
    {
        protected XmlNode m_ObjXmlNode = null;
        protected Color m_颜色;

        /// <summary>
        /// 新建颜色类，并把其中生成的XmlNode对象加入到父节点objAddToXmlNode
        /// </summary>
        /// <param name="xmlDocument">用于创建节点的根节点</param>
        /// <param name="valColor"></param>
        public 颜色类(XmlDocument xmlDocument, Color valColor)
        {
            m_ObjXmlNode = xmlDocument.CreateElement("颜色");

            XmlElement a = xmlDocument.CreateElement("a");
            XmlElement r = xmlDocument.CreateElement("r");
            XmlElement g = xmlDocument.CreateElement("g");
            XmlElement b = xmlDocument.CreateElement("b");

            a.InnerText = valColor.A.ToString();
            r.InnerText = valColor.R.ToString();
            g.InnerText = valColor.G.ToString();
            b.InnerText = valColor.B.ToString();

            m_ObjXmlNode.AppendChild(a);
            m_ObjXmlNode.AppendChild(r);
            m_ObjXmlNode.AppendChild(g);
            m_ObjXmlNode.AppendChild(b);

            m_颜色 = valColor;
            //添加至父节点
            //objParentXmlNode.AppendChild(m_ObjXmlNode);
        }

        /// <summary>
        /// 根据XmlNode对象构建颜色类
        /// </summary>
        /// <param name="objXmlNode"></param>
        public 颜色类(XmlNode objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
            m_颜色 = xml颜色;
        }

        /// <summary>
        /// 获取XmlNode对象
        /// </summary>
        public XmlNode ObjXmlNode
        {
            get
            {
                return m_ObjXmlNode;
            }
            //set
            //{
            //    m_ObjXmlNode = value;
            //}
        }

        public Color 颜色
        {
            set
            {
                m_颜色 = value;
                xml颜色 = m_颜色;
            }
            get
            {
                return m_颜色;
            }
        }
        /// <summary>
        /// 获取或设置颜色
        /// </summary>
        private Color xml颜色
        {
            set
            {
                if (ObjXmlNode != null)
                {
                    m_ObjXmlNode.SelectSingleNode("r").InnerText = Convert.ToString(value.R);
                    m_ObjXmlNode.SelectSingleNode("g").InnerText = Convert.ToString(value.G);
                    m_ObjXmlNode.SelectSingleNode("b").InnerText = Convert.ToString(value.B);
                    m_ObjXmlNode.SelectSingleNode("a").InnerText = Convert.ToString(value.A);
                }
            }
            get
            {
                if (ObjXmlNode != null)
                {
                    int tmpR = Convert.ToInt32(m_ObjXmlNode.SelectSingleNode("r").InnerText == "" ? "0" : m_ObjXmlNode.SelectSingleNode("r").InnerText);
                    int tmpG = Convert.ToInt32(m_ObjXmlNode.SelectSingleNode("g").InnerText == "" ? "0" : m_ObjXmlNode.SelectSingleNode("g").InnerText);
                    int tmpB = Convert.ToInt32(m_ObjXmlNode.SelectSingleNode("b").InnerText == "" ? "0" : m_ObjXmlNode.SelectSingleNode("b").InnerText);
                    int tmpA = Convert.ToInt32(m_ObjXmlNode.SelectSingleNode("a").InnerText == "" ? "255" : m_ObjXmlNode.SelectSingleNode("a").InnerText);
                    Color tmpColor = Color.FromArgb(tmpA, tmpR, tmpG, tmpB);
                    return tmpColor;
                }
                else
                {
                    return Color.FromArgb(0, 0, 0);
                }
            }
        }
    }

    public class 字体类
    {
        protected XmlNode m_ObjXmlNode = null;
        protected Font m_字体;

        /// <summary>
        /// 新建字体类，并把其中生成的XmlNode对象加入到父节点objAddToXmlNode
        /// </summary>
        /// <param name="xmlDocument">用于创建节点的根节点</param>
        /// <param name="valFont"></param>
        public 字体类(XmlDocument xmlDocument, Font valFont)
        {
            m_ObjXmlNode = xmlDocument.CreateElement("字体");

            XmlElement tmp字体 = xmlDocument.CreateElement("字体");
            XmlElement tmp大小 = xmlDocument.CreateElement("大小");
            XmlElement tmp粗体 = xmlDocument.CreateElement("粗体");
            XmlElement tmp斜体 = xmlDocument.CreateElement("斜体");
            XmlElement tmp下划线 = xmlDocument.CreateElement("下划线");
            XmlElement tmp删除线 = xmlDocument.CreateElement("删除线");

            tmp字体.InnerText = valFont.Name;
            tmp大小.InnerText = valFont.Size.ToString();
            tmp粗体.InnerText = valFont.Bold ? "是" : "否";
            tmp斜体.InnerText = valFont.Italic ? "是" : "否";
            tmp下划线.InnerText = valFont.Underline ? "是" : "否";
            tmp删除线.InnerText = valFont.Strikeout ? "是" : "否";

            m_ObjXmlNode.AppendChild(tmp字体);
            m_ObjXmlNode.AppendChild(tmp大小);
            m_ObjXmlNode.AppendChild(tmp粗体);
            m_ObjXmlNode.AppendChild(tmp斜体);
            m_ObjXmlNode.AppendChild(tmp下划线);
            m_ObjXmlNode.AppendChild(tmp删除线);

            m_字体 = valFont;
            //添加至父节点
            //objParentXmlNode.AppendChild(m_ObjXmlNode);
        }

        /// <summary>
        /// 根据XmlNode对象构建字体类
        /// </summary>
        /// <param name="objXmlNode"></param>
        public 字体类(XmlNode objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
            m_字体 = xml字体;
        }

        ~字体类()
        {
            if (m_字体!=null)
            {
                m_字体.Dispose();
            }
        }

        /// <summary>
        /// 获取XmlNode对象
        /// </summary>
        public XmlNode ObjXmlNode
        {
            get
            {
                return m_ObjXmlNode;
            }
        }

        public Font 字体
        {
            set
            {
                m_字体 = value;
                xml字体 = m_字体;
            }
            get
            {
                return m_字体;
            }
        }

        /// <summary>
        /// 获取或设置字体
        /// </summary>
        private Font xml字体
        {
            set
            {
            if (m_ObjXmlNode != null)
                {
                    m_ObjXmlNode.SelectSingleNode("字体").InnerText = Convert.ToString(value.Name);
                    m_ObjXmlNode.SelectSingleNode("大小").InnerText = Convert.ToString(value.Size);
                    m_ObjXmlNode.SelectSingleNode("粗体").InnerText = value.Bold ? "是" : "否";
                    m_ObjXmlNode.SelectSingleNode("斜体").InnerText = value.Italic ? "是" : "否";
                    m_ObjXmlNode.SelectSingleNode("下划线").InnerText = value.Underline ? "是" : "否";
                    m_ObjXmlNode.SelectSingleNode("删除线").InnerText = value.Strikeout ? "是" : "否";
                }
            }
            get
            {
                FontStyle tmpFontStyle = FontStyle.Regular;
                if (ObjXmlNode != null)
                {
                    string 字体名称 = m_ObjXmlNode.SelectSingleNode("字体").InnerText;
                    float 大小 = Convert.ToSingle(m_ObjXmlNode.SelectSingleNode("大小").InnerText);
                    bool 粗体 = m_ObjXmlNode.SelectSingleNode("粗体").InnerText == "是" ? true : false;
                    bool 斜体 = m_ObjXmlNode.SelectSingleNode("斜体").InnerText == "是" ? true : false;
                    bool 下划线 = m_ObjXmlNode.SelectSingleNode("下划线").InnerText == "是" ? true : false;
                    bool 删除线 = m_ObjXmlNode.SelectSingleNode("删除线").InnerText == "是" ? true : false;

                    if (粗体) tmpFontStyle |= FontStyle.Bold;
                    if (斜体) tmpFontStyle |= FontStyle.Italic;
                    if (下划线) tmpFontStyle |= FontStyle.Underline;
                    if (删除线) tmpFontStyle |= FontStyle.Strikeout;

                    //Font tmpFont = new Font(字体名称, 大小, tmpFontStyle,GraphicsUnit.Pixel);
                    Font tmpFont = new Font(字体名称, 大小, tmpFontStyle);
                    return tmpFont;
                }
                else
                {
                    return new Font("宋体", 10);
                }
            }
        }

    }

    public class 对齐类
    {
        protected XmlNode m_ObjXmlNode = null;
        protected enum水平对齐 m_水平对齐;
        protected enum垂直对齐 m_垂直对齐;
        protected bool m_自动换行;

        public 对齐类(XmlDocument xmlDocument, enum水平对齐 val水平对齐, enum垂直对齐 val垂直对齐,bool val自动换行)
        {
            m_ObjXmlNode = xmlDocument.CreateElement("对齐");

            XmlElement tmp水平对齐 = xmlDocument.CreateElement("水平对齐");
            XmlElement tmp垂直对齐 = xmlDocument.CreateElement("垂直对齐");
            XmlElement tmp自动换行 = xmlDocument.CreateElement("自动换行");

            tmp水平对齐.InnerText = val水平对齐.ToString();
            tmp垂直对齐.InnerText = val垂直对齐.ToString();
            tmp自动换行.InnerText = val自动换行 ? "是" : "否";

            m_ObjXmlNode.AppendChild(tmp水平对齐);
            m_ObjXmlNode.AppendChild(tmp垂直对齐);
            m_ObjXmlNode.AppendChild(tmp自动换行);

            m_水平对齐 = val水平对齐;
            m_垂直对齐 = val垂直对齐;
            m_自动换行 = val自动换行;
            //添加至父节点
            //objParentXmlNode.AppendChild(m_ObjXmlNode);
        }

        public 对齐类(XmlNode objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
            m_水平对齐 = xml水平对齐;
            m_垂直对齐 = xml垂直对齐;
            m_自动换行 = xml自动换行;
        }

        public XmlNode ObjXmlNode
        {
            get
            {
                return m_ObjXmlNode;
            }
            //set
            //{
            //    m_ObjXmlNode = value;
            //}
        }

        public enum水平对齐 水平对齐
        {
            set
            {
                m_水平对齐 = value;
                xml水平对齐 = m_水平对齐;
            }
            get
            {
                return m_水平对齐;
            }
        }
        public enum垂直对齐 垂直对齐
        {
            set
            {
                m_垂直对齐 = value;
                xml垂直对齐 = m_垂直对齐;
            }
            get
            {
                return m_垂直对齐;
            }
        }
        public bool 自动换行
        {
            set
            {
                m_自动换行 = value;
                xml自动换行 = m_自动换行;
            }
            get
            {
                return m_自动换行;
            }
        }

        private enum水平对齐 xml水平对齐
        {
            get
            {
                if (m_ObjXmlNode!=null)
                {
                    XmlNode tmpXmlNode = m_ObjXmlNode.SelectSingleNode("水平对齐");
                    if (tmpXmlNode!=null)
                    {
                        return (enum水平对齐) Enum.Parse(typeof (enum水平对齐), tmpXmlNode.InnerText);
                    }
                    else
                    {
                        return enum水平对齐.居中;
                    }
                }
                else
                {
                    return enum水平对齐.居中;
                }
            }
            set
            {
                if (m_ObjXmlNode!=null)
                {
                    XmlNode tmpXmlNode = m_ObjXmlNode.SelectSingleNode("水平对齐");
                    if (tmpXmlNode!=null)
                    {
                        tmpXmlNode.InnerText = value.ToString();
                    }
                }
            }
        }

        private enum垂直对齐 xml垂直对齐
        {
            get
            {
                if (m_ObjXmlNode != null)
                {
                    XmlNode tmpXmlNode = m_ObjXmlNode.SelectSingleNode("垂直对齐");
                    if (tmpXmlNode != null)
                    {
                        return (enum垂直对齐)Enum.Parse(typeof(enum垂直对齐), tmpXmlNode.InnerText);
                    }
                    else
                    {
                        return enum垂直对齐.居中;
                    }
                }
                else
                {
                    return enum垂直对齐.居中;
                }
            }
            set
            {
                if (m_ObjXmlNode != null)
                {
                    XmlNode tmpXmlNode = m_ObjXmlNode.SelectSingleNode("垂直对齐");
                    if (tmpXmlNode != null)
                    {
                        tmpXmlNode.InnerText = value.ToString();
                    }
                }
            }
        }

        private bool xml自动换行
        {
            get
            {
                if (m_ObjXmlNode!=null)
                {
                    XmlNode tmpXmlNode = m_ObjXmlNode.SelectSingleNode("自动换行");
                    if (tmpXmlNode!=null)
                    {
                        return tmpXmlNode.InnerText == "是" ? true : false;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (m_ObjXmlNode!=null)
                {
                    XmlNode tmpXmlNode = m_ObjXmlNode.SelectSingleNode("自动换行");
                    if (tmpXmlNode!=null)
                    {
                        tmpXmlNode.InnerText = (value ? "是" : "否");
                    }
                }
            }
        }
    }

    public class 公共类
    {

        protected XmlNode m_ObjXmlNode = null;
        protected XmlDocument m_ObjXmlDocument = null;
        protected string m_名称;
        protected string m_关键字;
        protected bool m_Selected = false;
        protected 颜色类 m_Obj颜色;
        protected 位置类 m_Obj位置;
        protected bool m_是否打印;


        public override string ToString()
        {
            return 名称;
            //return base.ToString();
        }

        /// <summary>
        /// 创建新的XmlNode对象，并加入到父节点objParentXmlNode对象中。
        /// </summary>
        /// <param name="objXmlDocument">根节点</param>
        /// <param name="valEnumCollectionType"></param>
        /// <param name="str名称">要创建的节点的名称属性</param>
        /// <param name="str关键字">要创建的节点的关键字属性</param>
        /// <param name="val是否打印"></param>
        /// <param name="val位置"></param>
        /// <param name="val颜色"></param>
        public 公共类(XmlDocument objXmlDocument,enumCollectionType valEnumCollectionType, string str名称, string str关键字,bool val是否打印,Rectangle val位置,Color val颜色)
        {
            m_ObjXmlDocument = objXmlDocument;

            string tmpStr="";
            switch(valEnumCollectionType)
            {
                case enumCollectionType.图形:
                    tmpStr = "图形";
                    break;
                case enumCollectionType.标签:
                    tmpStr = "标签";
                    break;
                case enumCollectionType.数据:
                    tmpStr = "数据";
                    break;
            }
            m_ObjXmlNode = ObjXmlDocument.CreateElement(tmpStr);

            XmlAttribute tmpXmlAttribute名称 = objXmlDocument.CreateAttribute("名称");
            XmlAttribute tmpXmlAttribute关键字 = objXmlDocument.CreateAttribute("关键字");

            tmpXmlAttribute名称.InnerText = str名称;
            tmpXmlAttribute关键字.InnerText = str关键字;

            ObjXmlNode.Attributes.Append(tmpXmlAttribute名称);
            ObjXmlNode.Attributes.Append(tmpXmlAttribute关键字);

            颜色类 tmpObj颜色 = new 颜色类(objXmlDocument, val颜色);
            ObjXmlNode.AppendChild(tmpObj颜色.ObjXmlNode);

            位置类 tmpObj位置 = new 位置类(objXmlDocument, val位置);
            ObjXmlNode.AppendChild(tmpObj位置.ObjXmlNode);

            m_名称 = str名称;
            m_关键字 = str关键字;
            m_是否打印 = val是否打印;
            m_Obj位置 = tmpObj位置;
            m_Obj颜色 = tmpObj颜色;
            //objParentXmlNode.AppendChild(m_ObjXmlNode);
        }

        /// <summary>
        /// 通过objXmlNode构建公共类对象
        /// </summary>
        /// <param name="objXmlDocument">根目录</param>
        /// <param name="objXmlNode">被构建的XmlNode对象</param>
        public 公共类(XmlDocument objXmlDocument, XmlNode objXmlNode)
        {
            m_ObjXmlDocument = objXmlDocument;
            m_ObjXmlNode = objXmlNode;
            m_名称 = xml名称;
            m_关键字 = xml关键字;
            m_是否打印 = xml是否打印;
            m_Obj位置 = xmlObj位置;
            m_Obj颜色 = xmlObj颜色;
        }
        public XmlNode ObjXmlNode
        {
            get
            {
                return m_ObjXmlNode;
            }
            //set
            //{
            //    m_ObjXmlNode = value;
            //}
        }
        public XmlDocument ObjXmlDocument
        {
            get
            {
                return m_ObjXmlDocument;
            }
        }

        public string 名称
        {
            set
            {
                m_名称 = value;
                xml名称 = m_名称;
            }
            get
            {
                return m_名称;
            }
        }
        public string 关键字
        {
            set
            {
                m_关键字 = value;
                xml关键字 = m_关键字;
            }
            get
            {
                return m_关键字;
            }
        }
        public bool Selected
        {
            set
            {
                m_Selected = value;
            }
            get
            {
                return m_Selected;
            }
        }
        public bool 是否打印
        {
            get
            {
                return m_是否打印;
            }
            set
            {
                m_是否打印 = value;
                xml是否打印 = m_是否打印;
            }
        }
        public 颜色类 Obj颜色
        {
            get
            {
                return m_Obj颜色;
            }
        }
        public 位置类 Obj位置
        {
            get
            {
                return m_Obj位置;
            }
        }

        private string xml名称
        {
            get
            {
                XmlAttribute tmpXmlAttribute = m_ObjXmlNode.Attributes["名称"];
                if (tmpXmlAttribute != null)
                {
                    return tmpXmlAttribute.Value;
                }
                else
                {
                    return "";
                }
            }
            set
            {
                XmlAttribute tmpXmlAttribute = m_ObjXmlNode.Attributes["名称"];
                if (tmpXmlAttribute != null)
                {
                    tmpXmlAttribute.Value = value;
                }
            }
        }
        private string xml关键字
        {
            get
            {
                XmlAttribute tmpXmlAttribute = m_ObjXmlNode.Attributes["关键字"];
                if (tmpXmlAttribute != null)
                {
                    return tmpXmlAttribute.Value;
                }
                else
                {
                    return "";
                }
            }
            set
            {
                XmlAttribute tmpXmlAttribute = m_ObjXmlNode.Attributes["关键字"];
                if (tmpXmlAttribute != null)
                {
                    tmpXmlAttribute.Value = value;
                }
            }
        }
        private bool xml是否打印
        {
            get
            {
                XmlNode tmpXmlNode;
                tmpXmlNode = m_ObjXmlNode.SelectSingleNode("是否打印");
                if (tmpXmlNode != null)
                {
                    if (tmpXmlNode.InnerText == "是")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            set
            {
                XmlNode tmpXmlNode;
                tmpXmlNode = m_ObjXmlNode.SelectSingleNode("是否打印");
                if (tmpXmlNode != null)
                {
                    tmpXmlNode.InnerText = value ? "是" : "否";
                }
                else
                {
                    tmpXmlNode = ObjXmlDocument.CreateElement("是否打印");
                    tmpXmlNode.InnerText = value ? "是" : "否";
                    ObjXmlNode.AppendChild(tmpXmlNode);

                }
            }
        }
        private 颜色类 xmlObj颜色
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("颜色");
                颜色类 tmpObj颜色 = new 颜色类(tmpXmlNode);
                return tmpObj颜色;
            }
        }
        private 位置类 xmlObj位置
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("位置");
                位置类 tmpObj位置 = new 位置类(tmpXmlNode);
                return tmpObj位置;
            }
        }

    }

    public class 公共方法
    {
        public static void DrawSlectedRectyangle(Graphics g,Rectangle r)
        {
            float i = 1.0f;
            Pen tmpPen = new Pen(Color.DarkGray);
            tmpPen.Width = 1.0f;
            tmpPen.DashCap = DashCap.Flat;
            tmpPen.DashPattern = new float[] { 0.2f, 0.3f, 0.2f, 0.3f };
            g.DrawRectangle(tmpPen, r.X - i, r.Y - i,r.Width + i * 2, r.Height + i * 2);
            tmpPen.Dispose();
        }
    }

    public class 图形 : 公共类
    {
        protected int m_粗细;
        protected DashStyle m_样式;
        protected enumShapeType m_类型;

        public 图形(XmlDocument valObjXmlDocument, string val名称, string val关键字, Rectangle val位置,bool val是否打印, int val粗细, DashStyle val线条样式, enumShapeType val类型, Color val颜色)
            : base(valObjXmlDocument,enumCollectionType.图形, val名称, val关键字,val是否打印,val位置,val颜色)
        {
            XmlNode tmpXmlNode;

            tmpXmlNode = valObjXmlDocument.CreateElement("是否打印");
            tmpXmlNode.InnerText = val是否打印 ? "是" : "否";
            ObjXmlNode.AppendChild(tmpXmlNode);

            tmpXmlNode = valObjXmlDocument.CreateElement("粗细");
            tmpXmlNode.InnerText = val粗细.ToString();
            ObjXmlNode.AppendChild(tmpXmlNode);

            tmpXmlNode = valObjXmlDocument.CreateElement("样式");
            tmpXmlNode.InnerXml = val线条样式.ToString();
            ObjXmlNode.AppendChild(tmpXmlNode);

            XmlAttribute tmpXmlAttribute = valObjXmlDocument.CreateAttribute("类型");
            tmpXmlAttribute.Value = val类型.ToString();
            ObjXmlNode.Attributes.Append(tmpXmlAttribute);

            m_粗细 = val粗细;
            m_样式 = val线条样式;
            m_类型 = val类型;
        }
        public 图形(XmlDocument objXmlDocument, XmlNode objXmlNode)
            : base(objXmlDocument, objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
            m_粗细 = xml粗细;
            m_样式 = xml样式;
            m_类型 = xml类型;
            //m_Selected = false;
        }

        public int 粗细
        {
            set
            {
                m_粗细 = value;
                xml粗细 = m_粗细;
            }
            get
            {
                return m_粗细;
            }
        }
        public DashStyle 样式
        {
            set
            {
                m_样式 = value;
                xml样式 = m_样式;
            }
            get
            {
                return m_样式;
            }
        }
        public enumShapeType 类型
        {
            set
            {
                m_类型 = value;
                xml类型 = m_类型;
            }
            get
            {
                return m_类型;
            }
        }

        private int xml粗细
        {
            get
            {
                XmlNode tmpXmlNode;
                tmpXmlNode = m_ObjXmlNode.SelectSingleNode("粗细");
                return tmpXmlNode != null ? Convert.ToInt32(tmpXmlNode.InnerText) : 0;
            }
            set
            {
                XmlNode tmpXmlNode;
                tmpXmlNode = m_ObjXmlNode.SelectSingleNode("粗细");
                if (tmpXmlNode != null)
                {
                    tmpXmlNode.InnerText = Convert.ToString(value);
                }
                else
                {
                    tmpXmlNode = ObjXmlDocument.CreateElement("粗细");
                    tmpXmlNode.InnerText = Convert.ToString(value);
                    ObjXmlNode.AppendChild(tmpXmlNode);
                }
                
            }
        }
        private DashStyle xml样式
        {
            get
            {
                XmlNode tmpXmlNode;
                tmpXmlNode = m_ObjXmlNode.SelectSingleNode("样式");
                return tmpXmlNode != null ? (DashStyle)Enum.Parse(typeof(DashStyle), tmpXmlNode.InnerText) : DashStyle.Solid;
            }
            set
            {
                XmlNode tmpXmlNode;
                tmpXmlNode = m_ObjXmlNode.SelectSingleNode("样式");
                if (tmpXmlNode != null)
                {
                    tmpXmlNode.InnerText = value.ToString();
                }
            }
        }
        private enumShapeType xml类型
        {
            get
            {
                XmlAttribute tmpXmlAttribute = m_ObjXmlNode.Attributes["类型"];
                if (tmpXmlAttribute != null)
                {
                    try
                    {
                        return (enumShapeType)Enum.Parse(typeof(enumShapeType), tmpXmlAttribute.Value);
                    }
                    catch
                    {
                        return (enumShapeType)Enum.Parse(typeof(enumShapeType), "直线");
                    }
                }
                else
                {
                    return (enumShapeType)Enum.Parse(typeof(enumShapeType), "直线");
                }
            }
            set
            {
                XmlAttribute tmpXmlAttribute = m_ObjXmlNode.Attributes["类型"];
                if (tmpXmlAttribute != null)
                {
                    tmpXmlAttribute.Value = value.ToString();
                }
            }
        }
        //属性 是否选择，如果选择，就依据相应的矩形绘制虚线。
        public void 绘制(Graphics g,bool val允许绘制阴影)
        {
            Pen tmpPen=new Pen(m_Obj颜色.颜色,粗细);
            tmpPen.DashStyle=样式;
            switch (m_类型)
            {
                case enumShapeType.矩形:
                    g.DrawRectangle(tmpPen,m_Obj位置.位置);
                    break;
                case enumShapeType.椭圆:
                    g.DrawEllipse(tmpPen, m_Obj位置.位置);
                    break;
                case enumShapeType.直线:
                    g.DrawLine(tmpPen,m_Obj位置.位置.X,m_Obj位置.位置.Y,m_Obj位置.位置.Right,m_Obj位置.位置.Bottom);
                    break;
            }
            tmpPen.Dispose();

            //如果已选择，就绘制虚线。
            if (val允许绘制阴影)
            {
                if (Selected)
                {
                    公共方法.DrawSlectedRectyangle(g, m_Obj位置.位置);
                }
            }
        }
    }

    public class 标签 : 公共类
    {
        //public override string ToString()
        //{
        //    return 名称;
        //    //return base.ToString();
        //}
        protected string m_文本;
        protected 对齐类 m_Obj对齐;
        protected 字体类 m_Obj字体;

        //构造 标签 的构造函数
        public 标签(XmlDocument valObjXmlDocument, string val名称, string val关键字,bool val是否打印, string val文本, Rectangle val位置, Font val字体, enum水平对齐 val水平对齐, enum垂直对齐 val垂直对齐, bool val自动换行, Color val颜色)
            : base(valObjXmlDocument,enumCollectionType.标签, val名称, val关键字,val是否打印,val位置,val颜色)
        {
            XmlNode tmpXmlNode;

            tmpXmlNode = valObjXmlDocument.CreateElement("是否打印");
            tmpXmlNode.InnerText = val是否打印 ? "是" : "否";
            ObjXmlNode.AppendChild(tmpXmlNode);


            tmpXmlNode = valObjXmlDocument.CreateElement("文本");
            tmpXmlNode.InnerText = val文本;
            ObjXmlNode.AppendChild(tmpXmlNode);

            字体类 tmpObj字体=new 字体类(valObjXmlDocument,val字体);
            ObjXmlNode.AppendChild(tmpObj字体.ObjXmlNode);

            对齐类 tmpObj对齐=new 对齐类(valObjXmlDocument,val水平对齐,val垂直对齐,val自动换行);
            ObjXmlNode.AppendChild(tmpObj对齐.ObjXmlNode);

            m_是否打印 = val是否打印;
            m_文本 = val文本;
            m_Obj对齐 = tmpObj对齐;
            m_Obj字体 = tmpObj字体;
        }
        
        //构造 数据 的构造函数
        public 标签(XmlDocument valObjXmlDocument, string val名称, string val关键字, bool val是否打印, Rectangle val位置, Font val字体, enum水平对齐 val水平对齐, enum垂直对齐 val垂直对齐, bool val自动换行, Color val颜色)
            : base(valObjXmlDocument, enumCollectionType.数据, val名称, val关键字, val是否打印, val位置, val颜色)
        {
            XmlNode tmpXmlNode;

            tmpXmlNode = valObjXmlDocument.CreateElement("是否打印");
            tmpXmlNode.InnerText = val是否打印 ? "是" : "否";
            ObjXmlNode.AppendChild(tmpXmlNode);

            字体类 tmpObj字体 = new 字体类(valObjXmlDocument, val字体);
            ObjXmlNode.AppendChild(tmpObj字体.ObjXmlNode);

            对齐类 tmpObj对齐 = new 对齐类(valObjXmlDocument, val水平对齐, val垂直对齐, val自动换行);
            ObjXmlNode.AppendChild(tmpObj对齐.ObjXmlNode);

            m_是否打印 = val是否打印;
            m_Obj对齐 = tmpObj对齐;
            m_Obj字体 = tmpObj字体;
        }
        
        public 标签(XmlDocument objXmlDocument, XmlNode objXmlNode)
            : base(objXmlDocument, objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
            m_文本 = xml文本;
            m_Obj对齐 = xmlObj对齐;
            m_Obj字体 = xmlObj字体;
        }
        

        public string 文本
        {
            set
            {
                m_文本 = value;
                xml文本 = m_文本;
            }
            get
            {
                return m_文本;
            }
        }
        public 对齐类 Obj对齐
        {
            get
            {
                return m_Obj对齐;
            }
        }
        public 字体类 Obj字体
        {
            get
            {
                return m_Obj字体;
            }
        }

        private string xml文本
        {
            get
            {
                XmlNode tmpXmlNode;
                tmpXmlNode = m_ObjXmlNode.SelectSingleNode("文本");
                return tmpXmlNode == null ? "" : tmpXmlNode.InnerText;
            }
            set
            {
                XmlNode tmpXmlNode;
                tmpXmlNode = m_ObjXmlNode.SelectSingleNode("文本");
                if (tmpXmlNode != null)
                    tmpXmlNode.InnerText = value;
            }
        }
        private 对齐类 xmlObj对齐
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("对齐");
                对齐类 tmpObj对齐 = new 对齐类(tmpXmlNode);
                return tmpObj对齐;
            }
        }
        private 字体类 xmlObj字体
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("字体");
                字体类 tmpObj字体 = new 字体类(tmpXmlNode);
                return tmpObj字体;
            }
        }

        public void 绘制(Graphics g,bool val显示为名称, bool val允许绘制阴影)
        {
            SolidBrush tmpSolidBrush=new SolidBrush(Obj颜色.颜色);
            StringFormat tmpStringFormat;

            if (Obj对齐.自动换行)
            {
                tmpStringFormat = new StringFormat();
            }
            else
            {
                tmpStringFormat = new StringFormat(StringFormatFlags.NoWrap);
            }
            tmpStringFormat.LineAlignment = (StringAlignment)Obj对齐.垂直对齐;
            tmpStringFormat.Alignment = (StringAlignment) Obj对齐.水平对齐;

            Font tmpObjFont =new Font(Obj字体.字体.Name,Obj字体.字体.Size / 5,Obj字体.字体.Style);
            if (val显示为名称)
            {
                g.DrawString(名称, tmpObjFont, tmpSolidBrush, Obj位置.位置, tmpStringFormat);
            }
            else
            {
                g.DrawString(文本, tmpObjFont, tmpSolidBrush, Obj位置.位置, tmpStringFormat);
            }
            
            tmpObjFont.Dispose();
            tmpSolidBrush.Dispose();
            tmpStringFormat.Dispose();

            //如果已选择，就绘制虚线。
            if (val允许绘制阴影)
            {
                if (Selected)
                {
                    公共方法.DrawSlectedRectyangle(g, Obj位置.位置);
                }
            }
       }
    }

    public class 数据 : 标签
    {

        public 数据(XmlDocument valObjXmlDocument, string val名称, string val关键字,
            bool val是否打印, Rectangle val位置, Color val颜色, Font val字体, enum水平对齐 val水平对齐, enum垂直对齐 val垂直对齐, bool val自动换行, enum数据来源类型 val数据来源类型)
            : base(valObjXmlDocument,val名称, val关键字,val是否打印,val位置,val字体,val水平对齐,val垂直对齐,val自动换行,val颜色)
        {

            数据来源类 tmpObj数据来源 = new 数据来源类(valObjXmlDocument, val数据来源类型);
            ObjXmlNode.AppendChild(tmpObj数据来源.ObjXmlNode);

            m_Obj数据来源 = tmpObj数据来源;
        }
        public 数据(XmlDocument objXmlDocument, XmlNode objXmlNode)
            : base(objXmlDocument, objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
            m_Obj数据来源 = xmlObj数据来源;
        }

        protected string m_值="";
        protected 数据来源类 m_Obj数据来源;
        
        public string 值
        {
            get
            {
                return m_值;
            }
            set
            {
                m_值 = value;
            }
        }
        public 数据来源类 Obj数据来源
        {
            get
            {
                return m_Obj数据来源;
            }
        }

        private 数据来源类 xmlObj数据来源
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("数据来源");
                数据来源类 tmpObj数据来源=new 数据来源类(tmpXmlNode);
                return tmpObj数据来源;
            }
        }

        public new void 绘制(Graphics g,bool val显示为名称, bool val允许绘制阴影)
        {
            SolidBrush tmpSolidBrush = new SolidBrush(base.Obj颜色.颜色);
            StringFormat tmpStringFormat;

            if (Obj对齐.自动换行)
            {
                tmpStringFormat = new StringFormat();
            }
            else
            {
                tmpStringFormat = new StringFormat(StringFormatFlags.NoWrap);
            }
            tmpStringFormat.LineAlignment = (StringAlignment)Obj对齐.垂直对齐;
            tmpStringFormat.Alignment = (StringAlignment)Obj对齐.水平对齐;

            Font tmpObjFont = new Font(Obj字体.字体.Name, Obj字体.字体.Size / 5, Obj字体.字体.Style);
            if (val显示为名称)
            {
                g.DrawString(名称, tmpObjFont, tmpSolidBrush, Obj位置.位置, tmpStringFormat);
            }
            else
            {
                g.DrawString(m_值, tmpObjFont, tmpSolidBrush, Obj位置.位置, tmpStringFormat);
            }

            tmpObjFont.Dispose();
            tmpSolidBrush.Dispose();
            tmpStringFormat.Dispose();

            //如果已选择，就绘制虚线。
            if (val允许绘制阴影)
            {
                if (Selected)
                {
                     公共方法.DrawSlectedRectyangle(g, Obj位置.位置);
                }
            }
        }
    }

    public class 数据来源类
    {
        protected XmlNode m_ObjXmlNode = null;
        protected ArrayList m_Obj数据开源集合 = new ArrayList();
        protected enum数据来源类型 m_数据来源类型;

        public 数据来源类(XmlDocument valObjXmlDocument,enum数据来源类型 val数据来源类型)
        {
            XmlNode tmpXmlNode;
            XmlAttribute tmpXmlAttribute;

            tmpXmlNode = valObjXmlDocument.CreateElement("数据来源");
            tmpXmlAttribute = valObjXmlDocument.CreateAttribute("数据来源类型");
            tmpXmlAttribute.Value = val数据来源类型.ToString();
            tmpXmlNode.Attributes.Append(tmpXmlAttribute);

            m_ObjXmlNode = tmpXmlNode;
            m_数据来源类型 = val数据来源类型;
        }
        public 数据来源类(XmlNode objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
            MakeObj数据开源集合(ObjXmlNode);
            m_数据来源类型 = xml数据来源类型;
        }
        private void MakeObj数据开源集合(XmlNode objXmlNode)
        {
            XmlNode tmpXmlNode;
            tmpXmlNode = objXmlNode.FirstChild;
            if (tmpXmlNode != null)
            {
                Obj数据开源集合.Add(new 值类(tmpXmlNode));
                while (tmpXmlNode.NextSibling != null)
                {
                    tmpXmlNode = tmpXmlNode.NextSibling;
                    Obj数据开源集合.Add(new 值类(tmpXmlNode));
                }
            }
        }
        public XmlNode ObjXmlNode
        {
            get
            {
                return m_ObjXmlNode;
            }
            //set
            //{
            //    m_ObjXmlNode = value;
            //}
        }

        public enum数据来源类型 数据来源类型
        {
            set
            {
                m_数据来源类型 = value;
                xml数据来源类型 = m_数据来源类型;
            }
            get
            {
                return m_数据来源类型;
            }
        }
        private enum数据来源类型 xml数据来源类型
        {
            get
            {
                XmlAttribute tmpXmlAttribute = m_ObjXmlNode.Attributes["数据来源类型"];
                if (tmpXmlAttribute != null)
                {
                    try
                    {
                        return (enum数据来源类型)Enum.Parse(typeof(enum数据来源类型), tmpXmlAttribute.Value);
                    }
                    catch
                    {
                        return (enum数据来源类型)Enum.Parse(typeof(enum数据来源类型), "文本");
                    }
                }
                else
                {
                    return (enum数据来源类型)Enum.Parse(typeof(enum数据来源类型), "文本");
                }
            }
            set
            {
                XmlAttribute tmpXmlAttribute = m_ObjXmlNode.Attributes["数据来源类型"];
                if (tmpXmlAttribute != null)
                {
                    tmpXmlAttribute.Value = value.ToString();
                }
            }
        }
        public ArrayList Obj数据开源集合
        {
            get
            {
                return m_Obj数据开源集合;
            }
        }
        public void Remove(值类 obj值类)
        {
            ObjXmlNode.RemoveChild(obj值类.ObjXmlNode);
            Obj数据开源集合.Remove(obj值类);
        }
        public void Add(值类 obj值类)
        {
            ObjXmlNode.AppendChild(obj值类.ObjXmlNode);
            Obj数据开源集合.Add(obj值类);
        }
    }

    public class 值类
    {
        protected XmlNode m_ObjXmlNode = null;
        protected string m_ID;
        protected string m_值;

        public 值类(XmlDocument valObjXmlDocument,string valID, string val文本)
        {
            XmlNode tmpXmlNode;
            XmlAttribute tmpXmlAttribute;

            tmpXmlNode = valObjXmlDocument.CreateElement("值");
            tmpXmlNode.InnerText = val文本;
            tmpXmlAttribute = valObjXmlDocument.CreateAttribute("ID");
            tmpXmlAttribute.Value = valID;
            tmpXmlNode.Attributes.Append(tmpXmlAttribute);

            m_ObjXmlNode = tmpXmlNode;

            m_ID = valID;
            m_值 = val文本;
        }
        public 值类(XmlNode objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
            m_ID = xmlID;
            m_值 = xml值;
        }
        public XmlNode ObjXmlNode
        {
            get
            {
                return m_ObjXmlNode;
            }
            //set
            //{
            //    m_ObjXmlNode = value;
            //}
        }

        public string ID
        {
            set
            {
                m_ID = value;
                xmlID = m_ID;
            }
            get
            {
                return m_ID;
            }
        }
        public string 值
        {
            set
            {
                m_值 = value;
                xml值 = m_值;
            }
            get
            {
                return m_值;
            }
        }

        private string xmlID
        {
            get
            {
                XmlAttribute tmpXmlAttribute = ObjXmlNode.Attributes["ID"];
                if (tmpXmlAttribute != null)
                {
                    return tmpXmlAttribute.Value;
                }
                else
                {
                    return "";
                }
            }
            set
            {
                XmlAttribute tmpXmlAttribute = ObjXmlNode.Attributes["ID"];
                if (tmpXmlAttribute != null)
                {
                    tmpXmlAttribute.Value = value;
                }
            }
        }
        private string xml值
        {
            get
            {
                return ObjXmlNode.InnerText;
            }
            set
            {
                ObjXmlNode.InnerText = value;
            }
        }
    }

    public class 内容
    {
        public event PageSettingsChangedHandle PagesettingChanged;
        public event ArrayListChangedHandle ArrayList图形Changed;
        public event ArrayListChangedHandle ArrayList标签Changed;
        public event ArrayListChangedHandle ArrayList数据Changed;
        
        private XmlDocument xmlD = new XmlDocument();
        private string m_DataPath = "";
        
        protected 页面设置 m_Obj页面设置 = null;
        protected ArrayList m_ObjArrayList图形 = null;
        protected ArrayList m_ObjArrayList标签 = null;
        protected ArrayList m_ObjArrayList数据 = null;

        public XmlDocument XmlDocument
        {
            get
            {
                return xmlD;
            }
        }

        public 页面设置 Obj页面设置
        {
            get
            {
                return m_Obj页面设置;
            }
            set
            {
                m_Obj页面设置 = value;
                PagesettingChanged();
            }
        }

        public string DataPath
        {
            get
            {
                return m_DataPath;
            }
            set
            {
                m_DataPath = value;
            }
        }

        public void LoadData()
        {
            if (DataPath!="")
            {
                xmlD.Load(DataPath);

                XmlNode tmpXmlNode = xmlD.SelectSingleNode("//页面设置");
                if (tmpXmlNode != null)
                {
                    Obj页面设置 = new 页面设置(tmpXmlNode);
                }

                tmpXmlNode = xmlD.SelectSingleNode("//图形集合");
                if (tmpXmlNode!=null)
                {
                    m_ObjArrayList图形 = CreateArrayList图形(tmpXmlNode);
                    if (ArrayList图形Changed!=null)
                    {
                        ArrayList图形Changed();
                    }
                }

                tmpXmlNode = xmlD.SelectSingleNode("//标签集合");
                if (tmpXmlNode != null)
                {
                    m_ObjArrayList标签 = CreateArrayList标签(tmpXmlNode);
                    if (ArrayList标签Changed != null)
                    {
                        ArrayList标签Changed();
                    }
                }

                tmpXmlNode = xmlD.SelectSingleNode("//数据集合");
                if (tmpXmlNode != null)
                {
                    m_ObjArrayList数据 = CreateArrayList数据(tmpXmlNode);
                    if (ArrayList数据Changed!=null)
                    {
                        ArrayList数据Changed();
                    }
                }
            }
        }

        #region 图形集合

        public ArrayList ObjArrayList图形
        {
            get
            {
                return m_ObjArrayList图形;
            }
            set
            {
                m_ObjArrayList图形 = value;
            }
        }

        private ArrayList CreateArrayList图形(XmlNode objXmlNode)
        {
            XmlNode tmpXmlN;
            ArrayList myArryList = null;
            if (objXmlNode != null)
            {
                myArryList = new ArrayList();
                tmpXmlN = objXmlNode.FirstChild;
                if (tmpXmlN != null)
                {
                    myArryList.Add(new 图形(xmlD, tmpXmlN));
                    while (tmpXmlN.NextSibling != null)
                    {
                        tmpXmlN = tmpXmlN.NextSibling;
                        myArryList.Add(new 图形(xmlD, tmpXmlN));
                    }
                }
            }
            return myArryList;
        }

        public void RemoveFromArrayList图形(图形 valObj图形)
        {
            if (valObj图形 != null)
            {
                valObj图形.ObjXmlNode.ParentNode.RemoveChild(valObj图形.ObjXmlNode);
                ObjArrayList图形.Remove(valObj图形);
                if (ArrayList图形Changed!=null)
                {
                    ArrayList图形Changed();
                }
            }
        }

        public void AddToArrayList图形(图形 valObj图形)
        {
            if (valObj图形 != null)
            {
                XmlNode tmpXmlNode = xmlD.SelectSingleNode("//图形集合");
                tmpXmlNode.AppendChild(valObj图形.ObjXmlNode);
                ObjArrayList图形.Add(valObj图形);
                if (ArrayList图形Changed!=null)
                {
                    ArrayList图形Changed();
                }
            }
        }

        #endregion

        #region 标签集合

        public ArrayList ObjArrayList标签
        {
            get
            {
                return m_ObjArrayList标签;
            }
            set
            {
                m_ObjArrayList标签 = value;
            }
        }

        private ArrayList CreateArrayList标签(XmlNode objXmlNode)
        {
            XmlNode tmpXmlN;
            ArrayList myArryList = null;
            if (objXmlNode != null)
            {
                myArryList = new ArrayList();
                tmpXmlN = objXmlNode.FirstChild;
                if (tmpXmlN != null)
                {
                    myArryList.Add(new 标签(xmlD, tmpXmlN));
                    while (tmpXmlN.NextSibling != null)
                    {
                        tmpXmlN = tmpXmlN.NextSibling;
                        myArryList.Add(new 标签(xmlD, tmpXmlN));
                    }
                }
            }
            return myArryList;
        }

        public void RemoveFromArrayList标签(标签 valObj标签)
        {
            if (valObj标签 != null)
            {
                valObj标签.ObjXmlNode.ParentNode.RemoveChild(valObj标签.ObjXmlNode);
                ObjArrayList标签.Remove(valObj标签);
                if (ArrayList标签Changed!=null)
                {
                    ArrayList标签Changed();
                }
            }
        }

        public void AddToArrayList标签(标签 valObj标签)
        {
            if (valObj标签 != null)
            {
                XmlNode tmpXmlNode = xmlD.SelectSingleNode("//标签集合");
                tmpXmlNode.AppendChild(valObj标签.ObjXmlNode);
                ObjArrayList标签.Add(valObj标签);
                if (ArrayList标签Changed != null)
                {
                    ArrayList标签Changed();
                }
            }
        }

        #endregion

        #region 数据集合

        public ArrayList ObjArrayList数据
        {
            get
            {
                return m_ObjArrayList数据;
            }
            set
            {
                m_ObjArrayList数据 = value;
            }
        }

        private ArrayList CreateArrayList数据(XmlNode objXmlNode)
        {
            XmlNode tmpXmlN;
            ArrayList myArryList = null;
            if (objXmlNode != null)
            {
                myArryList = new ArrayList();
                tmpXmlN = objXmlNode.FirstChild;
                if (tmpXmlN != null)
                {
                    myArryList.Add(new 数据(xmlD, tmpXmlN));
                    while (tmpXmlN.NextSibling != null)
                    {
                        tmpXmlN = tmpXmlN.NextSibling;
                        myArryList.Add(new 数据(xmlD, tmpXmlN));
                    }
                }
            }
            return myArryList;
        }

        public void RemoveFromArrayList数据(数据 valObj数据)
        {
            if (valObj数据 != null)
            {
                valObj数据.ObjXmlNode.ParentNode.RemoveChild(valObj数据.ObjXmlNode);
                ObjArrayList数据.Remove(valObj数据);
                if (ArrayList数据Changed!=null)
                {
                    ArrayList数据Changed();
                }
            }
        }

        public void AddToArrayList数据(数据 valObj数据)
        {
            if (valObj数据 != null)
            {
                XmlNode tmpXmlNode = xmlD.SelectSingleNode("//数据集合");
                tmpXmlNode.AppendChild(valObj数据.ObjXmlNode);
                ObjArrayList数据.Add(valObj数据);
                if (ArrayList数据Changed != null)
                {
                    ArrayList数据Changed();
                }
            }
        }

        #endregion

        public void Save()
        {
            if (DataPath!=null)
            {
                xmlD.Save(DataPath);
            }
        }

        public void SaveAs(string valPath)
        {
            if (valPath!=null)
            {
                xmlD.Save(valPath);
            }
        }
    }
}
