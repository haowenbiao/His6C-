using System.Data;
using ClassLibraryAbstractDataInformation;
using ClassLibraryDataTableFromQueryString;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryGetSQLString;
using ClassLibraryXmlizedAttribute;

namespace ClassLibraryQuantityUnit
{

    [XmlizedSqlstringIDClass(SqlStringIDLoad = 148, SqlStringIDAdd = 150, SqlStringIDEdit = 149, SqlStringIDRemove = 151, Path = @"/Record")]
    [XmlizedClass(XmlTemplate = @"<Record><RecordInformations></RecordInformations></Record>", DefaultPath = @"/Record/RecordInformations")]
    public class ClassQuantityUnitProperties : ClassAbstractData
    {

        #region 定义属性

        [XmlizedProperty]
        public string 名称 { get; set; }

        #endregion

        #region 覆写虚方法

        public override bool Check()
        {
            if (string.IsNullOrEmpty(名称))
            {
                OnError(new EventArgsOfExecuteError("计量单位名称不能为空！", "未通过数据合法性检查！"));
                return false;
            }
            return true;
        }

        public override void Clear()
        {
            名称 = null;
        }

        #endregion

    }

    //public class ClassQuantityUnitPropertiesLoader : ClassAbstractDataLoader
    //{
    //    public ClassQuantityUnitPropertiesLoader(ClassLoginInformation valLoginInformation, ClassAbstractData valData)
    //        : base(valLoginInformation, valData)
    //    {

    //    }

    //    protected override bool LoaduUnderTheRules(IDataReader valSqlDataReader)
    //    {
    //        ClassQuantityUnitProperties tmpQuantityUnitProperties = Data as ClassQuantityUnitProperties;
    //        if (tmpQuantityUnitProperties != null)
    //        {
    //            try
    //            {
    //                if (valSqlDataReader.Read())
    //                {
    //                    tmpQuantityUnitProperties.名称 = valSqlDataReader["名称"] as string;
    //                    tmpQuantityUnitProperties.P_操作员_ID = (long)valSqlDataReader["P_操作员_ID"];
    //                }
    //                return true;
    //            }
    //            catch
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
    //            //(30)SELECT * FROM YKGL_数量单位表 Where ID={0}
    //            return 30L;
    //        }
    //    }
    //}

    //public class ClassQuantityUnitPropertiesAdder : ClassAbstractDataAdder
    //{
    //    public ClassQuantityUnitPropertiesAdder(ClassLoginInformation valLoginInformation, ClassAbstractData valData)
    //        : base(valLoginInformation, 50, valData,EnumAuthorityLevel.有权限的操作员)
    //    {
    //    }

    //    protected override string ExecuteString
    //    {
    //        get
    //        {
    //            ClassQuantityUnitProperties tmpQuantityUnitProperties = Data as ClassQuantityUnitProperties;
    //            if (tmpQuantityUnitProperties != null)
    //            {
    //                //(31)INSERT INTO dbo.YKGL_数量单位表 (名称,P_操作员_ID) VALUES ('{0}',{1})
    //                string tmpString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 31);
    //                if (string.IsNullOrEmpty(tmpString1))
    //                {
    //                    return null;
    //                }
    //                string tmpString = string.Format(tmpString1, tmpQuantityUnitProperties.名称,
    //                                                 LoginInformation.OperaterID);
    //                return tmpString;
    //            }
    //            return null;
    //        }
    //    }
    //}

    //public class ClassQuantityUnitPropertiesEditer : ClassAbstractDataEditer
    //{
    //    public ClassQuantityUnitPropertiesEditer(ClassLoginInformation valLoginInformation, ClassAbstractData valData)
    //        : base(valLoginInformation, 51, valData,EnumAuthorityLevel.有权限且创建该记录的操作员)
    //    {
    //    }

    //    protected override string ExecuteString
    //    {
    //        get
    //        {
    //            ClassQuantityUnitProperties tmpQuantityUnitProperties = Data as ClassQuantityUnitProperties;
    //            if (tmpQuantityUnitProperties == null)
    //            {
    //                return null;
    //            }
    //            //(32)UPDATE dbo.YKGL_数量单位表 SET 名称 = '{0}' WHERE ID = {1}
    //            string tmpSqlString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 32);
    //            if (string.IsNullOrEmpty(tmpSqlString1))
    //            {
    //                return null;
    //            }
    //            string tmpSqlString = string.Format(tmpSqlString1, tmpQuantityUnitProperties.名称,
    //                                                tmpQuantityUnitProperties.ID);
    //            return tmpSqlString;
    //        }
    //    }

    //    protected override ClassAbstractDataLoader DataLoader
    //    {
    //        get { return new ClassQuantityUnitPropertiesLoader(LoginInformation, Data); }
    //    }
    //}

    //public class ClassQuantityUnitPropertiesRemover : ClassAbstractDataRemover
    //{
    //    public ClassQuantityUnitPropertiesRemover(ClassLoginInformation valLoginInformation, long valID)
    //        : base(valLoginInformation, 53, "YKGL_数量单位表", new ClassQuantityUnitProperties(valID),EnumAuthorityLevel.有权限且创建该记录的操作员)
    //    {
    //    }

    //    protected override ClassAbstractDataLoader DataLoader
    //    {
    //        get { return new ClassQuantityUnitPropertiesLoader(LoginInformation, Data); }
    //    }
    //}

    public class ClassLibraryQuantityUnitPublic
    {
        /// <summary>
        /// 夹在所有计量单位信息
        /// </summary>
        /// <param name="valConnectionString"></param>
        /// <returns></returns>
        public static DataTable LoadAllQuantityUnit(string valConnectionString)
        {
            //(38)SELECT ID,名称 FROM dbo.YKGL_数量单位表 ORDER BY ID
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valConnectionString, 38);
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
