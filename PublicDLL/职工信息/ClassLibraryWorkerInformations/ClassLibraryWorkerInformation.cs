using System;
using ClassLibraryAbstractDataInformation;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryXmlizedAttribute;

namespace ClassLibraryWorkerInformations
{
    [XmlizedSqlstringIDClass(SqlStringIDLoad = 144,SqlStringIDAdd = 146,SqlStringIDEdit = 145,SqlStringIDRemove = 147,Path = @"/Record")]
    [XmlizedClass(XmlTemplate = @"<Record><RecordInformations></RecordInformations></Record>", DefaultPath = @"/Record/RecordInformations")]
    public class ClassWorkerProperties : ClassAbstractData
    {
        #region 构造器

        public ClassWorkerProperties()
        {
            出生日期 = DateTime.Now;
            性别 = 0;
            是否操作员 = 0;
        }

        #endregion

        #region 定义属性

        //姓名,拼音码,性别,出生日期,身份证号码,家庭住址,联系电话1,联系电话2,是否操作员,备注
        [XmlizedProperty]
        public string 姓名 { get; set; }

        [XmlizedProperty]
        public string 拼音码 { get; set; }

        [XmlizedProperty]
        public int 性别 { get; set; }

        [XmlizedProperty]
        public DateTime 出生日期 { get; set; }

        [XmlizedProperty]
        public int 是否操作员 { get; set; }

        [XmlizedProperty]
        public string 身份证号码 { get; set; }

        [XmlizedProperty]
        public string 家庭住址 { get; set; }

        [XmlizedProperty]
        public string 联系电话1 { get; set; }

        [XmlizedProperty]
        public string 联系电话2 { get; set; }

        [XmlizedProperty]
        public string 备注 { get; set; }

        #endregion

        #region 覆写虚方法

        public override void Clear()
        {
            姓名 = null;
            拼音码 = null;
            是否操作员 = 0;
            身份证号码 = null;
            家庭住址 = null;
            联系电话1 = null;
            联系电话2 = null;
            备注 = null;
        }

        public override bool Check()
        {
            if (string.IsNullOrEmpty(姓名))
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

        #endregion
    }

    //public class ClassWorkerPropertiesLoader : ClassAbstractDataLoader
    //{
    //    public ClassWorkerPropertiesLoader(ClassLoginInformation valLoginInformation, ClassAbstractData valData)
    //        : base(valLoginInformation, valData)
    //    {

    //    }

    //    protected override bool LoaduUnderTheRules(IDataReader valSqlDataReader)
    //    {
    //        ClassWorkerProperties tmpWorkerProperties = Data as ClassWorkerProperties;
    //        if (tmpWorkerProperties != null)
    //        {
    //            try
    //            {
    //                if (valSqlDataReader.Read())
    //                {
    //                    tmpWorkerProperties.姓名 = valSqlDataReader["姓名"] as string;
    //                    tmpWorkerProperties.拼音码 = valSqlDataReader["拼音码"] as string;
    //                    tmpWorkerProperties.性别 = valSqlDataReader.GetBoolean(valSqlDataReader.GetOrdinal("性别")) ? 1 : 0;//["性别"];
    //                    tmpWorkerProperties.出生日期 = (DateTime)valSqlDataReader["出生日期"];
    //                    tmpWorkerProperties.是否操作员 = (bool)valSqlDataReader["是否操作员"] ? 1 : 0;
    //                    tmpWorkerProperties.身份证号码 = valSqlDataReader["身份证号码"] as string;
    //                    tmpWorkerProperties.家庭住址 = valSqlDataReader["家庭住址"] as string;
    //                    tmpWorkerProperties.联系电话1 = valSqlDataReader["联系电话1"] as string;
    //                    tmpWorkerProperties.联系电话2 = valSqlDataReader["联系电话2"] as string;
    //                    tmpWorkerProperties.备注 = valSqlDataReader["备注"] as string;
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
    //            return 26L;
    //        }
    //    }
    //}

