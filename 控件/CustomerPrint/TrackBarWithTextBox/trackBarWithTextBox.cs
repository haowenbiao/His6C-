using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace TrackBarWithTextBox
{
    public delegate void valueChangedHandle(object sender, EventArgs e);

    public partial class trackBarWithTextBox : UserControl
    {
        public event valueChangedHandle valueChanged;

        public trackBarWithTextBox()
        {
            InitializeComponent();
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                label1.Text = trackBar1.Value.ToString();

                //判断事件是否为空，事件接受方如果定义了事件的处理方法，则不为null
                //如果事件为空就触发事件，将导致一个空引用异常
                if (valueChanged != null)
                {
                    valueChanged(this, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        [Description("当前值")]//显示在属性设计视图中的描述
        [DefaultValue(0)]//给予初始值
        public int Value
        {
            get
            {
                return trackBar1.Value;
            }
            set
            {
                trackBar1.Value = value;
                label1.Text = value.ToString();
            }
        }

        [Description("最大值")]//显示在属性设计视图中的描述
        [DefaultValue(10)]//给予初始值
        public int Maximum
        {
            get
            {
                return trackBar1.Maximum;
            }
            set
            {
                trackBar1.Maximum = value;
            }
        }

        [Description("最小值")]//显示在属性设计视图中的描述
        [DefaultValue(0)]//给予初始值
        public int Minimum
        {
            get
            {
                return trackBar1.Minimum;
            }
            set
            {
                trackBar1.Minimum = value;
            }
        }
    }
}