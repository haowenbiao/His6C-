using System;
using System.Collections.Generic;
using System.Xml;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;

namespace CustomerPrint
{
    enum enumShapeType
    {
        直线=0,
        矩形,
        椭圆
    }
    enum enum数据来源类型 
    {
        文本=0,
        数值
    }

    class MyListObj:Object
    {
        string m_objKey, m_objName;
        public override string ToString()
        {
            //return base.ToString();
            return m_objName;
        }
        public MyListObj(string tmpName,string tmpKey)
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
    class 位置类
    {
        protected XmlNode m_ObjXmlNode = null;

        /// <summary>
        /// 新建位置类，并把其中生成的XmlNode对象加入到父节点objAddToXmlNode
        /// </summary>
        /// <param name="xmlDocument">用于创建节点的根节点</param>
        /// <param name="valRectangle"></param>
        public 位置类(XmlDocument xmlDocument,Rectangle valRectangle)
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
        
        /// <summary>
        /// 获取或设置位置
        /// </summary>
        public Rectangle 位置
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
    }
    class 颜色类
    {
        protected XmlNode m_ObjXmlNode = null;

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

        /// <summary>
        /// 获取或设置颜色
        /// </summary>
        public Color 颜色
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
    class 字体类
    {
        protected XmlNode m_ObjXmlNode = null;

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
            tmp粗体.InnerText = valFont.Bold ? "是": "否";
            tmp斜体.InnerText = valFont.Italic ? "是" : "否";
            tmp下划线.InnerText = valFont.Underline ? "是" : "否";
            tmp删除线.InnerText = valFont.Strikeout ? "是" : "否";

            m_ObjXmlNode.AppendChild(tmp字体);
            m_ObjXmlNode.AppendChild(tmp大小);
            m_ObjXmlNode.AppendChild(tmp粗体);
            m_ObjXmlNode.AppendChild(tmp斜体);
            m_ObjXmlNode.AppendChild(tmp下划线);
            m_ObjXmlNode.AppendChild(tmp删除线);

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

