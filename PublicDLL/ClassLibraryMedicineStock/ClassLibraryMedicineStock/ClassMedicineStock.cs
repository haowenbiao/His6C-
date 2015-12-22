using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ClassLibraryAbstractDataInformation;
using ClassLibraryDataTableFromQueryString;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;
using ClassLibrarySQLExecute;
using ClassLibraryXmlizedAttribute;

namespace ClassLibraryMedicineStock
{

    [XmlizedClass(XmlTemplate = @"<MedicineStockItem></MedicineStockItem>", DefaultPath = @"/MedicineStockItem")]
    public class ClassMedicineStockListItem : ClassAbstractDataBaseXmlized
    {
        public ClassMedicineStockListItem()
        {
            药品通用名称 = "";
            药品商品名称 = "";
            生产批号 = "";
            计量单位 = "";
            备注 = "";
        }

        [XmlizedProperty]
        public long YKGL_药品生产批号_ID { get; set; }

        [XmlizedProperty]
        public string 药品通用名称 { get; set; }

        [XmlizedProperty]
        public string 药品商品名称 { get; set; }

        [XmlizedProperty]
        public string 生产批号 { get; set; }

        [XmlizedProperty]
        public string 计量单位 { get; set; }

        [XmlizedProperty]
        public long 数量 { get; set; }

        [XmlizedProperty]
        public decimal 单价 { get; set; }

        [XmlizedProperty]
        public decimal 金额
        {
            get
            {
                decimal tmp金额 = 单价*数量;
                return tmp金额;
            }
        }

        [XmlizedProperty]
        public string 备注 { get; set; }
    }

    [XmlizedSqlstringIDClass(SqlStringIDAdd = 156, Path = @"/Record")]
    [XmlizedClass(XmlTemplate = @"<Record><RecordInformations></RecordInformations></Record>", DefaultPath = @"/Record/RecordInformations")]
    public class ClassMedicineStockProperties : ClassAbstractData
    {
        public ClassMedicineStockProperties()
        {
            _medicineStockLists = new List<ClassMedicineStockListItem>();
        }

        #region 属性

        private readonly List<ClassMedicineStockListItem> _medicineStockLists;
        [XmlizedProperty(ElementName = @"MedicineStockList")]
        public List<ClassMedicineStockListItem> MedicineStockList
        {
            get
            {
                return _medicineStockLists;
            }
        }

        [XmlizedProperty]
        public string 进货单编号 { get; set; }

        [XmlizedProperty]
        public long YKGL_药库信息_ID { get; set; }

        [XmlizedProperty]
        public long YKGL_供货单位信息_ID { get; set; }

        [XmlizedProperty]
        public long P_采购员_ID { get; set; }

        [XmlizedProperty]
        public decimal 金额
        {
            get
            {
                //decimal tmpAggregateAamount = 0M;
                //foreach (ClassMedicineStockListItem stockList in _medicineStockLists)
                //{
                //    tmpAggregateAamount += stockList.单价 * stockList.数量;
                //}
                //return tmpAggregateAamount;

                //Linq表达式，比上面的看得简单些
                return _medicineStockLists.Sum(stockList => stockList.单价 * stockList.数量);
            }
        }

        [XmlizedProperty]
        public string 备注 { get; set; }

        #endregion

        public override bool Check()
        {
            if (string.IsNullOrEmpty(进货单编号))
            {
                OnError(new EventArgsOfExecuteError("进货单编号不能为空，请输入进货单编号！", "未通过数据合法性检查！"));
                return false;
            }

            if (YKGL_药库信息_ID < 1)
            {
                OnError(new EventArgsOfExecuteError("请设置药库信息！", "未通过数据合法性检查！"));
                return false;
            }

            if (YKGL_供货单位信息_ID < 1)
            {
                OnError(new EventArgsOfExecuteError("请设置供货单位信息！", "未通过数据合法性检查！"));
                return false;
            }

            if (_medicineStockLists.Count == 0)
            {
                OnError(new EventArgsOfExecuteError("您还没有录入药品进货明细！", "未通过数据合法性检查！"));
                return false;
            }

            return true;
        }

        public override void Clear()
        {
        }
    }

    [XmlizedSqlstringIDClass(SqlStringIDLoad = 157, Path = @"/Record")]
    [XmlizedClass(XmlTemplate = @"<Record><RecordInformations></RecordInformations></Record>", DefaultPath = @"/Record/RecordInformations")]
    public class ClassMedicineStockFullProperties:ClassAbstractData
    {
        #region 属性

        public DataTable MedicineStockList { get; set; }

        [XmlizedProperty]
        public string 进货单编号 { get; set; }

        [XmlizedProperty]
        public string 药库名称 { get; set; }

