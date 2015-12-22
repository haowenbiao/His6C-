using System.Data;
using ClassLibraryAbstractDataInformation;
using ClassLibraryCostItems;
using ClassLibraryDataTableFromQueryString;
using ClassLibraryGetSQLString;
using ClassLibraryXmlizedAttribute;

namespace ClassLibraryCostItemAdjustPrice
{
    [XmlizedSqlstringIDClass(SqlStringIDEdit = 131, Path = @"/Record")]
    [XmlizedClass(XmlTemplate = @"<Record><RecordInformations></RecordInformations></Record>",DefaultPath = @"/Record/RecordInformations")]
    public class ClassCostItemAdjustPriceProperties : ClassAbstractData
    {
        #region 属性
        
        public ClassCostItemPropertiesSimple CostItemProperties { get; set; }

        [XmlizedProperty]
        public decimal 调整后单价 { get; set; }

        [XmlizedProperty]
        public string 备注 { get; set; }

        #endregion

        #region 覆写抽象方法

        public override bool Check()
        {
            return true;
        }

        public override void Clear()
        {
            return;
        }

        #endregion
    }

    public class ClassCostItemAdjustPricePublic
    {
        public static DataTable LoadAllCostItem(string valConnectionString)
        {
            //(69)SELECT ID,收费项目 FROM dbo.P_收费项目表
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valConnectionString, 69);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return null;
            }
            string tmpSqlString = tmpSQLString1;
            DataTableFromQueryString tmpDepartmentInformations = new DataTableFromQueryString(valConnectionString,
                                                                                              tmpSqlString);
            DataTable tmpDataTable = tmpDepartmentInformations.value;
            object[] tmpNewRow = new object[2];
            tmpNewRow[0] = 0L;
            tmpNewRow[1] = "所有收费项目";
            tmpDataTable.Rows.Add(tmpNewRow);
            tmpDataTable.DefaultView.Sort = "ID";
            return tmpDataTable;
        }
    }
}
