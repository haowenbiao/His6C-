using System.Threading;
using System.Windows.Forms;
using ClassLibraryDataTableFromQueryString;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;
using CustomForm;

namespace ClassLibraryAbstractFormDataListBase
{
    public abstract partial class FormDataListBase : FormCustomBase
    {
        private BindingManagerBase _bmb;
        private Thread _t;

        protected FormDataListBase()
        {
            InitializeComponent();
        }

        protected FormDataListBase(ClassLoginInformation valLoginInformation)
            :base(valLoginInformation)
        {
            if (!CanShow) return;
            InitializeComponent();
            LoadThread();

        }

        #region 加载线程

        protected BindingManagerBase Bmb
        {
            get{ return _bmb;}
            set{ _bmb = value;}
        }

        protected Thread T
        {
            get { return _t; }
            set { _t = value; }
        }

        protected void LoadThread()
        {
            if (_t != null)
            {
                _t.Abort();
            }
            _t = new Thread(LoadData) { IsBackground = true };
            _t.Start();
        }

        private void LoadData()
        {
            try
            {
                SetControlEnableAttributeInLoadThread(false);
                string tmpHelpText = HelpText;
                setHelpText("正在加载数据列表...");

                //Select ID ,名称 as 部门名称,部门类型,负责人 From P_部门信息表_View
                //string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 10);
                string tmpSqlString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, LoadSqlStringId);
                if (string.IsNullOrEmpty(tmpSqlString1))
                {
                    setHelpText("加载记录数据失败！");
                }
                else
                {
                    string tmpSqlString = tmpSqlString1;
                    DataTableFromQueryString tmpDepartmentInformations = new DataTableFromQueryString(LoginInformation.ConnectionString,
                                                                                                      tmpSqlString);
                    if (tmpDepartmentInformations.value == null)
                    {
                        setHelpText("加载记录数据失败！");
                    }
                    else
                    {
                        BindingToListControl( tmpDepartmentInformations.value);
                    }
                }

                setHelpText(tmpHelpText);
                SetControlEnableAttributeInLoadThread(true);
            }
            catch
            {
                setHelpText("加载记录数据失败！");
            }
        }

        #endregion

        #region 必须重载

        /// <summary>
        /// 当加载数据集时，用于从数据库中获取SQLString连接字符串的ID,继承者必须重载此属性
        /// </summary>
        protected abstract long LoadSqlStringId { get; }

        /// <summary>
        /// 必须重载此方法,在加载线程中，在加载的开始和结束后，设置控件的Enable 属性
        /// </summary>
        /// <param name="valBool"></param>
        protected abstract void SetControlEnableAttributeInLoadThread(object valBool);

        /// <summary>
        /// //必须重载此方法,把数据绑定至指定控件
        /// </summary>
        /// <param name="valDatasource"></param>
        protected abstract void BindingToListControl(object valDatasource);

        #endregion
    }
}
