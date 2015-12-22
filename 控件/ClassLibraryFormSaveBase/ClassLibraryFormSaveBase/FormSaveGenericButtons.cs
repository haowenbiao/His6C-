using System;
using System.ComponentModel;
using ClassLibraryLoginInformation;

namespace ClassLibraryFormSaveBase
{
    public partial class FormSaveGenericButtons<TAbstractData>
    {
        #region 构造器
        /// <summary>
        /// 默认构造器
        /// </summary>
        public FormSaveGenericButtons()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 增加，有权限的操作员和超级用户可以登录，如果AuthorityID小于等于0，则任何操作员都不可登录。
        /// </summary>
        /// <param name="valLoginInformation">登录信息</param>
        /// <param name="valAuthorityId">需要的权限ID</param>
        public FormSaveGenericButtons(ClassLoginInformation valLoginInformation, long valAuthorityId)
            : base(valLoginInformation, valAuthorityId)
        {
            InitializeComponent();
            buttonAdvanced.Visible = true;
            buttonAdvanced.Enabled = true;
            buttonOK.Click += buttonOK_Add_Click;
        }

        /// <summary>
        /// 修改，有权限的操作员和超级用户可以登录，如果AuthorityID小于等于0，则任何操作员都不可登录。
        /// </summary>
        /// <param name="valLoginInformation">登录信息</param>
        /// <param name="valAuthorityId">需要的权限ID</param>
        /// <param name="valID"></param>
        public FormSaveGenericButtons(ClassLoginInformation valLoginInformation, long valAuthorityId, long valID)
            : base(valLoginInformation, valAuthorityId, valID)
        {
            InitializeComponent();
            buttonOK.Click += buttonOK_Edit_Click;
        }

        #endregion

        #region 自定义属性

        [Description("是否显示“高级”按钮"), DefaultValue(true), Category("杂项"), Browsable(true)]
        public bool ShowAdvancedButton
        {
            get
            {
                return buttonAdvanced.Visible;
            }
            set
            {
                buttonAdvanced.Visible = value;
            }
        }

        [Description("获取或设置“高级”按钮是否有效"), DefaultValue(true), Category("杂项"), Browsable(true)]
        public bool AdvancedButtonEnabled
        {
            get
            {
                return buttonAdvanced.Enabled;
            }
            set
            {
                buttonAdvanced.Enabled = value;
            }
        }

        #endregion

        protected override void SetButtonOKEnableAttribute(bool valEnabled)
        {
            buttonOK.Enabled = valEnabled;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdvanced_Click(object sender, EventArgs e)
        {
            SizeState = SizeState == EnumSizeState.MaxSize ? EnumSizeState.MinSize : EnumSizeState.MaxSize;
        }
    }
}
