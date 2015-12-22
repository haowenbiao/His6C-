using ClassLibraryAbstractDataInformation;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryXmlizedAttribute;

namespace ClassLibraryCostItemUnit
{
    [XmlizedSqlstringIDClass(SqlStringIDLoad = 137, SqlStringIDAdd = 139, SqlStringIDEdit = 138, SqlStringIDRemove = 140, Path = @"/Record")]
    [XmlizedClass(XmlTemplate = @"<Record><RecordInformations></RecordInformations></Record>", DefaultPath = @"/Record/RecordInformations")]
    public class ClassCostItemUnitProperties : ClassAbstractData
    {
        #region 属性

        [XmlizedProperty]
        public string 单位名称 { get; set; }

        #endregion

        #region 覆写抽象方法

        public override bool Check()
        {
            if (string.IsNullOrEmpty(单位名称))
            {
                OnError(new EventArgsOfExecuteError("单位名称不能为空，请输入单位名称！", "未通过数据合法性检查！"));
                return false;
            }
            return true;
        }

        public override void Clear()
        {
            单位名称 = null;
        }

        #endregion
    }
}
