using System;
using System.Xml;

namespace SagaConfiguration
{
    public enum ServerType
    {
        SqlServerExpress,
        SqlServer
    }
    public class ServerConnectInformation
    {
        public ServerType ServerType { get; set; }
        public string ServerName { get; set; }
        public string Instance { get; set; }
        public string DataBase { get; set; }
        public int ServerPort { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }

        public void saveToXmlDocument(XmlNode valParentXmlNode)
        {
            if (valParentXmlNode==null)
            {
                return;
            }
            PublicFunction.getNodeVale(valParentXmlNode, "ServerType", ServerType.ToString());
            PublicFunction.setNodeValue(valParentXmlNode, "ServerName", ServerName);
            PublicFunction.setNodeValue(valParentXmlNode, "Instance", Instance);
            PublicFunction.setNodeValue(valParentXmlNode, "DataBase", DataBase);
            PublicFunction.setNodeValue(valParentXmlNode, "ServerPort", ServerPort.ToString());
            PublicFunction.setNodeValue(valParentXmlNode, "UserID", UserID);
            PublicFunction.setNodeValue(valParentXmlNode, "Password", Password);
        }
        public void loadFromXmlDocument(XmlNode valParentXmlNode)
        {
            if (valParentXmlNode==null)
            {
                return;
            }
            try
            {
                ServerType = (ServerType)Enum.Parse(typeof(ServerType),
                                                     PublicFunction.getNodeVale(valParentXmlNode, "ServerType",
                                                                                "SqlServerExpress"));
            }
            catch
            {
                ServerType = ServerType.SqlServerExpress;
            }
            ServerName = PublicFunction.getNodeVale(valParentXmlNode, "ServerName", "");
            Instance = PublicFunction.getNodeVale(valParentXmlNode, "Instance", "");
            DataBase = PublicFunction.getNodeVale(valParentXmlNode, "DataBase", "");
            ServerPort = Convert.ToInt32(PublicFunction.getNodeVale(valParentXmlNode, "ServerPort", "1433"));
            UserID = PublicFunction.getNodeVale(valParentXmlNode, "UserID", "sa");
            Password = PublicFunction.getNodeVale(valParentXmlNode, "Password", "");
        }
    }
}