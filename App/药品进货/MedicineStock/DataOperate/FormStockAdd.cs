using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;

namespace MedicineStock.DataOperate
{
    public partial class FormStockAdd : FormStockAddBase
    {
        public FormStockAdd(ClassLoginInformation valLoginInformation)
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
