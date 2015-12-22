using ClassLibraryLoginInformation;
using ClassLibraryMedicineKind;
using CustomForm;

namespace MedicineKinds.DataOperate
{
    //public partial class FormMedicineKindInformation : FormCustomDataLoaded_Design
    public partial class FormMedicineKindInformation : FormCustomDataLoaded<ClassMedicineKindPropertiesFull>
    {
        /// <summary>
        /// 权限ID为0，任何操作员都可登录
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valID"></param>
        public FormMedicineKindInformation(ClassLoginInformation valLoginInformation, long valID)
            : base(valLoginInformation,0,valID)
        {
            InitializeComponent();
        }

        #region 数据绑定

        protected override void BindingData()
        {
            ClassMedicineKindPropertiesFull MedicineKindProperties = Data as ClassMedicineKindPropertiesFull;
            if (MedicineKindProperties != null)
            {
                textBox通用名称.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesBasis.通用名称");
                textBox通用名称_拼音码.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesBasis.通用名称_拼音码");
                textBox商品名称.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesBasis.商品名称");
                textBox商品名称_拼音码.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesBasis.商品名称_拼音码");
                doubleTextBox单价.DataBindings.Add("Value", MedicineKindProperties, "MedicineKindPropertiesBasis.单价");
                textBox用法用量.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesBasis.用法用量");
                textBox生产企业.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesBasis.药品生产企业");
                textBox计量单位.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesBasis.计量单位");
                textBox计费类型.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesBasis.计费类型");
                textBox是否消耗品.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesBasis.是否消耗品");
                textBox有效期.DataBindings.Add("Text", MedicineKindProperties, "MedicineKindPropertiesBasis.有效期");
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
