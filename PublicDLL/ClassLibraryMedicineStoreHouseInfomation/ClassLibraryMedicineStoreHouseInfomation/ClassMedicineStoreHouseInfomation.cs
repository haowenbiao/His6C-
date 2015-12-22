using System.Data;
using ClassLibraryAbstractDataInformation;
using ClassLibraryDataTableFromQueryString;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryGetSQLString;
using ClassLibraryPublicEnum;
using ClassLibraryXmlizedAttribute;

namespace ClassLibraryMedicineStoreHouseInfomation
{
    [XmlizedSqlstringIDClass(SqlStringIDLoad = 152, SqlStringIDAdd = 154, SqlStringIDEdit = 153, SqlStringIDRemove = 155, Path = @"/Record")]
    [XmlizedClass(XmlTemplate = @"<Record><RecordInformations></RecordInformations></Record>", DefaultPath = @"/Record/RecordInformations")]
    public class ClassMedicineStoreHouseInfomationProperties : ClassAbstractData
    {

        #region 定义属性

        [XmlizedProperty]
        public string 药库名称 { get; set; }

        [XmlizedProperty]
        public string 拼音码 { get; set; }

        [XmlizedProperty]
        public string 位置 { get; set; }
              
        [XmlizedProperty]
        public string 负责人 { get; set; }

        [XmlizedProperty]
        public long YKGL_药库类型_ID { get; set; }

        [XmlizedProperty]
        public string 备注 { get; set; }

        #endregion

        public override bool Check()
        {
            if (string.IsNullOrEmpty(药库名称))
            {
                OnError(new EventArgsOfExecuteError("药库名称不能为空，请输入药库名称！", "未通过数据合法性检查！"));
                return false;
            }
            if (string.IsNullOrEmpty(拼音码))
            {
                OnError(new EventArgsOfExecuteError("药库拼音码不能为空，请输入药库拼音码！", "未通过数据合法性检查！"));
                return false;
            }

            if (YKGL_药库类型_ID < 1)
            {
                OnError(new EventArgsOfExecuteError("请设置药库类型！", "未通过数据合法性检查！"));
                return false;
            }
            return true;
        }

        public override void Clear()
        {
            药库名称 = null;
            拼音码 = null;
            位置 = null;
            负责人 = null;
            备注 = null;
        }
    }

    //public class ClassMedicineStoreHouseInfomationPropertiesLoader:ClassAbstractDataLoader
    //{
    //    public ClassMedicineStoreHouseInfomationPropertiesLoader(ClassLoginInformation valLoginInformation, ClassAbstractData valData)
    //        : base(valLoginInformation, valData)
    //    {
    //    }

    //    protected override long ExecuteStringID
    //    {
    //        get 
    //        {
    //            //(76)SELECT * FROM dbo.YKGL_药库信息表 WHERE ID = {0}
    //            return 76L;
    //        }
    //    }

    //    protected override bool LoaduUnderTheRules(IDataReader valSqlDataReader)
    //    {
    //        ClassMedicineStoreHouseInfomationProperties medicineStoreHouseInfomationProperties = Data as ClassMedicineStoreHouseInfomationProperties;
    //        if (medicineStoreHouseInfomationProperties != null)
    //        {
    //            try
    //            {
    //                if (valSqlDataReader.Read())
    //                {
    //                    medicineStoreHouseInfomationProperties.药库名称 = valSqlDataReader["药库名称"] as string;
    //                    medicineStoreHouseInfomationProperties.拼音码 = valSqlDataReader["拼音码"] as string;
    //                    medicineStoreHouseInfomationProperties.位置 = valSqlDataReader["位置"] as string;
    //                    medicineStoreHouseInfomationProperties.负责人 = valSqlDataReader["负责人"] as string;
    //                    medicineStoreHouseInfomationProperties.YKGL_药库类型_ID = (long)valSqlDataReader["YKGL_药库类型_ID"];
    //                    medicineStoreHouseInfomationProperties.备注 = valSqlDataReader["备注"] as string;
    //                    medicineStoreHouseInfomationProperties.P_操作员_ID = (long)valSqlDataReader["P_操作员_ID"];
    //                }
    //                return true;
    //            }
    //            catch (Exception)
    //            {
    //                return false;
    //            }
    //        }
    //        return false;
    //    }
    //}

