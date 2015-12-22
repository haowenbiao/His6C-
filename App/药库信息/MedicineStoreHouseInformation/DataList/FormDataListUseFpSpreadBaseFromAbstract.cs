using System;
using ClassLibraryAbstractFormDataListBase;
using ClassLibraryLoginInformation;

namespace MedicineStoreHouseInformation.DataList
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
                //(79)SELECT * FROM dbo.YKGL_药库信息表_View WHERE 1 > 2
                return 79L;
            }
        }

        protected override string KeyInTheConfigFile
        {
            get { return "MedicineStoreHouseInformation"; }
        }

        protected override string LoadSqlString
        {
            get { throw new NotImplementedException(); }
        }
    }
}
