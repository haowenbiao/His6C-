using System.Data;
using ClassLibraryAbstractDataInformation;
using ClassLibraryEventArgs;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;
using ClassLibraryPublicEnum;

namespace ClassLibraryMedicineProduceCompany
{

    public class ClassCompanyProperties : ClassAbstractData
    {
        #region 构造器

        public ClassCompanyProperties()
        {

        }

        public ClassCompanyProperties(long valID)
            : base(valID)
        {

        }

        #endregion

        #region 定义属性

        //名称,拼音码,地址,邮政编码,电话号码,传真号码,网址,电子邮件,备注
        public string 名称 { get; set; }
        public string 拼音码 { get; set; }
        public string 地址 { get; set; }
        public string 邮政编码 { get; set; }
        public string 电话号码 { get; set; }
        public string 传真号码 { get; set; }
        public string 网址 { get; set; }
        public string 电子邮件 { get; set; }
        public string 备注 { get; set; }
        #endregion

        #region 覆写虚方法

        public override bool check()
        {
            if (string.IsNullOrEmpty(名称))
            {
                EventArgsOfError tmpEventArgsOfError = new EventArgsOfError("企业名称不能为空，请输入姓名！", "未通过数据合法性检查！");
                OnError(tmpEventArgsOfError);
                return false;
            }
            if (string.IsNullOrEmpty(拼音码))
            {
                EventArgsOfError tmpEventArgsOfError = new EventArgsOfError("拼音码不能为空，请输入拼音码！", "未通过数据合法性检查！");
                OnError(tmpEventArgsOfError);
                return false;
            }
            return true;
        }

        public override void clear()
        {
            名称 = null;
            拼音码 = null;
            地址 = null;
            邮政编码 = null;
            电话号码 = null;
            传真号码 = null;
            网址 = null;
            电子邮件 = null;
            备注 = null;
        }

        #endregion
    }

    /// <summary>
    /// 任何操作员都可进行此操作
    /// </summary>
    public class ClassCompanyPropertiesLoader : ClassAbstractDataLoader
    {
        public ClassCompanyPropertiesLoader(ClassLoginInformation valLoginInformation, ClassAbstractData valData)
            : base(valLoginInformation, valData)
        {
        }

        protected override bool LoaduUnderTheRules(IDataReader valSqlDataReader)
        {
            ClassCompanyProperties tmpCompanyProperties = Data as ClassCompanyProperties;
            if (tmpCompanyProperties != null)
            {
                try
                {
                    if (valSqlDataReader.Read())
                    {
                        tmpCompanyProperties.名称 = valSqlDataReader["名称"] as string;
                        tmpCompanyProperties.拼音码 = valSqlDataReader["拼音码"] as string;
                        tmpCompanyProperties.地址 = valSqlDataReader["地址"] as string;
                        tmpCompanyProperties.邮政编码 = valSqlDataReader["邮政编码"] as string;
                        tmpCompanyProperties.电话号码 = valSqlDataReader["电话号码"] as string;
                        tmpCompanyProperties.传真号码 = valSqlDataReader["传真号码"] as string;
                        tmpCompanyProperties.网址 = valSqlDataReader["网址"] as string;
                        tmpCompanyProperties.电子邮件 = valSqlDataReader["电子邮件"] as string;
                        tmpCompanyProperties.备注 = valSqlDataReader["备注"] as string;
                        tmpCompanyProperties.P_操作员_ID = (long)valSqlDataReader["P_操作员_ID"];
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        protected override long ExecuteStringID
        {
            get
            {
                //(23)SELECT * FROM dbo.YKGL_药品生产企业表 WHERE ID = {0}
                return 23L;
            }
        }
    }

    /// <summary>
    /// 超级用户、有权限的操作员，可进行此操作
    /// </summary>
    public class ClassCompanyPropertiesAdder : ClassAbstractDataAdder
    {
        public ClassCompanyPropertiesAdder(ClassLoginInformation valLoginInformation, ClassAbstractData valData)
            : base(valLoginInformation, 47, valData, EnumAuthorityLevel.有权限的操作员)
        {
        }

        protected override string ExecuteString
        {
            get
            {
                {
                    ClassCompanyProperties tmpData = Data as ClassCompanyProperties;
                    if (tmpData != null)
                    {
                        //INSERT INTO dbo.YKGL_药品生产企业表 
                        //(名称,拼音码,地址,邮政编码,电话号码,传真号码,网址,电子邮件,备注,P_操作员_ID) 
                        //VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',{9})
                        string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 21);
                        if (string.IsNullOrEmpty(tmpSQLString1))
                        {
                            return null;
                        }
                        string tmpSQLString = string.Format(tmpSQLString1, tmpData.名称, tmpData.拼音码, tmpData.地址,
                                                            tmpData.邮政编码, tmpData.电话号码, tmpData.传真号码, tmpData.网址,
                                                            tmpData.电子邮件, tmpData.备注, LoginInformation.OperaterID);
                        return tmpSQLString;
                    }
                    return null;
                }
            }
        }

    }

    /// <summary>
    /// 超级用户、有权限的操作员、建立本记录的操作员，可进行此操作
    /// </summary>
    public class ClassCompanyPropertiesEditer : ClassAbstractDataEditer
    {
        public ClassCompanyPropertiesEditer(ClassLoginInformation valLoginInformation, ClassAbstractData valData)
            : base(valLoginInformation, 48, valData, EnumAuthorityLevel.有权限且创建该记录的操作员)
        {
        }

        protected override string ExecuteString
        {
            get
            {
                ClassCompanyProperties tmpCompanyProperties = Data as ClassCompanyProperties;
                if (tmpCompanyProperties != null)
                {
                    //(24)UPDATE dbo.YKGL_药品生产企业表 SET 名称 = '{0}',拼音码 = '{1}',地址 = '{2}',邮政编码 = '{3}',电话号码 = '{4}',传真号码 = '{5}',网址 = '{6}',电子邮件 = '{7}',备注 = '{8}' WHERE ID = {9}
                    string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 24);
                    if (string.IsNullOrEmpty(tmpSQLString1))
                    {
                        return null;
                    }
                    string tmpSQLString = string.Format(tmpSQLString1, tmpCompanyProperties.名称, tmpCompanyProperties.拼音码,
                                                        tmpCompanyProperties.地址, tmpCompanyProperties.邮政编码,
                                                        tmpCompanyProperties.电话号码, tmpCompanyProperties.传真号码,
                                                        tmpCompanyProperties.网址, tmpCompanyProperties.电子邮件,
                                                        tmpCompanyProperties.备注, tmpCompanyProperties.ID);
                    return tmpSQLString;
                }
                return null;
            }
        }

        protected override ClassAbstractDataLoader DataLoader
        {
            get { return new ClassCompanyPropertiesLoader(LoginInformation, Data); }
        }
    }

    /// <summary>
    /// 超级用户、有权限的操作员、建立本记录的操作员，可进行此操作
    /// </summary>
    public class ClassCompanyPropertiesRemover : ClassAbstractDataRemover
    {
        public ClassCompanyPropertiesRemover(ClassLoginInformation valLoginInformation, long valID)
            : base(valLoginInformation, 49, "YKGL_药品生产企业表", new ClassCompanyProperties(valID), EnumAuthorityLevel.有权限且创建该记录的操作员)
        {
        }


        protected override ClassAbstractDataLoader DataLoader
        {
            get { return new ClassCompanyPropertiesLoader(LoginInformation, Data); }
        }
    }
}
