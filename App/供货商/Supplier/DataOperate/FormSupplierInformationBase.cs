using System;
using System.ComponentModel;
using System.Windows.Forms;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;
using ClassLibrarySupplier;
using CustomForm;

namespace SupplierInformations.DataOperate
{
    //public partial class FormSupplierInformationBase : FormCustomDataLoaded_Design
    public partial class FormSupplierInformationBase : FormCustomSaved<ClassSupplierProperties>
    {
        #region 构造器

        protected FormSupplierInformationBase()
        {
            InitializeComponent();
        }

        public FormSupplierInformationBase(ClassLoginInformation valLoginInformation):base(valLoginInformation,88)
        {
            InitializeComponent();
            textBox名称.Tag = textBox拼音码;
        }

        public FormSupplierInformationBase(ClassLoginInformation valLoginInformation, long valID)
            : base(valLoginInformation,89, valID)
        {
            InitializeComponent();
            textBox名称.Tag = textBox拼音码;
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
            textBox名称.Focus();

            base.OnExecuteSucceed(e);
        }

        #endregion

        #region 数据绑定

        protected sealed override void BindingData()
        {
            ClassSupplierProperties supplierProperties = Data as ClassSupplierProperties;
            if (supplierProperties != null)
            {
                textBox名称.DataBindings.Add("Text", supplierProperties, "名称");
                textBox拼音码.DataBindings.Add("Text", supplierProperties, "拼音码");
                textBox负责人.DataBindings.Add("Text", supplierProperties, "负责人");
                textBox地址.DataBindings.Add("Text", supplierProperties, "地址");
                textBox邮编.DataBindings.Add("Text", supplierProperties, "邮编");
                textBox联系电话.DataBindings.Add("Text", supplierProperties, "联系电话");
                textBox传真.DataBindings.Add("Text", supplierProperties, "传真");
                textBoxWithButton备注.DataBindings.Add("Text", supplierProperties, "备注");
            }
        }

        #endregion
    }
}
