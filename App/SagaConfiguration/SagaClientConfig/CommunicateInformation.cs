using System;
using System.Xml;

namespace SagaConfiguration
{
    public class CommunicateInformation
    {
        public string ComputerName { get; set; }
        public string ComputerIP { get; set; }
        public int CommunicatePort { get; set; }
        public int StreamBufferSize { get; set; }

        public void saveToXmlDocument(XmlNode valParentXmlNode)
        {
            if (valParentXmlNode==null)
            {
                return;
            }
            PublicFunction.setNodeValue(valParentXmlNode, "ComputerName", ComputerName);
            PublicFunction.setNodeValue(valParentXmlNode, "ComputerIP", ComputerIP);
            PublicFunction.setNodeValue(valParentXmlNode, "CommunicatePort", CommunicatePort.ToString());
            PublicFunction.setNodeValue(valParentXmlNode, "StreamBufferSize", StreamBufferSize.ToString());
        }
        public void loadFromXmlDocument(XmlNode valParentXmlNode)
        {
            if (valParentXmlNode==null)
            {
                return;
            }
            ComputerName = PublicFunction.getNodeVale(valParentXmlNode, "ComputerName", "");
            ComputerIP = PublicFunction.getNodeVale(valParentXmlNode, "ComputerIP", "");
            CommunicatePort = Convert.ToInt32(PublicFunction.getNodeVale(valParentXmlNode, "CommunicatePort", "8888"));
            StreamBufferSize = Convert.ToInt32(PublicFunction.getNodeVale(valParentXmlNode, "StreamBufferSize", "256"));
        }
    }
}
