using System.Data;
using ClassLibraryAbstractDataInformation;
using ClassLibraryDataTableFromQueryString;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryGetSQLString;
using ClassLibraryXmlizedAttribute;

namespace ClassLibraryCostItems
{
    [XmlizedSqlstringIDClass(SqlStringIDLoad = 120, SqlStringIDAdd = 122, SqlStringIDEdit = 121, SqlStringIDRemove = 123, Path = @"/Record")]
    [XmlizedClass(XmlTemplate = @"<Record><RecordInformations></RecordInformations></Record>", DefaultPath = @"/Record/RecordInformations")]
    public class ClassCostItemProperties : ClassAbstractData
    {
        #region 定义属性

        [XmlizedProperty]
        public string 收费项目 { get; set; }

        [XmlizedProperty]
        public string 拼音码 { get; set; }

        [XmlizedProperty]
        public double 单价 { get; set; }

        [XmlizedProperty]
        public long P_收费项目单位_ID { get; set; }

        [XmlizedProperty]
        public long P_计费类型_ID { get; set; }

        [XmlizedProperty]
        public string 备注 { get; set; }

        #endregion

        #region 覆写抽象方法

        public override bool Check()
        {
            if (string.IsNullOrEmpty(收费项目))
            {
                OnError(new EventArgsOfExecuteError("收费项目的名称不能为空，请输入收费项目的名称！", "未通过数据合法性检查！"));
                return false;
            }

            if (string.IsNullOrEmpty(拼音码))
            {
                OnError(new EventArgsOfExecuteError("收费项目的拼音码不能为空，请输入收费项目的拼音码！", "未通过数据合法性检查！"));
                return false;
            }

            

            if (P_收费项目单位_ID < 1)
            {
                OnError(new EventArgsOfExecuteError("请设置收费项目单位！", "未通过数据合法性检查！"));
                return false;
            }

            if (P_计费类型_ID < 1)
            {
                OnError(new EventArgsOfExecuteError("请设置计费类型！", "未通过数据合法性检查！"));
                return false;
            }

            return true;
        }

        public override void Clear()
        {
            收费项目 = null;
            拼音码 = null;
            备注 = null;
        }

        #endregion
    }

    [XmlizedSqlstringIDClass(SqlStringIDLoad = 130, Path = @"/Record")]
    [XmlizedClass(XmlTemplate = @"<Record><CostItemPropertiesSimple></CostItemPropertiesSimple></Record>", DefaultPath = @"/Record/CostItemPropertiesSimple")]
    public class ClassCostItemPropertiesSimple:ClassAbstractData
    {
        #region 定义属性

        [XmlizedProperty]
        public string 收费项目 { get; set; }

        [XmlizedProperty]
        public double 单价 { get; set; }

        [XmlizedProperty]
        public string 计量单位 { get; set; }

        #endregion

        #region 覆写抽象方法

        public override bool Check()
        {
            return true;
        }

        public override void Clear()
        {
        }

        #endregion
    }

    ///// <summary>
    ///// 任何操作员都可进行此操作
    ///// </summary>
    //public class ClassCostItemPropertiesLoader : ClassAbstractDataLoader
    //{
    //    public ClassCostItemPropertiesLoader(ClassLoginInformation valLoginInformation, ClassAbstractData valData)
    //        : base(valLoginInformation, valData)
    //    {

    //    }

    //    protected override bool LoaduUnderTheRules(IDataReader valSqlDataReader)
    //    {
    //        ClassCostItemProperties costItemProperties = Data as ClassCostItemProperties;
    //        if (costItemProperties != null)
    //        {
    //            try
    //            {
    //                if (valSqlDataReader.Read())
    //                {
    //                    costItemProperties.收费项目 = valSqlDataReader["收费项目"] as string;
    //                    costItemProperties.拼音码 = valSqlDataReader["拼音码"] as string;
    //                    costItemProperties.单价 = (double) (decimal) (valSqlDataReader["单价"]);
    //                    //costItemProperties.单价 = (double)(decimal)(valSqlDataReader["单价"] == DBNull.Value ? 0M : valSqlDataReader["单价"]);
                        
    //                    costItemProperties.P_收费项目单位_ID = (long)valSqlDataReader["P_收费项目单位_ID"];
    //                    costItemProperties.P_计费类型_ID = (long)valSqlDataReader["P_计费类型_ID"];
    //                    costItemProperties.备注 = valSqlDataReader["备注"] as string;
    //                    costItemProperties.P_操作员_ID = (long)valSqlDataReader["P_操作员_ID"];
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

