using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;

namespace ClassLibrarySQLExecute
{
    public abstract class ClassAbstractExecuteWithXmlParameterStringBase : ClassAbstractBaseExecuteWithSQLProcedure
    {
        private readonly string _XmlParameterString;

        protected ClassAbstractExecuteWithXmlParameterStringBase(ClassLoginInformation valLoginInformation, string valProcedureName, string XmlParameterString)
            : base(valLoginInformation, valProcedureName)
        {
            _XmlParameterString = XmlParameterString;
        }

        protected string XmlParameterString
        {
        	get
        	{
        		return _XmlParameterString;
        	}
        }
    }

    public abstract class ClassAbstractExecuteWithXmlParameterString : ClassAbstractExecuteWithXmlParameterStringBase
    {
        public event ExecuteSucceedHandler ExecuteSucceed;

        protected ClassAbstractExecuteWithXmlParameterString(ClassLoginInformation valLoginInformation, string valUserProceduerName, string valXmlSQLParameter)
            : base(valLoginInformation, valUserProceduerName, valXmlSQLParameter)
        {
            
        }

        protected virtual void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            if (ExecuteSucceed != null)
            {
                ExecuteSucceed(this, e);
            }
        }

        public virtual bool execute()
        {
            using (SqlConnection tmpSqlConnection = new SqlConnection(LoginInformation.ConnectionString))
            {
                SqlCommand tmpSqlCommand = tmpSqlConnection.CreateCommand();
                tmpSqlCommand.CommandType = CommandType.StoredProcedure;
                tmpSqlCommand.CommandText = ProcedureName;

                #region 定义参数

                //定义参数
                defineParameters(tmpSqlCommand.Parameters);

                SqlParameter tmpReturnValueSqlParameter = new SqlParameter("@succeed", SqlDbType.Bit) { Direction = ParameterDirection.ReturnValue };
                tmpSqlCommand.Parameters.Add(tmpReturnValueSqlParameter);

                SqlParameter tmpXmlParameter = new SqlParameter("@XmlParameter", SqlDbType.Xml)
                                                   {
                                                       Direction = ParameterDirection.InputOutput,
                                                       Value =
                                                           new SqlXml(new XmlTextReader(XmlParameterString,
                                                                                        XmlNodeType.Document, null))
                                                   };

                tmpSqlCommand.Parameters.Add(tmpXmlParameter);

                #endregion

                try
                {
                    tmpSqlConnection.Open();
                    tmpSqlCommand.ExecuteNonQuery();
                    int tmpSucced = (int)(tmpReturnValueSqlParameter.Value);
                    if (tmpSucced == 0)
                    {
                        EventArgsOfExecuteError tmpEventArgsOfError = new EventArgsOfExecuteError(((SqlXml)tmpXmlParameter.Value).Value);
                        OnError(tmpEventArgsOfError);
                        return false;
                    }
                    else
                    {
                        EventArgsOfExecuteSucceed eventArgsOfExecuteSucceed = new EventArgsOfExecuteSucceed(((SqlXml)tmpXmlParameter.Value).Value);
                        OnExecuteSucceed(eventArgsOfExecuteSucceed);
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    OnError(new EventArgsOfExecuteError(ex.Message, "不可预知错误！"));
                    return false;
                }
                finally
                {
                    tmpSqlCommand.Dispose();
                }
            }
        }
    }

    public class ClassExecuteWithXmlParameterString:ClassAbstractExecuteWithXmlParameterString
    {
        public ClassExecuteWithXmlParameterString(ClassLoginInformation valLoginInformation, string valUserProceduerName, string valXmlParameterString)
            : base(valLoginInformation, valUserProceduerName, valXmlParameterString)
        {
        }

        public override void defineParameters(SqlParameterCollection valSqlParameterCollection)
        {
            return;
        }
    }

    //public abstract class ClassAbstractExecuteWithXmlizedSQLStringLoad:ClassAbstractExecuteWithXmlizedSQLString
    //{
    //    protected ClassAbstractExecuteWithXmlizedSQLStringLoad(ClassLoginInformation valLoginInformation, string valUserProceduerName, string valXmlizedSQLString)
    //        : base(valLoginInformation, valUserProceduerName, valXmlizedSQLString)
    //    {
    //    }

    //    public string RecordXmlized { get; set; }

    //    public sealed override bool execute()
    //    {
    //        using (SqlConnection tmpSqlConnection = new SqlConnection(LoginInformation.ConnectionString))
    //        {
    //            SqlCommand tmpSqlCommand = tmpSqlConnection.CreateCommand();
    //            tmpSqlCommand.CommandType = CommandType.StoredProcedure;
    //            tmpSqlCommand.CommandText = ProcedureName;

    //            #region 定义参数

    //            //定义参数
    //            defineParameters(tmpSqlCommand.Parameters);

    //            SqlParameter tmpSqlParameterID = new SqlParameter("@ID", SqlDbType.BigInt) { Direction = ParameterDirection.Output, };
    //            tmpSqlCommand.Parameters.Add(tmpSqlParameterID);

    //            SqlParameter tmpErrorMessageSqlParameter = new SqlParameter("@ErrorMessage", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
    //            tmpSqlCommand.Parameters.Add(tmpErrorMessageSqlParameter);

    //            SqlParameter tmpReturnValueSqlParameter = new SqlParameter("@succeed", SqlDbType.Bit) { Direction = ParameterDirection.ReturnValue };
    //            tmpSqlCommand.Parameters.Add(tmpReturnValueSqlParameter);

