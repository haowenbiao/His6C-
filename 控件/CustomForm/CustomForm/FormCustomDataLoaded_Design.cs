using System;
using ClassLibraryLoginInformation;

namespace CustomForm
{
    public partial class FormCustomDataLoaded_Design : FormCustomAuthoritied
    {
        #region 构造器

        protected FormCustomDataLoaded_Design()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 有权限的操作员和超级用户可以登录，如果AuthorityID小于等于0，则任何操作员都可登录。
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valAuthorityID"></param>
        public FormCustomDataLoaded_Design(ClassLoginInformation valLoginInformation, long valAuthorityID)
            : base(valLoginInformation,valAuthorityID)
        {
            InitializeComponent();
        }

        /// <summary>
        /// 任何操作员都可登录
        /// </summary>
        /// <param name="valLoginInformation"></param>
        public FormCustomDataLoaded_Design(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation)
        {
            InitializeComponent();
        }

        #endregion
        
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
