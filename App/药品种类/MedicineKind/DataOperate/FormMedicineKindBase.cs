using System;
using System.ComponentModel;
using System.Windows.Forms;
using ClassLibraryCostType;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;
using ClassLibraryMedicineKind;
using ClassLibraryPublicEnum;
using ClassLibraryQuantityUnit;
using CustomForm;

namespace MedicineKinds.DataOperate
{
    public partial class FormMedicineKindBase : FormCustomSaved<ClassMedicineKindProperties>
    {
        #region 构造器

        public FormMedicineKindBase()
        {
            InitializeComponent();
        }

        public FormMedicineKindBase(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation, 24)
        {
            InitializeComponent();
        }

        public FormMedicineKindBase(ClassLoginInformation valLoginInformation, long valID)
            : base(valLoginInformation, 25, valID)
        {
            InitializeComponent();

            doubleTextBox单价.Enabled = false;
        }

        #endregion

        protected override void LoadData()
        {
            if (DesignMode)
            {
                return;
            }
            comboBox是否消耗品.DataSource = Enum.GetNames(typeof(enum是否));
            comboBox计量单位.DataSource = ClassLibraryQuantityUnitPublic.LoadAllQuantityUnit(LoginInformation.ConnectionString);
            comboBox计量单位.DisplayMember = "名称";
            comboBox计量单位.ValueMember = "ID";
            comboBox计费类型.DataSource = ClassLibraryCostTypePublic.LoadAllCostType(LoginInformation.ConnectionString);
            comboBox计费类型.DisplayMember = "计费类型";
            comboBox计费类型.ValueMember = "ID";

            textBox通用名称.Tag = textBox通用名称_拼音码;
            textBox商品名称.Tag = textBox商品名称_拼音码; 
            base.LoadData();
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
            textBox通用名称.Focus();

            base.OnExecuteSucceed(e);
        }

        #endregion

        #region 数据绑定

        protected sealed override void BindingData()
        {
            ClassMedicineKindProperties MedicineKindProperties = Data as ClassMedicineKindProperties;
            if (MedicineKindProperties != null)
            {
                textBox通用名称.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesBasis.通用名称");
                textBox通用名称_拼音码.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesBasis.通用名称_拼音码");
                textBox商品名称.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesBasis.商品名称");
                textBox商品名称_拼音码.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesBasis.商品名称_拼音码");
                doubleTextBox单价.DataBindings.Add("Value", MedicineKindProperties, "MedicineKindPropertiesBasis.单价");
                textBox用法用量.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesBasis.用法用量");
                textBox生产企业.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesBasis.药品生产企业");
                try
                {
                    comboBox计量单位.DataBindings.Add("SelectedValue", MedicineKindProperties, "MedicineKindPropertiesBasis.YKGL_计量单位_ID");
                    comboBox计费类型.DataBindings.Add("SelectedValue", MedicineKindProperties, "MedicineKindPropertiesBasis.P_计费类型_ID");
                }
                catch
                {
                    return;
                }
                comboBox是否消耗品.DataBindings.Add("SelectedIndex", MedicineKindProperties, "MedicineKindPropertiesBasis.是否消耗品");
                numericUpDown有效期.DataBindings.Add("Value", MedicineKindProperties, "MedicineKindPropertiesBasis.有效期");
                
                textBoxWithButton备注.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesBasis.备注");

                textBoxWithButton批准文号.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesAdditional.批准文号");
                textBoxWithButton适应症.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesAdditional.适应症");
                textBoxWithButton禁忌.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesAdditional.禁忌");
                textBoxWithButton儿童用药.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesAdditional.儿童用药");
                textBoxWithButton药物过量.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesAdditional.药物过量");
                textBoxWithButton贮藏.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesAdditional.贮藏");
                textBoxWithButton成份.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesAdditional.成份");
                textBoxWithButton规格.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesAdditional.规格");
                textBoxWithButton注意事项.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesAdditional.注意事项");
                textBoxWithButton老年用药.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesAdditional.老年用药");
                textBoxWithButton药理毒理.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesAdditional.药理毒理");
                textBoxWithButton包装.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesAdditional.包装");
                textBoxWithButton性状.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesAdditional.性状");
                textBoxWithButton不良反应.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesAdditional.不良反应");
                textBoxWithButton孕妇及哺乳期妇女用药.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesAdditional.孕妇及哺乳期妇女用药");
                textBoxWithButton药物相互作用.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesAdditional.药物相互作用");
                textBoxWithButton药代动力学.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesAdditional.药代动力学");
                textBoxWithButton执行标准.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesAdditional.执行标准");
            }
        }

        #endregion
    }
}
