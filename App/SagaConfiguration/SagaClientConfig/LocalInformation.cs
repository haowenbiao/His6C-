using System.Xml;

namespace SagaConfiguration
{
    public class LocalInformation
    {
        private CommunicateInformation m_CommunicateInformation = new CommunicateInformation();

        public CommunicateInformation communicateInformation
        {
            get
            {
                return m_CommunicateInformation;
            }
        }

        public void loadFromXmlDocument(XmlNode valParentXmlNode)
        {
            if (valParentXmlNode==null)
            {
                return;
            }
            XmlNode tmpCommunicateInformation = valParentXmlNode.SelectSingleNode("CommunicateInformation");
            if (tmpCommunicateInformation == null)
            {
                tmpCommunicateInformation = valParentXmlNode.OwnerDocument.CreateElement("CommunicateInformation");
                valParentXmlNode.AppendChild(tmpCommunicateInformation);
            }
            communicateInformation.loadFromXmlDocument(tmpCommunicateInformation);
        }
        public void saveToXmlDocument(XmlNode valParentXmlNode)
        {
            if (valParentXmlNode == null)
            {
                return;
            }
            XmlNode tmpCommunicateInformation = valParentXmlNode.SelectSingleNode("CommunicateInformation");
            if (tmpCommunicateInformation == null)
            {
                tmpCommunicateInformation = valParentXmlNode.OwnerDocument.CreateElement("CommunicateInformation");
                valParentXmlNode.AppendChild(tmpCommunicateInformation);
            }
            communicateInformation.saveToXmlDocument(tmpCommunicateInformation);
        }
    }
}
