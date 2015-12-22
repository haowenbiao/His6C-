using System.Data;
using System.Data.SqlClient;

namespace ClassLibrarySQLExecute
{
    public class ClassExecuteScalarData
    {
        public static object GetScalarObject(string valConnectionString, string valExecuteSqlString)
        {
            SqlConnection tmpSqlConnection = null;
            IDbCommand tmpDbCommand = null;

            try
            {
                tmpSqlConnection = new SqlConnection(valConnectionString);
                tmpDbCommand = tmpSqlConnection.CreateCommand();
                tmpDbCommand.CommandText = valExecuteSqlString;
                tmpDbCommand.CommandType = CommandType.Text;
                tmpSqlConnection.Open();
                object  tmpScalarValue = tmpDbCommand.ExecuteScalar();
                return tmpScalarValue;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (tmpDbCommand != null) tmpDbCommand.Dispose();
                if (tmpSqlConnection != null) tmpSqlConnection.Dispose();
            }
        }

        public static long? GetScalarLong(string valConnectionString, string valExecuteSqlString)
        {
            object tmpObjectValue = GetScalarObject(valConnectionString, valExecuteSqlString);
            try
            {
                if (tmpObjectValue == null)
                {
                    return null;
                }
                long tmpLongValue = (long) tmpObjectValue;
                return tmpLongValue;
            }
            catch
            {
                return null;
            }
        }

        public static string GetScalarString(string valConnectionString, string valExecuteSqlString)
        {
            object tmpObjectValue = GetScalarObject(valConnectionString, valExecuteSqlString);
            try
            {
                return tmpObjectValue as string;
            }
            catch
            {
                return null;
            }
        }

        public static bool GetScalarBoolean(string valConnectionString, string valExecuteSqlString)
        {
            object tmpObjectValue = GetScalarObject(valConnectionString, valExecuteSqlString);
            try
            {
                if (tmpObjectValue == null)
                {
                    return false;
                }
                bool tmpBoolValue = (bool)tmpObjectValue;
                return tmpBoolValue;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 执行Sql语句，并返回影响的行数。
        /// </summary>
        /// <param name="valConnectionString"></param>
        /// <param name="valExecuteSqlString"></param>
        /// <returns>返回影响的行数。</returns>
        public static int ExecuteSqlString(string valConnectionString, string valExecuteSqlString)
        {
            SqlConnection tmpSqlConnection = null;
            IDbCommand tmpDbCommand = null;

            try
            {
                tmpSqlConnection = new SqlConnection(valConnectionString);
                tmpDbCommand = tmpSqlConnection.CreateCommand();
                tmpDbCommand.CommandText = valExecuteSqlString;
                tmpDbCommand.CommandType = CommandType.Text;
                tmpSqlConnection.Open();
                int tmpEffect = tmpDbCommand.ExecuteNonQuery();
                return tmpEffect;
            }
            catch
            {
                return 0;
            }
            finally
            {
                if (tmpDbCommand != null) tmpDbCommand.Dispose();
                if (tmpSqlConnection != null) tmpSqlConnection.Dispose();
            }
        }
    }
}
