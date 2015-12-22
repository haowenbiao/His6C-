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
        ֱ��=0,
        ����,
        ��Բ
    }
    enum enum������Դ���� 
    {
        �ı�=0,
        ��ֵ
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
    class λ����
    {
        protected XmlNode m_ObjXmlNode = null;

        /// <summary>
        /// �½�λ���࣬�����������ɵ�XmlNode������뵽���ڵ�objAddToXmlNode
        /// </summary>
        /// <param name="xmlDocument">���ڴ����ڵ�ĸ��ڵ�</param>
        /// <param name="valRectangle"></param>
        public λ����(XmlDocument xmlDocument,Rectangle valRectangle)
        {
            m_ObjXmlNode = xmlDocument.CreateElement("λ��");
            
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
            
            //��������ڵ�
            //objParentXmlNode.AppendChild(m_ObjXmlNode);
        }
        
        /// <summary>
        /// ����XmlNode���󹹽�λ����
        /// </summary>
        /// <param name="objXmlNode"></param>
        public λ����(XmlNode objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
        }
        
        /// <summary>
        /// ��ȡXmlNode����
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
        /// ��ȡ������λ��
        /// </summary>
        public Rectangle λ��
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
    class ��ɫ��
    {
        protected XmlNode m_ObjXmlNode = null;

        /// <summary>
        /// �½���ɫ�࣬�����������ɵ�XmlNode������뵽���ڵ�objAddToXmlNode
        /// </summary>
        /// <param name="xmlDocument">���ڴ����ڵ�ĸ��ڵ�</param>
        /// <param name="valColor"></param>
        public ��ɫ��(XmlDocument xmlDocument, Color valColor)
        {
            m_ObjXmlNode = xmlDocument.CreateElement("��ɫ");

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
            
            //��������ڵ�
            //objParentXmlNode.AppendChild(m_ObjXmlNode);
        }

        /// <summary>
        /// ����XmlNode���󹹽���ɫ��
        /// </summary>
        /// <param name="objXmlNode"></param>
        public ��ɫ��(XmlNode objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
        }

        /// <summary>
        /// ��ȡXmlNode����
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
        /// ��ȡ��������ɫ
        /// </summary>
        public Color ��ɫ
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
    class ������
    {
        protected XmlNode m_ObjXmlNode = null;

        /// <summary>
        /// �½������࣬�����������ɵ�XmlNode������뵽���ڵ�objAddToXmlNode
        /// </summary>
        /// <param name="xmlDocument">���ڴ����ڵ�ĸ��ڵ�</param>
        /// <param name="valFont"></param>
        public ������(XmlDocument xmlDocument, Font valFont)
        {
            m_ObjXmlNode = xmlDocument.CreateElement("����");

            XmlElement tmp���� = xmlDocument.CreateElement("����");
            XmlElement tmp��С = xmlDocument.CreateElement("��С");
            XmlElement tmp���� = xmlDocument.CreateElement("����");
            XmlElement tmpб�� = xmlDocument.CreateElement("б��");
            XmlElement tmp�»��� = xmlDocument.CreateElement("�»���");
            XmlElement tmpɾ���� = xmlDocument.CreateElement("ɾ����");

            tmp����.InnerText = valFont.Name;
            tmp��С.InnerText = valFont.Size.ToString();
            tmp����.InnerText = valFont.Bold ? "��": "��";
            tmpб��.InnerText = valFont.Italic ? "��" : "��";
            tmp�»���.InnerText = valFont.Underline ? "��" : "��";
            tmpɾ����.InnerText = valFont.Strikeout ? "��" : "��";

            m_ObjXmlNode.AppendChild(tmp����);
            m_ObjXmlNode.AppendChild(tmp��С);
            m_ObjXmlNode.AppendChild(tmp����);
            m_ObjXmlNode.AppendChild(tmpб��);
            m_ObjXmlNode.AppendChild(tmp�»���);
            m_ObjXmlNode.AppendChild(tmpɾ����);

            //��������ڵ�
            //objParentXmlNode.AppendChild(m_ObjXmlNode);
        }

        /// <summary>
        /// ����XmlNode���󹹽�������
        /// </summary>
        /// <param name="objXmlNode"></param>
        public ������(XmlNode objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
        }

        /// <summary>
        /// ��ȡXmlNode����
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
        /// ��ȡ����������
        /// </summary>
        public Font ����
        {
            set
            {
                if (ObjXmlNode != null)
                {
                    ObjXmlNode.SelectSingleNode("����").InnerText = Convert.ToString(value.Name);
                    ObjXmlNode.SelectSingleNode("��С").InnerText = Convert.ToString(value.Size);
                    ObjXmlNode.SelectSingleNode("����").InnerText = value.Bold ? "��" : "��";
                    ObjXmlNode.SelectSingleNode("б��").InnerText = value.Italic ? "��" : "��";
                    ObjXmlNode.SelectSingleNode("�»���").InnerText = value.Underline ? "��" : "��";
                    ObjXmlNode.SelectSingleNode("ɾ����").InnerText = value.Strikeout ? "��" : "��";
                }
            }
            get
            {
                FontStyle tmpFontStyle = FontStyle.Regular;
                if (ObjXmlNode != null)
                {
                    string �������� = ObjXmlNode.SelectSingleNode("����").InnerText;
                    float ��С = Convert.ToInt32(ObjXmlNode.SelectSingleNode("��С").InnerText);
                    bool ���� = ObjXmlNode.SelectSingleNode("����").InnerText == "��" ? true : false;
                    bool б�� = ObjXmlNode.SelectSingleNode("б��").InnerText == "��" ? true : false;
                    bool �»��� = ObjXmlNode.SelectSingleNode("�»���").InnerText == "��" ? true : false;
                    bool ɾ���� = ObjXmlNode.SelectSingleNode("ɾ����").InnerText == "��" ? true : false;
                    
                    if (����) tmpFontStyle = tmpFontStyle | FontStyle.Bold;
                    if (б��) tmpFontStyle = tmpFontStyle | FontStyle.Bold;
                    if (�»���) tmpFontStyle = tmpFontStyle | FontStyle.Bold;
                    if (ɾ����) tmpFontStyle = tmpFontStyle | FontStyle.Bold;

                    Font tmpFont = new Font(��������, ��С, tmpFontStyle);
                    return tmpFont;
                }
                else
                {
                    return new Font("����", 10);
                }
            }
        }
    }
    class ������ 
    {
        protected XmlNode m_ObjXmlNode = null;
        protected XmlDocument m_ObjXmlDocument = null;

        public override string ToString()
        {
            return ����;
            //return base.ToString();
        }

        /// <summary>
        /// �����µ�XmlNode���󣬲����뵽���ڵ�objParentXmlNode�����С�
        /// </summary>
        /// <param name="objXmlDocument">���ڵ�</param>
        /// <param name="str����">Ҫ�����Ľڵ����������</param>
        /// <param name="str�ؼ���">Ҫ�����Ľڵ�Ĺؼ�������</param>
        public ������(XmlDocument objXmlDocument, string str����,string str�ؼ���) 
        {
            m_ObjXmlDocument = objXmlDocument;

            m_ObjXmlNode = ObjXmlDocument.CreateElement("ͼ��");

            XmlAttribute tmpXmlAttribute���� = objXmlDocument.CreateAttribute("����");
            XmlAttribute tmpXmlAttribute�ؼ��� = objXmlDocument.CreateAttribute("�ؼ���");

            tmpXmlAttribute����.InnerText = str����;
            tmpXmlAttribute�ؼ���.InnerText = str�ؼ���;

            ObjXmlNode.Attributes.Append(tmpXmlAttribute����);
            ObjXmlNode.Attributes.Append(tmpXmlAttribute�ؼ���);

            //objParentXmlNode.AppendChild(m_ObjXmlNode);
        }

        /// <summary>
        /// ͨ��objXmlNode�������������
        /// </summary>
        /// <param name="objXmlDocument">��Ŀ¼</param>
        /// <param name="objXmlNode">��������XmlNode����</param>
        public ������(XmlDocument objXmlDocument , XmlNode objXmlNode)
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
        public string ����
        {
            get
            {
                XmlAttribute tmpXmlAttribute = m_ObjXmlNode.Attributes["����"];
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
                XmlAttribute tmpXmlAttribute = m_ObjXmlNode.Attributes["����"];
                if (tmpXmlAttribute != null)
                {
                    tmpXmlAttribute.Value = value;
                }
            }
        }
        public string �ؼ���
        {
            get
            {
                XmlAttribute tmpXmlAttribute = m_ObjXmlNode.Attributes["�ؼ���"];
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
                XmlAttribute tmpXmlAttribute = m_ObjXmlNode.Attributes["�ؼ���"];
                if (tmpXmlAttribute != null)
                {
                    tmpXmlAttribute.Value = value;
                }
            }
        }
    }
    class ͼ�� : ������
    {
        public ͼ��(XmlDocument valObjXmlDocument, string val����,string val�ؼ���,Rectangle valλ��, int val��ϸ,DashStyle val������ʽ,enumShapeType val����,Color val��ɫ)
            : base(valObjXmlDocument, val����, val�ؼ���)
        {
            XmlNode tmpXmlNode;
            tmpXmlNode = valObjXmlDocument.CreateElement("��ϸ");
            tmpXmlNode.InnerText = val��ϸ.ToString();
            ObjXmlNode.AppendChild(tmpXmlNode);

            tmpXmlNode = valObjXmlDocument.CreateElement("��ʽ");
            tmpXmlNode.InnerXml = val������ʽ.ToString();
            ObjXmlNode.AppendChild(tmpXmlNode);

            XmlAttribute tmpXmlAttribute = valObjXmlDocument.CreateAttribute("����");
            tmpXmlAttribute.Value = val����.ToString();
            ObjXmlNode.Attributes.Append(tmpXmlAttribute);

            ��ɫ�� tmpObj��ɫ = new ��ɫ��(valObjXmlDocument, val��ɫ);
            ObjXmlNode.AppendChild(tmpObj��ɫ.ObjXmlNode);

            λ���� tmpObjλ�� = new λ����(valObjXmlDocument, valλ��);
            ObjXmlNode.AppendChild(tmpObjλ��.ObjXmlNode);

        }
        public ͼ��(XmlDocument objXmlDocument, XmlNode objXmlNode)
            : base(objXmlDocument,objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
        }
        public int ��ϸ
        {
            get
            {
                XmlNode tmpXmlNode;
                tmpXmlNode = m_ObjXmlNode.SelectSingleNode("��ϸ");
                return tmpXmlNode != null ? Convert.ToInt32(tmpXmlNode.InnerText) : 0;
            }
            set
            {
                XmlNode tmpXmlNode;
                tmpXmlNode = m_ObjXmlNode.SelectSingleNode("��ϸ");
                tmpXmlNode.InnerText = Convert.ToString(value);
            }
        }
        public DashStyle ��ʽ
        {
            get
            {
                XmlNode tmpXmlNode;
                tmpXmlNode = m_ObjXmlNode.SelectSingleNode("��ʽ");
                return tmpXmlNode != null ? (DashStyle)Enum.Parse(typeof(DashStyle),tmpXmlNode.InnerText) : DashStyle.Solid;
            }
            set
            {
                XmlNode tmpXmlNode;
                tmpXmlNode = m_ObjXmlNode.SelectSingleNode("��ʽ");
                if (tmpXmlNode!=null)
                {
                    tmpXmlNode.InnerText = value.ToString();
                }
            }
        }
        public enumShapeType ����
        {
            get
            {
                XmlAttribute tmpXmlAttribute = m_ObjXmlNode.Attributes["����"];
                if (tmpXmlAttribute!=null)
                {
                    try
                    {
                        return (enumShapeType) Enum.Parse(typeof (enumShapeType), tmpXmlAttribute.Value);
                    }
                    catch
                    {
                        return (enumShapeType)Enum.Parse(typeof(enumShapeType), "ֱ��");
                    }
                }
                else
                {
                    return (enumShapeType)Enum.Parse(typeof(enumShapeType), "ֱ��");
                }
            }
            set
            {
                XmlAttribute tmpXmlAttribute = m_ObjXmlNode.Attributes["����"];
                if (tmpXmlAttribute!=null)
                {
                    tmpXmlAttribute.Value = value.ToString();
                }
            }
        }
        public ��ɫ�� Obj��ɫ
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("��ɫ");
                ��ɫ�� tmpObj��ɫ = new ��ɫ��(tmpXmlNode);
                return tmpObj��ɫ;
            }
        }
        public λ���� Objλ��
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("λ��");
                λ���� tmpObjλ�� = new λ����(tmpXmlNode);
                return tmpObjλ��;
            }
        }
    }
    class ��ǩ : ������
    {
        public override string ToString()
        {
            return ����;
            //return base.ToString();
        }
        public ��ǩ(XmlDocument objXmlDocument,XmlNode objXmlNode)
            : base(objXmlDocument, objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
        }
        public string �ı�
        {
            get
            {
                XmlNode tmpXmlNode;
                tmpXmlNode = m_ObjXmlNode.SelectSingleNode("�ı�");
                return tmpXmlNode == null ? "" : tmpXmlNode.InnerText;
            }
            set
            {
                XmlNode tmpXmlNode;
                tmpXmlNode = m_ObjXmlNode.SelectSingleNode("�ı�");
                if (tmpXmlNode != null)
                    tmpXmlNode.InnerText = value;
            }
        }
        public ��ɫ�� Obj��ɫ
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("��ɫ");
                ��ɫ�� tmpObj��ɫ = new ��ɫ��(tmpXmlNode);
                return tmpObj��ɫ;
            }
        }
        public λ���� Objλ��
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("λ��");
                λ���� tmpObjλ�� = new λ����(tmpXmlNode);
                return tmpObjλ��;
            }
        }
        public ������ Obj����
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("����");
                ������ tmpObj���� = new ������(tmpXmlNode);
                return tmpObj����;
            }
        }
    }
    class ���ݱ�ǩ��
    {
        protected XmlNode m_ObjXmlNode = null;
        public ���ݱ�ǩ��(XmlNode objXmlNode) 
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
        public string �ı�
        {
            get
            {
                XmlNode tmpXmlNode;
                tmpXmlNode = m_ObjXmlNode.SelectSingleNode("�ı�");
                return tmpXmlNode == null ? "" : tmpXmlNode.InnerText;
            }
            set
            {
                XmlNode tmpXmlNode;
                tmpXmlNode = m_ObjXmlNode.SelectSingleNode("�ı�");
                if (tmpXmlNode != null)
                    tmpXmlNode.InnerText = value;
            }
        }
        public ��ɫ�� Obj��ɫ
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("��ɫ");
                ��ɫ�� tmpObj��ɫ = new ��ɫ��(tmpXmlNode);
                return tmpObj��ɫ;
            }
        }
        public λ���� Objλ��
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("λ��");
                λ���� tmpObjλ�� = new λ����(tmpXmlNode);
                return tmpObjλ��;
            }
        }
        public ������ Obj����
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("����");
                ������ tmpObj���� = new ������(tmpXmlNode);
                return tmpObj����;
            }
        }
    }
    class ����ֵ��
    {
        protected XmlNode m_ObjXmlNode = null;
        public ����ֵ��(XmlNode objXmlNode)
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
        public ��ɫ�� Obj��ɫ
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("��ɫ");
                ��ɫ�� tmpObj��ɫ = new ��ɫ��(tmpXmlNode);
                return tmpObj��ɫ;
            }
        }
        public λ���� Objλ��
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("λ��");
                λ���� tmpObjλ�� = new λ����(tmpXmlNode);
                return tmpObjλ��;
            }
        }
        public ������ Obj����
        {
            get
            {
                XmlNode tmpXmlNode = ObjXmlNode.SelectSingleNode("����");
                ������ tmpObj���� = new ������(tmpXmlNode);
                return tmpObj����;
            }
        }
    }
    class ������Դ�� 
    { 
        protected XmlNode m_ObjXmlNode = null;
        protected ArrayList m_Obj���ݿ�Դ����=null;

        public ������Դ��(XmlNode objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
            MakeObj���ݿ�Դ����(ObjXmlNode);
        }
        private void MakeObj���ݿ�Դ����(XmlNode objXmlNode)
        {
            XmlNode tmpXmlNode;
            tmpXmlNode = objXmlNode.FirstChild;
            if (tmpXmlNode!=null)
            {
                Obj���ݿ�Դ����.Add(new ֵ��(tmpXmlNode));
                while (tmpXmlNode.NextSibling !=null)
                {
                    tmpXmlNode = tmpXmlNode.NextSibling;
                    Obj���ݿ�Դ����.Add(new ֵ��(tmpXmlNode));
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
        public enum������Դ���� ������Դ���� 
        {
            get
            {
                XmlAttribute tmpXmlAttribute = m_ObjXmlNode.Attributes["������Դ����"];
                if (tmpXmlAttribute != null)
                {
                    try
                    {
                        return (enum������Դ����)Enum.Parse(typeof(enum������Դ����), tmpXmlAttribute.Value);
                    }
                    catch
                    {
                        return (enum������Դ����)Enum.Parse(typeof(enum������Դ����), "�ı�");
                    }
                }
                else
                {
                    return (enum������Դ����)Enum.Parse(typeof(enum������Դ����), "�ı�");
                }
            }
            set
            {
                XmlAttribute tmpXmlAttribute = m_ObjXmlNode.Attributes["������Դ����"];
                if (tmpXmlAttribute != null)
                {
                    tmpXmlAttribute.Value = value.ToString();
                }
            }
        }
        public ArrayList Obj���ݿ�Դ����
        {
            get
            {
                return m_Obj���ݿ�Դ����;
            }
        }
        public void Remove(ֵ�� objֵ��)
        {
            ObjXmlNode.RemoveChild(objֵ��.ObjXmlNode);
            Obj���ݿ�Դ����.Remove(objֵ��);
        }
        public void Add(ֵ�� objֵ��)
        {
            ObjXmlNode.AppendChild(objֵ��.ObjXmlNode);
            Obj���ݿ�Դ����.Add(objֵ��);
        }
    }
    class ֵ��
    {
        protected XmlNode m_ObjXmlNode = null;
        
        public ֵ��(XmlNode objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
        }
        public override string ToString()
        {
            return ֵ;
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
        public string ֵ
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
    class ���� : ������
    {
        public ����(XmlDocument objXmlDocument , XmlNode objXmlNode)
            : base(objXmlDocument, objXmlNode)
        {
            m_ObjXmlNode = objXmlNode;
        }
        public ��ǩ ���ݱ�ǩ
        {
            get
            {
                XmlNode tmpXmlNode;
                ��ǩ tmp���ݱ�ǩ;
                tmpXmlNode = ObjXmlNode.SelectSingleNode("���ݱ�ǩ");
                tmp���ݱ�ǩ = new ��ǩ(m_ObjXmlDocument , tmpXmlNode);
                return tmp���ݱ�ǩ;
            }
        }
    }

}
