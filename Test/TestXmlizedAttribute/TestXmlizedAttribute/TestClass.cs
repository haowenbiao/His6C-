using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using ClassLibraryXmlizedAttribute;

namespace TestXmlizedAttribute
{
    public abstract class AbstractTestClass:IImportFromXmlable,IExportToXmlable
    {
        [XmlizedProperty]
        public long ID { get; set; }

        public string ExportToXml()
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlNode DefaulParent = null;
            Type type = GetType();

            #region 生成根节点或父节点和SqlStringID节点

            object[] tmpCustomAttributes = type.GetCustomAttributes(true);
            XmlizedClassAttribute classAttribute =
                GetAttribute(tmpCustomAttributes, a => a.GetType() == typeof(XmlizedClassAttribute)) as
                XmlizedClassAttribute;

            if (classAttribute != null)
            {
                xmlDocument.LoadXml(classAttribute.XmlTemplate);
                DefaulParent = xmlDocument.SelectSingleNode(classAttribute.DefaultPath);

                XmlizedSqlstringIDClassAttribute sqlstringIDClassAttribute =
                    GetAttribute(tmpCustomAttributes, a => a.GetType() == typeof(XmlizedSqlstringIDClassAttribute)) as
                    XmlizedSqlstringIDClassAttribute;
                if (sqlstringIDClassAttribute != null)
                {
                    string tmpSqlStringIDXml = sqlstringIDClassAttribute.ToXml();
                    XmlDocument tmpXmlDocument = new XmlDocument();
                    tmpXmlDocument.LoadXml(tmpSqlStringIDXml);
                    XmlElement tmpRoot = tmpXmlDocument.DocumentElement;
                    if (tmpRoot != null)
                    {
                        XmlNode tmpXmlNode = xmlDocument.ImportNode(tmpRoot, true);
                        if (string.IsNullOrEmpty(sqlstringIDClassAttribute.Path))
                        {
                            DefaulParent.AppendChild(tmpXmlNode);
                        }
                        else
                        {
                            XmlNode tmpParentxmlNode = xmlDocument.SelectSingleNode(sqlstringIDClassAttribute.Path);
                            tmpParentxmlNode.AppendChild(tmpXmlNode);
                        }
                    }
                }
            }

            #endregion

