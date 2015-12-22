using System;
using System.ComponentModel;
using System.Windows.Forms;
using ClassLibraryCostItems;
using ClassLibraryCostType;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;
using CustomForm;

namespace CostItems.DataOperate
{
    public partial class FormCostItemBase : FormCustomSaved<ClassCostItemProperties>
    {
        public FormCostItemBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="valLoginInformation"></param>
        public FormCostItemBase(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation, 56)
        {
            InitializeComponent();

            comboBox计量单位.DataSource = ClassCostItemPublic.LoadAllCostItemUnit(LoginInformation.ConnectionString);
            comboBox计量单位.DisplayMember = "单位名称";
            comboBox计量单位.ValueMember = "ID";
            comboBox计费类型.DataSource = ClassLibraryCostTypePublic.LoadAllCostType(LoginInformation.ConnectionString);
            comboBox计费类型.DisplayMember = "计费类型";
            comboBox计费类型.ValueMember = "ID";

            textBox收费项目.Tag = textBox拼音码;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valID"></param>
        public FormCostItemBase(ClassLoginInformation valLoginInformation,long valID)
            : base(valLoginInformation, 57, valID)
        {
            InitializeComponent();

            doubleTextBox单价.Enabled = false;

            comboBox计量单位.DataSource = ClassCostItemPublic.LoadAllCostItemUnit(LoginInformation.ConnectionString);
            comboBox计量单位.DisplayMember = "单位名称";
            comboBox计量单位.ValueMember = "ID";
            comboBox计费类型.DataSource = ClassLibraryCostTypePublic.LoadAllCostType(LoginInformation.ConnectionString);
            comboBox计费类型.DisplayMember = "计费类型";
            comboBox计费类型.ValueMember = "ID";

            textBox收费项目.Tag = textBox拼音码;
        }

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
            textBox收费项目.Focus();

            base.OnExecuteSucceed(e);
        }

        #endregion

        #region 数据绑定

        protected sealed override void BindingData()
        {
            ClassCostItemProperties CostItemProperties = Data as ClassCostItemProperties;
            if (CostItemProperties != null)
            {
                textBox收费项目.DataBindings.Add("Text", CostItemProperties, "收费项目");
                textBox拼音码.DataBindings.Add("Text", CostItemProperties, "拼音码");
                doubleTextBox单价.DataBindings.Add("Value", CostItemProperties,"单价");
                try
                {
                    comboBox计量单位.DataBindings.Add("SelectedValue", CostItemProperties, "P_收费项目单位_ID");
                    //comboBox计量单位.SelectedValue
                    comboBox计费类型.DataBindings.Add("SelectedValue", CostItemProperties, "P_计费类型_ID");
                }
                catch
                {
                    return;                    
                }
                textBoxWithButton备注.DataBindings.Add("Text", CostItemProperties, "备注");
            }
        }

        #endregion
    }
}
