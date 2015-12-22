using ClassLibraryAbstractFormDataListBase;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;

namespace CostType.DataList
{
    public partial class FormDataListUseDataGridViewBaseFromAbstract : FormAbstractDataListUseDataGridViewBase
    {

        #region 构造器

        public FormDataListUseDataGridViewBaseFromAbstract()
        {
            InitializeComponent();
        }

        public FormDataListUseDataGridViewBaseFromAbstract(ClassLoginInformation valLoginInformation, bool valCanInvokeDataListItemSelectedEvent)
            : base(valLoginInformation, valCanInvokeDataListItemSelectedEvent)
        {
            InitializeComponent();
        }

        #endregion

        protected override string LoadSqlString
        {
            get
            {
                //(48)SELECT * FROM dbo.P_计费类型表_View
                string tmpSqlString1 =
                    ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 48);
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
