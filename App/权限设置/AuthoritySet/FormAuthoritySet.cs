using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClassLibraryAuthoritySet;
using ClassLibraryDataTableFromQueryString;
using ClassLibraryEventArgs;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;

namespace AuthoritySet
{
    public partial class FormAuthoritySet : CustomForm.FormCustomBase
    {
        private readonly long WorkerID;

        public FormAuthoritySet(ClassLoginInformation valLoginInformation, long valWorkerID)
            : base(valLoginInformation)
        {
            if (valLoginInformation.OperaterID != 1)
            {
                CanShow = false;
                OnError(new EventArgsOfError("权限验证错误：", "只有超级用户才能进行权限设置！"));
                Width = 0;
                Height = 0;
                return;
            }
            #region 检查必要性
            ClassLoginInformation tmpLoginInformation = new ClassLoginInformation(LoginInformation.ConnectionString, valWorkerID);
            if (!ClassAuthoritySetPublic.GetIsOperater(tmpLoginInformation))
            {
                CanShow = false;
                OnError(this, new EventArgsOfError("注意：该职工不是操作员，没有进行权限设置的必要！", ""));
                Width = 0;
                Height = 0;
                return;
            }
            #endregion

            InitializeComponent();
            Text = Text + "-" + ClassAuthoritySetPublic.GetWorkerName(tmpLoginInformation);
            LoginInformation = valLoginInformation;
            WorkerID = valWorkerID;
            loadDataAll权限();
            loadDataAll模块();
        }

        private void loadDataAll模块()
        {
            //SELECT ID,模块名称 FROM P_系统模块表 WHERE 是否有效 = 1
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 12);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return;
            }
            string tmpSQLString = tmpSQLString1;

            DataTableFromQueryString tmpAuthorities = new DataTableFromQueryString(LoginInformation.ConnectionString, tmpSQLString);
            if (tmpAuthorities.value == null)
            {
                return;
            }
            dataGridView模块.DataSource = tmpAuthorities.value;
            dataGridView模块.Columns[0].Visible = false;
            dataGridView模块.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BindingManagerBase bmb模块 = BindingContext[tmpAuthorities.value];
            bmb模块.CurrentChanged += 模块Current_Changed;
            模块Binding_Complete(bmb模块);
        }

        private void loadDataAll权限()
        {
            //SELECT CAST(1 AS BIT) AS 选择,ID,权限,P_系统模块_ID FROM dbo.P_权限表 WHERE 是否有效=1 AND ID IN (SELECT P_权限_ID FROM dbo.P_职工信息_权限设置_表 WHERE P_职工信息_ID = {0}) UNION SELECT CAST(0 AS BIT) AS 选择,ID,权限,P_系统模块_ID FROM dbo.P_权限表 WHERE 是否有效=1 AND ID NOT IN (SELECT P_权限_ID FROM dbo.P_职工信息_权限设置_表 WHERE P_职工信息_ID = {0}) ORDER BY ID
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 13);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return;
            }
            string tmpSQLString = string.Format(tmpSQLString1, WorkerID);

            DataTableFromQueryString tmpAuthorities = new DataTableFromQueryString(LoginInformation.ConnectionString, tmpSQLString);
            if (tmpAuthorities.value == null)
            {
                return;
            }
            //所有列只读
            foreach (DataColumn dc in tmpAuthorities.value.Columns)
            {
                dc.ReadOnly = true;
            }

            //选择列可更改
            DataColumn tmpDC = tmpAuthorities.value.Columns[0];
            tmpDC.ReadOnly = false;

            dataGridView权限.DataSource = tmpAuthorities.value;
            dataGridView权限.Columns[1].Visible = false;
            dataGridView权限.Columns[2].Visible = false;
            dataGridView权限.Columns[5].Visible = false;
            dataGridView权限.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BindingManagerBase bmb权限 = BindingContext[tmpAuthorities.value];
            bmb权限.CurrentChanged += 权限Current_Changed;
        }

        private void loadData权限From模块ID(long valID)
        {
            DataTable tmpDataTable = dataGridView权限.DataSource as DataTable;
            if (tmpDataTable == null)
            {
                return;
            }
            tmpDataTable.DefaultView.RowFilter = string.Format("P_系统模块_ID = {0}", valID);
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 模块Current_Changed(object sender, EventArgs e)
        {
            BindingManagerBase tmpBindingManagerBase = (BindingManagerBase)sender;
            DataRowView tmpDataRowView = tmpBindingManagerBase.Current as DataRowView;
            if (tmpDataRowView == null)
            {
                return;
            }
            groupBox2.Text = string.Format("权限-{0}", tmpDataRowView["模块名称"]);
            long tmpID = (long)tmpDataRowView["ID"];
            loadData权限From模块ID(tmpID);
        }

        private void 模块Binding_Complete(object sender)
        {
            模块Current_Changed(sender, null);
        }

        private void 权限Current_Changed(object sender, EventArgs e)
        {
            BindingManagerBase tmpBindingManagerBase = (BindingManagerBase)sender;
            DataRowView tmpDataRowView = tmpBindingManagerBase.Current as DataRowView;
            if (tmpDataRowView == null)
            {
                return;
            }

            bool IsSuperAuthority = (string)tmpDataRowView[4] == "*";
            dataGridView权限.Columns[0].ReadOnly = IsSuperAuthority;
            string tmpString1 = IsSuperAuthority ? "    注意：此功能为超级权限，只能超级用户使用，不能赋予其他操作员！" : "";
            string tmpString = tmpDataRowView["权限"] + tmpString1;
            toolStripStatusLabel1.Text = string.Format("权限：{0}", tmpString);
            toolStripStatusLabel1.ForeColor = IsSuperAuthority ? Color.Red : DefaultForeColor;
        }

        private void save()
        {
            dataGridView权限.EndEdit();
            DataTable tmpDataTable = dataGridView权限.DataSource as DataTable;
            if (tmpDataTable == null)
            {
                return;
            }
            string tmpAuthorityIDsString = "<IDs>";
            foreach (DataRow dr in tmpDataTable.Rows)
            {
                if ((bool)dr["选择"])
                {
                    tmpAuthorityIDsString += string.Format("<ID>{0}</ID>", dr["ID"]);
                }
            }
            tmpAuthorityIDsString += "</IDs>";
            ClassAuthoritySet tmpClassAuthoritySet = new ClassAuthoritySet(LoginInformation, WorkerID,
                                                                           tmpAuthorityIDsString);
            tmpClassAuthoritySet.ExecuteSucceed += OnSaveSucceed;
            tmpClassAuthoritySet.Error += OnError;
            tmpClassAuthoritySet.execute();
        }

        protected virtual void OnSaveSucceed(object sender, EventArgsOfExecuteSucceed e)
        {
            MessageBox.Show(@"保存成功！", @"权限设置");
            Close();
        }

        private static void OnError(object sender, EventArgsOfError e)
        {
            MessageBox.Show(e.CustomErrorMessage + Environment.NewLine + e.SystemErrorMessage, @"错误", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            save();
        }

    }
}
