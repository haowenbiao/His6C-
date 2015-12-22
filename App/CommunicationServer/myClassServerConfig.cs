using System;
using System.Windows.Forms;
using System.Xml;

namespace CommunicateServer
{
    class myClassServerConfig
    {
        public string Server { get; set; }
        public string Instance { get; set; }
        public string DataBase { get; set; }
        public string ServerIP { get; set; }
        public int ServerPort { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }

        public bool load()
        {
            XmlDocument tmpXmlDocument = new XmlDocument();
            XmlNode tmpRoot;
            XmlNode tmpConnectionString;
            XmlNode tmpXmlNode;
            try
            {
                tmpXmlDocument.Load(Application.StartupPath + @"\ServerConfig.xml");
                tmpRoot = tmpXmlDocument.SelectSingleNode("Config");
                tmpConnectionString = tmpRoot.SelectSingleNode("ConnectionString");
                
                tmpXmlNode = tmpConnectionString.SelectSingleNode("Server");
                if (tmpXmlNode != null)
                {
                    Server = tmpXmlNode.InnerText;
                }
                tmpXmlNode = tmpConnectionString.SelectSingleNode("Instance");
                if (tmpXmlNode != null)
                {
                    Instance = tmpXmlNode.InnerText;
                }
                tmpXmlNode = tmpConnectionString.SelectSingleNode("DataBase");
                if (tmpXmlNode != null)
                {
                    DataBase = tmpXmlNode.InnerText;
                }
                tmpXmlNode = tmpConnectionString.SelectSingleNode("ServerIP");
                if (tmpXmlNode != null)
                {
                    ServerIP = tmpXmlNode.InnerText;
                }
                tmpXmlNode = tmpConnectionString.SelectSingleNode("ServerPort");
                if (tmpXmlNode != null)
                {
                    try
                    {
                        ServerPort = Convert.ToInt32(tmpXmlNode.InnerText);
                    }
                    catch
                    {
                        ServerPort = 0;
                    }
                }
                tmpXmlNode = tmpConnectionString.SelectSingleNode("UserID");
                if (tmpXmlNode != null)
                {
                    UserID = tmpXmlNode.InnerText;
                }
                tmpXmlNode = tmpConnectionString.SelectSingleNode("Password");
                if (tmpXmlNode != null)
                {
                    Password = tmpXmlNode.InnerText;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void save()
        {
            XmlDocument tmpXmlDocument = new XmlDocument();
            XmlNode tmpRoot;
            XmlNode tmpConnectionString;
            XmlNode tmpXmlNode;
            try
            {
                tmpXmlDocument.Load(Application.StartupPath + @"\ServerConfig.xml");
            }
            catch
            {
                ;
            }
            tmpRoot = tmpXmlDocument.SelectSingleNode("Config");
            if (tmpRoot==null)
            {
                tmpRoot = tmpXmlDocument.CreateElement("Config");
                tmpXmlDocument.AppendChild(tmpRoot);
            }
            tmpConnectionString = tmpRoot.SelectSingleNode("ConnectionString");
            if (tmpConnectionString==null)
            {
                tmpConnectionString = tmpXmlDocument.CreateElement("ConnectionString");
                tmpRoot.AppendChild(tmpConnectionString);
            }

            tmpXmlNode = tmpConnectionString.SelectSingleNode("Server");
            if (tmpXmlNode == null)
            {
                tmpXmlNode = tmpXmlDocument.CreateElement("Server");
                tmpConnectionString.AppendChild(tmpXmlNode);
            }
            tmpXmlNode.InnerText = Server;

            tmpXmlNode = tmpConnectionString.SelectSingleNode("Instance");
            if (tmpXmlNode == null)
            {
                tmpXmlNode = tmpXmlDocument.CreateElement("Instance");
                tmpConnectionString.AppendChild(tmpXmlNode);
            }
            tmpXmlNode.InnerText = Instance;

            tmpXmlNode = tmpConnectionString.SelectSingleNode("DataBase");
            if (tmpXmlNode == null)
            {
                tmpXmlNode = tmpXmlDocument.CreateElement("DataBase");
                tmpConnectionString.AppendChild(tmpXmlNode);
            }
            tmpXmlNode.InnerText = DataBase;

            tmpXmlNode = tmpConnectionString.SelectSingleNode("ServerIP");
            if (tmpXmlNode == null)
            {
                tmpXmlNode = tmpXmlDocument.CreateElement("ServerIP");
                tmpConnectionString.AppendChild(tmpXmlNode);
            }
            tmpXmlNode.InnerText = ServerIP;

            tmpXmlNode = tmpConnectionString.SelectSingleNode("ServerPort");
            if (tmpXmlNode == null)
            {
                tmpXmlNode = tmpXmlDocument.CreateElement("ServerPort");
                tmpConnectionString.AppendChild(tmpXmlNode);
            }
            tmpXmlNode.InnerText = ServerPort.ToString();

            tmpXmlNode = tmpConnectionString.SelectSingleNode("UserID");
            if (tmpXmlNode == null)
            {
                tmpXmlNode = tmpXmlDocument.CreateElement("UserID");
                tmpConnectionString.AppendChild(tmpXmlNode);
            }
            tmpXmlNode.InnerText = UserID;

            tmpXmlNode = tmpConnectionString.SelectSingleNode("Password");
            if (tmpXmlNode == null)
            {
                tmpXmlNode = tmpXmlDocument.CreateElement("Password");
                tmpConnectionString.AppendChild(tmpXmlNode);
            }
            tmpXmlNode.InnerText = Password;
        }
    }
}