using System;
using System.Data.SqlClient;
using System.Data;
using CustomTextBox;

namespace DepartmentInformation
{
    public class DepartmentType
    {
        public event OnErrorHandle OnError;

        public DepartmentType(string valConnctionString)
        {
            ConnectionString = valConnctionString;
            value = loadDepartmentType();
        }
        private string ConnectionString { get; set; }

        public DataTable value { get; private set; }

        private DataTable loadDepartmentType()
        {
            SqlConnection tmpSqlConnection = null;
            SqlDataAdapter tmpSqlDataAdapter = null;
            try
            {
                tmpSqlConnection = new SqlConnection(ConnectionString);
                tmpSqlDataAdapter = new SqlDataAdapter("Select * from P_部门类型表", tmpSqlConnection);
                DataTable tmpDataTable = new DataTable();
                tmpSqlConnection.Open();
                tmpSqlDataAdapter.Fill(tmpDataTable);
                return tmpDataTable;
            }
            catch (Exception tmpEx)
            {
                OnError(this, tmpEx.Message);
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
