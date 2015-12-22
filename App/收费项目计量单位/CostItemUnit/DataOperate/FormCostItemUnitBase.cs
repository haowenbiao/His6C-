using System.ComponentModel;
using System.Windows.Forms;
using ClassLibraryCostItemUnit;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;
using CustomForm;

namespace CostItemUnit.DataOperate
{
    //public partial class FormCostItemUnitBase : FormCustomDataLoaded_Design
    public partial class FormCostItemUnitBase : FormCustomSaved<ClassCostItemUnitProperties>
    {

        #region 构造器

        protected FormCostItemUnitBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="valLoginInformation"></param>
        protected FormCostItemUnitBase(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation, 60)
        {
            InitializeComponent();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valID"></param>
        protected FormCostItemUnitBase(ClassLoginInformation valLoginInformation, long valID)
            : base(valLoginInformation, 61, valID)
        {
            InitializeComponent();
        }

        #endregion

        #region 数据验证

        protected sealed override void control_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.control_KeyPress(sender, e);
        }

        protected sealed override void NoneNullabletextBox_Validating(object sender, CancelEventArgs e)
        {
            base.NoneNullabletextBox_Validating(sender, e);
        }

        #endregion

        #region 继承的事件

        protected override void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            MessageBox.Show(@"保存成功！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox单位名称.Focus();

            base.OnExecuteSucceed(e);
        }

        #endregion

        #region 数据绑定

        protected sealed override void BindingData()
        {
            ClassCostItemUnitProperties CostTypeProperties = Data as ClassCostItemUnitProperties;
            if (CostTypeProperties != null)
            {
                textBox单位名称.DataBindings.Add("Text", CostTypeProperties, "单位名称");
            }
        }

        #endregion
    }
}
