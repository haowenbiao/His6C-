using ClassLibraryAbstractFormDataListBase;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;

namespace QuantityUnit.DataList
{
    public partial class FormDataListUseDataGridViewBaseFromAbstract : FormAbstractDataListUseDataGridViewBase
    {
        public FormDataListUseDataGridViewBaseFromAbstract()
        {
            InitializeComponent();
        }

        public FormDataListUseDataGridViewBaseFromAbstract(ClassLoginInformation valLoginInformation, bool valCanInvokeDataListItemSelectedEvent)
            : base(valLoginInformation,valCanInvokeDataListItemSelectedEvent)
        {
            InitializeComponent();
        }

        protected override string LoadSqlString
        {
            get
            {
                //(29)SELECT * FROM YKGL_数量单位表_View
                string tmpSqlString1 =
                    ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 29);
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
