using ClassLibraryAbstractDataInformation;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;
using ClassLibraryMedicineKind;
using ClassLibraryMedicineKindAdjustPrice;

namespace MedicineKindAdjustPrice.DataOperate
{
    public partial class FormMedicineKindAdjustPriceEdit : FormMedicineKindAdjustPriceBase
    {
        public FormMedicineKindAdjustPriceEdit(ClassLoginInformation valLoginInformation, long valMedicineKineID)
            : base(valLoginInformation,valMedicineKineID)
        {
            InitializeComponent();
        }

        protected override void LoadData()
        {
            ClassMedicineKindPropertiesSimple tmpMedicineKindPropertiesSimple = new ClassMedicineKindPropertiesSimple { ID = Data.ID };
            ClassDataLoader dataLoader = new ClassDataLoader(LoginInformation, tmpMedicineKindPropertiesSimple);
            dataLoader.ExecuteError += OnLoadError;
            if (dataLoader.execute())
            {
                ClassMedicineKindAdjustPriceProperties medicineKindAdjustPriceProperties =
                    Data as ClassMedicineKindAdjustPriceProperties;
                if (medicineKindAdjustPriceProperties != null)
                    medicineKindAdjustPriceProperties.MedicineKindProperties = tmpMedicineKindPropertiesSimple;
            }
            //base.LoadData();
        }

        protected override void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            base.OnExecuteSucceed(e);
            Close();
        }
    }
}
