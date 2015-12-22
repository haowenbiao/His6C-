using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;

namespace MedicineKinds.DataOperate
{
    public partial class FormMedicineKindAdd : FormMedicineKindBase
    {
        public FormMedicineKindAdd(ClassLoginInformation valLoginInformation)
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
