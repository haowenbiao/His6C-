using System;

namespace ClassLibraryXmlizedAttribute
{
    public interface IImportFromXmlable
    {
        void ImportFromXml(string valXml);
    }

    public interface IExportToXmlable
    {
        string ExportToXml();
    }

    [AttributeUsage(AttributeTargets.Property,AllowMultiple = false)]
    public class XmlizedPropertyAttribute : Attribute
    {
        public string ElementName { get; set; }

        public string Path { get; set; }
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class XmlizedClassAttribute:Attribute
    {
        public string XmlTemplate { get; set; }

        public string DefaultPath { get; set; }
    }

    [AttributeUsage(AttributeTargets.Class,AllowMultiple = false)]
    public class XmlizedSqlstringIDClassAttribute:Attribute
    {
        public long SqlStringIDLoad { get; set; }
        public long SqlStringIDAdd { get; set; }
        public long SqlStringIDEdit { get; set; }
        public long SqlStringIDRemove { get; set; }

        public string Path { get; set; }

        public string ToXml()
        {
            string tmpFormatXml = @"<SqlStringID><SqlStringIDLoad>{0}</SqlStringIDLoad><SqlStringIDAdd>{1}</SqlStringIDAdd><SqlStringIDEdit>{2}</SqlStringIDEdit><SqlStringIDRemove>{3}</SqlStringIDRemove></SqlStringID>";
            string tmpXml = string.Format(tmpFormatXml, SqlStringIDLoad, SqlStringIDAdd, SqlStringIDEdit,
                                          SqlStringIDRemove);
            return tmpXml;
        }
    }
}
