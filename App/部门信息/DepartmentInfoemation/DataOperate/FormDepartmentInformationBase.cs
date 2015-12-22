using System;
using System.Windows.Forms;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;
using ClassLibraryDepartmentInformation;
using CustomForm;

namespace DepartmentInformation.DataOperate
{
    public partial class FormDepartmentInformationBase : FormCustomSaved<ClassDepartmentProperties>
    {
        #region 构造器

        protected FormDepartmentInformationBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="valLoginInformatio"></param>
        public FormDepartmentInformationBase(ClassLoginInformation valLoginInformatio)
            : base(valLoginInformatio, 73)
        {
            InitializeComponent();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valID"></param>
        public FormDepartmentInformationBase(ClassLoginInformation valLoginInformation,long valID)
            : base(valLoginInformation, 74, valID)
        {
            InitializeComponent();
        }

        #endregion

        protected override void OnLoad(EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }
            textBox名称.Tag = textBox拼音码;
            if (!BindComboBox(comboBox部门类型, 9, "ID", "名称"))
            {
                //SetButtonOKEnableAttribute(false);
                SetHelpText(@"注意：加载数据“部门类型”失败！");
            }
            base.OnLoad(e);
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

        protected sealed override void NoneNullabletextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            base.NoneNullabletextBox_Validating(sender, e);
        }

        #endregion

        #region 继承的事件

        protected override void OnSizeStateChanged(EventArgsOfSizeStateChanged e)
        {
            groupBox2.Visible = SizeState == EnumSizeState.MaxSize;
            Refresh();
            //MessageBox.Show("OnSizeStateChanged");
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
            ClassDepartmentProperties DepartmentProperties = Data as ClassDepartmentProperties;
            if (DepartmentProperties != null)
            {
                textBox名称.DataBindings.Add("Text", DepartmentProperties, "名称");
                textBox拼音码.DataBindings.Add("Text", DepartmentProperties, "拼音码");
                comboBox部门类型.DataBindings.Add("SelectedValue", DepartmentProperties, "P_部门类型_ID");
                textBox负责人.DataBindings.Add("Text", DepartmentProperties, "负责人");
                textBoxWithButton备注.DataBindings.Add("Text", DepartmentProperties, "备注");
            }
        }

        #endregion
    }
}