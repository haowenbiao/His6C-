using System.Data;
using ClassLibraryDataTableFromQueryString;
using ClassLibraryGetSQLString;
using ClassLibrarySQLExecute;

namespace ClassLibraryMedicineKind
{
    public class ClassMedicineKindPublic
    {
        /// <summary>
        /// 加载所有药品种类信息，包括“所有药品”项。
        /// </summary>
        /// <param name="valConnectionString"></param>
        /// <returns></returns>
        public static DataTable LoadAllMedicineKindsWithAll(string valConnectionString)
        {
            //(72)SELECT ID,通用名称,通用名称_拼音码,商品名称,商品名称_拼音码 FROM dbo.YKGL_药品种类表 ORDER BY ID
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valConnectionString, 72);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return null;
            }
            string tmpSqlString = tmpSQLString1;
            DataTableFromQueryString tmpDepartmentInformations = new DataTableFromQueryString(valConnectionString,
                                                                                              tmpSqlString);
            DataTable tmpDataTable = tmpDepartmentInformations.value;
            object[] tmpNewRow = new object[5];
            tmpNewRow[0] = 0L;
            tmpNewRow[1] = "所有药品";
            tmpNewRow[2] = "";
            tmpNewRow[3] = "所有药品";
            tmpNewRow[4] = "";
            tmpDataTable.Rows.Add(tmpNewRow);
            tmpDataTable.DefaultView.Sort = "ID";
            return tmpDataTable;
        }

        /// <summary>
        /// 加载所有药品种类信息。
        /// </summary>
        /// <param name="valConnectionString"></param>
        /// <returns></returns>
        public static DataTable LoadAllMedicineKinds(string valConnectionString)
        {
            //(72)SELECT ID,通用名称,通用名称_拼音码,商品名称,商品名称_拼音码 FROM dbo.YKGL_药品种类表 ORDER BY ID
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valConnectionString, 72);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return null;
            }
            string tmpSqlString = tmpSQLString1;
            DataTableFromQueryString tmpDepartmentInformations = new DataTableFromQueryString(valConnectionString,
                                                                                              tmpSqlString);
            DataTable tmpDataTable = tmpDepartmentInformations.value;
            tmpDataTable.DefaultView.Sort = "ID";
            return tmpDataTable;
        }

        /// <summary>
        /// 获得药品有效期（按月计算）
        /// </summary>
        /// <param name="valConnectionString"></param>
        /// <param name="valMedicineKind"></param>
        /// <returns></returns>
        public static long GetMedicineKindPeriodOfValidity(string valConnectionString, long valMedicineKind)
        {
            //(95)SELECT [有效期(月)] FROM dbo.YKGL_药品种类表 WHERE ID = {0}
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valConnectionString, 95);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return 0L;
            }
            string tmpSqlString = string.Format(tmpSQLString1, valMedicineKind);
            long? tmpMedicineKindPeriodOfValidity = ClassExecuteScalarData.GetScalarLong(valConnectionString,
                                                                                         tmpSqlString);
            if (tmpMedicineKindPeriodOfValidity.HasValue)
            {
                return tmpMedicineKindPeriodOfValidity.Value;
            }
            return 0L;
        }

    }
}