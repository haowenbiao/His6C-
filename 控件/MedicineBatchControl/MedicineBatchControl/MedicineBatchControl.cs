using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using ClassLibraryAbstractDataInformation;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;
using ClassLibraryMedicineKind;
using ClassLibraryMedicineProductionBatch;
using ClassLibraryPublicEnum;
using ClassLibrarySQLExecute;

namespace MedicineBatchControl
{
    public partial class MedicineBatchControl : UserControl
    {

        public MedicineBatchControl()
        {
            InitializeComponent();

            #region 初始化属性

            ClassMedicineProductionBatchProperties tmpData=new ClassMedicineProductionBatchProperties
                                                               {
                                                                   生产日期 =
                                                                       Convert.ToDateTime(
                                                                       DateTime.Now.ToShortTimeString()),
                                                                   有效期至 =
                                                                       Convert.ToDateTime(
                                                                       DateTime.Now.ToShortTimeString())
                                                               };
            classMedicineProductionBatchPropertiesBindingSource.DataSource = tmpData;
            InputedManual = false;
            SearchType = EnumSearchType.FirstAddThanSearch;
            //MedicineBatchName = "";
            MedicineKindID = 0L;
            ID = 0L;

            #endregion
        }

        #region 属性

        private ClassLoginInformation m_LoginInformation;

        [Browsable(false)]
        public ClassLoginInformation LoginInformation
        {
            get
            {
                return m_LoginInformation;
            }
            set
            {
                m_LoginInformation = value;
                MedicineProductionBatchProperties.P_操作员_ID = value != null ? value.OperaterID : 0L;
            }
        }

        private EnumSearchType _searchType;
        [Browsable(true), DefaultValue(EnumSearchType.FirstAddThanSearch)]
        public EnumSearchType SearchType
        {
            get
            {
                return _searchType;
            }
            set
            {
                _searchType = value;
                if (value == EnumSearchType.OnlySearch)
                {
                    dateTimeTextBox生产日期.Enabled = false;
                    dateTimeTextBox有效期至.Enabled = false;
                }
                else
                {
                    dateTimeTextBox生产日期.Enabled = true;
                    dateTimeTextBox有效期至.Enabled = true;
                }
            }
        }

        private ClassMedicineProductionBatchProperties MedicineProductionBatchProperties
        {
            get
            {
                ClassMedicineProductionBatchProperties tmpMedicineProductionBatchProperties =
                    classMedicineProductionBatchPropertiesBindingSource.DataSource as
                    ClassMedicineProductionBatchProperties;
                return tmpMedicineProductionBatchProperties;
            }
        }

        //药品种类ID
        [Browsable(false),DefaultValue(0L)]
        public long MedicineKindID
        {
            get
            {
                return ((ClassMedicineProductionBatchProperties)
                        classMedicineProductionBatchPropertiesBindingSource.DataSource).YKGL_药品种类_ID;
            }
            set
            {
                ID = 0L;
                MedicineProductionBatchProperties.生产批号 = "";
                MedicineProductionBatchProperties.YKGL_药品种类_ID = value;
                MedicineKindPeriodOfValidity = 0;
                if (value == 0L)
                {
                    //如果未设置药品种类，则本控件不可用。
                    Enabled = false;
                }
                else
                {
                    Enabled = true;
                    if (!DesignMode)
                    {
                        MedicineKindPeriodOfValidity =
                            (int)
                            ClassMedicineKindPublic.GetMedicineKindPeriodOfValidity(LoginInformation.ConnectionString,
                                                                                    value);
                    }
                }
            }
        }
        
