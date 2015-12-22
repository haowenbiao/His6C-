using System.Data;
using ClassLibraryDataTableFromQueryString;
using ClassLibraryGetSQLString;

namespace ClassLibraryWorkerInformations
{
    public class ClassWorkerPublic
    {
        /// <summary>
        /// 加载职员列表。
        /// </summary>
        /// <param name="valConnectionString"></param>
        /// <param name="valWithAllItem">是否包含“所有”项目</param>
        /// <returns></returns>
        public static DataTable LoadWorkerList(string valConnectionString,bool valWithAllItem)
        {
            //(104)SELECT ID ,P_职工信息_ID ,P_部门信息_ID ,职工姓名 ,拼音码 ,部门名称 FROM dbo.P_职工信息_部门信息_表_View ORDER BY P_部门信息_ID
            //(171)SELECT  p1.ID ,p1.姓名 ,p1.拼音码 ,STUFF(( SELECT  ',' + 名称 FROM P_部门信息表 p2 ,dbo.P_职工信息_部门信息_表 p3 WHERE   p3.P_部门信息_ID = p2.ID AND p3.P_职工信息_ID = p1.ID  ORDER BY p2.ID FOR XML PATH('')), 1, 1, SPACE(0)) AS 部门 FROM    dbo.P_职工信息表 p1 ORDER BY p1.ID
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valConnectionString, 171);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return null;
            }
            string tmpSqlString = tmpSQLString1;
            DataTableFromQueryString tmpDepartmentInformations = new DataTableFromQueryString(valConnectionString,
                                                                                              tmpSqlString);
            DataTable tmpDataTable = tmpDepartmentInformations.value;
            if (valWithAllItem)
            {
                object[] tmpNewRow = new object[6];
                tmpNewRow[0] = 0L;
                tmpNewRow[1] = 0L;
                tmpNewRow[2] = 0L;
                tmpNewRow[3] = "所有职工";
                tmpNewRow[4] = "All";
                tmpNewRow[5] = "";
                tmpDataTable.Rows.Add(tmpNewRow);
            }
            //tmpDataTable.DefaultView.Sort = "P_部门信息_ID";
            return tmpDataTable;
        }
    }
}