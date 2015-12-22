using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;

namespace SupplierInformations.DataOperate
{
    public partial class FormSupplierInformationAdd : FormSupplierInformationBase
    {
        public FormSupplierInformationAdd(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation)
        {
            InitializeComponent();
        }

        protected override void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            Data.Clear();
            ReBinding();

            base.OnExecuteSucceed(e);
        }

    }
}
