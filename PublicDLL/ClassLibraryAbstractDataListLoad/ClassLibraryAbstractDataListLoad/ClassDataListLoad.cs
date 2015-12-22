using System;
using System.Threading;
using ClassLibraryDataTableFromQueryString;
using ClassLibraryEventArgs.EventArgsOfDataList;
using ClassLibraryLoginInformation;

namespace ClassLibraryDataListLoad
{
    
    public class  ClassDataListLoad
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valClassLoginInformation">用户登录信息</param>
        /// <param name="valLoadSqlString">当加载数据集时，用于从数据库中获取SQLString连接字符串的ID</param>
        public ClassDataListLoad(ClassLoginInformation valClassLoginInformation, string valLoadSqlString)
        {
            _loginInformation = valClassLoginInformation;
            _loadSqlString = valLoadSqlString;
        }

        #region 异步方法

        /// <summary>
        /// 异步方法,开始加载。
        /// </summary>
        public void Begin()
        {
            LoadThread();
        }

        /// <summary>
        /// 异步方法,结束加载。
        /// </summary>
        public void End()
        {
            if (T!=null)
            {
                T.Abort();
            }
        }
        
        #endregion

        #region 属性

        private readonly ClassLoginInformation _loginInformation;

        private ClassLoginInformation LoginInformation
        {
            get
            {
                return _loginInformation;
            }
        }

        private readonly string _loadSqlString;

        private string LoadSqlString
        {
            get { return _loadSqlString; }
        }

        #endregion

        #region 事件

        public event AfterDataListLoadSucceedHandler AfterDataListLoadSucceed;

        protected virtual void OnAfterDataListLoadSucceed(EventArgsOfAfterDataListLoadSucceed e)
        {
            AfterDataListLoadSucceedHandler Succeed = AfterDataListLoadSucceed;
            if (Succeed != null) Succeed(this,e);
        }

        public event AfterDataListLoadFailHandler AfterDataListLoadFail;

        protected virtual void OnAfterDataListLoadFail(EventArgsOfAfterDataListLoadFail e)
        {
            AfterDataListLoadFailHandler Fail = AfterDataListLoadFail;
            if (Fail != null) Fail(this,e);
        }

        public event BeforeDataListLoadHandler BeforeDataListLoad;

        protected virtual void OnBeforeDataListLoad(EventArgsOfBeforeDataListLoad e)
        {
            BeforeDataListLoadHandler BeforeLoad = BeforeDataListLoad;
            if (BeforeLoad != null) BeforeLoad(this,e);
        }

        #endregion

        #region 加载线程

        private Thread T { get; set; }

        private void LoadThread()
        {
            if (T != null)
            {
                T.Abort();
            }
            T = new Thread(LoadData) { IsBackground = true };
            T.Start();
        }

        private void LoadData()
        {
            try
            {
                OnBeforeDataListLoad(new EventArgsOfBeforeDataListLoad());

                //string tmpSqlString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, LoadSqlStringId);
                if (string.IsNullOrEmpty(LoadSqlString))
                {
                    OnAfterDataListLoadFail(new EventArgsOfAfterDataListLoadFail(""));
                }
                else
                {
                    string tmpSqlString = LoadSqlString;
                    DataTableFromQueryString tmpDepartmentInformations = new DataTableFromQueryString(LoginInformation.ConnectionString,
                                                                                                      tmpSqlString);
                    if (tmpDepartmentInformations.value == null)
                    {
                        OnAfterDataListLoadFail(new EventArgsOfAfterDataListLoadFail(""));
                    }
                    else
                    {
                        OnAfterDataListLoadSucceed(new EventArgsOfAfterDataListLoadSucceed(tmpDepartmentInformations.value)); 
                    }
                }
            }
            catch (Exception e)
            {
                OnAfterDataListLoadFail(new EventArgsOfAfterDataListLoadFail(e.Message));
            }
        }

        #endregion
    }
}
