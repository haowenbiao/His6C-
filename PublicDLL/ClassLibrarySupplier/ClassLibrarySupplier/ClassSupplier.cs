using System.Data;
using ClassLibraryAbstractDataInformation;
using ClassLibraryDataTableFromQueryString;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryGetSQLString;
using ClassLibraryXmlizedAttribute;

namespace ClassLibrarySupplier
{
    [XmlizedSqlstringIDClass(SqlStringIDLoad = 165, SqlStringIDAdd = 166, SqlStringIDEdit = 167, SqlStringIDRemove = 168, Path = @"/Record")]
    [XmlizedClass(XmlTemplate = @"<Record><RecordInformations></RecordInformations></Record>", DefaultPath = @"/Record/RecordInformations")]
    public class ClassSupplierProperties : ClassAbstractData
    {
        #region 属性

        [XmlizedProperty]
        public string 名称 { get; set; }

        [XmlizedProperty]
        public string 拼音码 { get; set; }

        [XmlizedProperty]
        public string 负责人 { get; set; }

        [XmlizedProperty]
        public string 地址 { get; set; }

        [XmlizedProperty]
        public string 邮编 { get; set; }

        [XmlizedProperty]
        public string 联系电话 { get; set; }

        [XmlizedProperty]
        public string 传真 { get; set; }

        [XmlizedProperty]
        public string 备注 { get; set; }

        #endregion

        public override bool Check()
        {
            if (string.IsNullOrEmpty(名称))
            {
                OnError(new EventArgsOfExecuteError("供货商名称不能为空，请输入供货商名称！", "未通过数据合法性检查！"));
                return false;
            }
            if (string.IsNullOrEmpty(拼音码))
            {
                OnError(new EventArgsOfExecuteError("供货商拼音码不能为空，请输入供货商拼音码！", "未通过数据合法性检查！"));
                return false;
            }
            return true;
        }

        public override void Clear()
        {
            名称 = null;
            拼音码 = null;
            负责人 = null;
            地址 = null;
            邮编 = null;
            联系电话 = null;
            传真 = null;
            备注 = null;
        }
    }

    //public class ClassSupplierPropertiesLoader : ClassAbstractDataLoader
    //{
    //    public ClassSupplierPropertiesLoader(ClassLoginInformation valLoginInformation, ClassAbstractData valData)
    //        : base(valLoginInformation, valData)
    //    {

    //    }

    //    protected override long ExecuteStringID
    //    {
    //        get
    //        {
    //            //(82)SELECT * FROM dbo.YKGL_供货单位信息表 WHERE ID = {0}
    //            return 82L;
    //        }
    //    }

    //    protected override bool LoaduUnderTheRules(System.Data.IDataReader valSqlDataReader)
    //    {
    //        ClassSupplierProperties supplierProperties = Data as ClassSupplierProperties;
    //        if (supplierProperties != null)
    //        {
    //            try
    //            {
    //                if (valSqlDataReader.Read())
    //                {
    //                    supplierProperties.名称 = valSqlDataReader["名称"] as string;
    //                    supplierProperties.拼音码 = valSqlDataReader["拼音码"] as string;
    //                    supplierProperties.负责人 = valSqlDataReader["负责人"] as string;
    //                    supplierProperties.地址 = valSqlDataReader["地址"] as string;
    //                    supplierProperties.邮编 = valSqlDataReader["邮编"] as string;
    //                    supplierProperties.联系电话 = valSqlDataReader["联系电话"] as string;
    //                    supplierProperties.传真 = valSqlDataReader["传真"] as string;
    //                    supplierProperties.备注 = valSqlDataReader["备注"] as string;
    //                    supplierProperties.P_操作员_ID = (long)valSqlDataReader["P_操作员_ID"];
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

    //public class ClassSupplierPropertiesAdder:ClassAbstractDataAdder
    //{
    //    public ClassSupplierPropertiesAdder(ClassLoginInformation valLoginInformation, ClassAbstractData valData)
    //        : base(valLoginInformation, 88, valData, EnumAuthorityLevel.有权限的操作员)
    //    {
    //    }

    //    protected override string ExecuteString
    //    {
    //        get
    //        {
    //            ClassSupplierProperties tmpData = Data as ClassSupplierProperties;
    //            if (tmpData != null)
    //            {
    //                //(83)INSERT INTO dbo.YKGL_供货单位信息表 
    //                //(名称,拼音码,负责人,地址,邮编,联系电话,传真,备注,P_操作员_ID) 
    //                //VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',{8} ) 
    //                string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 83);
    //                if (string.IsNullOrEmpty(tmpSQLString1))
    //                {
    //                    return null;
    //                }
    //                string tmpSQLString = string.Format(tmpSQLString1, tmpData.名称, tmpData.拼音码, tmpData.负责人, tmpData.地址,
    //                                                    tmpData.邮编, tmpData.联系电话, tmpData.传真, tmpData.备注,
    //                                                    LoginInformation.OperaterID);
    //                return tmpSQLString;
    //            }
    //            return null;
    //        }
    //    }
    //}

