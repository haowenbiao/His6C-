using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using ClassLibraryDataTableFromQueryString;
using ClassLibraryGetSQLString;

namespace VerifyDifferSelector
{
    public partial class VerifyDifferSelector : ComboBox
    {
        public VerifyDifferSelector()
        {
            InitializeComponent();
            DropDownStyle = ComboBoxStyle.DropDownList;
            AutoLoadDataAfterSetConnectionSqlString = true;
        }

        [Description("是否在设置连接字符串后，自动加载数据。"), Browsable(true), DefaultValue(true)]
        public bool AutoLoadDataAfterSetConnectionSqlString { get; set; }


        private string _ConnectionSqlString;

        [Description("与数据库服务器的连接字符串。"), Browsable(true), DefaultValue("")]
        public string ConnectionSqlString
        {
            get
            {
                return _ConnectionSqlString;
            }
            set
            {
                _ConnectionSqlString = value;
                if (!DesignMode)
                {
                    if (AutoLoadDataAfterSetConnectionSqlString)
                    {
                        LoadData(_ConnectionSqlString);
                    }
                }
            }
        }

        /// <summary>
        /// 加载数据。
        /// </summary>
        public void LoadData(string valConnectionString)
        {
            if (string.IsNullOrEmpty(ConnectionSqlString))
            {
                return;
            }
            try
            {
                //(172)SELECT ID,审核意见名称 FROM dbo.P_审核意见表 ORDER BY ID
                string tmpSQLString1 = ClassGetSQLString.GetSQLString(valConnectionString, 172);
                if (string.IsNullOrEmpty(tmpSQLString1))
                {
                    return;
                }
                string tmpSqlString = tmpSQLString1;
                DataTableFromQueryString tmpDepartmentInformations = new DataTableFromQueryString(valConnectionString,
                                                                                                  tmpSqlString);
                DataTable tmpDataTable = tmpDepartmentInformations.value;
                tmpDataTable.DefaultView.Sort = "ID";

                DataSource = tmpDataTable;
                ValueMember = "ID";
                DisplayMember = "审核意见名称";
            }
            catch
            {
                return;
            }
        }
    }
}
