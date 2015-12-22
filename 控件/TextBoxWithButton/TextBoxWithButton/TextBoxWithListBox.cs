using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TextBoxWithListBox
{
    public partial class TextBoxWithListBox : TextBox
    {
        public TextBoxWithListBox()
        {
            InitializeComponent();

            toolStripControlHost = new ToolStripControlHost(listBox);
            toolStripControlHost.AutoSize = false;
            toolStripDropDown = new ToolStripDropDown { AutoClose = false};
            toolStripDropDown.Items.Add(toolStripControlHost);
            toolStripDropDown.Opened += toolStripDropDown_Opened;
            toolStripDropDown.Closed += toolStripDropDown_Closed;
            //DataGridViewHost.Width = DropDown.Width;
            //DataGridViewHost.Height = DropDown.Height;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (listBox.SelectedIndex < listBox.Items.Count - 1)
                {
                    listBox.SelectedIndex += 1;
                }
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (listBox.SelectedIndex > 0)
                {
                    listBox.SelectedIndex -= 1;
                }
                e.Handled = true;
            }

            base.OnKeyDown(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Text = listBox.Text;
                toolStripDropDown.Close();
            }
            base.OnKeyUp(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (!toolStripDropDown.Visible)
            {
                ShowDropDown();
            }
            base.OnTextChanged(e);
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

        private ToolStripControlHost toolStripControlHost;
        private ToolStripDropDown toolStripDropDown;

        private void ShowDropDown()
        {
            if (toolStripDropDown!=null)
            {
                toolStripDropDown.Show(this, 0, Height);
            }
        }

        private void buttonDropDown_Click(object sender, EventArgs e)
        {
            if (toolStripDropDown.Visible)
            {
                toolStripDropDown.Close();
            }
            else
            {
                ShowDropDown();
            }
        }

        private void listBox_MouseClick(object sender, MouseEventArgs e)
        {
            Text = listBox.Text;
            toolStripDropDown.Close();
        }

        private void toolStripDropDown_Opened(Object sender, EventArgs e)
        {
            buttonDropDown.Text = "∧";
        }

        private void toolStripDropDown_Closed(Object sender, EventArgs e)
        {
            buttonDropDown.Text = "∨";
        }

        #region 属性

        [Description("数据源。"), Category("数据"), Browsable(true)]
        public object DataSource
        {
            get
            {
                return listBox.DataSource;
            }
            set
            {
                listBox.DataSource = value;
            }
        }

        [Description("项的显示属性。"), Category("数据"), Browsable(true)]
        public string DisplayMember
        {
            get
            {
                return listBox.DisplayMember;
            }
            set
            {
                listBox.DisplayMember = value;
            }
        }

        [Description("项的实际值。"), Category("数据"), Browsable(true)]
        public string ValueMember
        {
            get
            {
                return listBox.ValueMember;
            }
            set
            {
                listBox.ValueMember = value;
            }
        }

        [Description("列表框的项。"), Category("数据"), Browsable(true)]
        public ListBox.ObjectCollection Items
        {
            get
            {
                return listBox.Items;
            }
        }

        [Browsable(false)]
        public int SelectedIndex
        {
            get
            {
                return listBox.SelectedIndex;
            }
        }

        [Browsable(false)]
        public object SelectedItem
        {
            get
            {
                return listBox.SelectedItem;
            }
        }

        [Browsable(false)]
        public object SelectedValue
        {
            get
            {
                return listBox.SelectedValue;
            }
        }

        [Browsable(false)]
        public override string SelectedText
        {
            get
            {
                return listBox.Text;
            }
        }

        #endregion
    }
}