        [XmlizedProperty]
        public string 供货单位 { get; set; }

        [XmlizedProperty]
        public string 采购员 { get; set; }

        [XmlizedProperty]
        public DateTime 进货时间 { get; set; }

        [XmlizedProperty]
        public string 进货会计期 { get; set; }

        [XmlizedProperty]
        public decimal 进货单总金额 { get; set; }

        [XmlizedProperty]
        public string 备注 { get; set; }

        [XmlizedProperty]
        public string 操作员 { get; set; }

        [XmlizedProperty]
        public long? P_审核意见_ID { get; set; }

        [XmlizedProperty]
        public string 审核状态 { get; set; }

        [XmlizedProperty]
        public string 审核人 { get; set; }
        
        [XmlizedProperty]
        public DateTime? 审核时间 { get; set; }

        [XmlizedProperty]
        public string 审核会计期 { get; set; }

        [XmlizedProperty]
        public string 审核备注 { get; set; }

        #endregion

        public void LoadStockList(ClassLoginInformation valLoginInformation)
        {
            ClassDataLoader dataLoader = new ClassDataLoader(valLoginInformation,this);
            dataLoader.execute();
            ClassMedicineStockPublic.LoadMedicineStockListOfMedicineStockFullProperties(
                valLoginInformation.ConnectionString, this);
        }

        #region 没用

        public override bool Check()
        {
            return true;
        }

        public override void Clear()
        {
        }

        #endregion
    }

    /// <summary>
    /// 药品审核入库
    /// </summary>
    [XmlizedSqlstringIDClass(SqlStringIDAdd = 163, Path = @"/Record")]
    [XmlizedClass(XmlTemplate = @"<Record><RecordInformations></RecordInformations></Record>", DefaultPath = @"/Record/RecordInformations")]
    public class ClassMedicineStockVerifyAndWareHousing : ClassAbstractData
    {
        #region 属性

        [XmlizedProperty]
        public long YKGL_进货记录_ID { get; set; }

        [XmlizedProperty]
        public long P_审核人_ID { get; set; }

        [XmlizedProperty]
        public long P_审核意见_ID { get; set; }

        [XmlizedProperty]
        public string 备注 { get; set; }

        #endregion

        public override bool Check()
        {
            return true;
        }

        public override void Clear()
        {
        }
    }

    public class ClassMedicineStockPublic
    {
        //获取新的进货单编号
        public static string GetStockNumber(string valConnectionString)
        {
            //(106)DECLARE @tmpStockNumber AS VARCHAR(50);EXECUTE dbo.usp_GetStockNumber @tmpStockNumber OUT;SELECT @tmpStockNumber;
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valConnectionString, 106);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return "";
            }
            string tmpSqlString = tmpSQLString1;
            string tmpStockNumber = ClassExecuteScalarData.GetScalarString(valConnectionString,
                                                                                            tmpSqlString);
            return tmpStockNumber;
        }

        //加载进货单进货明细。
        internal static void LoadMedicineStockListOfMedicineStockFullProperties(string valConnectionString,ClassMedicineStockFullProperties valClassMedicineStockFullProperties)
        {
            //(109)SELECT 药品通用名称,药品商品名称,计量单位,数量,单价 as [单价(元)],(单价*数量) as [金额(元)],生产批号,生产日期,有效期至,药品生产企业,备注 FROM dbo.YKGL_进货记录明细表_View WHERE YKGL_进货记录_ID = {0}
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valConnectionString, 109);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return;
            }
            string tmpSqlString = string.Format(tmpSQLString1, valClassMedicineStockFullProperties.ID);
            DataTableFromQueryString MedicineStockListOfMedicineStockFullProperties = new DataTableFromQueryString(valConnectionString,
                                                                                              tmpSqlString);
            valClassMedicineStockFullProperties.MedicineStockList = MedicineStockListOfMedicineStockFullProperties.value;
        }

        /// <summary>
        /// 检查进货单是否已审核入库
        /// </summary>
        /// <param name="valConnectionString"></param>
        /// <param name="valID">进货单编号</param>
        /// <returns></returns>
        public static bool GetMedicineStockIsVerified(string valConnectionString,long valID)
        {
            //(173)SELECT COUNT_big(0) FROM dbo.YKGL_进货记录审核表 WHERE YKGL_进货记录_ID = {0}
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valConnectionString, 173);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return false;
            }
            string tmpSQLString = string.Format(tmpSQLString1, valID);
            long? tmplong = ClassExecuteScalarData.GetScalarLong(valConnectionString, tmpSQLString);
            if (tmplong==null)
            {
                return false;
            }
            return tmplong > 0;
        }
    
    }
    
}
