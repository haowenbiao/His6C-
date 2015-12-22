using System;
using System.Windows.Forms;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;
using ClassLibraryWorkerInformations;
using ClassLibraryPublicEnum;
using CustomForm;

namespace WorkerInformations.DataOperate
{
    public partial class FormWorkerInformationBase : FormCustomSaved<ClassWorkerProperties>
    {
        #region 构造器

        protected FormWorkerInformationBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 增加职工信息
        /// </summary>
        /// <param name="valLoginInformation"></param>
        protected FormWorkerInformationBase(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation, 76)
        {
            InitializeComponent();

            comboBox性别.DataSource = Enum.GetNames(typeof(enum性别));
            //comboBox是否操作员.DataSource = Enum.GetNames(typeof(enum是否));

            textBox姓名.Tag = textBox拼音码;
        }

        /// <summary>
        /// 修改职工信息
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valID"></param>
        protected FormWorkerInformationBase(ClassLoginInformation valLoginInformation, long valID)
            : base(valLoginInformation, 77, valID)
        {
            InitializeComponent();

            comboBox性别.DataSource = Enum.GetNames(typeof(enum性别));
            //comboBox是否操作员.DataSource = Enum.GetNames(typeof(enum是否));

            textBox姓名.Tag = textBox拼音码;
        }

        #endregion

        #region 数据绑定

        //绑定数据
        protected sealed override void BindingData()
        {
            ClassWorkerProperties WorkerProperties = Data as ClassWorkerProperties;
            if (WorkerProperties != null)
            {
                textBox姓名.DataBindings.Add("Text", WorkerProperties, "姓名");
                textBox拼音码.DataBindings.Add("Text", WorkerProperties, "拼音码");
                comboBox性别.DataBindings.Add("SelectedIndex", WorkerProperties, "性别");
                dateTimePicker出生日期.DataBindings.Add("Value", WorkerProperties, "出生日期");
                //comboBox是否操作员.DataBindings.Add("SelectedIndex", WorkerProperties, "是否操作员");

                textBox身份证号码.DataBindings.Add("Text", WorkerProperties, "身份证号码");
                textBox家庭住址.DataBindings.Add("Text", WorkerProperties, "家庭住址");
                textBox联系电话1.DataBindings.Add("Text", WorkerProperties, "联系电话1");
                textBox联系电话2.DataBindings.Add("Text", WorkerProperties, "联系电话2");
                textBoxWithButton备注.DataBindings.Add("Text", WorkerProperties, "备注");
            }
        }

        #endregion

        #region 验证

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

            base.OnSizeStateChanged(e);
        }

        protected override void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            MessageBox.Show(@"保存完成！", @"信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox姓名.Focus();

            base.OnExecuteSucceed(e);
        }

        #endregion

    }
}