using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomTextBox
{
    public partial class FormWithDataGridView : Form
    {
        public FormWithDataGridView()
        {
            InitializeComponent();
            DataGridView.TopLeftHeaderCell.Value = "Ctrl+";
        }

        #region 属性

        public DataGridView DataGridView
        {
            get
            {
                return dataGridView1;
            }
        }

        public string HelpText1
        {
            get
            {
                return labelHeplText1.Text;
            }
            set
            {
                labelHeplText1.Text = value;
            }
        }

        public Color HelpText1ForeColor
        {
            get
            {
                return labelHeplText1.ForeColor;
            }
            set
            {
                labelHeplText1.ForeColor = value;
            }
        }

        public string HelpText2
        {
            get
            {
                return labelHelpText2.Text;
            }
            set
            {
                labelHelpText2.Text = value;
            }
        }

        public Color HelpText2ForeColor
        {
            get
            {
                return labelHelpText2.ForeColor;
            }
            set
            {
                labelHelpText2.ForeColor = value;
            }
        }

        public BindingManagerBase BindingManagerBase
        {
            get
            {
                if (DataGridView.DataSource==null)
                {
                    return null;
                }
                return BindingContext[DataGridView.DataSource];
            }
        }

        #endregion

        #region 事件

        public event EventHandler DropDownClose;

        private void OnDropDownClose(EventArgs e)
        {
            EventHandler Handler = DropDownClose;
            if (Handler != null) Handler(this, e);
        }
        
        #endregion

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //只给前10个设置快捷键
            DataGridView tmpDataGridView = sender as DataGridView;
            if (tmpDataGridView==null) return;
            if (e.RowIndex > 9) return;
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                                                e.RowBounds.Location.Y,
                                                tmpDataGridView.RowHeadersWidth,
                                                e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, e.RowIndex.ToString(),
                                  tmpDataGridView.RowHeadersDefaultCellStyle.Font,
                                  rectangle,
                                  tmpDataGridView.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            OnDropDownClose(e);
        }
    }
}