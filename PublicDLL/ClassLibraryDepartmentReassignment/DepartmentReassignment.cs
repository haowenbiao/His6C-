using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryAbstractDataInformation;
using ClassLibraryDataTableFromQueryString;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;
using ClassLibrarySQLExecute;
using ClassLibraryWorkerInformations;
using ClassLibraryXmlizedAttribute;

namespace ClassLibraryDepartmentReassignment
{
    [XmlizedSqlstringIDClass(SqlStringIDEdit = 142, Path = @"/Record")]
    [XmlizedClass(XmlTemplate = @"<Record><RecordInformations></RecordInformations></Record>", DefaultPath = @"/Record/RecordInformations")]
    public class ClassDepartMentReassingmentIn:ClassAbstractData
    {
        #region 定义属性

        [XmlizedProperty]
        public long P_职工信息_ID { get; set; }

        [XmlizedProperty]
        public long P_部门信息_ID { get; set; }

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

    [XmlizedSqlstringIDClass(SqlStringIDEdit = 143, Path = @"/Record")]
    [XmlizedClass(XmlTemplate = @"<Record><RecordInformations></RecordInformations></Record>", DefaultPath = @"/Record/RecordInformations")]
    public class ClassDepartMentReassingmentOut : ClassAbstractData
    {
        public ClassDepartMentReassingmentOut()
        {
            _departmentReassingmentInRecords = new List<ClassDepartMentReassingmentInRecord>();
        }

        #region 定义属性

        //[XmlizedProperty]
        //public long P_职工信息_ID { get; set; }

        //[XmlizedProperty]
        //public long P_职工岗位调动记录_调入_ID { get; set; }

        private readonly List<ClassDepartMentReassingmentInRecord> _departmentReassingmentInRecords;
        [XmlizedProperty(ElementName = @"ReassingmentInRecords")]
        public List<ClassDepartMentReassingmentInRecord> DepartmentReassingmentInRecords
        {
            get
            {
                return _departmentReassingmentInRecords;
            }
        }

        [XmlizedProperty]
        public string 备注 { get; set; }

        #endregion

        #region 覆写抽象方法

        public override bool Check()
        {
            if (_departmentReassingmentInRecords.Count<0)
            {
                return false;
            }
            return true;
        }

        public override void Clear()
        {
            return;
        }

        #endregion
    }

    [XmlizedClass(XmlTemplate = @"<ReassingmentInRecord></ReassingmentInRecord>", DefaultPath = @"/ReassingmentInRecord")]
    public class ClassDepartMentReassingmentInRecord : ClassAbstractDataBaseXmlized
    {
        [XmlizedProperty]
        public long P_职工岗位调动记录_调入_ID { get; set; }
    }

    //调入类
    public class ClassDepartmentReassignmentIn : ClassAbstractAddExecuteWithSQLProcedure
    {
        private readonly long m_职工信息_ID;
        private readonly long m_部门信息_ID;
        private readonly string m_备注;

        public ClassDepartmentReassignmentIn(ClassLoginInformation valLoginInformation, long val职工信息_ID, long val部门信息_ID, string val备注)
            : base(valLoginInformation, "usp_职工岗位调入")
        {
            m_职工信息_ID = val职工信息_ID;
            m_部门信息_ID = val部门信息_ID;
            m_备注 = val备注;
        }

        private string 备注
        {
            get { return m_备注; }
        }

        private long 部门信息_ID
        {
            get { return m_部门信息_ID; }
        }

        private long 职工信息_ID
        {
            get { return m_职工信息_ID; }
        }

        public override void defineParameters(SqlParameterCollection valSqlParameterCollection)
        {
            SqlParameter tmpSQLParameterSQLString = new SqlParameter("@职工信息_ID", SqlDbType.BigInt) { Value = 职工信息_ID };
            valSqlParameterCollection.Add(tmpSQLParameterSQLString);
            tmpSQLParameterSQLString = new SqlParameter("@部门信息_ID", SqlDbType.BigInt) { Value = 部门信息_ID };
            valSqlParameterCollection.Add(tmpSQLParameterSQLString);
            tmpSQLParameterSQLString = new SqlParameter("@备注", SqlDbType.NVarChar, 1000) { Value = 备注 };
            valSqlParameterCollection.Add(tmpSQLParameterSQLString);
        }
    }

    //调出类
    public class ClassDepartmentReassignmentOut : ClassAbstractAddExecuteWithSQLProcedure
    {
        private readonly string m_IDsXML;
        private readonly string m_备注;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valIDsXML">格式为："<IDs><ID>24</ID><ID>25</ID><ID>26</ID></IDs>"</param>
        /// <param name="val备注"></param>
        public ClassDepartmentReassignmentOut(ClassLoginInformation valLoginInformation, string valIDsXML, string val备注)
            : base(valLoginInformation, "usp_职工岗位调出")
        {
            m_IDsXML = valIDsXML;
            m_备注 = val备注;
        }

        //SET @tmpXML = '<IDs>
        //                <ID>24</ID>
        //                <ID>25</ID>
        //                <ID>26</ID>
        //              </IDs>' ;
        private string IDsXML
        {
            get { return m_IDsXML; }
        }

