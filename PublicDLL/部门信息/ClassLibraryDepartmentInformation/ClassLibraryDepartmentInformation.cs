using ClassLibraryAbstractDataInformation;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryXmlizedAttribute;

namespace ClassLibraryDepartmentInformation
{
    [XmlizedSqlstringIDClass(SqlStringIDLoad = 133, SqlStringIDAdd = 135, SqlStringIDEdit = 134, SqlStringIDRemove = 136, Path = @"/Record")]
    [XmlizedClass(XmlTemplate = @"<Record><RecordInformations></RecordInformations></Record>", DefaultPath = @"/Record/RecordInformations")]
    public class ClassDepartmentProperties : ClassAbstractData
    {
        public ClassDepartmentProperties()
        {
            P_部门类型_ID = 1;
        }

        [XmlizedProperty]
        public string 名称 { get; set; }

        [XmlizedProperty]
        public string 拼音码 { get; set; }

        [XmlizedProperty]
        public long P_部门类型_ID { get; set; }

        [XmlizedProperty]
        public string 负责人 { get; set; }

        [XmlizedProperty]
        public string 备注 { get; set; }

        public override bool Check()
        {
            if (string.IsNullOrEmpty(名称))
            {
                EventArgsOfExecuteError tmpEventArgsOfError = new EventArgsOfExecuteError("姓名不能为空，请输入姓名！", "未通过数据合法性检查！");
                OnError(tmpEventArgsOfError);
                return false;
            }
            if (string.IsNullOrEmpty(拼音码))
            {
                EventArgsOfExecuteError tmpEventArgsOfError = new EventArgsOfExecuteError("拼音码不能为空，请输入拼音码！", "未通过数据合法性检查！");
                OnError(tmpEventArgsOfError);
                return false;
            }
            return true;
        }

        public override void Clear()
        {
            名称 = null;
            拼音码 = null;
            负责人 = null;
            备注 = null;
        }
    }
}
