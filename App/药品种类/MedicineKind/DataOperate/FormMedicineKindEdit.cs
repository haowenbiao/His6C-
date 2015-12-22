using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;

namespace MedicineKinds.DataOperate
{
    public partial class FormMedicineKindEdit : FormMedicineKindBase
    {
        public FormMedicineKindEdit(ClassLoginInformation valLoginInformation, long valID)
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