        /// <summary>
        /// 获取或设置字体
        /// </summary>
        public Font 字体
        {
            set
            {
                if (ObjXmlNode != null)
                {
                    ObjXmlNode.SelectSingleNode("字体").InnerText = Convert.ToString(value.Name);
                    ObjXmlNode.SelectSingleNode("大小").InnerText = Convert.ToString(value.Size);
                    ObjXmlNode.SelectSingleNode("粗体").InnerText = value.Bold ? "是" : "否";
                    ObjXmlNode.SelectSingleNode("斜体").InnerText = value.Italic ? "是" : "否";
                    ObjXmlNode.SelectSingleNode("下划线").InnerText = value.Underline ? "是" : "否";
                    ObjXmlNode.SelectSingleNode("删除线").InnerText = value.Strikeout ? "是" : "否";
                }
            }
            get
            {
                FontStyle tmpFontStyle = FontStyle.Regular;
                if (ObjXmlNode != null)
                {
                    string 字体名称 = ObjXmlNode.SelectSingleNode("字体").InnerText;
                    float 大小 = Convert.ToInt32(ObjXmlNode.SelectSingleNode("大小").InnerText);
                    bool 粗体 = ObjXmlNode.SelectSingleNode("粗体").InnerText == "是" ? true : false;
                    bool 斜体 = ObjXmlNode.SelectSingleNode("斜体").InnerText == "是" ? true : false;
                    bool 下划线 = ObjXmlNode.SelectSingleNode("下划线").InnerText == "是" ? true : false;
                    bool 删除线 = ObjXmlNode.SelectSingleNode("删除线").InnerText == "是" ? true : false;
                    
                    if (粗体) tmpFontStyle = tmpFontStyle | FontStyle.Bold;
                    if (斜体) tmpFontStyle = tmpFontStyle | FontStyle.Bold;
                    if (下划线) tmpFontStyle = tmpFontStyle | FontStyle.Bold;
                    if (删除线) tmpFontStyle = tmpFontStyle | FontStyle.Bold;

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
    class 公共类 
    {
        protected XmlNode m_ObjXmlNode = null;
        protected XmlDocument m_ObjXmlDocument = null;

        public override string ToString()
        {
            return 名称;
            //return base.ToString();
        }

        /// <summary>
        /// 创建新的XmlNode对象，并加入到父节点objParentXmlNode对象中。
        /// </summary>
        /// <param name="objXmlDocument">根节点</param>
        /// <param name="str名称">要创建的节点的名称属性</param>
        /// <param name="str关键字">要创建的节点的关键字属性</param>
        public 公共类(XmlDocument objXmlDocument, string str名称,string str关键字) 
        {
            m_ObjXmlDocument = objXmlDocument;

            m_ObjXmlNode = ObjXmlDocument.CreateElement("图形");

            XmlAttribute tmpXmlAttribute名称 = objXmlDocument.CreateAttribute("名称");
            XmlAttribute tmpXmlAttribute关键字 = objXmlDocument.CreateAttribute("关键字");

            tmpXmlAttribute名称.InnerText = str名称;
            tmpXmlAttribute关键字.InnerText = str关键字;

            ObjXmlNode.Attributes.Append(tmpXmlAttribute名称);
            ObjXmlNode.Attributes.Append(tmpXmlAttribute关键字);

            //objParentXmlNode.AppendChild(m_ObjXmlNode);
        }

        /// <summary>
        /// 通过objXmlNode构建公共类对象
        /// </summary>
        /// <param name="objXmlDocument">根目录</param>
        /// <param name="objXmlNode">被构建的XmlNode对象</param>
        public 公共类(XmlDocument objXmlDocument , XmlNode objXmlNode)
        {
            m_ObjXmlDocument = objXmlDocument;
            m_ObjXmlNode = objXmlNode;
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
        public string 关键字
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
    }
    class 图形 : 公共类
    {
        public 图形(XmlDocument valObjXmlDocument, string val名称,string val关键字,Rectangle val位置, int val粗细,DashStyle val线条样式,enumShapeType val类型,Color val颜色)
            : base(valObjXmlDocument, val名称, val关键字)
        {
            XmlNode tmpXmlNode;
            tmpXmlNode = valObjXmlDocument.CreateElement("粗细");
            tmpXmlNode.InnerText = val粗细.ToString();
            ObjXmlNode.AppendChild(tmpXmlNode);

            tmpXmlNode = valObjXmlDocument.CreateElement("样式");
            tmpXmlNode.InnerXml = val线条样式.ToString();
            ObjXmlNode.AppendChild(tmpXmlNode);

            XmlAttribute tmpXmlAttribute = valObjXmlDocument.CreateAttribute("类型");
            tmpXmlAttribute.Value = val类型.ToString();
            ObjXmlNode.Attributes.Append(tmpXmlAttribute);

            颜色类 tmpObj颜色 = new 颜色类(valObjXmlDocument, val颜色);
            ObjXmlNode.AppendChild(tmpObj颜色.ObjXmlNode);

            位置类 tmpObj位置 = new 位置类(valObjXmlDocument, val位置);
            ObjXmlNode.AppendChild(tmpObj位置.ObjXmlNode);

        }
        public 图形(XmlDocument objXmlDocument, XmlNode objXmlNode)
            : base(objXmlDocument,objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
        }
        public int 粗细
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
                tmpXmlNode.InnerText = Convert.ToString(value);
            }
        }
        public DashStyle 样式
        {
            get
            {
                XmlNode tmpXmlNode;
                tmpXmlNode = m_ObjXmlNode.SelectSingleNode("样式");
                return tmpXmlNode != null ? (DashStyle)Enum.Parse(typeof(DashStyle),tmpXmlNode.InnerText) : DashStyle.Solid;
            }
            set
            {
                XmlNode tmpXmlNode;
                tmpXmlNode = m_ObjXmlNode.SelectSingleNode("样式");
                if (tmpXmlNode!=null)
                {
                    tmpXmlNode.InnerText = value.ToString();
                }
            }
        }
        public enumShapeType 类型
        {
            get
            {
                XmlAttribute tmpXmlAttribute = m_ObjXmlNode.Attributes["类型"];
                if (tmpXmlAttribute!=null)
                {
                    try
                    {
                        return (enumShapeType) Enum.Parse(typeof (enumShapeType), tmpXmlAttribute.Value);
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
                if (tmpXmlAttribute!=null)
                {
                    tmpXmlAttribute.Value = value.ToString();
                }
            }
        }
        public 颜色类 Obj颜色
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("颜色");
                颜色类 tmpObj颜色 = new 颜色类(tmpXmlNode);
                return tmpObj颜色;
            }
        }
        public 位置类 Obj位置
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("位置");
                位置类 tmpObj位置 = new 位置类(tmpXmlNode);
                return tmpObj位置;
            }
        }
    }
    class 标签 : 公共类
    {
        public override string ToString()
        {
            return 名称;
            //return base.ToString();
        }
        public 标签(XmlDocument objXmlDocument,XmlNode objXmlNode)
            : base(objXmlDocument, objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
        }
        public string 文本
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
        public 颜色类 Obj颜色
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("颜色");
                颜色类 tmpObj颜色 = new 颜色类(tmpXmlNode);
                return tmpObj颜色;
            }
        }
        public 位置类 Obj位置
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("位置");
                位置类 tmpObj位置 = new 位置类(tmpXmlNode);
                return tmpObj位置;
            }
        }
        public 字体类 Obj字体
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("字体");
                字体类 tmpObj字体 = new 字体类(tmpXmlNode);
                return tmpObj字体;
            }
        }
    }
    class 数据标签类
    {
        protected XmlNode m_ObjXmlNode = null;
        public 数据标签类(XmlNode objXmlNode) 
        {
            m_ObjXmlNode = objXmlNode;
        }
        public XmlNode ObjXmlNode
        {
            get
            {
                return m_ObjXmlNode;
            }
            set
            {
                m_ObjXmlNode = value;
            }
        }
        public string 文本
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
        public 颜色类 Obj颜色
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("颜色");
                颜色类 tmpObj颜色 = new 颜色类(tmpXmlNode);
                return tmpObj颜色;
            }
        }
        public 位置类 Obj位置
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("位置");
                位置类 tmpObj位置 = new 位置类(tmpXmlNode);
                return tmpObj位置;
            }
        }
        public 字体类 Obj字体
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("字体");
                字体类 tmpObj字体 = new 字体类(tmpXmlNode);
                return tmpObj字体;
            }
        }
    }
    class 数据值类
    {
        protected XmlNode m_ObjXmlNode = null;
        public 数据值类(XmlNode objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
        }
        public XmlNode ObjXmlNode
        {
            get
            {
                return m_ObjXmlNode;
            }
            set
            {
                m_ObjXmlNode = value;
            }
        }
        public 颜色类 Obj颜色
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("颜色");
                颜色类 tmpObj颜色 = new 颜色类(tmpXmlNode);
                return tmpObj颜色;
            }
        }
        public 位置类 Obj位置
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("位置");
                位置类 tmpObj位置 = new 位置类(tmpXmlNode);
                return tmpObj位置;
            }
        }
        public 字体类 Obj字体
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("字体");
                字体类 tmpObj字体 = new 字体类(tmpXmlNode);
                return tmpObj字体;
            }
        }
    }
    class 数据来源类 
    { 
        protected XmlNode m_ObjXmlNode = null;
        protected ArrayList m_Obj数据开源集合=null;

        public 数据来源类(XmlNode objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
            MakeObj数据开源集合(ObjXmlNode);
        }
        private void MakeObj数据开源集合(XmlNode objXmlNode)
        {
            XmlNode tmpXmlNode;
            tmpXmlNode = objXmlNode.FirstChild;
            if (tmpXmlNode!=null)
            {
                Obj数据开源集合.Add(new 值类(tmpXmlNode));
                while (tmpXmlNode.NextSibling !=null)
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
    class 值类
    {
        protected XmlNode m_ObjXmlNode = null;
        
        public 值类(XmlNode objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
        }
        public override string ToString()
        {
            return 值;
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
        public string 值
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
    class 数据 : 公共类
    {
        public 数据(XmlDocument objXmlDocument , XmlNode objXmlNode)
            : base(objXmlDocument, objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
        }
        public 标签 数据标签
        {
            get
            {
                XmlNode tmpXmlNode;
                标签 tmp数据标签;
                tmpXmlNode = ObjXmlNode.SelectSingleNode("数据标签");
                tmp数据标签 = new 标签(m_ObjXmlDocument , tmpXmlNode);
                return tmp数据标签;
            }
        }
    }

}
