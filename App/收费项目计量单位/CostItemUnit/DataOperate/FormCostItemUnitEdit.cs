using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;

namespace CostItemUnit.DataOperate
{
    public partial class FormCostItemUnitEdit : FormCostItemUnitBase
    {
        #region 构造器

        public FormCostItemUnitEdit()
        {
            InitializeComponent();
        }

        public FormCostItemUnitEdit(ClassLoginInformation valLoginInformation, long valID)
            : base(valLoginInformation, valID)
        {
            InitializeComponent();
        }
        #endregion

        protected override void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            base.OnExecuteSucceed(e);

            Close();
        }
    }
}
