using System;
using System.Data;
using System.Windows.Forms;
using ClassLibraryDataListLoad;
//using ClassLibraryEventArgs;
using ClassLibraryEventArgs.EventArgsOfDataList;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;
using CustomForm;
using ClassLibraryDataListColumnShowInformationConfig;
//using FarPoint.Win.Spread;

namespace ClassLibraryAbstractFormDataListBase
{
    /// <summary>
    /// 必须重载的属性：LoadSqlStringId，FarPointSpreadPageSetKey，FpSpreadDoubleClick
    /// </summary>
    public abstract partial class FormAbstractDataListUseFpSpreadBase : FormCustomAuthoritied//FormDataListBase
    {

        protected FormAbstractDataListUseFpSpreadBase()
        {
            InitializeComponent();
        }

        #region 构造器

        /// <summary>
        /// 用于显示数据集的窗体，任何操作员都可登录
        /// </summary>
        /// <param name="valLoginInformation">用户登录信息</param>
        protected FormAbstractDataListUseFpSpreadBase(ClassLoginInformation valLoginInformation)
            :this(valLoginInformation,true)
        {
        }

        /// <summary>
        /// 用于显示数据集的窗体，任何操作员都可登录
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valLoadDataImmdiately">是否立即加载数据</param>
        protected FormAbstractDataListUseFpSpreadBase(ClassLoginInformation valLoginInformation, bool valLoadDataImmdiately)
            : base(valLoginInformation)
        {
            InitializeComponent();
            if (valLoadDataImmdiately) LoadDataThread();
        }

        /// <summary>
        /// 用于显示数据集的窗体，有权限的操作员和超级用户可以登录，如果AuthorityID小于等于0，则任何操作员都不可登录。
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="?"></param>
        /// <param name="valAuthorityID"></param>
        protected FormAbstractDataListUseFpSpreadBase(ClassLoginInformation valLoginInformation, long valAuthorityID)
            : this(valLoginInformation, valAuthorityID, true)
        {

        }

        /// <summary>
        /// 用于显示数据集的窗体，有权限的操作员和超级用户可以登录，如果AuthorityID小于等于0，则任何操作员都不可登录。
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valAuthorityID"></param>
        /// <param name="valLoadDataImmdiately">是否立即加载数据</param>
        protected FormAbstractDataListUseFpSpreadBase(ClassLoginInformation valLoginInformation, long valAuthorityID, bool valLoadDataImmdiately)
            : base(valLoginInformation, valAuthorityID)
        {
            InitializeComponent();
            if (valLoadDataImmdiately) LoadDataThread();
        }
        #endregion

        protected void LoadDataThread()
        {
            string tmpLoadSqlString = LoadSqlString;
            ClassDataListLoad l = new ClassDataListLoad(LoginInformation, tmpLoadSqlString);
            l.BeforeDataListLoad += DataListLoad_BeforeDataListLoad;
            l.AfterDataListLoadFail += DataListLoad_AfterDataListLoadFail;
            l.AfterDataListLoadSucceed += DataListLoad_AfterDataListLoadSucceed;
            l.Begin();
        }

        #region 事件

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
            //fpSpread1.DataSource = null;
            //dataGridView1.DataSource = null;
            SetControlEnabled(toolStripContainer1, false);
            
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
            SetControlEnabled(toolStripContainer1,true);
            
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
                    //tmpListControl.DataSource = null;
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

