using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;

namespace CostItems.DataOperate
{
    public partial class FormCostItemAdd : FormCostItemBase
    {
        public FormCostItemAdd(ClassLoginInformation valLoginInformation)
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
