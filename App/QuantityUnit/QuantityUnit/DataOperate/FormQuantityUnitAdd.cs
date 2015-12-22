using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;

namespace QuantityUnit.DataOperate
{
    public partial class FormQuantityUnitAdd : FormQuantityUnitBase
    {
        public FormQuantityUnitAdd(ClassLoginInformation valLoginInformation)
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
