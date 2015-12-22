
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;

namespace CostItems.DataOperate
{
    public partial class FormCostItemEdit : FormCostItemBase
    {
        public FormCostItemEdit(ClassLoginInformation valLoginInformation, long valID)
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
