using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;

namespace QuantityUnit.DataOperate
{
    public partial class FormQuantityUnitEdit : FormQuantityUnitBase
    {
        public FormQuantityUnitEdit(ClassLoginInformation valLoginInformation,long valID)
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
