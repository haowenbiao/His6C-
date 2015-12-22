using System;
using ClassLibraryAbstractFormDataListBase;
using ClassLibraryLoginInformation;

namespace CostItemAdjustPrice.DataList
{
    public partial class FormDataListUseUseFpSpreadFromAbstract : FormAbstractDataListUseFpSpreadBase
    {
        public FormDataListUseUseFpSpreadFromAbstract()
        {
            InitializeComponent();
        }

        public FormDataListUseUseFpSpreadFromAbstract(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation, 64, false)
        {
            InitializeComponent();
        }

        protected override long IDOfSqlStringThatGetColumnsOfDataTable
        {
            get { return 64L; }
        }

        protected override string KeyInTheConfigFile
        {
            get { return "CostItemAdjustPrice"; }
        }

        protected override string LoadSqlString
        {
            get { throw new NotImplementedException(); }
        }
    }
}
