using ClassLibraryAbstractDataInformation;
using ClassLibraryMedicineKind;
using ClassLibraryXmlizedAttribute;

namespace ClassLibraryMedicineKindAdjustPrice
{
    [XmlizedSqlstringIDClass(SqlStringIDEdit = 132, Path = @"/Record")]
    [XmlizedClass(XmlTemplate = @"<Record><RecordInformations></RecordInformations></Record>", DefaultPath = @"/Record/RecordInformations")]
    public class ClassMedicineKindAdjustPriceProperties : ClassAbstractData
    {
        #region 属性

        public ClassMedicineKindPropertiesSimple MedicineKindProperties { get; set; }

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

    //public class ClassMedicineKindAdjustPricePropertiesAdder:ClassAbstractDataAdder
    //{
    //    public ClassMedicineKindAdjustPricePropertiesAdder(ClassLoginInformation valLoginInformation, ClassAbstractData valData)
    //        : base(valLoginInformation, 42, valData, EnumAuthorityLevel.有权限的操作员)
    //    {
    //    }

    //    protected override string ExecuteString
    //    {
    //        get
    //        {
    //            ClassMedicineKindAdjustPriceProperties medicineKindAdjustPriceProperties = Data as ClassMedicineKindAdjustPriceProperties;
    //            if (medicineKindAdjustPriceProperties != null)
    //            {
    //                //(70)UPDATE dbo.YKGL_药品种类表 SET 单价 = {0} WHERE ID = {1};INSERT INTO dbo.YKGL_药品销售价格调整记录表 (YKGL_药品种类_ID,单价,备注,P_操作员_ID) VALUES ( {1},{0},N'{2}',{3} )
    //                string tmpSqlString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 70);
    //                if (string.IsNullOrEmpty(tmpSqlString1))
    //                {
    //                    return null;
    //                }

    //                string tmpSqlString = string.Format(tmpSqlString1, medicineKindAdjustPriceProperties.调整后单价,
    //                                                    medicineKindAdjustPriceProperties.MedicineKindProperties.ID,
    //                                                    medicineKindAdjustPriceProperties.备注, LoginInformation.OperaterID);
    //                return tmpSqlString;
    //            }
    //            return null;
    //        }
    //    }
    //}

    public class ClassMedicineKindAdjustPricePublic
    {
        //public static DataTable LoadAllMedicineKinds(string valConnectionString)
        //{
        //    //(72)SELECT ID,通用名称,通用名称_拼音码,商品名称,商品名称_拼音码 FROM dbo.YKGL_药品种类表 ORDER BY ID
        //    string tmpSQLString1 = ClassGetSQLString.GetSQLString(valConnectionString, 72);
        //    if (string.IsNullOrEmpty(tmpSQLString1))
        //    {
        //        return null;
        //    }
        //    string tmpSqlString = tmpSQLString1;
        //    DataTableFromQueryString tmpDepartmentInformations = new DataTableFromQueryString(valConnectionString,
        //                                                                                      tmpSqlString);
        //    DataTable tmpDataTable = tmpDepartmentInformations.value;
        //    object[] tmpNewRow = new object[5];
        //    tmpNewRow[0] = 0L;
        //    tmpNewRow[1] = "";
        //    tmpNewRow[2] = "";
        //    tmpNewRow[3] = "所有药品";
        //    tmpNewRow[4] = "";
        //    tmpDataTable.Rows.Add(tmpNewRow);
        //    tmpDataTable.DefaultView.Sort = "ID";
        //    return tmpDataTable;
        //}
    }
}
