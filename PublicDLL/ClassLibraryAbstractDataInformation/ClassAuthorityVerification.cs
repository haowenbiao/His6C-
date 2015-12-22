using System;
using ClassLibraryAuthoritySet;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;

namespace ClassLibraryAbstractDataInformation
{
    public sealed class ClassAuthorityVerification
    {
        /// <summary>
        /// 当权限验证需要验证记录创建者时，需要提供ClassAbstractData，一般是在修改的情况下。
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valAuthorityID"></param>
        /// <param name="valData"></param>
        public ClassAuthorityVerification(ClassLoginInformation valLoginInformation,long valAuthorityID,ClassAbstractData valData = null)
        {
            LoginInformation = valLoginInformation;
            AuthorityID = valAuthorityID;
            Data = valData;
        }

        #region 属性

        private ClassLoginInformation LoginInformation { get; set; }

        private long AuthorityID { get; set; }

        private ClassAbstractData Data { get; set; }

        #endregion

        #region 事件

        public EventHandler<EventArgsOfExecuteSucceed> ExecuteSucceed;

        public EventHandler<EventArgsOfExecuteError> ExecuteError;

        private void OnExecuteError(EventArgsOfExecuteError e)
        {
            if (ExecuteError != null)
            {
                ExecuteError(this, e);
            }
        }

        private void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            if (ExecuteSucceed != null)
            {
                ExecuteSucceed(this, e);
            }
        }

        #endregion

        #region 方法

        public bool VerifyAuthority()
        {
            //如果权限ID为“0”，则任何操作员都可执行
            if (AuthorityID == 0)
            {
                OnExecuteSucceed(new EventArgsOfExecuteSucceed(AuthorityID, "权限验证通过"));
                return true;
            }    
        
            if (LoginInformation.OperaterID == 1)
            {
                OnExecuteSucceed(new EventArgsOfExecuteSucceed(AuthorityID,"权限验证通过"));
                return true;
            }
            
            long? tmpAuthorityAttributeID = ClassAuthoritySetPublic.GetAuthorityAttributeID(LoginInformation, AuthorityID);

            switch (tmpAuthorityAttributeID)
            {
                //有权限即可
                case 1:
                    if (!ClassAuthoritySetPublic.VerifyAuthority(LoginInformation, AuthorityID))
                    {
                        OnExecuteError(new EventArgsOfExecuteError("当前操作员需要“" + ClassAuthoritySetPublic.GetAuthorityName(LoginInformation, AuthorityID) + "”的权限！", "注意：当前用户没有进行此操作的权限！"));
                        return false;
                    }
                    break;
                //有权限且是数据的创建者
                case 2:
                    if (!ClassAuthoritySetPublic.VerifyAuthority(LoginInformation, AuthorityID))
                    {
                        OnExecuteError(new EventArgsOfExecuteError("当前操作员需要“" + ClassAuthoritySetPublic.GetAuthorityName(LoginInformation, AuthorityID) + "”的权限！", "注意：当前用户没有进行此操作的权限！"));
                        return false;
                    }
                    if (Data != null)
                    {
                        ClassDataLoader dataLoader = new ClassDataLoader(LoginInformation, Data);
                        bool loadSucceed = dataLoader.execute();
                        if (loadSucceed)
                        {
                            if (LoginInformation.OperaterID != Data.P_操作员_ID)
                            {
                                OnExecuteError(new EventArgsOfExecuteError("只有建立该记录的操作员才能进行此操作。", "权限不足！"));
                                return false;
                            }
                        }
                        else
                        {
                            OnExecuteError(new EventArgsOfExecuteError("权限验证过程中出现错误：", "未能正确加载数据！"));
                            return false;
                        }
                    }
                    break;
                //超级权限
                case 3:
                    OnExecuteError(new EventArgsOfExecuteError("权限验证错误：", "只有超级用户才有进行此操作的权限！"));
                    return false;
                    //break;
                //权限未开放
                case 4:
                    OnExecuteError(new EventArgsOfExecuteError("权限验证错误：", "此权限未开放！"));
                    return false;
                    //break;
            }
            return true;
        }

        #endregion
    }
}
