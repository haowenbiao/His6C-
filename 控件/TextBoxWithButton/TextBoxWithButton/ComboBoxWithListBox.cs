using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CustomTextBox
{
    public partial class ComboBoxWithListBox : ComboBox
    {
        #region 成员变量

        private const int WM_LBUTTONDOWN = 0x201, WM_LBUTTONDBLCLK = 0x203;
        ToolStripControlHost toolStripControlHost;
        ToolStripDropDown toolStripDropDown;
        public event EventHandler AfterSelector;

        #endregion

        public ComboBoxWithListBox()
        {
            //InitializeComponent();
            DrawListBox(ListBox);
        }

        #region 属性

        #region 数据绑定(暂停)

        //private BindingSource bs = new BindingSource();

        //public new object DataSource
        //{
        //    get
        //    {
        //        return bs.DataSource;
        //    }
        //    set
        //    {
        //        bs.DataSource = value;
        //        _listBox.DataSource = bs;
        //        _listBox.ResetBindings();
        //    }
        //}

        //public new string DisplayMember
        //{
        //    get
        //    {
        //        return _listBox.DisplayMember;
        //    }
        //    set
        //    {
        //        _listBox.DisplayMember = value;
        //        _listBox.ResetBindings();
        //    }
        //}

        //public new string ValueMember
        //{
        //    get
        //    {
        //        return _listBox.ValueMember;
        //    }
        //    set
        //    {
        //        _listBox.ValueMember = value;
        //        _listBox.ResetBindings();
        //    }
        //}

        #endregion

        private ListBox _listBox;

        [Browsable(false)]
        public ListBox ListBox
        {
            get
            {
                if (_listBox != null)
                {
                    if (_listBox.IsDisposed)
                    {
                        _listBox = new ListBox {BorderStyle = BorderStyle.None};
                        _listBox.MouseClick += listBox_Click;
                    }
                }
                else
                {
                    _listBox = new ListBox {BorderStyle = BorderStyle.None};
                    _listBox.MouseClick += listBox_Click;
                }
                return _listBox;
            }
        }

        private object _SelectedValue;

        [Browsable(false)]
        public new object SelectedValue
        {
            set
            {
                _SelectedValue = value;
                try
                {
                    ListBox.SelectedValue = value;
                    Text = ListBox.Text;
                    toolStripDropDown.Close();
                    OnAfterSelected(new EventArgs());
                }
                catch
                {
                    return;
                }
            }
            get
            {
                return _SelectedValue;
            }
        }

        #endregion

        #region 绘制ListBox以及下拉ListBox
        
        private void DrawListBox(Control valListBox)
        {
            //设置DataGridView的数据源
            Form frmDataSource = new Form();
            frmDataSource.Controls.Add(valListBox);
            frmDataSource.SuspendLayout();

            toolStripControlHost = new ToolStripControlHost(valListBox) {AutoSize = false};

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

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (ListBox.SelectedIndex < ListBox.Items.Count - 1)
                {
                    ListBox.SelectedIndex += 1;
                }
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (ListBox.SelectedIndex > 0)
                {
                    ListBox.SelectedIndex -= 1;
                }
                e.Handled = true;
            }

            base.OnKeyDown(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataRowView tmpDataRowView = ListBox.SelectedItem as DataRowView;
                if (tmpDataRowView == null) return;
                if (tmpDataRowView.DataView.Table.Columns.Contains(ListBox.ValueMember))
                {
                    _SelectedValue = tmpDataRowView[ListBox.ValueMember];
                    Text = ListBox.Text;

                    OnAfterSelected(e);
                    toolStripDropDown.Close();
                }
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

        protected override void OnLostFocus(EventArgs e)
        {
            toolStripDropDown.Close();
            base.OnLostFocus(e);
        }

        protected override void OnTextUpdate(EventArgs e)
        {
            if (!toolStripDropDown.Visible)
            {
                ShowDropDown();
            }

            base.OnTextChanged(e);
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

        private void listBox_Click(object sender, EventArgs e)
        {
            DataRowView tmpDataRowView = ListBox.SelectedItem as DataRowView;
            if (tmpDataRowView == null) return;
            if (tmpDataRowView.DataView.Table.Columns.Contains(ListBox.ValueMember))
            {
                _SelectedValue = tmpDataRowView[ListBox.ValueMember];
                Text = ListBox.Text;

                OnAfterSelected(e);
                toolStripDropDown.Close();
            }
        }

        protected virtual void OnAfterSelected(EventArgs e)
        {
            if (AfterSelector != null)
            {
                AfterSelector(this, e);
            }
        }

        #endregion
    }
}