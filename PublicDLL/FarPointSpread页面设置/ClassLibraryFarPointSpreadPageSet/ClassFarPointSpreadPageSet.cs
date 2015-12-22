using System;
using System.Drawing.Printing;
using System.Xml;
using FarPoint.Win.Spread;

namespace ClassLibraryFarPointSpreadPageSet
{
    public class ClassFarPointSpreadPageSet:PrintInfo
    {
        private readonly string XmlFileName;
        private readonly string NodeString;

        public ClassFarPointSpreadPageSet(string valXmlFileName,string valNodeString)
        {
            XmlFileName = valXmlFileName;
            NodeString = valNodeString;
            load();
        }

        private void load()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(XmlFileName);
            //XmlNode XmlNodeConfiguration = xmlDocument.SelectSingleNode("Configuration");
            XmlNode XmlNodeConfiguration = SelectSingleNode(xmlDocument, "Configuration");
            XmlNode XmlNodeLocalInformation = SelectSingleNode(XmlNodeConfiguration,"LocalInformation");
            XmlNode XmlNodeFarPointSpreadPageSets = SelectSingleNode(XmlNodeLocalInformation, "FarPointSpreadPageSets");
            XmlNode XmlNodeWorkerInformations = SelectSingleNode(XmlNodeFarPointSpreadPageSets, NodeString);

            XmlNode tmpXmlNode;

            tmpXmlNode = SelectSingleNode(XmlNodeWorkerInformations, "Centering", "None");
            Centering = Enum.IsDefined(typeof (Centering), tmpXmlNode.InnerText)
                                 ? (Centering) Enum.Parse(typeof (Centering), tmpXmlNode.InnerText)
                                 : Centering.None;
            
            tmpXmlNode = SelectSingleNode(XmlNodeWorkerInformations,"PrintMargin");
            PrintMargin pm = new PrintMargin
                                 {
                                     Top = Convert.ToInt32(SelectSingleNode(tmpXmlNode, "Top", "0").InnerText),
                                     Bottom = Convert.ToInt32(SelectSingleNode(tmpXmlNode, "Bottom", "0").InnerText),
                                     Left = Convert.ToInt32(SelectSingleNode(tmpXmlNode, "Left", "0").InnerText),
                                     Right = Convert.ToInt32(SelectSingleNode(tmpXmlNode, "Right", "0").InnerText)
                                 };
            Margin = pm;

            tmpXmlNode = SelectSingleNode(XmlNodeWorkerInformations, "Orientation", "Portrait");
            Orientation = Enum.IsDefined(typeof (PrintOrientation), tmpXmlNode.InnerText)
                                   ? (PrintOrientation) Enum.Parse(typeof (PrintOrientation), tmpXmlNode.InnerText)
                                   : PrintOrientation.Portrait;

            tmpXmlNode = SelectSingleNode(XmlNodeWorkerInformations, "ShowBorder", "true");
            ShowBorder = tmpXmlNode.InnerText == "True" || tmpXmlNode.InnerText == "true" ? true : false;

            tmpXmlNode = SelectSingleNode(XmlNodeWorkerInformations,"ShowColor","false");
            ShowColor = tmpXmlNode.InnerText == "True" || tmpXmlNode.InnerText == "true" ? true : false;

            tmpXmlNode = SelectSingleNode(XmlNodeWorkerInformations, "ShowColumnHeader", "Inherit");
            ShowColumnHeader = Enum.IsDefined(typeof (PrintHeader), tmpXmlNode.InnerText)
                                        ? (PrintHeader) Enum.Parse(typeof (PrintHeader), tmpXmlNode.InnerText)
                                        : PrintHeader.Inherit;

            tmpXmlNode = SelectSingleNode(XmlNodeWorkerInformations, "ShowRowHeader", "Inherit");
            ShowRowHeader = Enum.IsDefined(typeof(PrintHeader), tmpXmlNode.InnerText)
                                        ? (PrintHeader)Enum.Parse(typeof(PrintHeader), tmpXmlNode.InnerText)
                                        : PrintHeader.Inherit;

            tmpXmlNode = SelectSingleNode(XmlNodeWorkerInformations, "ShowGrid", "true");
            ShowGrid = tmpXmlNode.InnerText == "True" || tmpXmlNode.InnerText == "true" ? true : false;

            tmpXmlNode = SelectSingleNode(XmlNodeWorkerInformations, "ShowShadows", "false");
            ShowShadows = tmpXmlNode.InnerText == "True" || tmpXmlNode.InnerText == "true" ? true : false;