    //public class ClassSupplierPropertiesEditer:ClassAbstractDataEditer
    //{
    //    public ClassSupplierPropertiesEditer(ClassLoginInformation valLoginInformation, ClassAbstractData valData)
    //        : base(valLoginInformation, 89, valData, EnumAuthorityLevel.有权限且创建该记录的操作员)
    //    {
    //    }

    //    protected override ClassAbstractDataLoader DataLoader
    //    {
    //        get { return new ClassSupplierPropertiesLoader(LoginInformation, Data); }
    //    }

    //    protected override string ExecuteString
    //    {
    //        get
    //        {
    //            ClassSupplierProperties supplierProperties = Data as ClassSupplierProperties;
    //            if (supplierProperties != null)
    //            {
    //                //(84)UPDATE dbo.YKGL_供货单位信息表 
    //                //SET 名称 = '{0}',
    //                //拼音码 = '{1}',
    //                //负责人 = '{2}',
    //                //地址 = '{3}',
    //                //邮编 = '{4}',
    //                //联系电话 = '{5}',
    //                //传真 = '{6}',
    //                //备注 = '{7}' 
    //                //WHERE ID = {8}
    //                string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 84);
    //                if (string.IsNullOrEmpty(tmpSQLString1))
    //                {
    //                    return null;
    //                }
    //                string tmpSQLString = string.Format(tmpSQLString1, supplierProperties.名称, supplierProperties.拼音码,
    //                                                    supplierProperties.负责人, supplierProperties.地址,
    //                                                    supplierProperties.邮编, supplierProperties.联系电话,
    //                                                    supplierProperties.传真, supplierProperties.备注,
    //                                                    supplierProperties.ID);
    //                return tmpSQLString;
    //            }
    //            return null;
    //        }
    //    }
    //}

    //public class ClassSupplierPropertiesRemover:ClassAbstractDataRemover
    //{
    //    public ClassSupplierPropertiesRemover(ClassLoginInformation valLoginInformation, long valID)
    //        : base(valLoginInformation, 90, "YKGL_供货单位信息表", new ClassSupplierProperties(valID), EnumAuthorityLevel.有权限且创建该记录的操作员)
    //    {
    //    }

    //    protected override ClassAbstractDataLoader DataLoader
    //    {
    //        get { return new ClassSupplierPropertiesLoader(LoginInformation, Data); }
    //    }
    //}

    public class ClassSupplierPublic
    {
        /// <summary>
        /// 加载所有供货商信息，包括“所有供货商”项。
        /// </summary>
        /// <param name="valConnectionString"></param>
        /// <returns></returns>
        public static DataTable LoadAllSuppliersWithAll(string valConnectionString)
        {
            //(99)SELECT ID ,名称 AS 供货商 ,拼音码 FROM dbo.YKGL_供货单位信息表 ORDER BY ID
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valConnectionString, 99);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return null;
            }
            string tmpSqlString = tmpSQLString1;
            DataTableFromQueryString tmpDepartmentInformations = new DataTableFromQueryString(valConnectionString,
                                                                                              tmpSqlString);
            DataTable tmpDataTable = tmpDepartmentInformations.value;
            object[] tmpNewRow = new object[3];
            tmpNewRow[0] = 0L;
            tmpNewRow[1] = "所有供货商";
            tmpNewRow[2] = "all";
            tmpDataTable.Rows.Add(tmpNewRow);
            tmpDataTable.DefaultView.Sort = "ID";
            return tmpDataTable;
        }

        /// <summary>
        /// 加载所有供货商信息。
        /// </summary>
        /// <param name="valConnectionString"></param>
        /// <returns></returns>
        public static DataTable LoadAllSuppliers(string valConnectionString)
        {
            //(99)SELECT ID ,名称 AS 供货商 ,拼音码 FROM dbo.YKGL_供货单位信息表 ORDER BY ID
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valConnectionString, 99);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return null;
            }
            string tmpSqlString = tmpSQLString1;
            DataTableFromQueryString tmpDepartmentInformations = new DataTableFromQueryString(valConnectionString,
                                                                                              tmpSqlString);
            DataTable tmpDataTable = tmpDepartmentInformations.value;
            tmpDataTable.DefaultView.Sort = "ID";
            return tmpDataTable;
        }

    }
}
