using System.Data;
using System.Data.SqlClient;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;
using ClassLibrarySQLExecute;

namespace ClassLibraryAuthoritySet
{
    public class ClassAuthoritySet : ClassAbstractAddExecuteWithSQLProcedure
    {
        private readonly long m_WorkerID;
        private readonly string m_AuthorityIDsXML;

        /// <summary>
        /// 权限设置类
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valWorkerID"></param>
        /// <param name="valAuthorityIDsXML">格式为："《Ds》《ID》24《/ID》《ID》25《/ID》《ID》26《/ID》《/IDs》"</param>
        public ClassAuthoritySet(ClassLoginInformation valLoginInformation, long valWorkerID,string valAuthorityIDsXML)
            : base(valLoginInformation, "usp_权限设置")
        {
            m_WorkerID = valWorkerID;
            m_AuthorityIDsXML = valAuthorityIDsXML;
        }

        private long WorkerID
        {
            get { return m_WorkerID; }
        }

        private string AuthorityIDsXML
        {
            get { return m_AuthorityIDsXML; }
        }

        public override void defineParameters(SqlParameterCollection valSqlParameterCollection)
        {
            SqlParameter tmpSQLParameterSQLString = new SqlParameter("@WorkerID", SqlDbType.BigInt) { Value = WorkerID };
            valSqlParameterCollection.Add(tmpSQLParameterSQLString);
            tmpSQLParameterSQLString = new SqlParameter("@AuthorityIDsXML", SqlDbType.Xml, 1000) { Value = AuthorityIDsXML };
            valSqlParameterCollection.Add(tmpSQLParameterSQLString);
        }
    }
    
    public class ClassAuthoritySetChangePassWord
    {
        public event ExecuteSucceedHandler ExecuteSucceed;
        public event ExecuteErrorHandler Error;

        public ClassAuthoritySetChangePassWord(ClassLoginInformation valLoginInformation, string valOriginalPassWord, string valNewPassWord)
        {
            LoginInformation = valLoginInformation;
            OriginalPassWord = valOriginalPassWord;
            NewPassWord = valNewPassWord;
        }

        private ClassLoginInformation LoginInformation { get; set; }
        private string OriginalPassWord { get; set; }
        private string NewPassWord { get; set; }

        public void Change()
        {
            string tmpOriginalPassWord = ClassAuthoritySetPublic.GetWorkerPassWord(LoginInformation);
            if ((tmpOriginalPassWord != OriginalPassWord) && !(string.IsNullOrEmpty(tmpOriginalPassWord) && string.IsNullOrEmpty(OriginalPassWord)))
            {
                OnError(new EventArgsOfExecuteError(string.Empty, "原密码不正确，请重新输入原密码！"));
                return;
            }

            //UPDATE dbo.P_职工信息表 SET 登录密码 = '{0}' WHERE ID = {1}
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 15);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                OnError(new EventArgsOfExecuteError(string.Empty, "未知错误！"));
                return;
            }
            string tmpSQLString = string.Format(tmpSQLString1,NewPassWord,LoginInformation.OperaterID);
            int tmpEffect = ClassExecuteScalarData.ExecuteSqlString(LoginInformation.ConnectionString, tmpSQLString);
            if (tmpEffect < 1)
            {
                OnError(new EventArgsOfExecuteError("", "修改密码失败！"));
            }
            else
            {
                OnExecuteSucceed(new EventArgsOfExecuteSucceed(0,"密码修改成功！"));
            }
            //ClassEditedWithSQLString tmpClassChangePassWord = new ClassEditedWithSQLString(LoginInformation, tmpSQLString);
            //tmpClassChangePassWord.ExecuteSucceed += this_ExecuteSucceed;
            //tmpClassChangePassWord.Error += this_Error;
            //tmpClassChangePassWord.execute();
        }

        #region 自定义事件

/*
        private void this_ExecuteSucceed(object sender,EventArgsOfExecuteSucceed e)
        {
            OnExecuteSucceed(e);
        }
*/

