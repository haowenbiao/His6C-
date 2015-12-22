using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;

namespace MedicineStoreHouseInformation.DataOperate
{
    public partial class FormMedicineStoreHouseInformationAdd : FormMedicineStoreHouseInformationBase
    {
        public FormMedicineStoreHouseInformationAdd(ClassLoginInformation valLoginInformation)
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
