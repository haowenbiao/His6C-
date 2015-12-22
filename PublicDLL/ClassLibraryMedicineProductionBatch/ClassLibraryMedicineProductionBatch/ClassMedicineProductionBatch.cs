using System;
using ClassLibraryAbstractDataInformation;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;
using ClassLibrarySQLExecute;
using ClassLibraryXmlizedAttribute;

namespace ClassLibraryMedicineProductionBatch
{
    [XmlizedSqlstringIDClass(SqlStringIDLoad = 158, SqlStringIDAdd = 160, SqlStringIDEdit = 159, SqlStringIDRemove = 161, Path = @"/Record")]
    [XmlizedClass(XmlTemplate = @"<Record><RecordInformations></RecordInformations></Record>", DefaultPath = @"/Record/RecordInformations")]
    public class ClassMedicineProductionBatchProperties : ClassAbstractData
    {
        #region 属性

        [XmlizedProperty]
        public long YKGL_药品种类_ID { get; set; }

        [XmlizedProperty]
        public string 生产批号 { get; set; }

        [XmlizedProperty]
        public DateTime 生产日期 { get; set; }

        [XmlizedProperty]
        public DateTime 有效期至 { get; set; }

        #endregion

        public override bool Check()
        {
            if (string.IsNullOrEmpty(生产批号))
            {
                OnError(new EventArgsOfExecuteError("生产批号不能为空，请输入生产批号！", "未通过数据合法性检查！"));
                return false;
            }
            if (有效期至 <= 生产日期)
            {
                OnError(new EventArgsOfExecuteError("“有效期至” 必须大于 “生产日期”！", "未通过数据合法性检查！"));
                return false;
            }
            return true;
        }

        public override void Clear()
        {
            生产批号 = null;
        }
    }

    //public class ClassMedicineProductionBatchPropertiesLoader : ClassAbstractDataLoader
    //{
    //    public ClassMedicineProductionBatchPropertiesLoader(ClassLoginInformation valLoginInformation, ClassAbstractData valData)
    //        : base(valLoginInformation, valData)
    //    {

    //    }

    //    protected override long ExecuteStringID
    //    {
    //        get
    //        {
    //            //(90)SELECT * FROM dbo.YKGL_药品生产批号表 WHERE ID = {0}
    //            return 90L;
    //        }
    //    }

    //    protected override bool LoaduUnderTheRules(System.Data.IDataReader valSqlDataReader)
    //    {
    //        ClassMedicineProductionBatchProperties supplierProperties = Data as ClassMedicineProductionBatchProperties;
    //        if (supplierProperties != null)
    //        {
    //            try
    //            {
    //                if (valSqlDataReader.Read())
    //                {
    //                    supplierProperties.YKGL_药品种类_ID = (long)valSqlDataReader["YKGL_药品种类_ID"];
    //                    supplierProperties.生产批号 = valSqlDataReader["生产批号"] as string;
    //                    supplierProperties.生产日期 = (DateTime)valSqlDataReader["生产日期"];
    //                    supplierProperties.有效期至 = (DateTime)valSqlDataReader["有效期至"];
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

    //public class ClassMedicineProductionBatchPropertiesAdder : ClassAbstractDataAdder
    //{
    //    public ClassMedicineProductionBatchPropertiesAdder(ClassLoginInformation valLoginInformation, ClassAbstractData valData)
    //        : base(valLoginInformation, 27, valData, EnumAuthorityLevel.有权限的操作员)
    //    {
    //    }

    //    protected override string ExecuteString
    //    {
    //        get
    //        {
    //            ClassMedicineProductionBatchProperties tmpData = Data as ClassMedicineProductionBatchProperties;
    //            if (tmpData != null)
    //            {
    //                //(91)INSERT INTO dbo.YKGL_药品生产批号表 
    //                //(YKGL_药品种类_ID,生产批号,生产日期,有效期至,P_操作员_ID) 
    //                //VALUES ( {0},N'{1}',/*'2009-8-26 16:52:3.78'*/'{2}',/*'2009-8-26 16:52:3.78'*/'{3}',{4} ) 
    //                string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 91);
    //                if (string.IsNullOrEmpty(tmpSQLString1))
    //                {
    //                    return null;
    //                }
    //                string tmpSQLString = string.Format(tmpSQLString1, tmpData.YKGL_药品种类_ID, tmpData.生产批号,
    //                                                    tmpData.生产日期.ToShortDateString(),
    //                                                    tmpData.有效期至.ToShortDateString(), LoginInformation.OperaterID);
    //                return tmpSQLString;
    //            }
    //            return null;
    //        }
    //    }
    //}