            //纸张设置
            tmpXmlNode = SelectSingleNode(XmlNodeWorkerInformations,"PaperSize");
            XmlNode tmpXmlNodeCustomSize = SelectSingleNode(tmpXmlNode,"CustomSize");
            int tmpWidth = Convert.ToInt32(SelectSingleNode(tmpXmlNodeCustomSize,"Width","800").InnerText);
            int tmpHeight = Convert.ToInt32(SelectSingleNode(tmpXmlNodeCustomSize,"Height","800").InnerText);

            PrintDocument pd = new PrintDocument();
            PaperSize tmpPaperSize = null;
            foreach(PaperSize p in pd.PrinterSettings.PaperSizes)
            {
                if (p.Width == tmpWidth && p.Height == tmpHeight)
                {
                    tmpPaperSize = p;
                    break;
                }
            }

            if (tmpPaperSize==null)
            {
                tmpPaperSize = new PaperSize("自定义纸张", tmpWidth,tmpHeight);
            }
            PaperSize = tmpPaperSize;
            pd.Dispose();

        }

        public void save()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(XmlFileName);
            XmlNode XmlNodeConfiguration = SelectSingleNode(xmlDocument,"Configuration");
            XmlNode XmlNodeLocalInformation = SelectSingleNode(XmlNodeConfiguration,"LocalInformation");
            XmlNode XmlNodeFarPointSpreadPageSets = SelectSingleNode(XmlNodeLocalInformation,"FarPointSpreadPageSets");
            XmlNode XmlNodeWorkerInformations = SelectSingleNode(XmlNodeFarPointSpreadPageSets,NodeString);

            XmlNode tmpXmlNode;

            SelectSingleNode(XmlNodeWorkerInformations,"Centering").InnerText = Centering.ToString();

            tmpXmlNode = SelectSingleNode(XmlNodeWorkerInformations,"PrintMargin");
            SelectSingleNode(tmpXmlNode,"Top").InnerText = Margin.Top.ToString();
            SelectSingleNode(tmpXmlNode,"Bottom").InnerText = Margin.Bottom.ToString();
            SelectSingleNode(tmpXmlNode,"Left").InnerText = Margin.Left.ToString();
            SelectSingleNode(tmpXmlNode,"Right").InnerText = Margin.Right.ToString();

            SelectSingleNode(XmlNodeWorkerInformations,"Orientation").InnerText = Orientation.ToString();

            SelectSingleNode(XmlNodeWorkerInformations,"ShowBorder").InnerText = ShowBorder.ToString();

            SelectSingleNode(XmlNodeWorkerInformations,"ShowColor").InnerText = ShowColor.ToString();

            SelectSingleNode(XmlNodeWorkerInformations,"ShowColumnHeader").InnerText = ShowColumnHeader.ToString();

            SelectSingleNode(XmlNodeWorkerInformations,"ShowRowHeader").InnerText = ShowRowHeader.ToString();

            SelectSingleNode(XmlNodeWorkerInformations,"ShowGrid").InnerText = ShowGrid.ToString();

            SelectSingleNode(XmlNodeWorkerInformations,"ShowShadows").InnerText = ShowShadows.ToString();

            tmpXmlNode = SelectSingleNode(XmlNodeWorkerInformations,"PaperSize");
            SelectSingleNode(tmpXmlNode,"PaperName").InnerText = PaperSize.PaperName;
            SelectSingleNode(tmpXmlNode,"PaperKind").InnerText = PaperSize.Kind.ToString();
            XmlNode tmpXmlNodeCustomSize = SelectSingleNode(tmpXmlNode,"CustomSize");
            SelectSingleNode(tmpXmlNodeCustomSize,"Width").InnerText = PaperSize.Width.ToString();
            SelectSingleNode(tmpXmlNodeCustomSize,"Height").InnerText = PaperSize.Height.ToString();

            xmlDocument.Save(XmlFileName);
        }
        
        private XmlNode SelectSingleNode(XmlNode valXmlNode,string valSelectedNodeString)
        {
            XmlNode tmpXmlNode = null;
            tmpXmlNode = valXmlNode.SelectSingleNode(valSelectedNodeString);
            if (tmpXmlNode==null)
            {
                tmpXmlNode = valXmlNode.OwnerDocument.CreateElement(valSelectedNodeString);
                valXmlNode.AppendChild(tmpXmlNode);
            }
            return tmpXmlNode;
        }
        private XmlNode SelectSingleNode(XmlNode valXmlNode, string valSelectedNodeString, string valStringValue)
        {
            XmlNode tmpXmlNode = SelectSingleNode(valXmlNode, valSelectedNodeString);
            if (string.IsNullOrEmpty(tmpXmlNode.InnerText))
            {
                tmpXmlNode.InnerText = valStringValue;
            }
            return tmpXmlNode;
        } 
    }
}
