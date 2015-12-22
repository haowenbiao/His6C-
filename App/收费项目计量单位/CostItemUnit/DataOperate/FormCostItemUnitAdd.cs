using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;

namespace CostItemUnit.DataOperate
{
    public partial class FormCostItemUnitAdd : FormCostItemUnitBase
    {
        /// <summary>
        /// 有权限的操作员和建立该记录的操作员可进行此操作
        /// </summary>
        /// <param name="valLoginInformation"></param>
        public FormCostItemUnitAdd(ClassLoginInformation valLoginInformation)
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
