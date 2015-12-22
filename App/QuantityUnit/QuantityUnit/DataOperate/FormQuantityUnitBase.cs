using System.Windows.Forms;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;
using ClassLibraryQuantityUnit;
using CustomForm;

namespace QuantityUnit.DataOperate
{
    public partial class FormQuantityUnitBase : FormCustomSaved<ClassQuantityUnitProperties>
    //public partial class FormQuantityUnitBase : FormCustomDataLoaded_Design
    {
        #region 构造器

        public FormQuantityUnitBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="valLoginInformation"></param>
        public FormQuantityUnitBase(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation, 50)
        {
            InitializeComponent();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valID"></param>
        public FormQuantityUnitBase(ClassLoginInformation valLoginInformation, long valID)
            : base(valLoginInformation, 51, valID)
        {
            InitializeComponent();
        }


        #endregion

        #region 数据绑定

        //绑定数据
        protected sealed override void BindingData()
        {
            ClassQuantityUnitProperties QuantityUnitProperties = Data as ClassQuantityUnitProperties;
            if (QuantityUnitProperties != null)
            {
                textBox名称.DataBindings.Add("Text", QuantityUnitProperties, "名称");
            }
        }

        #endregion

        #region 按钮动作

        protected override void control_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.control_KeyPress(sender, e);
        }
        
        #endregion

        #region 继承的事件

        protected override void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            MessageBox.Show(@"保存完成！", @"信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox名称.Focus();

            base.OnExecuteSucceed(e);
        }

        #endregion

    }
}
