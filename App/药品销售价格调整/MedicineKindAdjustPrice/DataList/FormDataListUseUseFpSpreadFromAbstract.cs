using System;
using ClassLibraryAbstractFormDataListBase;
using ClassLibraryLoginInformation;

namespace MedicineKindAdjustPrice.DataList
{
    public partial class FormDataListUseUseFpSpreadFromAbstract : FormAbstractDataListUseFpSpreadBase
    {
        public FormDataListUseUseFpSpreadFromAbstract()
        {
            InitializeComponent();
        }

        public FormDataListUseUseFpSpreadFromAbstract(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation, 42, false)
        {
            InitializeComponent();
        } 

        protected override long IDOfSqlStringThatGetColumnsOfDataTable
        {
            get { return 71L; }
        }

        protected override string KeyInTheConfigFile
        {
            get { return "MedicineKindAdjustPrice"; }
        }

        protected override string LoadSqlString
        {
            get { throw new NotImplementedException(); }
        }
    }
}