    //            #endregion

    //            try
    //            {
    //                tmpSqlConnection.Open();
    //                tmpSqlCommand.ExecuteNonQuery();
    //                int tmpSucced = (int)(tmpReturnValueSqlParameter.Value);
    //                if (tmpSucced == 0)
    //                {
    //                    EventArgsOfError tmpEventArgsOfError =
    //                        new EventArgsOfError(tmpErrorMessageSqlParameter.Value as string, "存储过程执行过程中发生错误！");
    //                    OnError(tmpEventArgsOfError);
    //                    return false;
    //                }
    //                else
    //                {
    //                    SqlParameter tmpXmlParameter = tmpSqlCommand.Parameters["@RecordXmlized"];
    //                    RecordXmlized = ((SqlXml) tmpXmlParameter.Value).Value;
    //                    OnExecuteSucceed( new EventArgsOfExecuteSucceed((long)tmpSqlParameterID.Value, null));
    //                    return true;
    //                }
    //            }
    //            catch (Exception ex)
    //            {
    //                OnError(new EventArgsOfError(ex.Message, "不可预知错误！"));
    //                return false;
    //            }
    //            finally
    //            {
    //                tmpSqlCommand.Dispose();
    //            }
    //        }
    //    }
    //}

    //public class ClassLoadWithXmlizedSQLString:ClassAbstractExecuteWithXmlizedSQLString
    //{
    //    public ClassLoadWithXmlizedSQLString(ClassLoginInformation valLoginInformation, string valXmlizedSQLString)
    //        : base(valLoginInformation, "usp_LoadComplicatedWithXmlizedParameter", valXmlizedSQLString)
    //    {
    //    }

    //    public override void defineParameters(SqlParameterCollection valSqlParameterCollection)
    //    {
    //        SqlParameter tmpSQLParameterSQLString = new SqlParameter("@RecordXmlized", SqlDbType.Xml)
    //                                                    {
    //                                                        Direction = ParameterDirection.Output,
    //                                                        Value =
    //                                                            new SqlXml(new XmlTextReader(XmlizedSQLString,
    //                                                                                         XmlNodeType.Document, null))
    //                                                    };
    //        valSqlParameterCollection.Add(tmpSQLParameterSQLString);
    //    }
    //}

    //public class ClassAddedWithSQLString:ClassAbstractExecuteWithXmlizedSQLString
    //{
    //    public ClassAddedWithSQLString(ClassLoginInformation valLoginInformation, string valExecuteSQLString)
    //        : base(valLoginInformation, "usp_AddGeneral", valExecuteSQLString)
    //    {
    //    }
    //}

    //public class ClassEditedWithSQLString : ClassAbstractExecuteWithXmlizedSQLStringBase
    //{
    //    public event ExecuteSucceedHandler ExecuteSucceed;

    //    public ClassEditedWithSQLString(ClassLoginInformation valLoginInformation, string valExecuteSQLString)
    //        : base(valLoginInformation, "usp_EditGeneral", valExecuteSQLString)
    //    {
    //    }

    //    protected virtual void OnExecuteSucceed(object sender)
    //    {
    //        if (ExecuteSucceed != null)
    //        {
    //            ExecuteSucceed(this, new EventArgsOfExecuteSucceed(0, null));
    //        }
    //    }

    //    public bool execute()
    //    {
    //        using (SqlConnection tmpSqlConnection = new SqlConnection(LoginInformation.ConnectionString))
    //        {
    //            SqlCommand tmpSqlCommand = tmpSqlConnection.CreateCommand();
    //            tmpSqlCommand.CommandType = CommandType.StoredProcedure;
    //            tmpSqlCommand.CommandText = "usp_EditGeneral";

    //            #region 定义参数

    //            //定义参数
    //            defineParameters(tmpSqlCommand.Parameters);

    //            SqlParameter tmpErrorMessageSqlParameter = new SqlParameter("@ErrorMessage", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
    //            tmpSqlCommand.Parameters.Add(tmpErrorMessageSqlParameter);

    //            SqlParameter tmpReturnValueSqlParameter = new SqlParameter("@succeed", SqlDbType.Bit) { Direction = ParameterDirection.ReturnValue };
    //            tmpSqlCommand.Parameters.Add(tmpReturnValueSqlParameter);

    //            #endregion

    //            try
    //            {
    //                tmpSqlConnection.Open();
    //                tmpSqlCommand.ExecuteNonQuery();
    //                int tmpSucced = (int)(tmpReturnValueSqlParameter.Value);
    //                if (tmpSucced == 0)
    //                {
    //                    EventArgsOfError tmpEventArgsOfError =
    //                        new EventArgsOfError(tmpErrorMessageSqlParameter.Value as string, "存储过程执行过程中发生错误！");
    //                    OnError(tmpEventArgsOfError);
    //                    return false;
    //                }
    //                else
    //                {
    //                    OnExecuteSucceed(this);
    //                    return true;
    //                }
    //            }
    //            catch (Exception ex)
    //            {
    //                EventArgsOfError tmpEventArgsOfError =
    //                    new EventArgsOfError(ex.Message, "不可预知错误！");
    //                OnError(tmpEventArgsOfError);
    //                return false;
    //            }
    //            finally
    //            {
    //                tmpSqlCommand.Dispose();
    //            }
    //        }
    //    }
    //}
}