using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CustomTextBox
{
    public partial class ComboBoxWithControl : ComboBox
    {
        #region 自定义事件

        public delegate void DropDownOpenedHandle(object sender, EventArgs e);

        public delegate void DropDownOpeningHandle(object sender, CancelEventArgs e);

        public delegate void DropDownClosedHandle(object sender, ToolStripDropDownClosedEventArgs e);

        public delegate void DropDownClosingHandle(object sender, ToolStripDropDownClosingEventArgs e);

        public event DropDownOpenedHandle DropDownOpened;

        public event DropDownOpeningHandle DropDownOpening;

        public new event DropDownClosedHandle DropDownClosed;

        public event DropDownClosingHandle DropDownClosing;

        protected virtual void OnDropDownClosing(ToolStripDropDownClosingEventArgs e)
        {
            DropDownClosingHandle Closing = DropDownClosing;
            if (Closing != null) Closing(this, e);
        }

        protected virtual void OnDropDownClosed(ToolStripDropDownClosedEventArgs e)
        {
            DropDownClosedHandle Closed = DropDownClosed;
            if (Closed != null) Closed(this, e);
        }

        protected virtual void OnDropDownOpening(CancelEventArgs e)
        {
            DropDownOpeningHandle Opening = DropDownOpening;
            if (Opening != null) Opening(this, e);
        }

        protected virtual void OnDropDownOpened(EventArgs e)
        {
            DropDownOpenedHandle Opened = DropDownOpened;
            if (Opened != null) Opened(this, e);
        }

        #endregion

        #region 成员变量

        private const int WM_LBUTTONDOWN = 0x201, WM_LBUTTONDBLCLK = 0x203;
        ToolStripControlHost toolStripControlHost;
        ToolStripDropDown toolStripDropDown;

        #endregion

        public ComboBoxWithControl()
        {
            InitializeComponent();

            #region 初始化下拉窗口
            toolStripDropDown = new ToolStripDropDown { Width = Width };
            toolStripDropDown.Opened += DropDown_Opened;
            toolStripDropDown.Opening += DropDown_Opening;
            toolStripDropDown.Closed += DropDown_Closed;
            toolStripDropDown.Closing += DropDown_Closing;
            #endregion

            #region 初始化属性

            DropDownAutoClosed = true;
            DropDownAutoSize = true;
            DropDownHeight = 106;
            DropDownWidth = 121;
            DropDownBackColor = Color.FromKnownColor(KnownColor.Control);

            #endregion
        }

        #region DropDown事件

        private void DropDown_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            OnDropDownClosing(e);
        }

        private void DropDown_Opening(object sender, CancelEventArgs e)
        {
            OnDropDownOpening(e);
        }

        private void DropDown_Opened(object sender, EventArgs e)
        {
            OnDropDownOpened(e);
        }

        private void DropDown_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            OnDropDownClosed(e);
        }

        #endregion

        #region 属性

        public new virtual string ValueMember
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

        public new virtual string DisplayMember
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

        [Description("下拉窗口的背景颜色。"), Browsable(true), DefaultValue(typeof(Color), "Control")]
        public virtual Color DropDownBackColor
        {
            get
            {
                return toolStripDropDown.BackColor;
            }
            set
            {
                toolStripDropDown.BackColor = value;
            }
        }

        [Description("是否自动关闭下拉窗口。"), Browsable(true), DefaultValue(true)]
        public virtual bool DropDownAutoClosed
        {
            get
            {
                return toolStripDropDown.AutoClose;
            }
            set
            {
                toolStripDropDown.AutoClose = value;
            }
        }

        [Description("是否自动设置下拉窗口大小。"), Browsable(true), DefaultValue(true)]
        public virtual bool DropDownAutoSize { get; set; }

        [Description("组合框中下拉框的高度（以像素为单位）"), Browsable(true), DefaultValue(106)]
        public new virtual int DropDownHeight { get; set; }

        [Description("组合框中下拉框的宽度（以像素为单位）"), Browsable(true), DefaultValue(121)]
        public new virtual int DropDownWidth { get; set; }

        /// <summary>
        /// 获取下拉窗口是否已经打开.
        /// </summary>
        public bool DropDownIsOpened
        {
            get
            {
                return toolStripDropDown.Visible;
            }
        }

        private Control _PopUpControl;
        [Browsable(false)]
        public Control PopUpControl
        {
            get
            {
                return _PopUpControl;
            }
            set
            {
                if (toolStripDropDown.Items.Count > 0)
                {
                    toolStripDropDown.Items.Clear();
                }
                _PopUpControl = value;
                if (_PopUpControl != null && !_PopUpControl.IsDisposed)
                {
                    DrawDataGridView(_PopUpControl);
                }
            }
        }
        
        #endregion

        #region 方法

        //public void RefreshDataSource()
        //{
        //    toolStripDropDown.Items.Remove(toolStripControlHost);
        //    Control tmpControl = toolStripControlHost.Control;
        //    Form frmDataSource = new Form();
        //    frmDataSource.Controls.Add(tmpControl);
        //    frmDataSource.SuspendLayout();
        //    toolStripControlHost = new ToolStripControlHost(tmpControl) { AutoSize = true };
        //    toolStripDropDown.Items.Add(toolStripControlHost);
        //}

        public void DropDownClose()
        {
            toolStripDropDown.Close();
        }

        public void DropDownOpen()
        {
            ShowDropDown();
        }

        #endregion

        #region 绘制DataGridView以及下拉DataGridView

        private void DrawDataGridView(Control valControl)
        {
            //设置DataGridView的数据源
            Form frmDataSource = new Form();
            frmDataSource.Controls.Add(valControl);
            frmDataSource.SuspendLayout();

            toolStripControlHost = new ToolStripControlHost(valControl) {AutoSize = false};
            toolStripDropDown.Items.Add(toolStripControlHost);
        }

        private void ShowDropDown()
        {
            if (toolStripDropDown.Visible) return;
            if (toolStripDropDown.Items.Count > 0)
            {
                if (!DropDownAutoSize)
                {
                    toolStripControlHost.Size = new Size(DropDownWidth - 2, DropDownHeight);
                }
                toolStripDropDown.Show(this, 0, Height);
            }
        }

        #endregion

        #region 重载事件

        protected override void OnEnter(EventArgs e)
        {
            if (!DropDownAutoClosed)
            {
                ShowDropDown();
            }
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            toolStripDropDown.Close();
            base.OnLeave(e);
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
                    ShowDropDown();
                }
            }
            base.OnKeyDown(e);
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

        #endregion
    }
}