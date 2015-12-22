using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using ClassLibraryMedicineKind;
using CustomTextBox;

namespace MedicineKindSelectControl
{
    public partial class MedicineKindSelectControl : ComboBoxWithControlDataGridView
    {
        public MedicineKindSelectControl()
        {
            InitializeComponent();

            #region 初始化属性

            ValueMember = "ID";
            DisplayMember = "商品名称";

            AutoLoadDataAfterSetConnectionSqlString = true;
            IsLoadExceptAll = true;
            _ConnectionSqlString = "";
            HelpText2 = "使用说明：输入药品的“通用名称拼音码”或“商品名称拼音码”或“药品通用名称”或“商品名称”均可进行药品的模糊查询。";
            HelpText1ForeColor = Color.Red;
            HelpText2ForeColor = Color.Red;
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
                DataGridView.DataSource = null;
                return;
            }
            try
            {
                DataGridView.DataSource = IsLoadExceptAll ? ClassMedicineKindPublic.LoadAllMedicineKinds(ConnectionSqlString) : ClassMedicineKindPublic.LoadAllMedicineKindsWithAll(ConnectionSqlString);
                DataGridView.Columns[0].Visible = false;
                DataGridView.Columns[2].Visible = false;
                DataGridView.Columns[4].Visible = false;
                DataGridView.BackColor = Color.White;
            }
            catch
            {
                return;
            }
        }

        #region 属性

        [Description("是否加载排除了“所有药品”的药品种类。"), Browsable(true), DefaultValue(true)]
        public bool IsLoadExceptAll { get; set; }
        
        [Description("设置连接字符串后，是否自动加载数据。"), Browsable(true), DefaultValue(true)]
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
        
        [Browsable(false), DefaultValue("ID")]
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

        [Browsable(false), DefaultValue("商品名称")]
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

        [Browsable(true), DefaultValue(typeof(Color), "White")]
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

        [Browsable(false), DefaultValue("使用说明：输入药品的“通用名称拼音码”或“商品名称拼音码”或“药品通用名称”或“商品名称”均可进行药品的模糊查询。")]
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

        #region 重载事件

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            //label1.Text = comboBoxWithDateGridView1.SelectedValue.ToString();
            DataTable dataTable = DataGridView.DataSource as DataTable;
            if (dataTable != null) dataTable.DefaultView.RowFilter = "";
            base.OnSelectedIndexChanged(e);
        }

        protected override void OnTextUpdate(EventArgs e)
        {
            //DropDownOpen();
            DataTable dataTable = DataGridView.DataSource as DataTable;
            string tmpString = string.Format("商品名称_拼音码 LIKE '{0}%' OR 商品名称 LIKE '{0}%' OR 通用名称_拼音码 LIKE '{0}%' OR 通用名称 LIKE '{0}%'", Text.Trim());
            if (dataTable != null) dataTable.DefaultView.RowFilter = tmpString;
            base.OnTextUpdate(e);
        }

        #endregion
    }
}
