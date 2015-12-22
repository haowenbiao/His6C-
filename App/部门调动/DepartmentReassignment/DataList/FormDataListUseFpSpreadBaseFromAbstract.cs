using System;
using ClassLibraryAbstractFormDataListBase;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;

namespace DepartmentReassignment.DataList
{
    public partial class FormDataListUseFpSpreadBaseFromAbstract : FormAbstractDataListUseFpSpreadBase
    {
        public FormDataListUseFpSpreadBaseFromAbstract()
        {
            InitializeComponent();
        }

        public FormDataListUseFpSpreadBaseFromAbstract(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation, 83, false)
        {
            InitializeComponent();
        }

        protected override string LoadSqlString
        {
            get
            {
                string tmpSqlString;
                if (string.IsNullOrEmpty(WorkerNameOrPYMForSearch))
                {
                    //SELECT  职工姓名,调动类型,调动部门,调动时间,会计期,备注 FROM P_职工岗位调动记录_View
                    string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 3);
                    if (string.IsNullOrEmpty(tmpSQLString1))
                    {
                        return null;
                    }
                    tmpSqlString = tmpSQLString1;
                }
                else
                {
                    //(4)SELECT ID=0, 职工姓名,调动类型,调动部门,调动时间,会计期,备注 FROM P_职工岗位调动记录_View WHERE 职工姓名 LIKE '%{0}%' OR 拼音码 LIKE '%{1}%'
                    string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 4);
                    if (string.IsNullOrEmpty(tmpSQLString1))
                    {
                        return null;
                    }
                    tmpSqlString = string.Format(tmpSQLString1, WorkerNameOrPYMForSearch, WorkerNameOrPYMForSearch);
                }
                return tmpSqlString;
            }
        }

        protected virtual string WorkerNameOrPYMForSearch
        {
            get { throw new NotImplementedException(); }
        }


        protected override long IDOfSqlStringThatGetColumnsOfDataTable
        {
            get { return 43L; }
        }

        protected override string KeyInTheConfigFile
        {
            get { return "DepartmentReassignment"; }
        }
    }
}