    //public class ClassMedicineStoreHouseInfomationPropertiesAdder:ClassAbstractDataAdder
    //{
    //    public ClassMedicineStoreHouseInfomationPropertiesAdder(ClassLoginInformation valLoginInformation, ClassAbstractData valData)
    //        : base(valLoginInformation, 85, valData, EnumAuthorityLevel.有权限的操作员)
    //    {
    //    }

    //    protected override string ExecuteString
    //    {
    //        get
    //        {
    //            ClassMedicineStoreHouseInfomationProperties tmpData = Data as ClassMedicineStoreHouseInfomationProperties;
    //            if (tmpData != null)
    //            {
    //                //(77)INSERT INTO dbo.YKGL_药库信息表 
    //                //(药库名称,拼音码,位置,负责人,YKGL_药库类型_ID,备注,P_操作员_ID) 
    //                //VALUES (N'{0}',N'{1}',N'{2}',N'{3}',{4},N'{5}',{6} ) 
    //                string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 77);
    //                if (string.IsNullOrEmpty(tmpSQLString1))
    //                {
    //                    return null;
    //                }
    //                string tmpSQLString = string.Format(tmpSQLString1, tmpData.药库名称,
    //                                                    tmpData.拼音码,
    //                                                    tmpData.位置,
    //                                                    tmpData.负责人,
    //                                                    tmpData.YKGL_药库类型_ID,
    //                                                    tmpData.备注,
    //                                                    LoginInformation.OperaterID);
    //                return tmpSQLString;
    //            }
    //            return null;
    //        }
    //    }
    //}

    //public class ClassMedicineStoreHouseInfomationPropertiesEditer:ClassAbstractDataEditer
    //{
    //    public ClassMedicineStoreHouseInfomationPropertiesEditer(ClassLoginInformation valLoginInformation, ClassAbstractData valData)
    //        : base(valLoginInformation, 86, valData, EnumAuthorityLevel.有权限且创建该记录的操作员)
    //    {
    //    }

    //    protected override ClassAbstractDataLoader DataLoader
    //    {
    //        get { return new ClassMedicineStoreHouseInfomationPropertiesLoader(LoginInformation, Data); }
    //    }

    //    protected override string ExecuteString
    //    {
    //        get
    //        {
    //            ClassMedicineStoreHouseInfomationProperties medicineStoreHouseInfomationProperties = Data as ClassMedicineStoreHouseInfomationProperties;
    //            if (medicineStoreHouseInfomationProperties != null)
    //            {
    //                //(78)UPDATE dbo.YKGL_药库信息表 
    //                //SET 药库名称 = '{0}',
    //                //拼音码 = '{1}',
    //                //位置 = '{2}',
    //                //负责人 = '{3}',
    //                //YKGL_药库类型_ID {4},
    //                //备注 = '{5}' 
    //                //WHERE ID = {6}
    //                string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 78);
    //                if (string.IsNullOrEmpty(tmpSQLString1))
    //                {
    //                    return null;
    //                }
    //                string tmpSQLString = string.Format(tmpSQLString1, medicineStoreHouseInfomationProperties.药库名称,
    //                                                    medicineStoreHouseInfomationProperties.拼音码,
    //                                                    medicineStoreHouseInfomationProperties.位置,
    //                                                    medicineStoreHouseInfomationProperties.负责人,
    //                                                    medicineStoreHouseInfomationProperties.YKGL_药库类型_ID,
    //                                                    medicineStoreHouseInfomationProperties.备注,
    //                                                    medicineStoreHouseInfomationProperties.ID);
    //                return tmpSQLString;
    //            }
    //            return null;
    //        }
    //    }
    //}

