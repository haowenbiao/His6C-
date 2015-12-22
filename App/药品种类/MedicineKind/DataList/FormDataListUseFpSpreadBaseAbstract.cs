using System;
using ClassLibraryAbstractFormDataListBase;
using ClassLibraryLoginInformation;

namespace MedicineKinds.DataList
{
    public partial class FormDataListUseFpSpreadBaseAbstract : FormAbstractDataListUseFpSpreadBase
    {
        protected FormDataListUseFpSpreadBaseAbstract()
        {
            InitializeComponent();
        }

        protected FormDataListUseFpSpreadBaseAbstract(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation, false)
        {
            InitializeComponent();
        }

        protected override string LoadSqlString
        {
            get { throw new NotImplementedException(); }
        }

        protected override long IDOfSqlStringThatGetColumnsOfDataTable
        {
            get { return 40L; }
        }

        protected override string KeyInTheConfigFile
        {
            get { return "MedicineKinds"; }
        }
    }
}