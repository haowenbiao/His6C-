using ClassLibraryAbstractFormDataListBase;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;

namespace CostItemUnit.DataList
{
    public partial class FormDataListUseDataGridViewBaseFromAbstract : FormAbstractDataListUseDataGridViewBase
    {
        public FormDataListUseDataGridViewBaseFromAbstract()
        {
            InitializeComponent();
        }

        public FormDataListUseDataGridViewBaseFromAbstract(ClassLoginInformation valLoginInformation, bool valCanInvokeDataListItemSelectedEvent)
            : base(valLoginInformation, valCanInvokeDataListItemSelectedEvent)
        {
            InitializeComponent();
        } 
        protected override string LoadSqlString
        {
            get
            {
                //(52)SELECT * FROM dbo.P_收费项目单位表_View
                string tmpSqlString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 52);
                if (string.IsNullOrEmpty(tmpSqlString1))
                {
                    return null;
                }
                string tmpSqlString = tmpSqlString1;
                return tmpSqlString;
            }
        }
    }
}
