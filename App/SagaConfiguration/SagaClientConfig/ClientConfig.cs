using System.Xml;

namespace SagaConfiguration
{
    public class ClientConfig
    {
        private ServerInformation m_SagaServerInformation = new ServerInformation();
        private LocalInformation m_LocalInformation = new LocalInformation();

        public ServerInformation serverInformation
        {
            get
            {
                return m_SagaServerInformation;
            }
        }
        public LocalInformation localInformation
        {
            get
            {
                return m_LocalInformation;
            }
        }

        private XmlDocument xmlDocument { get; set; }
        private string fileName { get; set; }

        public ClientConfig(string valFileName, bool loaded)
        {
            if (valFileName == "")
            {
                return;
            }
            try
            {
                xmlDocument = new XmlDocument();
                xmlDocument.Load(valFileName);
                fileName = valFileName;
                if (loaded)
                {
                    load();
                }
            }
            catch
            {
                return;
            }
        }
        
        public bool load()
        {
            if (xmlDocument==null)
            {
                return false;
            }
            //Configuration
            XmlNode tmpConfiguration = xmlDocument.SelectSingleNode("Configuration");
            if (tmpConfiguration==null)
            {
                tmpConfiguration = xmlDocument.CreateElement("Configuration");
                xmlDocument.AppendChild(tmpConfiguration);
            }
            //load ServerInformation
            XmlNode tmpServerInformation = tmpConfiguration.SelectSingleNode("ServerInformation");
            if (tmpServerInformation==null)
            {
                tmpServerInformation = xmlDocument.CreateElement("ServerInformation");
                tmpConfiguration.AppendChild(tmpServerInformation);
            }
            serverInformation.loadFromXmlDocument(tmpServerInformation);
            //load LocalInformation
            XmlNode tmpLocalInformation = tmpConfiguration.SelectSingleNode("LocalInformation");
            if (tmpLocalInformation==null)
            {
                tmpLocalInformation = xmlDocument.CreateElement("LocalInformation");
                tmpConfiguration.AppendChild(tmpLocalInformation);
            }
            localInformation.loadFromXmlDocument(tmpLocalInformation);

            return true;
        }
        public bool save()
        {
            return save(fileName);
        }
        public bool save(string valFileName)
        {
            if (xmlDocument == null)
            {
                return false;
            }
            XmlNode tmpConfiguration = xmlDocument.SelectSingleNode("Configuration");
            if (tmpConfiguration == null)
            {
                tmpConfiguration = xmlDocument.CreateElement("Configuration");
                xmlDocument.AppendChild(tmpConfiguration);
            }

            XmlNode tmpServerInformation = tmpConfiguration.SelectSingleNode("ServerInformation");
            if (tmpServerInformation == null)
            {
                tmpServerInformation = xmlDocument.CreateElement("ServerInformation");
                tmpConfiguration.AppendChild(tmpServerInformation);
            }
            serverInformation.saveToXmlDocument(tmpServerInformation);

            XmlNode tmpLocalInformation = tmpConfiguration.SelectSingleNode("LocalInformation");
            if (tmpLocalInformation == null)
            {
                tmpLocalInformation = xmlDocument.CreateElement("LocalInformation");
                tmpConfiguration.AppendChild(tmpLocalInformation);
            }
            localInformation.saveToXmlDocument(tmpLocalInformation);

            try
            {
                xmlDocument.Save(valFileName);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}