/*
        private void this_Error(object sender,EventArgsOfError e)
        {
            OnError(e);
        }
*/

        public void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            if (ExecuteSucceed != null)
            {
                ExecuteSucceed(this, e);
            }
        }

        public void OnError(EventArgsOfExecuteError e)
        {
            if (Error != null)
            {
                Error(this, e);
            }
        }

        #endregion
    }

    public class ClassAuthoritySetPublic
    {
        /// <summary>
        /// 返回用户的密码
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <returns></returns>
        internal static string GetWorkerPassWord(ClassLoginInformation valLoginInformation)
        {
            //SELECT 登录密码 FROM dbo.P_职工信息表 WHERE ID = {0}
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valLoginInformation.ConnectionString, 14);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
	            return null;
            }
            string tmpSQLString = string.Format(tmpSQLString1, valLoginInformation.OperaterID);
            string tmpString = ClassExecuteScalarData.GetScalarString(valLoginInformation.ConnectionString, tmpSQLString);
            return tmpString;
        }

        /// <summary>
        /// 验证密码
        /// </summary>
        /// <returns></returns>
        public static bool VerifyPassWord(ClassLoginInformation valLoginInformation,string valPassWord)
        {
            string tmpPassWord = GetWorkerPassWord(valLoginInformation);
            return tmpPassWord == valPassWord;
        }

        /// <summary>
        /// 根据用户ID，返回用户的姓名
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <returns></returns>
        public static string GetWorkerName(ClassLoginInformation valLoginInformation)
        {
            //SELECT 姓名 FROM dbo.P_职工信息表 WHERE ID = {0}
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valLoginInformation.ConnectionString, 16);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return null;
            }
            string tmpSQLString = string.Format(tmpSQLString1, valLoginInformation.OperaterID);
            string tmpString = ClassExecuteScalarData.GetScalarString(valLoginInformation.ConnectionString, tmpSQLString);
            return tmpString;
        }

        /// <summary>
        /// 验证用户的权限
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valAuthorityID"></param>
        /// <returns></returns>
        public static bool VerifyAuthority(ClassLoginInformation valLoginInformation, long valAuthorityID)
        {
            if (!GetIsOperater(valLoginInformation))
            {
                return false;
            }
            
            //SELECT ID FROM dbo.P_职工信息_权限设置_表_View WHERE P_职工信息_ID = {0} AND P_权限_ID = {1}
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valLoginInformation.ConnectionString, 17);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return false;
            }
            string tmpSQLString = string.Format(tmpSQLString1, valLoginInformation.OperaterID, valAuthorityID);
            object tmpObject = ClassExecuteScalarData.GetScalarObject(valLoginInformation.ConnectionString, tmpSQLString);
            return tmpObject == null ? false : true;
        }

        /// <summary>
        /// 检查用户是否操作员
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <returns></returns>
        public static bool GetIsOperater(ClassLoginInformation valLoginInformation)
        {
            //SELECT 是否操作员 FROM dbo.P_职工信息表 WHERE ID = {0}
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valLoginInformation.ConnectionString, 18);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return false;
            }
            string tmpSQLString = string.Format(tmpSQLString1, valLoginInformation.OperaterID);
            bool tmpBool = ClassExecuteScalarData.GetScalarBoolean(valLoginInformation.ConnectionString, tmpSQLString);
            return tmpBool;
        }

        ///// <summary>
        ///// 检查某权限是否是超级权限，及只有超级用户才能有的权限。
        ///// </summary>
        ///// <param name="valConnectString"></param>
        ///// <param name="valAuthorityID"></param>
        ///// <returns></returns>
        //public static bool GetIsSuperAuhority(string valConnectString,long valAuthorityID)
        //{
        //    //(60)SELECT 超级权限 FROM dbo.P_权限表 WHERE ID = {0}
        //    string tmpSQLString1 = ClassGetSQLString.GetSQLString(valConnectString, 60);
        //    if (string.IsNullOrEmpty(tmpSQLString1))
        //    {
        //        return false;
        //    }
        //    string tmpSQLString = string.Format(tmpSQLString1, valAuthorityID);
        //    bool tmpBool = ClassExecuteScalarData.GetScalarBoolean(valConnectString, tmpSQLString);
        //    return tmpBool;
        //}

        /// <summary>
        /// 获得权限的名字
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="AuthorityID"></param>
        /// <returns></returns>
        public static string GetAuthorityName(ClassLoginInformation valLoginInformation, long AuthorityID)
        {
            //(169)SELECT 权限 FROM dbo.P_权限表 WHERE ID = {0}
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valLoginInformation.ConnectionString, 169);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return null;
            }
            string tmpSQLString = string.Format(tmpSQLString1, AuthorityID);
            string tmpString = ClassExecuteScalarData.GetScalarString(valLoginInformation.ConnectionString, tmpSQLString);
            return tmpString;
        }

        /// <summary>
        /// 获得权限属性ID
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="AuthorityID"></param>
        /// <returns></returns>
        public static long? GetAuthorityAttributeID(ClassLoginInformation valLoginInformation, long AuthorityID)
        {
            //(170)SELECT P_权限属性_ID FROM dbo.P_权限表 WHERE ID = {0}
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valLoginInformation.ConnectionString, 170);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return null;
            }
            string tmpSQLString = string.Format(tmpSQLString1, AuthorityID);
            long? tmplong = ClassExecuteScalarData.GetScalarLong(valLoginInformation.ConnectionString, tmpSQLString);
            return tmplong;
        }
    }
}
