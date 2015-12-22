using System;
using System.ComponentModel;
using System.Drawing;

namespace CustomForm
{
    /// <summary>
    /// Description of FormCustomAutoSize.
    /// </summary>
    public partial class FormCustomAutoSized : FormCustomHelped
    {
        #region 构造器

        protected FormCustomAutoSized()
        {
            InitializeComponent();
            ShowResizeButton = true;
            ShowButtonPanel = true;
        }

        #endregion
        
        //枚举类型可使用Flags 标志，表示这些枚举类型可以作为位域（即一组标志）处理
        //[Flags]
        public enum EnumSizeState
        {
            MaxSize = 1,
            MinSize = 2,
        }

        private EnumSizeState _sizeState = EnumSizeState.MaxSize;

        public EnumSizeState SizeState
        {
            get
            {
                return _sizeState;
            }
            set
            {
                _sizeState = value;
                Size = value == EnumSizeState.MinSize ? MinSize : MaxSize;
                OnSizeStateChanged(new EventArgsOfSizeStateChanged());
            }
        }

        #region 事件

        public class EventArgsOfSizeStateChanged : EventArgs
        {
        }

        public delegate void SizeStateChangedHandler(object sender, EventArgsOfSizeStateChanged e);

        public event SizeStateChangedHandler SizeStateChanged;

        protected virtual void OnSizeStateChanged(EventArgsOfSizeStateChanged e)
        {
            if (SizeStateChanged != null)
            {
                SizeStateChanged(this, e);
            }
        }

        #endregion

        private Size _maxSize = new Size(300, 300);
        private Size _minSize = new Size(300, 300);

        [Description("窗体的最大尺寸"), Category("杂项"), Browsable(true)]
        public Size MaxSize
        {
            set
            {
                _maxSize = value;
                if (_sizeState == EnumSizeState.MaxSize)
                {
                    Size = value;
                }
            }
            get { return _maxSize; }
        }

        [Description("窗体的最小尺寸"), Category("杂项"), Browsable(true)]
        public Size MinSize
        {
            set
            {
                _minSize = value;
                if (_sizeState == EnumSizeState.MinSize)
                {
                    Size = value;
                }
            }
            get { return _minSize; }
        }

        protected override void OnResize(EventArgs e)
        {
            if (SizeState == EnumSizeState.MinSize)
            {
                _minSize = Size;
            }
            else
            {
                _maxSize = Size;
            }

            base.OnResize(e);
        }

        private bool m_ShowResizeButton = true;

        [Description("是否显示控制窗体大小改变的按钮"), DefaultValue(true), Category("杂项"), Browsable(true)]
        public bool ShowResizeButton
        {
            get
            {
                return m_ShowResizeButton;
            }
            set
            {
                buttonResize.Enabled = value;
                buttonResize.Visible = value;
                m_ShowResizeButton = value;
            }
        }

        private bool m_ShowButtonPanel = true;

        [Description("是否显示按钮栏"), DefaultValue(true), Category("杂项"), Browsable(true)]
        public bool ShowButtonPanel
        {
            get
            {
                return m_ShowButtonPanel;
            }
            set 
            { 
                panelButtons.Enabled = value;
                panelButtons.Visible = value;
                m_ShowButtonPanel = value;
            }
        }

        private void buttonResize_Click(object sender, EventArgs e)
        {
            SizeState = SizeState == EnumSizeState.MaxSize ? EnumSizeState.MinSize : EnumSizeState.MaxSize;
        }

        protected override void OnLoad(EventArgs e)
        {
            if (!DesignMode)
            {
                SizeState = EnumSizeState.MinSize;
            }

            base.OnLoad(e);
        }
    }
}