    //    protected override long ExecuteStringID
    //    {
    //        get
    //        {
    //            //(53)SELECT * FROM dbo.P_收费项目表 WHERE ID = {0}
    //            return 53L;
    //        }
    //    }
    //}

    ///// <summary>
    ///// 超级用户才能进行此操作
    ///// </summary>
    //public class ClassCostItemPropertiesAdder : ClassAbstractDataAdder
    //{
    //    public ClassCostItemPropertiesAdder(ClassLoginInformation valLoginInformation, ClassAbstractData valData)
    //        : base(valLoginInformation, 56, valData, EnumAuthorityLevel.有权限的操作员)
    //    {
    //    }

    //    protected override string ExecuteString
    //    {
    //        get
    //        {
    //            ClassCostItemProperties costTypeProperties = Data as ClassCostItemProperties;
    //            if (costTypeProperties != null)
    //            {
    //                //(54)INSERT INTO dbo.P_收费项目表 (收费项目,拼音码,P_收费项目单位_ID,P_计费类型_ID,备注,P_操作员_ID) VALUES ( N'{0}',N'{1}',{2},{3},N'{4}',{5} ) 
    //                string tmpSqlString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 54);
    //                if (string.IsNullOrEmpty(tmpSqlString1))
    //                {
    //                    return null;
    //                }

    //                string tmpSqlString = string.Format(tmpSqlString1, costTypeProperties.收费项目, costTypeProperties.拼音码,
    //                                                    costTypeProperties.P_收费项目单位_ID, costTypeProperties.P_计费类型_ID,
    //                                                    costTypeProperties.备注, LoginInformation.OperaterID);
    //                return tmpSqlString;
    //            }
    //            return null;
    //        }
    //    }
    //}

    ///// <summary>
    ///// 超级用户才能进行此操作
    ///// </summary>
    //public class ClassCostItemPropertiesEditer:ClassAbstractDataEditer
    //{
    //    public ClassCostItemPropertiesEditer(ClassLoginInformation valLoginInformation,  ClassAbstractData valData)
    //        : base(valLoginInformation, 57, valData, EnumAuthorityLevel.有权限且创建该记录的操作员)
    //    {
    //    }

    //    protected override ClassAbstractDataLoader DataLoader
    //    {
    //        get { return new ClassCostItemPropertiesLoader(LoginInformation, Data); }
    //    }

    //    protected override string ExecuteString
    //    {
    //        get
    //        {

    //            ClassCostItemProperties costTypeProperties = Data as ClassCostItemProperties;
    //            if (costTypeProperties != null)
    //            {
    //                //(55)UPDATE dbo.P_收费项目表 SET 收费项目 = '{0}',拼音码 = '{1}',P_收费项目单位_ID = {2},P_计费类型_ID = {3},备注 = '{4}' WHERE ID = {5}
    //                string tmpSqlString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 55);
    //                if (string.IsNullOrEmpty(tmpSqlString1))
    //                {
    //                    return null;
    //                }
    //                string tmpSqlString = string.Format(tmpSqlString1, costTypeProperties.收费项目, costTypeProperties.拼音码,
    //                                                    costTypeProperties.P_收费项目单位_ID, costTypeProperties.P_计费类型_ID,
    //                                                    costTypeProperties.备注, costTypeProperties.ID);
    //                return tmpSqlString;
    //            }
    //            return null;
    //        }
    //    }
    //}
    
    ///// <summary>
    ///// 超级用户才能进行此操作
    ///// </summary>
    //public class ClassCostItemPropertiesRemover:ClassAbstractDataRemover
    //{
    //    public ClassCostItemPropertiesRemover(ClassLoginInformation valLoginInformation, long valID)
    //        : base(valLoginInformation, 58, "P_收费项目表", new ClassCostItemProperties(valID), EnumAuthorityLevel.有权限且创建该记录的操作员)
    //    {
    //    }

    //    protected override ClassAbstractDataLoader DataLoader
    //    {
    //        get { return new ClassCostItemPropertiesLoader(LoginInformation, Data); }
    //    }
    //}

    /// <summary>
    /// 公共方法
    /// </summary>
    public class ClassCostItemPublic
    {
        public static DataTable LoadAllCostItemUnit(string valConnectionString)
        {
            //(58)SELECT ID,单位名称 FROM dbo.P_收费项目单位表 ORDER BY ID
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valConnectionString, 58);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return null;
            }
            string tmpSQLstring = tmpSQLString1;
            DataTableFromQueryString tmpDepartmentInformations = new DataTableFromQueryString(valConnectionString,
                                                                                              tmpSQLstring);
            return tmpDepartmentInformations.value;
        }

    }
}
