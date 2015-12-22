using System.Data;
using ClassLibraryAbstractDataInformation;
using ClassLibraryDataTableFromQueryString;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryGetSQLString;
using ClassLibraryXmlizedAttribute;

namespace ClassLibraryCostType
{
    [XmlizedSqlstringIDClass(SqlStringIDLoad = 116, SqlStringIDAdd = 118, SqlStringIDEdit = 117, SqlStringIDRemove = 119, Path = @"/Record")]
    [XmlizedClass(XmlTemplate = @"<Record><RecordInformations></RecordInformations></Record>", DefaultPath = @"/Record/RecordInformations")]
    public class ClassCostTypeProperties : ClassAbstractData
    {
        #region 定义属性

        [XmlizedProperty]
        public string 计费类型 { get; set; }

        [XmlizedProperty]
        public string 拼音码 { get; set; }

        [XmlizedProperty]
        public string 备注 { get; set; }

        #endregion

        #region 覆写虚方法

        public override bool Check()
        {
            if (string.IsNullOrEmpty(计费类型))
            {
                OnError(new EventArgsOfExecuteError("计费类型的名称不能为空，请输入计费类型的名称！", "未通过数据合法性检查！"));
                return false;
            }

            if (string.IsNullOrEmpty(拼音码))
            {
                OnError(new EventArgsOfExecuteError("计费类型的拼音码不能为空，请输入计费类型的拼音码！", "未通过数据合法性检查！"));
                return false;
            }
            return true;
        }

        public override void Clear()
        {
            计费类型 = null;
            拼音码 = null;
            备注 = null;
        }

        #endregion
    }

    ///// <summary>
    ///// 任何操作员都可进行此操作
    ///// </summary>
    //public class ClassCostTypePropertiesLoader : ClassAbstractDataLoader
    //{
    //    public ClassCostTypePropertiesLoader(ClassLoginInformation valLoginInformation, ClassAbstractData valData)
    //        : base(valLoginInformation, valData)
    //    {

    //    }

    //    protected override bool LoaduUnderTheRules(IDataReader valSqlDataReader)
    //    {
    //        ClassCostTypeProperties costTypeProperties = Data as ClassCostTypeProperties;
    //        if (costTypeProperties != null)
    //        {
    //            try
    //            {
    //                if (valSqlDataReader.Read())
    //                {
    //                    costTypeProperties.计费类型 = valSqlDataReader["计费类型"] as string;
    //                    costTypeProperties.拼音码 = valSqlDataReader["拼音码"] as string;
    //                    costTypeProperties.备注 = valSqlDataReader["备注"] as string;
    //                    costTypeProperties.P_操作员_ID = (long)valSqlDataReader["P_操作员_ID"];
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
    //        //(44)SELECT * FROM dbo.P_计费类型表 WHERE ID = {0}
    //        get { return 44L; }
    //    }
    //}

    ///// <summary>
    ///// 超级用户才能进行此操作
    ///// </summary>
    //public class ClassCostTypePropertiesAdder : ClassAbstractDataAdder
    //{
    //    /// <summary>
    //    ///  超级用户才能进行此操作
    //    /// </summary>
    //    /// <param name="valLoginInformation"></param>
    //    /// <param name="valData"></param>
    //    public ClassCostTypePropertiesAdder(ClassLoginInformation valLoginInformation, ClassAbstractData valData)
    //        : base(valLoginInformation, 67, valData,EnumAuthorityLevel.有权限的操作员)
    //    {

    //    }

    //    protected override string ExecuteString
    //    {
    //        get
    //        {
    //            ClassCostTypeProperties costTypeProperties = Data as ClassCostTypeProperties;
    //            if (costTypeProperties != null)
    //            {
    //                //(45)INSERT INTO dbo.P_计费类型表 (计费类型,拼音码,备注,P_操作员_ID) VALUES (N'{0}',/ N'{1}',N'{2}',{3})
    //                string tmpSqlString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 45);
    //                if (string.IsNullOrEmpty(tmpSqlString1))
    //                {
    //                    return null;
    //                }

    //                string tmpSqlString = string.Format(tmpSqlString1, costTypeProperties.计费类型, costTypeProperties.拼音码,
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
    //public class ClassCostTypePropertiesEditer : ClassAbstractDataEditer
    //{
    //    /// <summary>
    //    /// 超级用户才能进行此操作
    //    /// </summary>
    //    /// <param name="valLoginInformation"></param>
    //    /// <param name="valData"></param>
    //    public ClassCostTypePropertiesEditer(ClassLoginInformation valLoginInformation, ClassAbstractData valData)
    //        : base(valLoginInformation, 68, valData,EnumAuthorityLevel.有权限且创建该记录的操作员)
    //    {

    //    }

    //    protected override string ExecuteString
    //    {
    //        get
    //        {

    //            ClassCostTypeProperties costTypeProperties = Data as ClassCostTypeProperties;
    //            if (costTypeProperties != null)
    //            {
    //                //(46)UPDATE dbo.P_计费类型表 SET 计费类型 = '{0}',拼音码 = '{1}',备注 = '{2}' WHERE ID = {3}
    //                string tmpSqlString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 46);
    //                if (string.IsNullOrEmpty(tmpSqlString1))
    //                {
    //                    return null;
    //                }
    //                string tmpSqlString = string.Format(tmpSqlString1, costTypeProperties.计费类型, costTypeProperties.拼音码,
    //                                                    costTypeProperties.备注, costTypeProperties.ID);
    //                return tmpSqlString;
    //            }
    //            return null;
    //        }
    //    }

    //    protected override ClassAbstractDataLoader DataLoader
    //    {
    //        get { return new ClassCostTypePropertiesLoader(LoginInformation, Data); }
    //    }
    //}

    ///// <summary>
    ///// 超级用户才能进行此操作
    ///// </summary>
    //public class ClassCostTypePropertiesRemover:ClassAbstractDataRemover
    //{

    //    public ClassCostTypePropertiesRemover(ClassLoginInformation valLoginInformation, long valID)
    //        : base(valLoginInformation, 70, "P_计费类型表", new ClassCostTypeProperties(valID),EnumAuthorityLevel.有权限且创建该记录的操作员)
    //    {
            
    //    }

    //    protected override ClassAbstractDataLoader DataLoader
    //    {
    //        get { return new ClassCostTypePropertiesLoader(LoginInformation, Data); }
    //    }
    //}

    public class ClassLibraryCostTypePublic
    {
        /// <summary>
        /// 夹在所有计费类型
        /// </summary>
        /// <param name="valConnectionString"></param>
        /// <returns></returns>
        public static DataTable LoadAllCostType(string valConnectionString)
        {
            //(39)SELECT ID,计费类型 FROM dbo.P_计费类型表 ORDER BY ID
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valConnectionString, 39);
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

