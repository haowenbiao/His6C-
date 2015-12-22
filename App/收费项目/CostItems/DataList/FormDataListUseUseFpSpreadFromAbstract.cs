using System;
using ClassLibraryAbstractFormDataListBase;
using ClassLibraryLoginInformation;

namespace CostItems.DataList
{
    public partial class FormDataListUseUseFpSpreadFromAbstract : FormAbstractDataListUseFpSpreadBase
    {
        #region 构造器

        public FormDataListUseUseFpSpreadFromAbstract()
        {
            InitializeComponent();
        }

        public FormDataListUseUseFpSpreadFromAbstract(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation, false)
        {
            InitializeComponent();
        }

        #endregion

        protected override long IDOfSqlStringThatGetColumnsOfDataTable
        {
            get
            {
                //(57)SELECT * FROM dbo.P_收费项目表_View WHERE 1 > 2
                return 57L;
            }
        }

        protected override string KeyInTheConfigFile
        {
            get { return "CostItems"; }
        }

        protected override string LoadSqlString
        {
            get { throw new NotImplementedException(); }
        }
    }
}
