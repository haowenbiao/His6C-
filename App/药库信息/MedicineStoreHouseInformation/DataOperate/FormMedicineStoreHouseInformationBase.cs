using System;
using System.ComponentModel;
using System.Windows.Forms;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;
using ClassLibraryMedicineStoreHouseInfomation;
using CustomForm;

namespace MedicineStoreHouseInformation.DataOperate
{
    //public partial class FormMedicineStoreHouseInformationBase : FormCustomDataLoaded_Design
    public partial class FormMedicineStoreHouseInformationBase : FormCustomSaved<ClassMedicineStoreHouseInfomationProperties>
    {
        #region 构造器

        public FormMedicineStoreHouseInformationBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="valLoginInformation"></param>
        public FormMedicineStoreHouseInformationBase(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation, 85)
        {
            InitializeComponent();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valID"></param>
        public FormMedicineStoreHouseInformationBase(ClassLoginInformation valLoginInformation, long valID)
            : base(valLoginInformation, 86, valID)
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }

            comboBox药库类型.DataSource =
                ClassMedicineStoreHouseInfomationPropertiesPublic.LoadAllMedicineStoreHouseInformationType(
                    LoginInformation.ConnectionString);
            comboBox药库类型.DisplayMember = "名称";
            comboBox药库类型.ValueMember = "ID";

            textBox药库名称.Tag = textBox拼音码; 

            base.OnLoad(e);
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
            textBox药库名称.Focus();

            base.OnExecuteSucceed(e);
        }

        #endregion

        #region 数据绑定

        protected sealed override void BindingData()
        {
            ClassMedicineStoreHouseInfomationProperties medicineStoreHouseInfomationProperties = Data as ClassMedicineStoreHouseInfomationProperties;
            if (medicineStoreHouseInfomationProperties != null)
            {
                textBox药库名称.DataBindings.Add("Text", medicineStoreHouseInfomationProperties, "药库名称");
                textBox拼音码.DataBindings.Add("Text", medicineStoreHouseInfomationProperties, "拼音码");
                textBox位置.DataBindings.Add("Text", medicineStoreHouseInfomationProperties, "位置");
                textBox负责人.DataBindings.Add("Text", medicineStoreHouseInfomationProperties, "负责人");
                textBoxWithButton备注.DataBindings.Add("Text", medicineStoreHouseInfomationProperties, "备注");
                try
                {
                    comboBox药库类型.DataBindings.Add("SelectedValue", medicineStoreHouseInfomationProperties, "YKGL_药库类型_ID");
                }
                catch
                {
                    return;
                }
            }
        }

        #endregion
    }
}