            #region 生成子节点
            if (DefaulParent == null)
            {
                return null;
            }
            XmlizedPropertyAttribute propertyAttribute;
            foreach (PropertyInfo propertyInfo in type.GetProperties())
            {

                foreach (Attribute attribute in propertyInfo.GetCustomAttributes(true))
                {
                    propertyAttribute = attribute as XmlizedPropertyAttribute;
                    if (propertyAttribute != null)
                    {
                        XmlNode tmpParent = string.IsNullOrEmpty(propertyAttribute.Path) ? DefaulParent : xmlDocument.SelectSingleNode(propertyAttribute.Path);
                        //继承了IExportToXmlable接口的属性
                        if (propertyInfo.PropertyType.GetInterface("IExportToXmlable", true) == typeof(IExportToXmlable))
                        {
                            IExportToXmlable exportToXmlable = propertyInfo.GetValue(this, null) as IExportToXmlable;
                            if (exportToXmlable != null)
                            {
                                XmlDocument tmpXmlDocument = new XmlDocument();
                                tmpXmlDocument.LoadXml(exportToXmlable.ExportToXml());
                                if (tmpXmlDocument.DocumentElement != null)
                                {
                                    XmlNode tmpXmlNode = xmlDocument.ImportNode(tmpXmlDocument.DocumentElement, true);
                                    tmpParent.AppendChild(tmpXmlNode);
                                }
                            }
                        }
                        else
                        {
                            //继承了List<IExportToXmlable>的属性
                            if (propertyInfo.PropertyType.IsGenericType)
                            {
                                if (propertyInfo.PropertyType.GetGenericArguments()[0].GetInterface("IExportToXmlable") == typeof(IExportToXmlable))
                                {
                                    IList exportToXmlables =
                                        propertyInfo.GetValue(this, null) as IList;
                                    if (exportToXmlables != null)
                                    {
                                        string tmpElementName = string.IsNullOrEmpty(propertyAttribute.ElementName) ? propertyInfo.Name : propertyAttribute.ElementName;
                                        XmlElement tmpXmlElement = xmlDocument.CreateElement(tmpElementName);
                                        foreach (IExportToXmlable exportToXmlable in exportToXmlables)
                                        {
                                            XmlDocument tmpXmlDocument = new XmlDocument();
                                            tmpXmlDocument.LoadXml(exportToXmlable.ExportToXml());
                                            XmlElement tmpRoot = tmpXmlDocument.DocumentElement;
                                            if (tmpRoot != null)
                                            {
                                                XmlNode tmpXmlNode = xmlDocument.ImportNode(tmpRoot, true);
                                                tmpXmlElement.AppendChild(tmpXmlNode);
                                            }
                                        }
                                        tmpParent.AppendChild(tmpXmlElement);
                                    }
                                }
                            }
                            //普通值类型属性
                            else
                            {
                                string tmpElementName = string.IsNullOrEmpty(propertyAttribute.ElementName)
                                                            ? propertyInfo.Name
                                                            : propertyAttribute.ElementName;
                                XmlElement tmpXmlElement = xmlDocument.CreateElement(tmpElementName);

                                object tmpValue = propertyInfo.GetValue(this, null);
                                //枚举类型
                                if (propertyInfo.PropertyType.IsEnum)
                                {
                                    tmpXmlElement.InnerText = ((int)tmpValue).ToString();
                                }
                                else
                                {
                                    if (propertyInfo.PropertyType == typeof(bool))
                                    {
                                        bool tmpBool = (bool) tmpValue;
                                        tmpXmlElement.InnerText = tmpBool ? "1" : "0";
                                    }
                                    else
                                    {
                                        tmpXmlElement.InnerText = tmpValue == null ? "" : tmpValue.ToString();
                                    }
                                }
                                tmpParent.AppendChild(tmpXmlElement);
                            }
                        }

                    }
                }
            }
            #endregion

            return xmlDocument.OuterXml;
        }
               
