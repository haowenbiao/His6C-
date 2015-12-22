using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace CustomTextBox
{
    public partial class ComboBoxWithControlDataGridView : ComboBoxWithControl
    {
        private FormWithDataGridView f = new FormWithDataGridView();

        public ComboBoxWithControlDataGridView()
        {
            InitializeComponent();

            #region 初始化属性

            HelpText1 = "同时按下Ctrl键+数字键，可以快速选择前十个选项（0—9）。";
            HelpText2 = "";
            DoubleClickSelect = false;
            DropDownBackColor = Color.White;
            HelpText1ForeColor =Color.FromKnownColor(KnownColor.ControlText);
            HelpText2ForeColor = Color.FromKnownColor(KnownColor.ControlText);

            SelectedValue = null;
            SelectedIndex = -1;
            SelectedItem = null;
            SelectedText = "";

            f.DropDownClose += f_DropDownClose;
            f.TopLevel = false;
            PopUpControl = f;

            DataGridView.KeyUp += DataGridView_KeyUp;
            DataGridView.MouseClick += DataGridView_MouseClick;
            DataGridView.MouseDoubleClick += DataGridView_MouseDoubleClick;
            DataGridView.PreviewKeyDown += DataGridView_PreviewKeyDown;

            #endregion
        }

        private void f_DropDownClose(object sender, EventArgs e)
        {
            DropDownClose();
        }

        private void DataGridView_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (DataGridView.SelectedRows[0].Index != DataGridView.Rows.Count - 1)
                    SendKeys.Send("{UP}");
            }
        }

        #region 属性

        [Browsable(false)]
        public DataGridView DataGridView
        {
            get
            {
                return f.DataGridView;
            }
        }

        [Description("帮助提示1。"), Browsable(true), DefaultValue("同时按下Ctrl键+数字键，可以快速选择前十个选项（0—9）。")]
        public virtual string HelpText1
        {
            get
            {
                return f.HelpText1;
            }
            set
            {
                f.HelpText1 = value;
            }
        }

        [Description("帮助1的前景颜色。"), Browsable(true), DefaultValue(typeof(Color),"ControlText")]
        public virtual Color HelpText1ForeColor
        {
            get
            {
                return f.HelpText1ForeColor;
            }
            set
            {
                f.HelpText1ForeColor = value;
            }
        }

        [Description("帮助提示2。"), Browsable(true), DefaultValue("")]
        public virtual string HelpText2
        {
            get
            {
                return f.HelpText2;
            }
            set
            {
                f.HelpText2 = value;
            }
        }

        [Description("帮助2的前景颜色。"), Browsable(true), DefaultValue(typeof(Color), "ControlText")]
        public virtual Color HelpText2ForeColor
        {
            get
            {
                return f.HelpText2ForeColor;
            }
            set
            {
                f.HelpText2ForeColor = value;
            }
        }

        [Description("鼠标双击进行选择还是单击进行选择。"), Browsable(true), DefaultValue(false)]
        public bool DoubleClickSelect { get; set; }

        [Description("下拉窗口的背景颜色。"), Browsable(true), DefaultValue(typeof(Color), "White")]
        public override Color DropDownBackColor
        {
            get
            {
                return base.DropDownBackColor;
            }
            set
            {
                f.BackColor = value;
                base.DropDownBackColor = value;
            }
        }
        
        public virtual long ID
        {
            get
            {
                long tmpID;
                try
                {
                    tmpID = (long) SelectedValue;
                }
                catch
                {
                    return 0L;
                }
                return tmpID;
            }
        }

        [Browsable(false),DefaultValue(null)]
        public new virtual object SelectedValue { get; set; }

        [Browsable(false),DefaultValue(-1)]
        public new virtual int SelectedIndex { get; set; }

        [Browsable(false),DefaultValue(null)]
        public new virtual object SelectedItem { get; set; }

        [Browsable(false),DefaultValue("")]
        public new virtual String SelectedText { get; set; }

        #endregion

        #region 方法

        /// <summary>
        /// 清除结果。
        /// </summary>
        public void ClearResult()
        {
            SelectedValue = null;
            SelectedIndex = -1;
            SelectedItem = null;
            SelectedText = "";
            Text = "";
            
            //引发事件。
            EventArgs e=new EventArgs();
            OnSelectedIndexChanged(e);
            OnSelectedItemChanged(e);
            OnSelectedValueChanged(e);
            OnSelectionChangeCommitted(e);
        }

        #endregion

        /// <summary>
        /// 弹出下拉表格并触发选择后事件
        /// </summary>
        /// <param name="e"></param>
        private void PopupGridView(EventArgs e)
        {
            if (f.BindingManagerBase != null)
            {
                DataRowView tmpDataRowView = f.BindingManagerBase.Current as DataRowView;
                if (tmpDataRowView != null)
                {
                    SelectedValue = tmpDataRowView[ValueMember];
                    SelectedIndex = f.BindingManagerBase.Position;
                    SelectedItem = tmpDataRowView;
                    SelectedText = tmpDataRowView[DisplayMember] as string;
                    Text = tmpDataRowView[DisplayMember].ToString();
                    OnSelectedIndexChanged(e);
                    OnSelectedItemChanged(e);
                    OnSelectedValueChanged(e);
                    OnSelectionChangeCommitted(e);
                }
            }
            DropDownClose();
        }

        #region 重载的事件

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (f.BindingManagerBase != null)
                {
                    f.BindingManagerBase.Position += 1;
                }
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (f.BindingManagerBase != null)
                {
                    f.BindingManagerBase.Position -= 1;
                }
                e.Handled = true;
            }

            base.OnKeyDown(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (DropDownIsOpened && f.BindingManagerBase != null && f.BindingManagerBase.Count > 0 && f.BindingManagerBase.Current.GetType() == typeof(DataRowView))
                {
                    PopupGridView(e);
                }
            }
            base.OnKeyPress(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            //使用Ctrl+数字键来快速选择。
            if (e.Control)
            {
                if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||
                    (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
                {
                    int index = 0;
                    if (e.KeyValue >= 48 && e.KeyValue <= 57)
                    {
                        index = e.KeyValue - 48;
                    }
                    if (e.KeyValue >= 96 && e.KeyValue <= 105)
                    {
                        index = e.KeyValue - 96;
                    }
                    if (index > DataGridView.Rows.Count - 1)
                    {
                        base.OnKeyUp(e);
                        return;
                    }
                    //DataGridView.Rows[index].Selected = true;
                    f.BindingManagerBase.Position = index;
                    PopupGridView(e);
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                DropDownClose();
            }
            base.OnKeyUp(e);
        }

        #region DataGridView事件

        private void DataGridView_KeyUp(object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
        }

        private void DataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (DoubleClickSelect)
                PopupGridView(e);
        }

        private void DataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (!DoubleClickSelect)
                PopupGridView(e);
        }

        #endregion

        #endregion
    }
}