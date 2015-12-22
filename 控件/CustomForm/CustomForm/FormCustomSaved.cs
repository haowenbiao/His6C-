using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using ClassLibraryAbstractDataInformation;
using ClassLibraryDataTableFromQueryString;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;
using ClassLibraryPYM;

namespace CustomForm
{
    public abstract partial class FormCustomSaved<TAbstractData> : FormCustomDataLoaded<TAbstractData> where TAbstractData : ClassAbstractData, new()
    //public partial class FormCustomSaved : FormCustomDataLoaded_Design
    {
        #region 构造器

        protected FormCustomSaved()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 增加，有权限的操作员和超级用户可以登录，如果AuthorityID小于等于0，则任何操作员都可登录。
        /// </summary>
        /// <param name="valLoginInformation">登录信息</param>
        /// <param name="valAuthorityId">需要的权限ID</param>
        protected FormCustomSaved(ClassLoginInformation valLoginInformation, long valAuthorityId)
            : base(valLoginInformation, valAuthorityId)
        {
            InitializeComponent();
            buttonOK.Click += buttonOK_Add_Click;
        }

        /// <summary>
        /// 修改，有权限的操作员和超级用户可以登录，如果AuthorityID小于等于0，则任何操作员都可登录。
        /// </summary>
        /// <param name="valLoginInformation">登录信息</param>
        /// <param name="valAuthorityId">需要的权限ID</param>
        /// <param name="valID"></param>
        protected FormCustomSaved(ClassLoginInformation valLoginInformation, long valAuthorityId, long valID)
            : base(valLoginInformation, valAuthorityId, valID)
        {
            InitializeComponent();
            buttonOK.Click += buttonOK_Edit_Click;
        }

        #endregion

        #region 按钮动作

        private void Add()
        {
            ClassDataAdder dataAdder = new ClassDataAdder
            {
                AuthorityID = AuthorityID,
                LoginInformation = LoginInformation,
                Data = Data
            };
            dataAdder.ExecuteError += this_ExecuteError;
            dataAdder.ExecuteSucceed += this_ExecuteSucceed;
            dataAdder.execute();
            dataAdder.ExecuteSucceed -= this_ExecuteSucceed;
            dataAdder.ExecuteError -= this_ExecuteError;
        }

        private void Edit()
        {
            ClassDataEditer dataEditer = new ClassDataEditer
            {
                AuthorityID = AuthorityID,
                LoginInformation = LoginInformation,
                Data = Data
            };
            dataEditer.ExecuteError += this_ExecuteError;
            dataEditer.ExecuteSucceed += this_ExecuteSucceed;
            dataEditer.execute();
            dataEditer.ExecuteSucceed -= this_ExecuteSucceed;
            dataEditer.ExecuteError -= this_ExecuteError;
        }

        protected virtual void buttonOK_Add_Click(object sender, EventArgs e)
        {
            Add();
        }

        protected virtual void buttonOK_Edit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        #endregion

        #region 数据验证

        /// <summary>
        /// 不用覆写，简单调用基方法即可，回车移动焦点到下一控件。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
        
        // 不用覆写，简单调用基方法即可，验证后，自动生成拼音码
        protected virtual void textBox名称_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t == null)
            {
                return;
            }
            TextBox textBox拼音码 = t.Tag as TextBox;
            if (textBox拼音码 == null)
            {
                return;
            }
            if (string.IsNullOrEmpty(textBox拼音码.Text))
                textBox拼音码.Text = PYM.transpy(t.Text);
        }

        // 不用覆写，简单调用基方法即可，验证非空输入框。
        protected virtual void NoneNullabletextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t != null) t.Text = t.Text.Replace(" ", "");

            if (t != null)
            {
                if (string.IsNullOrEmpty(t.Text))
                {
                    SetTextBoxError(sender, "此项不能为空！");
                }
                else
                {
                    SetTextBoxError(sender, "");
                }
            }
        }

        // 当输入框验证出错时，设置errorProvider。
        protected void SetTextBoxError(object sender, string valErrorMessage)
        {
            Control tmpControl = sender as Control;
            if (tmpControl != null)
            {
                errorProvider.SetError(tmpControl, valErrorMessage);
            }
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
                    SetHelpText(@"注意：加载数据失败！\n" + comboBoxDataSourceDisplayMember);
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