        //生产批号ID
        private long _id;
        [Browsable(false), DefaultValue(0L)]
        public long ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                ////设计模式不可赋值。
                //if (!DesignMode)
                //{
                //    string tmpMedicineProductionBatchName =
                //        ClassLibraryMedicineProductionBatchPublic.GetMedicineProductionBatchName(LoginInformation, value);
                //    MedicineProductionBatchProperties.生产批号 = value == 0 ? "" : tmpMedicineProductionBatchName;
                //    _id = string.IsNullOrEmpty(tmpMedicineProductionBatchName) ? 0L : value;
                //    classMedicineProductionBatchPropertiesBindingSource.ResetBindings(false);
                //}
            }
        }

        private int MedicineKindPeriodOfValidity { get; set; }

        #endregion

        #region 自定义事件

        public event ExecuteSucceedHandler SearchSucceed;

        public event ExecuteErrorHandler SearchError;

        private void OnSearchSucceed(EventArgsOfExecuteSucceed e)
        {
            ExecuteSucceedHandler Succeed = SearchSucceed;
            if (Succeed != null) Succeed(this, e);
        }

        private void OnSearchError(EventArgsOfExecuteError e)
        {
            ExecuteErrorHandler Error = SearchError;
            if (Error != null) Error(this, e);
        }

        #endregion

        #region 验证“生产批号”、“生产日期”和“有效期至”

        //当输入生产批号完毕，验证并查找该生产批号。
        private void textBox生产批号_Validated(object sender, EventArgs e)
        {
            MedicineProductionBatchProperties.生产批号 = MedicineProductionBatchProperties.生产批号.Trim();
            string tmpString = MedicineProductionBatchProperties.生产批号;
            if (string.IsNullOrEmpty(tmpString))
            {
                errorProvider1.SetError(textBox生产批号,"请输入生产批号！");
                return;
            }
            errorProvider1.SetError(textBox生产批号,"");

            SearchMethod();
            classMedicineProductionBatchPropertiesBindingSource.ResetBindings(false);
        }

        private bool InputedManual;

        private void dateTimeTextBox生产日期_ValueChanged(object sender, EventArgs e)
        {
            InputedManual = true;
        }

        private void dateTimeTextBox_Validated(object sender, EventArgs e)
        {
            if (!InputedManual) return;
            InputedManual = false;
            dateTimeTextBox有效期至.Value = dateTimeTextBox生产日期.Value.AddMonths(MedicineKindPeriodOfValidity);
            //classMedicineProductionBatchPropertiesBindingSource.ResetBindings(false);
        }

        //“有效期至”必须大于“生产日期”！
        private void dateTimeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimeTextBox生产日期.Value > dateTimeTextBox有效期至.Value)
            {
                errorProvider1.SetError(dateTimeTextBox生产日期, "“有效期至”必须大于“生产日期”！");
                errorProvider1.SetError(dateTimeTextBox有效期至, "“有效期至”必须大于“生产日期”！");
            }
            else
            {
                errorProvider1.SetError(dateTimeTextBox生产日期, "");
                errorProvider1.SetError(dateTimeTextBox有效期至, "");
            }
        }

        #endregion

        protected void control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        //增加药品生产批号。
        public void Add()
        {
            ID = 0L;
            if (LoginInformation == null) return;
            if (string.IsNullOrEmpty(MedicineProductionBatchProperties.生产批号))
            {
                return;
            }
            if (dateTimeTextBox生产日期.Value > dateTimeTextBox有效期至.Value)
            {
                return;
            }
            ClassMedicineProductionBatchProperties Data =
                classMedicineProductionBatchPropertiesBindingSource.DataSource as ClassMedicineProductionBatchProperties;
            if (Data != null)
            {
                ClassDataAdder Adder = new ClassDataAdder(LoginInformation, Data, 27);
                Adder.ExecuteError += Add_Error;
                Adder.ExecuteSucceed += Add_ExecuteSucceed;
                Adder.execute();
                Adder.ExecuteSucceed -= Add_ExecuteSucceed;
                Adder.ExecuteError -= Add_Error;
            }
        }

        //查找药品生产批号。
        public void Search()
        {
            if (LoginInformation == null) return;
            //(93)SELECT ID FROM dbo.YKGL_药品生产批号表 WHERE YKGL_药品种类_ID = {0} AND 生产批号 = '{1}'
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 93);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return;
            }
            string tmpSqlString = string.Format(tmpSQLString1, MedicineKindID, MedicineProductionBatchProperties.生产批号);
            long? tmpMedicineBatchID = ClassExecuteScalarData.GetScalarLong(LoginInformation.ConnectionString,
                                                                            tmpSqlString);
            if (tmpMedicineBatchID.HasValue)
            {
                ID = tmpMedicineBatchID.Value;
                //MessageBox.Show("Search OK!");
            }
            else
            {
                if (_searchType == EnumSearchType.FirstSearchThanAdd)
                {
                    Add();
                }
            }
        }

        //增加失败。
        private void Add_Error(object sender, EventArgsOfExecuteError e)
        {
            if (_searchType == EnumSearchType.FirstAddThanSearch)
            {
                Search();
            }
        }

        //增加成功。
        private void Add_ExecuteSucceed(object sender, EventArgsOfExecuteSucceed e)
        {
            _id = e.ID;
            //MessageBox.Show("Medicine Batch Add OK!");
        }

        public void ClearResult()
        {
            ((ClassMedicineProductionBatchProperties) classMedicineProductionBatchPropertiesBindingSource.DataSource).
                生产批号 = "";
            _id = 0L;
            classMedicineProductionBatchPropertiesBindingSource.ResetBindings(false);
            if (SearchType == EnumSearchType.OnlySearch)
            {
                dateTimeTextBox生产日期.Enabled = false;
                dateTimeTextBox有效期至.Enabled = false;
            }
            else
            {
                dateTimeTextBox生产日期.Enabled = true;
                dateTimeTextBox有效期至.Enabled = true;
            }
            MedicineKindID = 0L;
        }

        public void LoadInformation()
        {
            string tmpMedicineProductionBatchName = ClassLibraryMedicineProductionBatchPublic.GetMedicineProductionBatchName(LoginInformation, _id);
            MedicineProductionBatchProperties.生产批号 = _id == 0 ? "" : tmpMedicineProductionBatchName;
            classMedicineProductionBatchPropertiesBindingSource.ResetBindings(false);
        }

        #region 当TextBox生产批号验证完毕后，查询该生产批号

        private Thread _t;

        protected void SearchThread()
        {
            if (_t != null)
            {
                _t.Abort();
            }
            _t = new Thread(SearchMethod) { IsBackground = true };
            _t.Start();
        }

        private void SearchMethod()
        {
            if (LoginInformation == null) return;
            //(93)SELECT ID FROM dbo.YKGL_药品生产批号表 WHERE YKGL_药品种类_ID = {0} AND 生产批号 = '{1}'
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 93);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return;
            }
            string tmpSqlString = string.Format(tmpSQLString1, MedicineKindID, MedicineProductionBatchProperties.生产批号);
            long? tmpMedicineBatchID = ClassExecuteScalarData.GetScalarLong(LoginInformation.ConnectionString,
                                                                            tmpSqlString);
            if (tmpMedicineBatchID.HasValue)
            {
                //if (_id != tmpMedicineBatchID.Value)
                //{
                    ID = tmpMedicineBatchID.Value;
                    SearchComplete(true);
                    OnSearchSucceed(new EventArgsOfExecuteSucceed(_id,""));
                //}
            }
            else
            {
                _id = 0L;
                SearchComplete(false);
                OnSearchError(new EventArgsOfExecuteError("",""));
            }
        }

        private void SearchComplete(bool valSearched)
        {
            if (valSearched)
            {
                if (LoginInformation == null) return;
                ClassMedicineProductionBatchProperties tmpData = new ClassMedicineProductionBatchProperties { ID = ID };
                ClassDataLoader MedicineKindPropertiesLoader = new ClassDataLoader(LoginInformation, tmpData);
                if (MedicineKindPropertiesLoader.execute())
                {
                    SetControlState(dateTimeTextBox生产日期,false);
                    SetControlState(dateTimeTextBox有效期至,false);
                    if (ActiveControl != null)
                    {
                        //SendKeys.Send("{TAB}");
                        SendKeys.SendWait("{TAB}");
                    }

                    classMedicineProductionBatchPropertiesBindingSource.DataSource = tmpData;
                    classMedicineProductionBatchPropertiesBindingSource.ResetBindings(false);
                }
            }
            else
            {
                if (_searchType != EnumSearchType.OnlySearch)
                {
                    SetControlState(dateTimeTextBox生产日期, true);
                    SetControlState(dateTimeTextBox有效期至, true);
                    dateTimeTextBox生产日期.Focus();
                }
            }
        }

        private delegate void SetControlStateHandler(object valControl, object valEnabled);

        protected void SetPictureBoxState(object valControl,object valEnabled)
        {
            if (((Control)valControl).InvokeRequired)
            {
                SetControlStateHandler c = SetPictureBoxState;
                Invoke(c, new[] { valEnabled });
            }
            else
            {
                ((Control)valControl).Enabled = (bool)valEnabled;
                ((Control)valControl).Visible = (bool)valEnabled;
            }
        }

        protected void SetControlState(object valControl,object valEnabled)
        {
            if (InvokeRequired)
            {
                SetControlStateHandler c = SetControlState;
                Invoke(c, new[] { valControl,valEnabled });
            }
            else
            {
                ((Control)valControl).Enabled = (bool)valEnabled;
            }
        }

        private delegate void SetCursorStateHandler(object valCursor);

        protected void SetCursorState(object valCursor)
        {
            if (InvokeRequired)
            {
                SetCursorStateHandler c = SetCursorState;
                Invoke(c, new[] { valCursor });
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        #endregion

   }
}
