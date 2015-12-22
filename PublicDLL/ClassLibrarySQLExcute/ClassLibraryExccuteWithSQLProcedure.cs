using System;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;

namespace ClassLibrarySQLExecute
{
    public abstract class ClassAbstractBaseExecuteWithSQLProcedure
    {
        public event ExecuteErrorHandler Error;

        protected readonly ClassLoginInformation LoginInformation;
        protected readonly string ProcedureName;

        protected ClassAbstractBaseExecuteWithSQLProcedure(ClassLoginInformation valLoginInformation, string valProcedureName)
        {
            LoginInformation = valLoginInformation;
            ProcedureName = valProcedureName;
        }

        protected virtual void OnError(EventArgsOfExecuteError e)
        {
            if (Error != null)
            {
                Error(this, e);
            }
        }

        public abstract void defineParameters(SqlParameterCollection valSqlParameterCollection);
    }

    public abstract class ClassAbstractAddExecuteWithSQLProcedure : ClassAbstractBaseExecuteWithSQLProcedure
    {
        public event ExecuteSucceedHandler ExecuteSucceed;

        /*类ClassAbstractAddExecuteWithSQLProcedure 和 类ClassAddedWithSQLString的区别：
         *类ClassAddedWithSQLString使用存储过程"usp_AddGeneral"，"usp_AddGeneral"是个通用的存储过程，适合通常的情况。该类已经重载了父类的defineParameters方法，并在该方法中定义了"@SQLString"参数
         *类ClassAbstractAddExecuteWithSQLProcedure未指定存储过程，在使用过程中必须指定存储过程，使用特定的存储过程。要求继承该类的类重载defineParameters方法。例如在权限设置模块中应用到了该抽象类。
         */
        protected ClassAbstractAddExecuteWithSQLProcedure(ClassLoginInformation valLoginInformation, string valProcedureName)
            : base(valLoginInformation, valProcedureName)
        {
        }

        protected virtual void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            if (ExecuteSucceed != null)
            {
                ExecuteSucceed(this, e);
            }
        }

        public long execute()
        {
            using (SqlConnection tmpSqlConnection = new SqlConnection(LoginInformation.ConnectionString))
            {
                SqlCommand tmpSqlCommand = tmpSqlConnection.CreateCommand();
                tmpSqlCommand.CommandType = CommandType.StoredProcedure;
                tmpSqlCommand.CommandText = ProcedureName;

                #region 定义参数

                //定义参数
                defineParameters(tmpSqlCommand.Parameters);

                SqlParameter tmpSqlParameterID = new SqlParameter("@XmlParameter", SqlDbType.Xml) { Direction = ParameterDirection.InputOutput };
                tmpSqlCommand.Parameters.Add(tmpSqlParameterID);

                SqlParameter tmpErrorMessageSqlParameter = new SqlParameter("@ErrorMessage", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                tmpSqlCommand.Parameters.Add(tmpErrorMessageSqlParameter);

                SqlParameter tmpReturnValueSqlParameter = new SqlParameter("@succeed", SqlDbType.Bit) { Direction = ParameterDirection.ReturnValue };
                tmpSqlCommand.Parameters.Add(tmpReturnValueSqlParameter);

                #endregion

                try
                {
                    tmpSqlConnection.Open();
                    tmpSqlCommand.ExecuteNonQuery();
                    int tmpSucced = (int)(tmpReturnValueSqlParameter.Value);
                    if (tmpSucced == 0)
                    {
                        EventArgsOfExecuteError tmpEventArgsOfError =
                            new EventArgsOfExecuteError(tmpErrorMessageSqlParameter.Value as string, "存储过程执行过程中发生错误！");
                        OnError(tmpEventArgsOfError);
                        return -1L;
                    }
                    else
                    {
                        OnExecuteSucceed(new EventArgsOfExecuteSucceed((long)tmpSqlParameterID.Value, null));
                        return (long)tmpSqlParameterID.Value;
                    }
                }
                catch (Exception ex)
                {
                    EventArgsOfExecuteError tmpEventArgsOfError =
                        new EventArgsOfExecuteError(ex.Message, "不可预知错误！");
                    OnError(tmpEventArgsOfError);
                    return -1L;
                }
                finally
                {
                    tmpSqlCommand.Dispose();
                }
            }
        }
    }
}
