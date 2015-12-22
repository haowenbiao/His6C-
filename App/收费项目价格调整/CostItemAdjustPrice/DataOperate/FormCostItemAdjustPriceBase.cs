using System;
using System.Windows.Forms;
using ClassLibraryCostItemAdjustPrice;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;
using CustomForm;

namespace CostItemAdjustPrice.DataOperate
{
    public partial class FormCostItemAdjustPriceBase : FormCustomSaved<ClassCostItemAdjustPriceProperties>
    {
        #region 构造器

        public FormCostItemAdjustPriceBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 增加调整记录，调整价格，修改
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valID"></param>
        public FormCostItemAdjustPriceBase(ClassLoginInformation valLoginInformation, long valID)
            : base(valLoginInformation, 64, valID)
        {
            InitializeComponent();
        }

        #endregion

        #region 按钮动作

        protected override void buttonOK_Edit_Click(object sender, EventArgs e)
        {
            ClassCostItemAdjustPriceProperties costItemAdjustPriceProperties =
                Data as ClassCostItemAdjustPriceProperties;
            if (costItemAdjustPriceProperties != null)
            {
                if (costItemAdjustPriceProperties.调整后单价 == 0L)
                {
                    if (MessageBox.Show(@"注意：调整后价格为“0”，是否继续？", @"警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            base.buttonOK_Edit_Click(sender, e);
        }

        #endregion

        #region 继承的事件

        protected override void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            MessageBox.Show(@"保存成功！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            base.OnExecuteSucceed(e);
        }

        #endregion

        #region 数据绑定

        protected sealed override void BindingData()
        {
            ClassCostItemAdjustPriceProperties CostItemAdjustPriceProperties = Data as ClassCostItemAdjustPriceProperties;
            if (CostItemAdjustPriceProperties != null)
            {
                textBox收费项目名称.DataBindings.Add("Text", CostItemAdjustPriceProperties.CostItemProperties, "收费项目");
                textBox计量单位.DataBindings.Add("Text", CostItemAdjustPriceProperties.CostItemProperties, "计量单位");
                currencyTextBox当前单价.DataBindings.Add("Text", CostItemAdjustPriceProperties.CostItemProperties, "单价");
                doubleTextBox调整后单价.DataBindings.Add("Text", CostItemAdjustPriceProperties, "调整后单价");
                textBoxWithButton备注.DataBindings.Add("Text", CostItemAdjustPriceProperties, "备注");
            }
        }

        #endregion
    }
}
