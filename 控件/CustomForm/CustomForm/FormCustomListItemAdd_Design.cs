using System;
using ClassLibraryLoginInformation;

namespace CustomForm
{
    public partial class FormCustomListItemAdd_Design : FormCustomAuthoritied
    {
        #region 构造器

        protected FormCustomListItemAdd_Design()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 任何操作员都可登录
        /// </summary>
        /// <param name="valLoginInformation"></param>
        protected FormCustomListItemAdd_Design(ClassLoginInformation valLoginInformation)
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
