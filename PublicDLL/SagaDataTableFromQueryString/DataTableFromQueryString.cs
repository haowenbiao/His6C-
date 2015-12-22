using System.Data;
using System.Data.SqlClient;

namespace ClassLibraryDataTableFromQueryString
{
    public class DataTableFromQueryString
    {
        public DataTableFromQueryString(string valConnctionString,string valQueryString)
        {
            value = loadData(valConnctionString, valQueryString);
        }

        public DataTable value { get;private set; }

        private static DataTable loadData(string valConnctionString, string valQueryString)
        {
            SqlConnection tmpSqlConnection = null;
            SqlDataAdapter tmpSqlDataAdapter = null;
            try
            {
                tmpSqlConnection = new SqlConnection(valConnctionString);
                tmpSqlDataAdapter = new SqlDataAdapter(valQueryString, tmpSqlConnection);
                DataTable tmpDataTable = new DataTable();
                tmpSqlConnection.Open();
                tmpSqlDataAdapter.Fill(tmpDataTable);
                return tmpDataTable;
            }
            catch
            {
                //OnError(tmpEx.Message);
                return null;
            }
            finally
            {
                if (tmpSqlDataAdapter != null) tmpSqlDataAdapter.Dispose();
                if (tmpSqlConnection != null) tmpSqlConnection.Dispose();
            }
        }
    }
}
