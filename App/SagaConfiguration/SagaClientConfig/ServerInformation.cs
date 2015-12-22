using System.Xml;

namespace SagaConfiguration
{
    public class ServerInformation
    {
        private ServerConnectInformation m_SagaServerConnectInformation = new ServerConnectInformation();
        private CommunicateInformation m_CommunicateInformation = new CommunicateInformation();
        
        public CommunicateInformation communicateInformation
        {
            get
            {
                return m_CommunicateInformation;
            }
        }
        public ServerConnectInformation serverConnectInformation
        {
            get
            {
                return m_SagaServerConnectInformation;
            }
        }

        //保存至XmlDocument
        public void saveToXmlDocument(XmlNode valParentXmlNode)
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
            communicateInformation.saveToXmlDocument(tmpCommunicateInformation);

            XmlNode tmpServerConnectInformation = valParentXmlNode.SelectSingleNode("ServerConnectInformation");
            if (tmpServerConnectInformation == null)
            {
                tmpServerConnectInformation = valParentXmlNode.OwnerDocument.CreateElement("ServerConnectInformation");
                valParentXmlNode.AppendChild(tmpServerConnectInformation);
            }
            serverConnectInformation.saveToXmlDocument(tmpServerConnectInformation);
        }
        public void loadFromXmlDocument(XmlNode valParentXmlNode)
        {
            if(valParentXmlNode==null)
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

            XmlNode tmpServerConnectInformation = valParentXmlNode.SelectSingleNode("ServerConnectInformation");
            if (tmpServerConnectInformation == null)
            {
                tmpServerConnectInformation = valParentXmlNode.OwnerDocument.CreateElement("ServerConnectInformation");
                valParentXmlNode.AppendChild(tmpServerConnectInformation);
            }
            serverConnectInformation.loadFromXmlDocument(tmpServerConnectInformation);
        }
    }
}