                    //去掉不显示的列
                    ClassDataListColumnShowInformationConfig DataListColumnShowInformationConfig = new ClassDataListColumnShowInformationConfig(KeyInTheConfigFile);
                    foreach (int i in DataListColumnShowInformationConfig.ListNotShowColumn)
                    {
                        tmpListControl.Columns[i].Visible = false;
                    }
                }
        }

        #endregion
        
        /// <summary>
        /// 当 增加、修改、删除 操作完成后，执行此操作。
        /// </summary>
        /// <param name="e"></param>
        protected override void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            LoadDataThread();

            base.OnExecuteSucceed(e);
        }

        #region ListControl虚事件

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ListControlDoubleClick();
        }

        /// <summary>
        /// 当FpSpread被双击时执行此方法。
        /// </summary>
        protected virtual void ListControlDoubleClick()
        {
            
        }

        #endregion
        
        #region 抽象属性

        /// <summary>
        /// 当加载数据集时，用于从数据库中获取SQLString连接字符串的ID,继承者必须重载此属性
        /// </summary>
        protected abstract string LoadSqlString { get; }

        protected abstract long IDOfSqlStringThatGetColumnsOfDataTable { get; }

        ///// <summary>
        ///// 必须重载此属性，用于FarPointSpread页面设置，从FarPointSpreadPageSet.xml中提取或保存数据的关键字。
        ///// </summary>
        //protected abstract string FarPointSpreadPageSetKey { get; }

        /// <summary>
        /// 保存在配置文件中的关键字（列显示信息或FarPointSpread页面设置信息）。
        /// </summary>
        protected abstract string KeyInTheConfigFile { get; }

        #endregion

        #region 公共按钮

        private void CommandExport()
        {
            MessageBox.Show("未开发！");
            //SaveFileDialog s = new SaveFileDialog { DefaultExt = "xls", Filter = "Excel files(*.xls)|*.xls" };
            //if (s.ShowDialog(this) == DialogResult.OK)
            //{
            //    fpSpread1.SaveExcel(s.FileName, FarPoint.Excel.ExcelSaveFlags.SaveCustomColumnHeaders);
            //}
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadDataThread();
        }

        private void toolStripButtonOutput_Click(object sender, EventArgs e)
        {
            CommandExport();
        }

        private void toolStripButtonListItemSet_Click(object sender, EventArgs e)
        {
            FormDataListColumnsShowInformation formDataListColumnsShowInformation =
                new FormDataListColumnsShowInformation(LoginInformation, IDOfSqlStringThatGetColumnsOfDataTable,
                                                       KeyInTheConfigFile);
            formDataListColumnsShowInformation.ExecuteSucceed += FormDataListColumnsShowInformation_SaveSucceed;
            formDataListColumnsShowInformation.ShowDialog(this);
        }

        private void FormDataListColumnsShowInformation_SaveSucceed(object sender, EventArgsOfExecuteSucceed e)
        {
            DataGridView tmpListControl = dataGridView1;
            object tmpDataTable = tmpListControl.DataSource;
            tmpListControl.DataSource = null;
            tmpListControl.DataSource = tmpDataTable;
            tmpListControl.Columns[0].Visible = false;
            //去掉不显示的列
            ClassDataListColumnShowInformationConfig DataListColumnShowInformationConfig = new ClassDataListColumnShowInformationConfig(KeyInTheConfigFile);
            foreach (int i in DataListColumnShowInformationConfig.ListNotShowColumn)
            {
                tmpListControl.Columns[i].Visible = false;
            }
        }
        
        #region 打印相关

        private void 打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("未开发！");

            //PrintInfo printSet =
            //    new ClassFarPointSpreadPageSet("FarPointSpreadPageSet.xml", FarPointSpreadPageSetKey);
            //fpSpread1.ActiveSheet.PrintInfo = printSet;
            //fpSpread1.PrintSheet(0);
        }

        private void 打印预览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("未开发！");

            //PrintInfo printSet =
            //    new ClassFarPointSpreadPageSet("FarPointSpreadPageSet.xml", FarPointSpreadPageSetKey) { Preview = true };
            //fpSpread1.ActiveSheet.PrintInfo = printSet;
            //fpSpread1.PrintSheet(0);
        }

        private void 打印设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("未开发！");

            //FormFarPointSpreadPageSet tmpFarPointSpreadPageSet = new FormFarPointSpreadPageSet(FarPointSpreadPageSetKey);
            //tmpFarPointSpreadPageSet.ShowDialog(this);
        }

        #endregion

        #endregion

        #region 公共方法

        protected void AddToolStripToTopToolStripPanelOftoolStripContainer(ToolStrip valToolStrip)
        {
            toolStripContainer1.TopToolStripPanel.Controls.Add(valToolStrip);
            //valToolStrip.Location = new System.Drawing.Point(3, 50);
            //toolStripContainer1.TopToolStripPanel.Controls.SetChildIndex(valToolStrip, 0);
        }
        
        protected void AddItemOfToolStripToToolStripSpecial(ToolStrip valToolStrip)
        {
            int m = valToolStrip.Items.Count;
            for (int n = 1; n <= m; n++)
            {
                toolStripSpecial.Items.Add(valToolStrip.Items[0]);
            }
        }

        protected void AddItemOfcontextMenuStripTocontextMenuStripOnListControl(ContextMenuStrip valContextMenuStrip)
        {
            int m = valContextMenuStrip.Items.Count;
            for (int n = 1; n <= m; n++)
            {
                contextMenuStripOnListControl.Items.Add(valContextMenuStrip.Items[0]);
            }
        }
        
        /// <summary>
        /// 获得列表中当前数据行ID
        /// </summary>
        /// <returns></returns>
        protected long GetCurrentID()
        {
            try
            {
                if (Bmb.Position < 0) return 0L;
                DataRowView drv = Bmb.Current as DataRowView;
                if (drv != null)
                {
                    long tmpID = (long)drv["ID"];
                    return tmpID;
                }
                return 0L;
            }
            catch
            {
                return 0L;
            }
        }

        #endregion

    }
}
