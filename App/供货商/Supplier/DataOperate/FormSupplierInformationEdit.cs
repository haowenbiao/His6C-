using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;

namespace SupplierInformations.DataOperate
{
    public partial class FormSupplierInformationEdit : FormSupplierInformationBase
    {
        public FormSupplierInformationEdit(ClassLoginInformation valLoginInformation, long valID)
            : base(valLoginInformation, valID)
        {
            InitializeComponent();
        }

        protected override void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            base.OnExecuteSucceed(e);

            Close();
        }

    }
}
