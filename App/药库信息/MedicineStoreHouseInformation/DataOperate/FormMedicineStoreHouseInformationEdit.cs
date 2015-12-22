using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;

namespace MedicineStoreHouseInformation.DataOperate
{
    public partial class FormMedicineStoreHouseInformationEdit : FormMedicineStoreHouseInformationBase
    {
        public FormMedicineStoreHouseInformationEdit(ClassLoginInformation valLoginInformation, long valID)
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
