using System;
using System.ComponentModel;
using System.Windows.Forms;
using ClassLibraryCostType;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;
using CustomForm;

namespace CostType.DataOperate
{
    public partial class FormCostTypeBase : FormCustomSaved<ClassCostTypeProperties>
    {
        #region 构造器

        public FormCostTypeBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 增加，超级用户才可登录
        /// </summary>
        /// <param name="valLoginInformation"></param>
        public FormCostTypeBase(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation, 67)
        {
            InitializeComponent();
            textBox计费类型.Tag = textBox拼音码;
        }

        /// <summary>
        /// 修改，？？
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valID"></param>
        public FormCostTypeBase(ClassLoginInformation valLoginInformation, long valID)
            : base(valLoginInformation, 68, valID)
        {
            InitializeComponent();
            textBox计费类型.Tag = textBox拼音码;
        }

        #endregion

        #region 数据验证
       
        protected sealed override void control_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.control_KeyPress(sender, e);
        }

        protected sealed override void textBox名称_Validated(object sender, EventArgs e)
        {
            base.textBox名称_Validated(sender, e);
        }

        protected sealed override void NoneNullabletextBox_Validating(object sender, CancelEventArgs e)
        {
            base.NoneNullabletextBox_Validating(sender, e);
        }

        #endregion

        #region 继承的事件

        protected override void OnSizeStateChanged(EventArgsOfSizeStateChanged e)
        {
            groupBox2.Visible = SizeState == EnumSizeState.MaxSize;

            base.OnSizeStateChanged(e);
        }

        protected override void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            MessageBox.Show(@"保存成功！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox计费类型.Focus();

            base.OnExecuteSucceed(e);
        }

        #endregion

        #region 数据绑定

        protected sealed override void BindingData()
        {
            ClassCostTypeProperties CostTypeProperties = Data as ClassCostTypeProperties;
            if (CostTypeProperties != null)
            {
                textBox计费类型.DataBindings.Add("Text", CostTypeProperties, "计费类型");
                textBox拼音码.DataBindings.Add("Text", CostTypeProperties, "拼音码");
                textBoxWithButton备注.DataBindings.Add("Text", CostTypeProperties, "备注");
            }
        }
        
        #endregion
    }
}