    //public class ClassWorkerPropertiesAdder : ClassAbstractDataAdder
    //{
    //    public ClassWorkerPropertiesAdder(ClassLoginInformation valLoginInformation, ClassAbstractData valData)
    //        : base(valLoginInformation, 76, valData, EnumAuthorityLevel.有权限的操作员)
    //    {
    //    }

    //    protected override string ExecuteString
    //    {
    //        get
    //        {
    //            {
    //                ClassWorkerProperties tmpData = Data as ClassWorkerProperties;
    //                if (tmpData != null)
    //                {
    //                    //INSERT INTO dbo.P_职工信息表 (姓名,拼音码,性别,出生日期,身份证号码,家庭住址,联系电话1,联系电话2,是否操作员,备注) VALUES ('{0}','{1}',{2},'{3}','{4}','{5}','{6}','{7}',{8},'{9}')
    //                    string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 25);
    //                    if (string.IsNullOrEmpty(tmpSQLString1))
    //                    {
    //                        return null;
    //                    }

    //                    string tmpSQLString = string.Format(tmpSQLString1, tmpData.姓名, tmpData.拼音码, tmpData.性别,
    //                                                        tmpData.出生日期, tmpData.身份证号码, tmpData.家庭住址, tmpData.联系电话1,
    //                                                        tmpData.联系电话2, tmpData.是否操作员, tmpData.备注);
    //                    return tmpSQLString;
    //                }
    //                return null;
    //            }
    //        }
    //    }

    //}

    //public class ClassWorkerPropertiesEditer : ClassAbstractDataEditer
    //{
    //    public ClassWorkerPropertiesEditer(ClassLoginInformation valLoginInformation, ClassAbstractData valData)
    //        : base(valLoginInformation, 77, valData, EnumAuthorityLevel.有权限且创建该记录的操作员)
    //    {
    //    }

    //    protected override string ExecuteString
    //    {
    //        get
    //        {
    //            ClassWorkerProperties tmpData = Data as ClassWorkerProperties;
    //            if (tmpData != null)
    //            {
    //                //UPDATE  dbo.P_职工信息表 SET 姓名 = '{0}',拼音码 = '{1}',性别 = {2},出生日期 = '{3}',身份证号码 = '{4}',家庭住址 = '{5}',联系电话1 = '{6}',联系电话2 = '{7}',是否操作员 = {8},备注 = '{9}' WHERE ID = {10}
    //                string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 27);
    //                if (string.IsNullOrEmpty(tmpSQLString1))
    //                {
    //                    return null;
    //                }
    //                string tmpSQLString = string.Format(tmpSQLString1, tmpData.姓名, tmpData.拼音码, tmpData.性别, tmpData.出生日期,
    //                                                    tmpData.身份证号码, tmpData.家庭住址, tmpData.联系电话1, tmpData.联系电话2,
    //                                                    tmpData.是否操作员, tmpData.备注, tmpData.ID);
    //                return tmpSQLString;
    //            }
    //            return null;
    //        }
    //    }

    //    protected override ClassAbstractDataLoader DataLoader
    //    {
    //        get { return new ClassWorkerPropertiesLoader(LoginInformation, Data); }
    //    }
    //}

    //public class ClassWorkerPropertiesRemover : ClassAbstractDataRemover
    //{
    //    public ClassWorkerPropertiesRemover(ClassLoginInformation valLoginInformation, long valID)
    //        : base(valLoginInformation, 78, "P_职工信息表", new ClassWorkerProperties(valID), EnumAuthorityLevel.有权限且创建该记录的操作员)
    //    {
    //    }

    //    protected override ClassAbstractDataLoader DataLoader
    //    {
    //        get { return new ClassWorkerPropertiesLoader(LoginInformation, Data); }
    //    }
    //}
}