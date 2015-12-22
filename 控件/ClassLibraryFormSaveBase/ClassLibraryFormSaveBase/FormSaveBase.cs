using System.Data;
using System.Windows.Forms;
using ClassLibraryDataTableFromQueryString;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;
using CustomForm;

namespace ClassLibraryFormSaveBase
{
    public partial class FormSaveBase : FormCustomAuthoritied
    {

        #region 构造器

        /// <summary>
        /// 默认构造器
        /// </summary>
        public FormSaveBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 有权限的操作员和超级用户可以登录，如果AuthorityID小于等于0，则任何操作员都不可登录。
        /// </summary>
        /// <param name="valLoginInformation">登录信息</param>
        /// <param name="valAuthorityId">需要的权限ID</param>
        public FormSaveBase(ClassLoginInformation valLoginInformation, long valAuthorityId)
            : base(valLoginInformation, valAuthorityId)
        {
            InitializeComponent();
        }

        /// <summary>
        /// 任何操作员都可登录
        /// </summary>
        /// <param name="valLoginInformation">登录信息</param>
        public FormSaveBase(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation)
        {
            InitializeComponent();
        }

        #endregion

        #region 公共方法

        /// <summary>
        /// 绑定数据至ComboBox控件
        /// </summary>
        /// <param name="sender">要绑定的ComboBox控件</param>
        /// <param name="sqlStringId">绑定数据源获取字符串</param>
        /// <param name="comboBoxDataSourceValueMember">DataSource.ValueMember</param>
        /// <param name="comboBoxDataSourceDisplayMember">DataSource.DisplayMember</param>
        /// <returns></returns>
        protected bool BindComboBox(ComboBox sender, long sqlStringId, string comboBoxDataSourceValueMember, string comboBoxDataSourceDisplayMember)
        {
            string tmpSqlString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 9);
            if (!string.IsNullOrEmpty(tmpSqlString1))
            {
                DataTableFromQueryString tmpDepartmentType = new DataTableFromQueryString(LoginInformation.ConnectionString, tmpSqlString1);
                DataTable tmpDataTable = tmpDepartmentType.value;
                if (tmpDataTable == null)
                {
                    SetHelpText(@"注意：加载数据“部门类型”失败！");
                    //buttonOK.Enabled = false;
                    return false;
                }
                //bindComboBox部门类型(tmpDataTable);
                sender.DataSource = tmpDataTable;
                sender.DisplayMember = comboBoxDataSourceDisplayMember;
                sender.ValueMember = comboBoxDataSourceValueMember;
            }
            return true;
        }

        #endregion


    }
}
