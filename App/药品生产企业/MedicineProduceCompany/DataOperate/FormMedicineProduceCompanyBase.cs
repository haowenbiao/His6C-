using System;
using System.ComponentModel;
using System.Windows.Forms;
using ClassLibraryEventArgs;
using ClassLibraryFormSaveBase;
using ClassLibraryLoginInformation;
using ClassLibraryMedicineProduceCompany;

namespace MedicineProduceCompany.DataOperate
{
    public partial class FormMedicineProduceCompanyBase : FormSave
    {
        public FormMedicineProduceCompanyBase()
        {
            InitializeComponent();
        }

        public FormMedicineProduceCompanyBase(ClassLoginInformation valLoginInformation, long valAuthorityID)
            : base(valLoginInformation, valAuthorityID)
        {
            InitializeComponent();
            textBox企业名称.Tag = textBox拼音码;
        }
        
        #region 数据绑定

        //绑定数据
        protected sealed override void BindingData()
        {
            ClassCompanyProperties CompanyProperties = Data as ClassCompanyProperties;
            if (CompanyProperties != null)
            {
                textBox企业名称.DataBindings.Add("Text", CompanyProperties, "名称");
                textBox拼音码.DataBindings.Add("Text", CompanyProperties, "拼音码");

                textBox地址.DataBindings.Add("Text", CompanyProperties, "地址");
                textBox邮政编码.DataBindings.Add("Text", CompanyProperties, "邮政编码");
                textBox电话号码.DataBindings.Add("Text", CompanyProperties, "电话号码");
                textBox传真号码.DataBindings.Add("Text", CompanyProperties, "传真号码");
                textBox网址.DataBindings.Add("Text", CompanyProperties, "网址");
                textBox电子邮件.DataBindings.Add("Text", CompanyProperties, "电子邮件");
                textBoxWithButton备注.DataBindings.Add("Text", CompanyProperties, "备注");
            }
        }
        
        #endregion

        #region 按钮动作

        protected override void SetButtonOKEnableAttribute(bool valEnabled)
        {
            buttonOK.Enabled = valEnabled;
        }

        protected virtual void buttonOK_Click(object sender, EventArgs e)
        {

        }
        
        private void buttonAdvanced_Click(object sender, EventArgs e)
        {
            SizeState = SizeState == EnumSizeState.MaxSize ? EnumSizeState.MinSize : EnumSizeState.MaxSize;
        }
        
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //简单覆写
        protected sealed override void control_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.control_KeyPress(sender,e);
        }
        
        #endregion

        #region 继承的事件

        protected override void OnSizeChanged(EventArgs e)
        {
            groupBox2.Visible = SizeState == EnumSizeState.MaxSize;
            
            base.OnSizeChanged(e);
        }

        protected override void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            MessageBox.Show("保存完成！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox企业名称.Focus();

            base.OnExecuteSucceed(e);
        }

        #endregion

        #region 数据验证

        //简单覆写
        protected sealed override void textBox名称_Validated(object sender, EventArgs e)
        {
            base.textBox名称_Validated(sender, e);
        }
        
        //简单覆写
        protected sealed override void NoneNullabletextBox_Validating(object sender, CancelEventArgs e)
        {
            base.NoneNullabletextBox_Validating(sender, e);
        }
        
        #endregion
    }
}