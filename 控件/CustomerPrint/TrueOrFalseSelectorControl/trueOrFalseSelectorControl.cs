using System.ComponentModel;
using System.Windows.Forms;

namespace TrueOrFalseSelectorControl
{
    public partial class trueOrFalseSelectorControl : UserControl
    {
        public trueOrFalseSelectorControl()
        {
            InitializeComponent();
        }
        [Browsable(true)]
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                groupBox1.Text = base.Text;
            }
        }

        [Description("设置标题"),Category("我的分类"),Browsable(true)]
        public string 标题
        {
            get
            {
                return groupBox1.Text;
            }
            set
            {
                groupBox1.Text = value;
            }
        }

        [Description("设置值"),Category("我的分类")]
        public bool Value
        {
            get {
                return radioButtonTrue.Checked;
            }
            set
            {
                if (value)
                {
                    radioButtonTrue.Checked = true;
                }
                else
                {
                    radioButtonFalse.Checked = true;
                }
            }
        }
    }
}