    //public class ClassMedicineStoreHouseInfomationPropertiesRemover:ClassAbstractDataRemover
    //{
    //    public ClassMedicineStoreHouseInfomationPropertiesRemover(ClassLoginInformation valLoginInformation, long  valID)
    //        : base(valLoginInformation, 87, "YKGL_药库信息表", new ClassMedicineStoreHouseInfomationProperties(valID), EnumAuthorityLevel.有权限且创建该记录的操作员)
    //    {
    //    }

    //    protected override ClassAbstractDataLoader DataLoader
    //    {
    //        get { return new ClassMedicineStoreHouseInfomationPropertiesLoader(LoginInformation, Data); }
    //    }
    //}

    public class ClassMedicineStoreHouseInfomationPropertiesPublic
    {
        public static DataTable LoadAllMedicineStoreHouseInformationType(string valConnectionString)
        {
            //(81)SELECT ID,名称 FROM dbo.YKGL_药库类型表 ORDER BY ID
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valConnectionString, 81);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return null;
            }
            string tmpSQLstring = tmpSQLString1;
            DataTableFromQueryString tmpDepartmentInformations = new DataTableFromQueryString(valConnectionString,
                                                                                              tmpSQLstring);
            return tmpDepartmentInformations.value;
        }

        public static DataTable LoadSuppliers(string valConnectionString, EnumLoadStoreHouseInformationType valLoadStoreHouseInformationType)
        {
            long tmpSqlStringID = 0L;
            bool tmpWithAll = false;
            string tmpAllString = "";
            switch (valLoadStoreHouseInformationType)
            {
                case EnumLoadStoreHouseInformationType.All:
                    tmpSqlStringID = 100L;
                    break;
                case EnumLoadStoreHouseInformationType.OnlyStoreHouse:
                    tmpSqlStringID = 101L;
                    break;
                case EnumLoadStoreHouseInformationType.OnlyDrugStore:
                    tmpSqlStringID = 102L;
                    break;
                case EnumLoadStoreHouseInformationType.AllWithAll:
                    tmpSqlStringID = 100L;
                    tmpWithAll = true;
                    tmpAllString = "所有药库";
                    break;
                case EnumLoadStoreHouseInformationType.OnlyStoreHouseWithAll:
                    tmpSqlStringID = 101L;
                    tmpWithAll = true;
                    tmpAllString = "所有库房";
                    break;
                case EnumLoadStoreHouseInformationType.OnlyDrugStoreWithAll:
                    tmpSqlStringID = 102L;
                    tmpWithAll = true;
                    tmpAllString = "所有药房";
                    break;
            }

            //(100)SELECT ID ,药库名称 ,拼音码 FROM dbo.YKGL_药库信息表 ORDER BY ID
            //(101)SELECT ID ,药库名称 ,拼音码 FROM dbo.YKGL_药库信息表 WHERE YKGL_药库类型_ID = 1 ORDER BY ID
            //(102)SELECT ID ,药库名称 ,拼音码 FROM dbo.YKGL_药库信息表 WHERE YKGL_药库类型_ID <> 1 ORDER BY ID
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valConnectionString, tmpSqlStringID);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return null;
            }
            string tmpSqlString = tmpSQLString1;
            DataTableFromQueryString tmpDepartmentInformations = new DataTableFromQueryString(valConnectionString,
                                                                                              tmpSqlString);
            DataTable tmpDataTable = tmpDepartmentInformations.value;
            if (tmpWithAll)
            {
                object[] tmpNewRow = new object[3];
                tmpNewRow[0] = 0L;
                tmpNewRow[1] = tmpAllString;
                tmpNewRow[2] = "all";
                tmpDataTable.Rows.Add(tmpNewRow);
            }
            tmpDataTable.DefaultView.Sort = "ID";
            return tmpDataTable;
        }
    }

}
