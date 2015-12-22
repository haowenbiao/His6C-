using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using ClassLibraryWorkerInformations;
using CustomTextBox;

namespace WorkerSelectorControl
{
    public partial class WorkerSelectorComboBoxWithDataGridView : ComboBoxWithControlDataGridView
    {
        public WorkerSelectorComboBoxWithDataGridView()
        {
            InitializeComponent();

            #region 初始化属性

            _ConnectionSqlString = "";
            ValueMember = "P_职工信息_ID";
            DisplayMember = "职工姓名";
            HelpText2 = "使用说明：输入“职工姓名拼音码”或“职工姓名”均可进行职工的模糊查询。";
            HelpText1ForeColor = Color.Red;
            HelpText2ForeColor = Color.Red;
            AutoLoadDataAfterSetConnectionSqlString = true;
            IsLoadWithAll = false;
            DropDownBackColor = Color.White;
            DropDownHeight = 280;
            DropDownWidth = 258;
            DropDownAutoSize = false;
            DropDownAutoClosed = false;
            #endregion
        }

        /// <summary>
        /// 加载数据。
        /// </summary>
        public void LoadData()
        {
            if (string.IsNullOrEmpty(ConnectionSqlString))
            {
                return;
            }
            try
            {
                DataGridView.DataSource = ClassWorkerPublic.LoadWorkerList(ConnectionSqlString, IsLoadWithAll);
                DataGridView.Columns[0].Visible = false;
                DataGridView.Columns[1].Visible = false;
                DataGridView.Columns[2].Visible = false;
                DataGridView.BackColor = Color.White;
            }
            catch
            {
                return;
            }
        }

        #region 属性

        [Description("是否加载“所有职工”的药品种类。"), Browsable(true), DefaultValue(false)]
        public bool IsLoadWithAll { get; set; }
        
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
                        LoadData();
                    }
                }
            }
        }

        [Browsable(false), DefaultValue("P_职工信息_ID")]
        public sealed override string ValueMember
        {
            get
            {
                return base.ValueMember;
            }
            set
            {
                base.ValueMember = value;
            }
        }

        [Browsable(false), DefaultValue("职工姓名")]
        public sealed override string DisplayMember
        {
            get
            {
                return base.DisplayMember;
            }
            set
            {
                base.DisplayMember = value;
            }
        }

        [Browsable(true),DefaultValue(typeof(Color),"White")]
        public sealed override Color DropDownBackColor
        {
            get
            {
                return base.DropDownBackColor;
            }
            set
            {
                base.DropDownBackColor = value;
            }
        }

        [Description("组合框中下拉框的高度（以像素为单位）"), Browsable(true), DefaultValue(280)]
        public sealed override int DropDownHeight
        {
            get
            {
                return base.DropDownHeight;
            }
            set
            {
                base.DropDownHeight = value;
            }
        }

        [Description("组合框中下拉框的宽度（以像素为单位）"), Browsable(true), DefaultValue(258)]
        public sealed override int DropDownWidth
        {
            get
            {
                return base.DropDownWidth;
            }
            set
            {
                base.DropDownWidth = value;
            }
        }

        [Description("是否自动设置下拉窗口大小。"), Browsable(true), DefaultValue(false)]
        public sealed override bool DropDownAutoSize
        {
            get
            {
                return base.DropDownAutoSize;
            }
            set
            {
                base.DropDownAutoSize = value;
            }
        }

        [Description("是否自动关闭下拉窗口。"), Browsable(true), DefaultValue(false)]
        public sealed override bool DropDownAutoClosed
        {
            get
            {
                return base.DropDownAutoClosed;
            }
            set
            {
                base.DropDownAutoClosed = value;
            }
        }

        #region 帮助信息

        [Browsable(false)]
        public sealed override string HelpText1
        {
            get
            {
                return base.HelpText1;
            }
            set
            {
                base.HelpText1 = value;
            }
        }

        [Browsable(false), DefaultValue("使用说明：输入“职工姓名拼音码”或“职工姓名”均可进行职工的模糊查询。")]
        public sealed override string HelpText2
        {
            get
            {
                return base.HelpText2;
            }
            set
            {
                base.HelpText2 = value;
            }
        }

        [Browsable(false), DefaultValue(typeof(Color), "Red")]
        public sealed override Color HelpText1ForeColor
        {
            get
            {
                return base.HelpText1ForeColor;
            }
            set
            {
                base.HelpText1ForeColor = value;
            }
        }

        [Browsable(false), DefaultValue(typeof(Color), "Red")]
        public sealed override Color HelpText2ForeColor
        {
            get
            {
                return base.HelpText2ForeColor;
            }
            set
            {
                base.HelpText2ForeColor = value;
            }
        }

        #endregion

        #endregion

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            DataTable dataTable = DataGridView.DataSource as DataTable;
            if (dataTable != null) dataTable.DefaultView.RowFilter = "";
            base.OnSelectedIndexChanged(e);
        }

        protected override void OnTextUpdate(EventArgs e)
        {
            DataTable dataTable = DataGridView.DataSource as DataTable;
            string tmpString = string.Format("拼音码 LIKE '{0}%' OR 职工姓名 LIKE '{0}%'", Text.Trim());
            if (dataTable != null) dataTable.DefaultView.RowFilter = tmpString;
            base.OnTextUpdate(e);
        }

    }
}
