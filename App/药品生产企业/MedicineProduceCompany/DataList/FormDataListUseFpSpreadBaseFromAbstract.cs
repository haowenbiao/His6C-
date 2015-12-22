using System;
using ClassLibraryAbstractFormDataListBase;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;

namespace MedicineProduceCompany.DataList
{
    public partial class FormDataListUseFpSpreadBaseFromAbstract : FormAbstractDataListUseFpSpreadBase
    {
        protected FormDataListUseFpSpreadBaseFromAbstract()
        {
            InitializeComponent();
        }

        protected FormDataListUseFpSpreadBaseFromAbstract(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation)
        {
            InitializeComponent();
        }

        protected override string LoadSqlString
        {
            get
            {
                string tmpSqlString;
                if (string.IsNullOrEmpty(MedicineProductCompanyNameOrPYMForSearch))
                {
                    //(20) SELECT * FROM dbo.YKGL_药品生产企业表_View
                    string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 20);
                    if (string.IsNullOrEmpty(tmpSQLString1))
                    {
                        return null;
                    }
                    tmpSqlString = tmpSQLString1;
                }
                else
                {
                    //(19)SELECT * FROM dbo.YKGL_药品生产企业表_View WHERE 名称 LIKE '{0}%' OR 拼音码 LIKE '{0}%'
                    string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 19);
                    if (string.IsNullOrEmpty(tmpSQLString1))
                    {
                        return null;
                    }
                    tmpSqlString = string.Format(tmpSQLString1, MedicineProductCompanyNameOrPYMForSearch, MedicineProductCompanyNameOrPYMForSearch);
                }
                return tmpSqlString;
            }
        }

        protected virtual string MedicineProductCompanyNameOrPYMForSearch
        {
            get { throw new NotImplementedException(); }
        }

        protected override long IDOfSqlStringThatGetColumnsOfDataTable
        {
            get
            {
                //(47)SELECT * FROM dbo.YKGL_药品生产企业表_View WHERE 1 > 2
                return 47L;
            }
        }

        protected override string KeyInTheConfigFile
        {
            get { return "MedicineProductCompanies"; }
        }
    }
}