    //public class ClassMedicineProductionBatchPropertiesEditer : ClassAbstractDataEditer
    //{
    //    public ClassMedicineProductionBatchPropertiesEditer(ClassLoginInformation valLoginInformation, ClassAbstractData valData)
    //        : base(valLoginInformation, 28, valData, EnumAuthorityLevel.有权限且创建该记录的操作员)
    //    {
    //    }

    //    protected override ClassAbstractDataLoader DataLoader
    //    {
    //        get { return new ClassMedicineProductionBatchPropertiesLoader(LoginInformation, Data); }
    //    }

    //    protected override string ExecuteString
    //    {
    //        get
    //        {
    //            ClassMedicineProductionBatchProperties tmpData = Data as ClassMedicineProductionBatchProperties;
    //            if (tmpData != null)
    //            {
    //                //(92)UPDATE dbo.YKGL_药品生产批号表 
    //                //SET 生产批号 = '{0}',
    //                //生产日期 = '{1}',
    //                //有效期至 = '{2}' 
    //                //WHERE ID = {3}
    //                string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 92);
    //                if (string.IsNullOrEmpty(tmpSQLString1))
    //                {
    //                    return null;
    //                }
    //                string tmpSQLString = string.Format(tmpSQLString1, tmpData.生产批号, tmpData.生产日期.ToShortDateString(),
    //                                                    tmpData.有效期至.ToShortDateString(), tmpData.ID);
    //                return tmpSQLString;
    //            }
    //            return null;
    //        }
    //    }
    //}

    //public class ClassMedicineProductionBatchPropertiesRemover : ClassAbstractDataRemover
    //{
    //    public ClassMedicineProductionBatchPropertiesRemover(ClassLoginInformation valLoginInformation, long valID)
    //        : base(valLoginInformation, 29, "YKGL_药品生产批号表", new ClassMedicineProductionBatchProperties(valID), EnumAuthorityLevel.有权限且创建该记录的操作员)
    //    {
    //    }

    //    protected override ClassAbstractDataLoader DataLoader
    //    {
    //        get { return new ClassMedicineProductionBatchPropertiesLoader(LoginInformation, Data); }
    //    }
    //}

    public class ClassLibraryMedicineProductionBatchPublic
    {
        /// <summary>
        /// 获得某生产批号在某库存的数量。此方法名称错误。应为GetStoreQuantity。
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valStockHouseID"></param>
        /// <param name="valMedicineProductionBatchID"></param>
        /// <returns></returns>
        [Obsolete("此方法名称错误。请使用GetStoreQuantity方法", true)]
        public static long GetStockQuantity(ClassLoginInformation valLoginInformation, long valStockHouseID, long valMedicineProductionBatchID)
        {
            return GetStoreQuantity(valLoginInformation, valStockHouseID, valMedicineProductionBatchID);
        }

        /// <summary>
        /// 获得某生产批号在某库存的数量。
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valStockHouseID"></param>
        /// <param name="valMedicineProductionBatchID"></param>
        /// <returns></returns>
        public static long GetStoreQuantity(ClassLoginInformation valLoginInformation, long valStockHouseID, long valMedicineProductionBatchID)
        {
            if (valLoginInformation == null)
            {
                return 0L;
            }
            //(94)SELECT 库存数量 FROM dbo.YKGL_库存信息_药品生产批号_表 WHERE YKGL_药库信息_ID = {0} AND YKGL_药品生产批号_ID = {1}
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valLoginInformation.ConnectionString, 94);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return 0L;
            }
            string tmpSqlString = string.Format(tmpSQLString1, valStockHouseID, valMedicineProductionBatchID);
            long? tmpStockQuantity = ClassExecuteScalarData.GetScalarLong(valLoginInformation.ConnectionString,
                                                                            tmpSqlString);
            if (tmpStockQuantity.HasValue)
            {
                return tmpStockQuantity.Value;
            }
            return 0L;
        }

        /// <summary>
        /// 根据药品生产批号ID查找药品生产批号名称
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valMedicineProductionBatchID"></param>
        /// <returns></returns>
        public static string GetMedicineProductionBatchName(ClassLoginInformation valLoginInformation, long valMedicineProductionBatchID)
        {
            if (valLoginInformation == null)
            {
                return "";
            }
            //(105)SELECT 生产批号 FROM dbo.YKGL_药品生产批号表 WHERE ID = {0}
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valLoginInformation.ConnectionString, 105);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return "";
            }
            string tmpSqlString = string.Format(tmpSQLString1, valMedicineProductionBatchID);
            string tmpMedicineProductionBatchName = ClassExecuteScalarData.GetScalarString(valLoginInformation.ConnectionString,
                                                                            tmpSqlString);
            return tmpMedicineProductionBatchName;
        }
    }
}
