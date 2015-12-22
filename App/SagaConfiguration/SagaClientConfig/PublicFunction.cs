using System;
using System.Xml;

namespace SagaConfiguration
{
    class PublicFunction
    {
        //从目标节点中按关键字搜索子节点并返回子节点的值。
        public static String getNodeVale(XmlNode valFrom, string valKey, string valDefalt)
        {
            XmlNode tmpXmlNode = valFrom.SelectSingleNode(valKey);
            if (tmpXmlNode != null)
            {
                return tmpXmlNode.InnerText;
            }
            tmpXmlNode = valFrom.OwnerDocument.CreateElement(valKey);
            valFrom.AppendChild(tmpXmlNode);
            return valDefalt;
        }
        //从目标节点中按关键字搜索子节点并设置子节点的值。
        public static void setNodeValue(XmlNode valFrom, string valKey, string value)
        {
            XmlNode tmpXmlNode = valFrom.SelectSingleNode(valKey);
            if (tmpXmlNode == null)
            {
                tmpXmlNode = valFrom.OwnerDocument.CreateElement(valKey);
                valFrom.AppendChild(tmpXmlNode);
            }
            tmpXmlNode.InnerText = value;
        }
    }
}
