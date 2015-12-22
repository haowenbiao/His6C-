using ClassLibraryAbstractDataInformation;
using ClassLibraryCostItemAdjustPrice;
using ClassLibraryCostItems;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;

namespace CostItemAdjustPrice.DataOperate
{
    public partial class FormCostItemAdjustPriceEdit : FormCostItemAdjustPriceBase
    {
        public FormCostItemAdjustPriceEdit(ClassLoginInformation valLoginInformation, long valCostItemID)
            : base(valLoginInformation,valCostItemID)
        {
            InitializeComponent();
        }

        protected override void LoadData()
        {
            ClassCostItemPropertiesSimple tmpCostItemPropertiesSimple = new ClassCostItemPropertiesSimple {ID = Data.ID};
            ClassDataLoader dataLoader = new ClassDataLoader(LoginInformation, tmpCostItemPropertiesSimple);
            dataLoader.ExecuteError += OnLoadError;
            if (dataLoader.execute())
            {
                ClassCostItemAdjustPriceProperties costItemAdjustPriceProperties =
                    Data as ClassCostItemAdjustPriceProperties;
                if (costItemAdjustPriceProperties != null)
                    costItemAdjustPriceProperties.CostItemProperties = tmpCostItemPropertiesSimple;
            }
        }

        protected override void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            base.OnExecuteSucceed(e);
            Close();
        }

        //protected override void buttonOK_Click(object sender, EventArgs e)
        //{
        //    ClassCostItemAdjustPriceProperties costItemAdjustPriceProperties = Data as ClassCostItemAdjustPriceProperties;
        //    if (costItemAdjustPriceProperties != null)
        //        if (costItemAdjustPriceProperties.调整后单价 == 0D)
        //        {
        //            if (MessageBox.Show(@"注意：调整后价格为“0”，是否继续？", @"警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
        //            {
        //                return;
        //            }
        //        }

        //    ClassCostItemAdjustPricePropertiesAdder costItemAdjustPricePropertiesAdder = new ClassCostItemAdjustPricePropertiesAdder(LoginInformation, Data);
        //    costItemAdjustPricePropertiesAdder.Error += this_Error;
        //    costItemAdjustPricePropertiesAdder.ExecuteSucceed += this_ExecuteSucceed;
        //    costItemAdjustPricePropertiesAdder.execute();
        //    costItemAdjustPricePropertiesAdder.Error -= this_Error;

        //    base.buttonOK_Click(sender, e);
        //}
    }
}
