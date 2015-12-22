using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace CustomTextBox
{
    public partial class ComboBoxWithDateGridView : ComboBox
    {
        #region 成员变量

        private const int WM_LBUTTONDOWN = 0x201, WM_LBUTTONDBLCLK = 0x203;
        ToolStripControlHost toolStripControlHost;
        ToolStripDropDown toolStripDropDown;

        #endregion

        #region 构造器

        public ComboBoxWithDateGridView()
        {
            InitializeComponent();

            #region 初始化属性
            HelpText = "";
            DoubleClickSelect = false;
            #endregion

            _dataGridView.TopLeftHeaderCell.Value = "Ctrl+";
            DrawDataGridView(tableLayoutPanel1);
        }

        #endregion

        #region 属性

        [Description("帮助信息。"), Browsable(true), DefaultValue("")]
        public string HelpText
        {
            get
            {
                return labelHelp.Text;
            }
            set
            {
                labelHelp.Text = value;
            }
        }

        [Browsable(false)]
        public DataGridView DataGridView
        {
            get
            {
                return _dataGridView;
            }
        }

        [Description("鼠标双击进行选择还是单击进行选择。"), Browsable(true), DefaultValue(false)]
        public bool DoubleClickSelect { get; set; }

        public new string DisplayMember { get; set; }

        public new string ValueMember { get; set; }

        private object _SelectedValue;

        [Browsable(false)]
        public new object SelectedValue
        {
            get
            {
                return _SelectedValue;
            }
        }

        #endregion

        #region 绘制DataGridView以及下拉DataGridView

        private void DrawDataGridView(Control valDataGridView)
        {
            //设置DataGridView的数据源
            Form frmDataSource = new Form();
            frmDataSource.Controls.Add(valDataGridView);
            frmDataSource.SuspendLayout();

            toolStripControlHost = new ToolStripControlHost(valDataGridView) {AutoSize = false};

            toolStripDropDown = new ToolStripDropDown {Width = Width};
            toolStripDropDown.Items.Add(toolStripControlHost);
            toolStripDropDown.AutoClose = false;
            toolStripDropDown.BackColor = Color.White;
        }

        private void ShowDropDown()
        {
            if (toolStripDropDown != null)
            {
                #region 更新数据源的需要
                //toolStripDropDown.Items.Remove(toolStripControlHost);
                //Control tmpControl = toolStripControlHost.Control;
                //Form frmDataSource = new Form();
                //frmDataSource.Controls.Add(tmpControl);
                //frmDataSource.SuspendLayout();
                //toolStripControlHost = new ToolStripControlHost(tmpControl) { AutoSize = true };
                //toolStripDropDown.Items.Add(toolStripControlHost);
                #endregion

                toolStripControlHost.Size = new Size(DropDownWidth - 2, DropDownHeight);
                toolStripDropDown.Show(this, 0, Height);
            }
        }

        public void RefreshDataSource()
        {
            toolStripDropDown.Items.Remove(toolStripControlHost);
            Control tmpControl = toolStripControlHost.Control;
            Form frmDataSource = new Form();
            frmDataSource.Controls.Add(tmpControl);
            frmDataSource.SuspendLayout();
            toolStripControlHost = new ToolStripControlHost(tmpControl) { AutoSize = true };
            toolStripDropDown.Items.Add(toolStripControlHost);
            //toolStripControlHost.Size = new Size(DropDownWidth - 2, DropDownHeight);
        }

        #endregion

        #region 重写方法

        /// <summary>
        /// 弹出下拉表格并触发选择后事件
        /// </summary>
        /// <param name="e"></param>
        private void PopupGridView(EventArgs e)
        {
            if (DataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow m_dgvRow = DataGridView.SelectedRows[0];
                _SelectedValue = m_dgvRow.Cells[ValueMember].Value;
                Text = m_dgvRow.Cells[DisplayMember].Value.ToString();
                OnSelectedIndexChanged(e);
                OnSelectedItemChanged(e);
                OnSelectedValueChanged(e);
                OnSelectionChangeCommitted(e);
            }
            toolStripDropDown.Close();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            //屏蔽F4键。
            if (e.KeyCode == Keys.F4)
            {
                e.Handled = true;
                if (toolStripDropDown.Visible)
                {
                    toolStripDropDown.Close();
                }
                else
                {
                    toolStripDropDown.Show();
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (_dataGridView.SelectedRows[0].Index < _dataGridView.Rows.Count - 1)
                {
                    _dataGridView.Rows[_dataGridView.SelectedRows[0].Index + 1].Selected = true;     
                }
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (_dataGridView.SelectedRows[0].Index > 0)
                {
                    _dataGridView.Rows[_dataGridView.SelectedRows[0].Index - 1].Selected = true;
                }
                e.Handled = true;
            }

            base.OnKeyDown(e);
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
                    if (index > _dataGridView.Rows.Count - 1)
                    {
                        return;
                    }
                    _dataGridView.Rows[index].Selected = true;
                    PopupGridView(e);
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                toolStripDropDown.Close();
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                BindingManagerBase bmb = null;
                if (DataGridView.DataSource != null)
                {
                    bmb = BindingContext[DataGridView.DataSource];
                }
                if (bmb == null)
                {
                    return;
                }
                if (bmb.Count == 0)
                {
                    return;
                }
                if (bmb.Current.GetType()!=typeof(DataRowView))
                {
                    return;
                }
                PopupGridView(e);
            }
            base.OnKeyUp(e);
        }

        protected override void OnEnter(EventArgs e)
        {
            ShowDropDown();
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            toolStripDropDown.Close();
            base.OnLeave(e);
        }

        protected override void OnTextUpdate(EventArgs e)
        {
            if (!toolStripDropDown.Visible)
            {
                ShowDropDown();
            }

            base.OnTextUpdate(e);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDBLCLK || m.Msg == WM_LBUTTONDOWN)
            {
                if (toolStripDropDown.Visible)
                {
                    toolStripDropDown.Close();
                }
                else
                {
                    ShowDropDown();
                }

                return;
            }
            base.WndProc(ref m);
        }

        private void _dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (!DoubleClickSelect)
                PopupGridView(e);
        }

        private void _dataGridView_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_dataGridView.SelectedRows[0].Index != _dataGridView.Rows.Count - 1)
                    SendKeys.Send("{UP}");
            }

        }

        private void _dataGridView_KeyUp(object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
            //if (e.KeyCode == Keys.Escape)
            //{
            //    toolStripDropDown.Close();
            //    return;
            //}
            //if (e.KeyCode == Keys.Enter)
            //{
            //    PopupGridView(e);
            //}
        }

        private void _dataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (DoubleClickSelect)
                PopupGridView(e);
        }

        private void _dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //只给前10个设置快捷键
            if (e.RowIndex > 9) return;
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                                                e.RowBounds.Location.Y,
                                                _dataGridView.RowHeadersWidth - 4,
                                                e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, e.RowIndex.ToString() ,
                                  _dataGridView.RowHeadersDefaultCellStyle.Font,
                                  rectangle,
                                  _dataGridView.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
        }

        #endregion

    }    
}
