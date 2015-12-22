using ClassLibraryAbstractFormDataListBase;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;

namespace WorkerInformations.DataList
{
    public partial class FormDataListUseFpSpreadBaseFromAbstract : FormAbstractDataListUseFpSpreadBase
    {
        protected FormDataListUseFpSpreadBaseFromAbstract()
        {
            InitializeComponent();
        }

        protected FormDataListUseFpSpreadBaseFromAbstract(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation, 82)
        {
            InitializeComponent();
        }

        protected override string LoadSqlString
        {
            get
            {
                //SELECT [ID],[姓名],[拼音码],CASE [性别] WHEN 1 THEN '女' ELSE '男' END AS 性别,[出生日期],[身份证号码],[家庭住址],[联系电话1],[联系电话2],[是否操作员],[备注] FROM [P_职工信息表] Where ID > 1
                string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 28);
                return tmpSQLString1;
            }
        }

        protected override long IDOfSqlStringThatGetColumnsOfDataTable
        {
            get { return 41L; }
        }

        protected override string KeyInTheConfigFile
        {
            get { return "WokerInformations"; }
        }
    }
}
