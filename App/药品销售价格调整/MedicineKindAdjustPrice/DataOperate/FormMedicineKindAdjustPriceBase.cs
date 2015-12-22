using System;
using System.Windows.Forms;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;
using ClassLibraryMedicineKindAdjustPrice;
using CustomForm;

namespace MedicineKindAdjustPrice.DataOperate
{
    public partial class FormMedicineKindAdjustPriceBase : FormCustomSaved<ClassMedicineKindAdjustPriceProperties>
    {
        #region 构造器

        public FormMedicineKindAdjustPriceBase()
        {
            InitializeComponent();
        }

        public FormMedicineKindAdjustPriceBase(ClassLoginInformation valLoginInformation,long valID)
            : base(valLoginInformation, 42, valID)
        {
            InitializeComponent();
        }

        #endregion

        #region 按钮动作

        protected override void buttonOK_Edit_Click(object sender, EventArgs e)
        {
            ClassMedicineKindAdjustPriceProperties medicineKindAdjustPriceProperties = Data as ClassMedicineKindAdjustPriceProperties;
            if (medicineKindAdjustPriceProperties != null)
                if (medicineKindAdjustPriceProperties.调整后单价 == 0L)
                {
                    if (MessageBox.Show(@"注意：调整后价格为“0”，是否继续？", @"警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        return;
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

            Close();
        }

        #endregion

        #region 数据绑定

        protected sealed override void BindingData()
        {
            ClassMedicineKindAdjustPriceProperties MedicineKindAdjustPriceProperties = Data as ClassMedicineKindAdjustPriceProperties;
            if (MedicineKindAdjustPriceProperties != null)
            {
                textBox药品商品名称.DataBindings.Add("Text", MedicineKindAdjustPriceProperties, "MedicineKindProperties.通用名称");
                textBox药品通用名称.DataBindings.Add("Text", MedicineKindAdjustPriceProperties, "MedicineKindProperties.商品名称");
                textBox计量单位.DataBindings.Add("Text", MedicineKindAdjustPriceProperties, "MedicineKindProperties.计量单位");
                textBox当前单价.DataBindings.Add("Text", MedicineKindAdjustPriceProperties, "MedicineKindProperties.单价");
                doubleTextBox调整后单价.DataBindings.Add("Text", MedicineKindAdjustPriceProperties, "调整后单价");
                textBoxWithButton备注.DataBindings.Add("Text", MedicineKindAdjustPriceProperties, "备注");
            }
        }

        #endregion
    }
}