        private string 备注
        {
            get { return m_备注; }
        }

        public override void defineParameters(SqlParameterCollection valSqlParameterCollection)
        {
            SqlParameter tmpSQLParameterSQLString = new SqlParameter("@备注", SqlDbType.NVarChar, 1000) { Value = 备注 };
            valSqlParameterCollection.Add(tmpSQLParameterSQLString);
            tmpSQLParameterSQLString = new SqlParameter("@IDsXML", SqlDbType.Xml, 1000) { Value = IDsXML };
            valSqlParameterCollection.Add(tmpSQLParameterSQLString);
        }
    }

    //公共方法类
    public class ClassDepartmentReassignmentPublic
    {
        /// <summary>
        /// 加载职工信息
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valID"></param>
        /// <returns></returns>
        public static ClassWorkerProperties LoadWorkerInformation(ClassLoginInformation valLoginInformation, long valID)
        {
            ClassWorkerProperties tmpClassWorkerProperties = new ClassWorkerProperties {ID = valID};
            ClassDataLoader dataLoader = new ClassDataLoader(valLoginInformation, tmpClassWorkerProperties);
            bool succeed = dataLoader.execute();
            return succeed ? tmpClassWorkerProperties : null;
        }

        /// <summary>
        /// 加载职工所在的部门列表
        /// </summary>
        /// <param name="valConnectionString"></param>
        /// <param name="valID"></param>
        /// <returns></returns>
        public static DataTable LoadDepartmentsOfWorkerIn(string valConnectionString, long valID)
        {
            //"SELECT ID,部门名称 FROM [P_职工信息_部门信息_表_View] Where P_职工信息_ID = {0}"
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valConnectionString, 1);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return null;
            }
            string tmpSQLstring = string.Format(tmpSQLString1, valID);
            DataTableFromQueryString tmpDepartmentInformations = new DataTableFromQueryString(valConnectionString,
                                                                                              tmpSQLstring);
            return tmpDepartmentInformations.value;
        }

        /// <summary>
        /// 加载职工未在的部门列表
        /// </summary>
        /// <param name="valConnectionString"></param>
        /// <param name="valID"></param>
        public static DataTable LoadDepartmentsOfWorkerNotIn(string valConnectionString, long valID)
        {
            //SELECT ID,部门名称 FROM dbo.P_部门信息表 WHERE ID NOT IN (SELECT P_部门信息_ID FROM dbo.P_职工信息_部门信息_表 WHERE P_职工信息_ID = {0}) ORDER BY ID
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valConnectionString, 2);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return null;
            }
            string tmpSqlString = string.Format(tmpSQLString1, valID);
            DataTableFromQueryString tmpDepartmentInformations = new DataTableFromQueryString(valConnectionString,
                                                                                              tmpSqlString);
            return tmpDepartmentInformations.value;
        }

        /// <summary>
        /// 加载职工的调动记录
        /// </summary>
        /// <param name="valConnectionString"></param>
        /// <param name="valWorkerNameOrPYM"></param>
        /// <returns></returns>
        public static DataTable LoadDepartmentReassignmentRecords(string valConnectionString, string valWorkerNameOrPYM)
        {
            if (string.IsNullOrEmpty(valWorkerNameOrPYM))
            {
                //SELECT  职工姓名,调动类型,调动部门,调动时间,会计期,备注 FROM P_职工岗位调动记录_View
                string tmpSQLString1 = ClassGetSQLString.GetSQLString(valConnectionString, 3);
                if (string.IsNullOrEmpty(tmpSQLString1))
                {
                    return null;
                }
                string tmpSqlString = tmpSQLString1;
                DataTableFromQueryString tmpDepartmentInformations = new DataTableFromQueryString(valConnectionString,
                                                                                                  tmpSqlString);
                return tmpDepartmentInformations.value;
            }
            else
            {
                //SELECT  职工姓名,调动类型,调动部门,调动时间,会计期,备注 FROM P_职工岗位调动记录_View WHERE 职工姓名 ='{0}' OR 拼音码 = '{1}'
                string tmpSQLString1 = ClassGetSQLString.GetSQLString(valConnectionString, 4);
                if (string.IsNullOrEmpty(tmpSQLString1))
                {
                    return null;
                }
                string tmpSqlString = string.Format(tmpSQLString1, valWorkerNameOrPYM, valWorkerNameOrPYM);
                DataTableFromQueryString tmpDepartmentInformations = new DataTableFromQueryString(valConnectionString,
                                                                                                  tmpSqlString);
                return tmpDepartmentInformations.value;
            }
        }

        /// <summary>
        /// 加载所有职工的姓名列表
        /// </summary>
        /// <param name="valConnectionString"></param>
        /// <returns></returns>
        public static DataTable LoadAllWorkers(string valConnectionString)
        {
            //SELECT 姓名 FROM P_职工信息表 WHERE ID > 1
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valConnectionString, 5);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return null;
            }
            string tmpSqlString = tmpSQLString1;
            DataTableFromQueryString tmpDepartmentInformations = new DataTableFromQueryString(valConnectionString,
                                                                                              tmpSqlString);
            return tmpDepartmentInformations.value;
        }
    }
}
