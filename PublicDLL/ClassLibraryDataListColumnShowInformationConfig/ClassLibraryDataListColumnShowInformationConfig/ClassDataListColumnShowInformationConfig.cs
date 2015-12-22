using System;
using System.Collections.Generic;
using System.Xml;

namespace ClassLibraryDataListColumnShowInformationConfig
{
    public class ClassDataListColumnShowInformationConfig
    {
        List<int> _ListMustShowColumn = new List<int>();
        List<int> _ListNotShowColumn = new List<int>();
        private string _XmlFileName;

        /// <summary>
        /// 自定义配置文件名称
        /// </summary>
        /// <param name="valXmlFileName">配置文件名</param>
        /// <param name="valKey">关键字，配置信息保存的位置</param>
        public ClassDataListColumnShowInformationConfig(string valXmlFileName, string valKey)
        {
            _XmlFileName = valXmlFileName;
            Key = valKey;
            Load();
        }

        /// <summary>
        /// 配置文件默认为“LocalConfig.xml”
        /// </summary>
        /// <param name="valKey">关键字，配置信息保存的位置</param>
        public ClassDataListColumnShowInformationConfig(string valKey)
            : this("LocalConfig.xml", valKey)
        {

        }

        private string XmlFileName
        {
            get
            {
                return _XmlFileName;
            }
        }

        public string Key { get; private set; }

        public IList<int> ListMustShowColumn
        {
            get
            {
                return _ListMustShowColumn;
            }
        }

        public IList<int> ListNotShowColumn
        {
            get
            {
                return _ListNotShowColumn;
            }
        }

        public void ClearListNotShowColumn()
        {
            _ListNotShowColumn.RemoveRange(0, _ListNotShowColumn.Count);
        }

        private void Load()
        {
            XmlDocument xmlDocument = new XmlDocument();
            try
            {
                xmlDocument.Load(XmlFileName);
            }
            catch
            {
                return;
            }

            try
            {
                XmlNode XmlNodeConfiguration = xmlDocument.SelectSingleNode("Configuration");
                //XmlNode XmlNodeConfiguration = SelectSingleNode(xmlDocument, "Configuration");
                if (XmlNodeConfiguration == null)
                {
                    XmlNodeConfiguration = xmlDocument.CreateElement("Configuration");
                    xmlDocument.AppendChild(XmlNodeConfiguration);
                }

                XmlNode XmlNodeLocalInformation = SelectSingleNode(XmlNodeConfiguration, "LocalInformation");
                XmlNode XmlNodeDataListColunmsShowInformation = SelectSingleNode(XmlNodeLocalInformation,
                                                                                 "DataListColunmsShowInformation");
                XmlNode XmlNodeKey = SelectSingleNode(XmlNodeDataListColunmsShowInformation, Key);
                XmlNode XmlNodeMustShowColumn = SelectSingleNode(XmlNodeKey, "MustShowColumn");
                LoadColumns(XmlNodeMustShowColumn, _ListMustShowColumn);
                XmlNode XmlNodeShowColumn = SelectSingleNode(XmlNodeKey, "NotShowColumn");
                LoadColumns(XmlNodeShowColumn, _ListNotShowColumn);
                return;
            }
            catch
            {
                return;
            }
        }

        public bool Save()
        {
            XmlDocument xmlDocument = new XmlDocument();
            try
            {
                xmlDocument.Load(XmlFileName);
            }
            catch
            {
                ;
            }

            try
            {
                XmlNode XmlNodeConfiguration = xmlDocument.SelectSingleNode("Configuration");
                //XmlNode XmlNodeConfiguration = SelectSingleNode(xmlDocument, "Configuration");
                if (XmlNodeConfiguration==null)
                {
                    XmlNodeConfiguration = xmlDocument.CreateElement("Configuration");
                    xmlDocument.AppendChild(XmlNodeConfiguration);
                }

                XmlNode XmlNodeLocalInformation = SelectSingleNode(XmlNodeConfiguration, "LocalInformation");
                XmlNode XmlNodeDataListColunmsShowInformation = SelectSingleNode(XmlNodeLocalInformation,
                                                                                 "DataListColunmsShowInformation");
                XmlNode XmlNodeKey = SelectSingleNode(XmlNodeDataListColunmsShowInformation, Key);
                XmlNode XmlNodeShowColumn = SelectSingleNode(XmlNodeKey, "NotShowColumn");
                SaveShowColumns(XmlNodeShowColumn, _ListNotShowColumn);
                xmlDocument.Save(XmlFileName);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private XmlNode SelectSingleNode(XmlNode valXmlNode, string valSelectedNodeString)
        {
            XmlNode tmpXmlNode = valXmlNode.SelectSingleNode(valSelectedNodeString);
            if (tmpXmlNode == null)
            {
                tmpXmlNode = valXmlNode.OwnerDocument.CreateElement(valSelectedNodeString);
                valXmlNode.AppendChild(tmpXmlNode);
            }
            return tmpXmlNode;
        }

        private void LoadColumns(XmlNode valXmlNode, ICollection<int> valListColumn)
        {
            if (valXmlNode.HasChildNodes)
            {
                int ColumnCount = valXmlNode.ChildNodes.Count;
                for (int i = 0; i < ColumnCount; i++)
                {
                    try
                    {
                        int ColumnOrdinal = Convert.ToInt32(valXmlNode.ChildNodes[i].InnerText);
                        valListColumn.Add(ColumnOrdinal);
                    }
                    catch
                    {
                        return;
                    }
                }
            }
        }

        private void SaveShowColumns(XmlNode valXmlNode, ICollection<int> valListShowColumn)
        {
            if (valXmlNode.HasChildNodes)
            {
                valXmlNode.RemoveAll();
            }
            XmlNode tmpXmlNode;
            foreach (int i in valListShowColumn)
            {
                tmpXmlNode = valXmlNode.OwnerDocument.CreateElement("ColumnOrdinal");
                tmpXmlNode.InnerText = i.ToString();
                valXmlNode.AppendChild(tmpXmlNode);
            }
        }
    }

}
