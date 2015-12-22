using ClassLibraryAbstractFormDataListBase;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;

namespace DepartmentInformation.DataList
{
    public partial class FormDataListUseFpSpreadBaseFromAbstract : FormAbstractDataListUseFpSpreadBase
    {
        public FormDataListUseFpSpreadBaseFromAbstract()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 超级用户可登录
        /// </summary>
        /// <param name="valLoginInformation"></param>
        public FormDataListUseFpSpreadBaseFromAbstract(ClassLoginInformation valLoginInformation)
            :base(valLoginInformation,79)
        {
            InitializeComponent();
        }

        protected override string LoadSqlString
        {
            get
            {
                string tmpSqlString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 10);
                return tmpSqlString1;
            }
        }


        protected override long IDOfSqlStringThatGetColumnsOfDataTable
        {
            get { return 42L; }
        }

        protected override string KeyInTheConfigFile
        {
            get { return "DeparmentInformations"; }
        }
    }
}