        public void ImportFromXml(string valXml)
        {
            Type type = GetType();
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(valXml);
            XmlizedClassAttribute classAttribute = GetAttribute(type.GetCustomAttributes(true), a => a.GetType() == typeof(XmlizedClassAttribute)) as XmlizedClassAttribute;
            if (classAttribute == null)
            {
                return;
            }
            string DefaultPath = classAttribute.DefaultPath;

            foreach (PropertyInfo propertyInfo in type.GetProperties())
            {
                XmlizedPropertyAttribute propertyAttribute;
                foreach (Attribute attribute in propertyInfo.GetCustomAttributes(true))
                {
                    propertyAttribute = attribute as XmlizedPropertyAttribute;
                    if (propertyAttribute != null)
                    {
                        string tmpElementName = string.IsNullOrEmpty(propertyAttribute.ElementName)
                                                    ? propertyInfo.Name
                                                    : propertyAttribute.ElementName;
                        string tmpElementPath = string.IsNullOrEmpty(propertyAttribute.Path)
                                                    ? DefaultPath + @"/" + tmpElementName
                                                    : propertyAttribute.Path + @"/" + tmpElementName;
                        XmlNode tmpParentXmlNode = xmlDocument.SelectSingleNode(tmpElementPath);
                        //继承了IExportToXmlable接口的属性
                        if (propertyInfo.PropertyType.GetInterface("IExportToXmlable", true) == typeof(IExportToXmlable))
                        {
                            IImportFromXmlable importFromXmlable =
                                propertyInfo.GetValue(this, null) as IImportFromXmlable;
                            if (importFromXmlable != null) importFromXmlable.ImportFromXml(tmpParentXmlNode.OuterXml);
                        }
                        else
                        {
                            //继承了List<IImportFromXmlable>的属性
                            if (propertyInfo.PropertyType.IsGenericType)
                            {
                                Type tmpType = propertyInfo.PropertyType.GetGenericArguments()[0];
                                IImportFromXmlable tmpImportFromXmlableInstance;
                                if (tmpType.GetInterface("IImportFromXmlable") == typeof(IImportFromXmlable))
                                {
                                    IList importFromXmlables = propertyInfo.GetValue(this, null) as IList;
                                    Assembly assembly = Assembly.GetAssembly(tmpType);
                                    foreach (XmlNode tmpChildNode in tmpParentXmlNode.ChildNodes)
                                    {
                                        tmpImportFromXmlableInstance =
                                            assembly.CreateInstance(tmpType.FullName) as IImportFromXmlable;
                                        if (tmpImportFromXmlableInstance != null)
                                        {
                                            tmpImportFromXmlableInstance.ImportFromXml(tmpChildNode.OuterXml);
                                            if (importFromXmlables != null)
                                            {
                                                importFromXmlables.Add(tmpImportFromXmlableInstance);
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                //枚举类型
                                if (propertyInfo.PropertyType.IsEnum)
                                {
                                	if (Enum.IsDefined(propertyInfo.PropertyType,Convert.ToInt32(tmpParentXmlNode.InnerXml)))
                                    {
                                        object tmpValue = Enum.Parse(propertyInfo.PropertyType,
                                                                     tmpParentXmlNode.InnerXml);
                                        propertyInfo.SetValue(this, tmpValue, null);
                                    }
                                }
                                //普通值类型属性
                                else
                                {
                                    //bool型
                                    if (propertyInfo.PropertyType == typeof(bool))
                                    {
                                        propertyInfo.SetValue(this, tmpParentXmlNode.InnerText != "0", null);
                                    }
                                    else
                                    {
                                        object tmpValue = Convert.ChangeType(tmpParentXmlNode.InnerText,
                                                                             propertyInfo.PropertyType);
                                        propertyInfo.SetValue(this, tmpValue, null);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private Attribute GetAttribute( object[] valAttibutes,Predicate<Attribute> valPredicate)
        {
            foreach (Attribute valAttibute in valAttibutes)
            {
                if (valPredicate(valAttibute))
                {
                    return valAttibute;
                }
            }
            return null;
        }
    }

    [XmlizedClass(XmlTemplate = @"<Record><RecordInformations></RecordInformations></Record>",DefaultPath = @"/Record/RecordInformations")]
    [XmlizedSqlstringIDClass(SqlStringIDLoad = 1, SqlStringIDAdd = 2, SqlStringIDEdit = 3, SqlStringIDRemove = 4,Path = @"/Record")]
    public class TestClass : AbstractTestClass
    {
        public TestClass()
        {
            Sub=new SubClass();
            _subs = new List<SubClass>();
        }

        [XmlizedProperty(ElementName = @"计费类型")]
        public string 计费类型 { get; set; }

        [XmlizedProperty(ElementName = @"拼音码")]
        public string 拼音码 { get; set; }
        
        [XmlizedProperty]
        public bool 判断{get;set;}

        [XmlizedProperty(ElementName = @"备注")]
        public string 备注 { get; set; }

        [XmlizedProperty]
        public MyEnum Enum { get; set; }

        [XmlizedProperty]
        public SubClass Sub { get; set; }

        private readonly List<SubClass> _subs;
        [XmlizedProperty(ElementName = "Subs")]
        public List<SubClass> Subs
        {
            get
            {
                return _subs;
            }
        }
    }

    [XmlizedClass(XmlTemplate = @"<Sub></Sub>", DefaultPath = @"/Sub")]
    public class SubClass:AbstractTestClass
    {
        [XmlizedProperty]
        public string P1 { get; set; }

        [XmlizedProperty]
        public string P2 { get; set; }
    }

    public enum MyEnum
    {
        是=1,
        否=2
    }
}
