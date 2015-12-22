using System;
using ClassLibraryAbstractFormDataListBase;
using ClassLibraryLoginInformation;

namespace SupplierInformations.DataList
{
    public partial class FormDataListUseFpSpreadBaseFromAbstract : FormAbstractDataListUseFpSpreadBase
    {
        public FormDataListUseFpSpreadBaseFromAbstract()
        {
            InitializeComponent();
        }

        public FormDataListUseFpSpreadBaseFromAbstract(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation, true)
        {
            InitializeComponent();
        }

        protected override long IDOfSqlStringThatGetColumnsOfDataTable
        {
            get
            {
                //(85)SELECT * FROM dbo.YKGL_供货单位信息表_View WHERE 1 > 2
                return 85L;
            }
        }

        protected override string KeyInTheConfigFile
        {
            get { return "Supplier"; }
        }

        protected override string LoadSqlString
        {
            get { throw new NotImplementedException(); }
        }
    }
}
