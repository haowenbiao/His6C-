using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using ClassLibraryDataListLoad;
using ClassLibraryEventArgs.EventArgsOfDataList;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;
using CustomForm;

namespace ClassLibraryAbstractFormDataListBase
{
    public abstract partial class FormAbstractDataListUseDataGridViewBase : FormCustomAuthoritied //FormDataListBase
    {
        #region 构造器

        protected FormAbstractDataListUseDataGridViewBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 用于显示数据集的窗体，任何操作员都可登录
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valCanInvokeDataListItemSelectedEvent"></param>
        protected FormAbstractDataListUseDataGridViewBase(ClassLoginInformation valLoginInformation, bool valCanInvokeDataListItemSelectedEvent)
            : base(valLoginInformation)
        {
            InitializeComponent();
            CanInvokeDataListItemSelectedEvent = valCanInvokeDataListItemSelectedEvent;
            LoadDataThread();
        }

        /// <summary>
        /// 用于显示数据集的窗体，任何操作员都可登录
        /// </summary>
        /// <param name="valLoginInformation"></param>
        protected FormAbstractDataListUseDataGridViewBase(ClassLoginInformation valLoginInformation):this(valLoginInformation,false)
        {

        }

        #endregion 

        /// <summary>
        /// 加载数据，多线程执行
        /// </summary>
        protected void LoadDataThread()
        {
            ClassDataListLoad l = new ClassDataListLoad(LoginInformation, LoadSqlString);
            l.BeforeDataListLoad += DataListLoad_BeforeDataListLoad;
            l.AfterDataListLoadFail += DataListLoad_AfterDataListLoadFail;
            l.AfterDataListLoadSucceed += DataListLoad_AfterDataListLoadSucceed;
            l.Begin();
        }

        /// <summary>
        /// 当 增加、修改、删除 操作完成后，执行此操作。
        /// </summary>
        /// <param name="e"></param>
        protected override void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            LoadDataThread();

            base.OnExecuteSucceed(e);
        }

        #region 事件

        #region DataListLoad事件

        protected BindingManagerBase Bmb { get; set; }

        /// <summary>
        /// 临时放置窗体的帮助文本
        /// </summary>
        private string TmpHelpText { get; set; }

        public event AfterDataListLoadFailHandler AfterDataListLoadFail;

        public event AfterDataListLoadSucceedHandler AfterDataListLoadSucceed;

        public event BeforeDataListLoadHandler BeforeDataListLoad;

        protected virtual void OnBeforeDataListLoad(EventArgsOfBeforeDataListLoad e)
        {
            TmpHelpText = HelpText;
            SetHelpText("正在加载数据列表...");
            //dataGridView1.DataSource = null;加入这行代码会显示错误-线程间操作无效：从不是创建控件的线程访问它
            SetControlEnabled(panel2, false);

            BeforeDataListLoadHandler ListLoad = BeforeDataListLoad;
            if (ListLoad != null) ListLoad(this, e);
       }

        protected virtual void OnAfterDataListLoadFail(EventArgsOfAfterDataListLoadFail e)
        {
            SetHelpText("加载记录数据失败！" + e.SystemErrorMessage);

            AfterDataListLoadFailHandler Fail = AfterDataListLoadFail;
            if (Fail != null) Fail(this, e);
        }

        protected virtual void OnAfterDataListLoadSucceed(EventArgsOfAfterDataListLoadSucceed e)
        {
            SetHelpText(TmpHelpText);
            BindingToListControl(e.DataSource);
            SetControlEnabled(panel2 , true);
            
            AfterDataListLoadSucceedHandler Succeed = AfterDataListLoadSucceed;
            if (Succeed != null) Succeed(this, e);
        }

        protected void DataListLoad_BeforeDataListLoad(object sender, EventArgsOfBeforeDataListLoad e)
        {
            OnBeforeDataListLoad(e);
        }

        protected void DataListLoad_AfterDataListLoadFail(object sender, EventArgsOfAfterDataListLoadFail e)
        {
            OnAfterDataListLoadFail(e);
        }

        protected void DataListLoad_AfterDataListLoadSucceed(object sender, EventArgsOfAfterDataListLoadSucceed e)
        {
            OnAfterDataListLoadSucceed(e);
        }

        private delegate void BindingToListControlHandle(object valDatasource);

        protected virtual void BindingToListControl(object valDatasource)
        {
            DataGridView tmpListControl = dataGridView1;
            if (tmpListControl != null)
                if (tmpListControl.InvokeRequired)
                {
                    BindingToListControlHandle c = BindingToListControl;
                    Invoke(c, new[] { valDatasource });
                }
                else
                {
                    tmpListControl.DataSource = valDatasource;
                    //tmpListControl.ActiveSheet.Columns[0].Visible = false;
                    tmpListControl.Columns[0].Visible = false;
                    int tmpN = 0;
                    if (Bmb != null)
                    {
                        tmpN = Bmb.Position;
                    }
                    Bmb = BindingContext[valDatasource];
                    Bmb.Position = tmpN;
                }
        }

        #endregion

        #region DataListItemSelected事件

        public event DataListItemSelectedHandler DataListItemSelected;

        protected virtual void OnDataListItemSelected(EventArgsOfDataListItemSelected e)
        {
            DataListItemSelectedHandler Selected = DataListItemSelected;
            if (Selected != null) Selected(this, e);
        }

        private void MethodDataListItemSelected()
        {
            if (Bmb.Position < 0) return;
            DataRowView drv = Bmb.Current as DataRowView;
            if (drv != null)
            {
                long tmpID = (long)drv["ID"];
                OnDataListItemSelected(new EventArgsOfDataListItemSelected(tmpID));
                Close();
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            MethodDataListItemSelected();
        }

        #endregion

        #region ListControlDoubleClick虚事件

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CanInvokeDataListItemSelectedEvent)
            {
                MethodDataListItemSelected();
            }
            else
            {
                ListControlDoubleClick();
            }
        }

        /// <summary>
        /// 当ListControl被双击时执行此方法。
        /// </summary>
        protected virtual void ListControlDoubleClick()
        {
            
        }

        #endregion

        #endregion

        #region 自定义属性

        private bool _CanInvokeDataListItemSelectedEvent;

        [Description("是否可以引发DataListItemSelected事件。"), DefaultValue(false), Category("杂项"), Browsable(true)]
        public bool CanInvokeDataListItemSelectedEvent
        {
            get
            {
                return _CanInvokeDataListItemSelectedEvent;
            }
            set
            {
                buttonSelect.Enabled = value;
                buttonSelect.Visible = value;
                _CanInvokeDataListItemSelectedEvent = value;
            }
        }

        #region 抽象属性

        /// <summary>
        /// 当加载数据集时，用于从数据库中获取SQLString连接字符串的ID,继承者必须重载此属性
        /// </summary>
        protected abstract string LoadSqlString { get; }

        #endregion

        #endregion

        #region 公共按钮

        #region AddEditRemove按钮虚函数

        protected virtual void buttonAdd_Click(object sender, EventArgs e)
        {
            
        }

        protected virtual void buttonEdit_Click(object sender, EventArgs e)
        {
            
        }

        protected virtual void buttonRemove_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadDataThread();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
        
        #region 公共方法

        protected void AddItemOfcontextMenuStripTocontextMenuStripOnListControl(ContextMenuStrip valContextMenuStrip)
        {
            int m = valContextMenuStrip.Items.Count;
            for (int n = 1; n <= m; n++)
            {
                contextMenuStripOnListControl.Items.Add(valContextMenuStrip.Items[0]);
            }
        }

        #endregion

    }
}
