using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibraryGetSQLString
{
    public class ClassGetSQLString
    {
        public static string GetSQLString(string valConnectionString, long valID)
        {
            try
            {
                SqlConnection tmpSqlConnection = new SqlConnection(valConnectionString);
                IDbCommand tmpCommand = tmpSqlConnection.CreateCommand();
                tmpCommand.CommandText = "Select SQLString from P_SQLString Where ID = " + valID;
                tmpCommand.CommandType = CommandType.Text;
                tmpSqlConnection.Open();
                string tmpSQLString = tmpCommand.ExecuteScalar() as string;
                return tmpSQLString;
            }
            catch
            {
                return "";
            }
        }
        public static SqlXml GetRecordXmlized(string valConnectionString, long valID)
        {
            try
            {
                SqlConnection tmpSqlConnection = new SqlConnection(valConnectionString);
                SqlCommand tmpCommand = tmpSqlConnection.CreateCommand();
                tmpCommand.CommandText = "SELECT RecordXmlized FROM dbo.P_RecordXmlized WHERE ID = " + valID;
                tmpCommand.CommandType = CommandType.Text;
                tmpSqlConnection.Open();
                SqlDataReader tmpDataReader = tmpCommand.ExecuteReader();
                //object tmpObject = tmpCommand.ExecuteScalar() ;
                if (tmpDataReader!=null && tmpDataReader.Read())
                {
                    SqlXml tmpRecordXmlized = tmpDataReader.GetSqlXml(0);
                    return tmpRecordXmlized;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
