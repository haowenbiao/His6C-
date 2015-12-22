using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using CustomerPrintClassLibrary;

namespace CustomerPrint
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            comboBox标签集合_水平对齐.DataSource = Enum.GetValues(typeof (enum水平对齐));
            comboBox标签集合_垂直对齐.DataSource = Enum.GetValues(typeof (enum垂直对齐));

            comboBox数据集合_对齐_水平对齐.DataSource = Enum.GetValues(typeof (enum水平对齐));
            comboBox数据集合_对齐_垂直对齐.DataSource = Enum.GetValues(typeof (enum垂直对齐));
        }

        //打开文件
        private void 打开_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                customerPrintControl1.Obj内容.DataPath = openFileDialog1.FileName;
                customerPrintControl1.Obj内容.LoadData();
            }
        }

        private void 保存_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                customerPrintControl1.Obj内容.SaveAs(saveFileDialog1.FileName);
            }
        }
        
        private void 关闭_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton放大_Click(object sender, EventArgs e)
        {
            customerPrintControl1.放大();
        }

        private void toolStripButton缩小_Click(object sender, EventArgs e)
        {
            customerPrintControl1.缩小();
        }

        #region 操作图形集合

        private void listBox图形集合_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox tmpListBox = (ListBox)sender;

            图形 tmp图形Obj = (图形)tmpListBox.SelectedItem;
            customerPrintControl1.SelectedItem = tmp图形Obj;
            customerPrintControl1.Refresh();
            if (tmp图形Obj != null)
            {
                textBox图形名称.Text = tmp图形Obj.名称;
                positionControl图形集合_位置.rectangle = tmp图形Obj.Obj位置.位置;
                numericUpDown图形_粗细.Value = tmp图形Obj.粗细;
                trueOrFalseSelectorControl图形集合.Value = tmp图形Obj.是否打印;
                radioButton图形集合_图形样式_直线.Checked = tmp图形Obj.类型 == enumShapeType.直线 ? true : false;
                radioButton图形集合_图形样式_矩形.Checked = tmp图形Obj.类型 == enumShapeType.矩形 ? true : false;
                radioButton图形集合_图形样式_椭圆.Checked = tmp图形Obj.类型 == enumShapeType.椭圆 ? true : false;

                dashStyleComboList图形_线条样式.SelectedIndex = (Byte)tmp图形Obj.样式;
                colorSelector图形集合_颜色.color = tmp图形Obj.Obj颜色.颜色;
            }
        }

        private void customerPrintControl1_ArrayListOf图形Changed()
        {
            listBox图形集合.DataSource = null;
            listBox图形集合.DataSource = customerPrintControl1.Obj内容.ObjArrayList图形;
        }

        #region 增加、修改、删除
        private void button图形集合_增加_Click(object sender, EventArgs e)
        {
            if (customerPrintControl1.Obj内容.XmlDocument.DocumentElement != null)
            {
                ListBox tmpListBox = listBox图形集合;

                string tmp名称 = textBox图形名称.Text;
                Rectangle tmp位置 = positionControl图形集合_位置.rectangle;
                int tmp粗细 = Convert.ToInt32(numericUpDown图形_粗细.Value);
                DashStyle tmp样式 = (DashStyle)Enum.Parse(typeof(DashStyle), dashStyleComboList图形_线条样式.SelectedItem.ToString());
                Color tmp颜色 = colorSelector图形集合_颜色.color;
                string tmp关键字 = Guid.NewGuid().ToString();
                enumShapeType tmp图形类型 = enumShapeType.直线;
                if (radioButton图形集合_图形样式_直线.Checked)
                    tmp图形类型 = enumShapeType.直线;
                if (radioButton图形集合_图形样式_矩形.Checked)
                    tmp图形类型 = enumShapeType.矩形;
                if (radioButton图形集合_图形样式_椭圆.Checked)
                    tmp图形类型 = enumShapeType.椭圆;
                bool tmp是否打印 = trueOrFalseSelectorControl图形集合.Value;
                图形 tmp图形Obj = new 图形(customerPrintControl1.Obj内容.XmlDocument, tmp名称, tmp关键字, tmp位置,tmp是否打印, tmp粗细, tmp样式, tmp图形类型, tmp颜色);
                customerPrintControl1.Obj内容.AddToArrayList图形(tmp图形Obj);
                tmpListBox.SelectedItem = tmp图形Obj;
                MessageBox.Show("添加成功！");
            }
        }
            
        private void button图形集合_修改_Click(object sender, EventArgs e)
        {
            ListBox tmpListBox = listBox图形集合;
            图形 tmp图形Obj = (图形)tmpListBox.SelectedItem;
            if (tmp图形Obj != null)
            {
                tmp图形Obj.名称=textBox图形名称.Text;
                tmp图形Obj.Obj位置.位置 = positionControl图形集合_位置.rectangle;
                tmp图形Obj.粗细 = Convert.ToInt32(numericUpDown图形_粗细.Value);
                tmp图形Obj.样式 =(DashStyle)Enum.Parse(typeof(DashStyle),dashStyleComboList图形_线条样式.SelectedItem.ToString());
                tmp图形Obj.Obj颜色.颜色 = colorSelector图形集合_颜色.color;
                if (radioButton图形集合_图形样式_直线.Checked)
                    tmp图形Obj.类型 = enumShapeType.直线;
                if (radioButton图形集合_图形样式_矩形.Checked)
                    tmp图形Obj.类型 = enumShapeType.矩形;
                if (radioButton图形集合_图形样式_椭圆.Checked)
                    tmp图形Obj.类型 = enumShapeType.椭圆;
                tmp图形Obj.是否打印 = trueOrFalseSelectorControl图形集合.Value;
            }
            customerPrintControl1_ArrayListOf图形Changed();
            customerPrintControl1.Refresh();
            MessageBox.Show("修改成功！");
        }

        private void button图形集合_删除_Click(object sender, EventArgs e)
        {
            ListBox tmpListBox = listBox图形集合;
            图形 tmp图形Obj = (图形)tmpListBox.SelectedItem;
            if ((tmp图形Obj != null))
            {
                customerPrintControl1.Obj内容.RemoveFromArrayList图形(tmp图形Obj);
                customerPrintControl1.Refresh();
                MessageBox.Show("删除成功！");
            }
        }
        #endregion

        #region 移动
        private void button图形集合_上_Click(object sender, EventArgs e)
        {
            图形 tmp图形Obj;
            ListBox tmpListBox = listBox图形集合;
            for (int i=0;i<tmpListBox.SelectedItems.Count;i++)
            {
                tmp图形Obj = (图形)tmpListBox.SelectedItems[i];
                if (tmp图形Obj != null)
                {
                    tmp图形Obj.Obj位置.向上移动(Convert.ToInt32(numericUpDown图形集合_移动步长.Value));
                    positionControl图形集合_位置.rectangle = tmp图形Obj.Obj位置.位置;
                    customerPrintControl1.Refresh();
                }
            }
        }

        private void button图形集合_下_Click(object sender, EventArgs e)
        {
            图形 tmp图形Obj;
            ListBox tmpListBox = listBox图形集合;
            for (int i = 0; i < tmpListBox.SelectedItems.Count; i++)
            {
                tmp图形Obj = (图形)tmpListBox.SelectedItems[i];
                if (tmp图形Obj != null)
                {
                    tmp图形Obj.Obj位置.向下移动(Convert.ToInt32(numericUpDown图形集合_移动步长.Value));
                    positionControl图形集合_位置.rectangle = tmp图形Obj.Obj位置.位置;
                    customerPrintControl1.Refresh();
                }
            }
        }

        private void button图形集合_左_Click(object sender, EventArgs e)
        {
            图形 tmp图形Obj;
            ListBox tmpListBox = listBox图形集合;
            for (int i = 0; i < tmpListBox.SelectedItems.Count; i++)
            {
                tmp图形Obj = (图形)tmpListBox.SelectedItems[i];
                if (tmp图形Obj != null)
                {
                    tmp图形Obj.Obj位置.向左移动(Convert.ToInt32(numericUpDown图形集合_移动步长.Value));
                    positionControl图形集合_位置.rectangle = tmp图形Obj.Obj位置.位置;
                    customerPrintControl1.Refresh();
                }
            }
        }

        private void button图形集合_右_Click(object sender, EventArgs e)
        {
            图形 tmp图形Obj;
            ListBox tmpListBox = listBox图形集合;
            for (int i = 0; i < tmpListBox.SelectedItems.Count; i++)
            {
                tmp图形Obj = (图形)tmpListBox.SelectedItems[i];
                if (tmp图形Obj != null)
                {
                    tmp图形Obj.Obj位置.向右移动(Convert.ToInt32(numericUpDown图形集合_移动步长.Value));
                    positionControl图形集合_位置.rectangle = tmp图形Obj.Obj位置.位置;
                    customerPrintControl1.Refresh();
                }
            }
        }
        #endregion

        #endregion

        #region 操作标签集合

        private Font m_Obj标签集合Font;

        private void listBox标签集合_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox tmpListBox = (ListBox)sender;

            标签 tmpObj标签 = (标签)tmpListBox.SelectedItem;
            customerPrintControl1.SelectedItem = tmpObj标签;
            customerPrintControl1.Refresh();
            if (tmpObj标签!=null)
            {
                textBox标签集合_名称.Text = tmpObj标签.名称;
                textBox标签集合_文本.Text = tmpObj标签.文本;

                trueOrFalseSelectorControl标签集合.Value = tmpObj标签.是否打印;

                positionControl标签集合_位置.rectangle = tmpObj标签.Obj位置.位置;

                comboBox标签集合_水平对齐.SelectedItem = tmpObj标签.Obj对齐.水平对齐;
                comboBox标签集合_垂直对齐.SelectedItem = tmpObj标签.Obj对齐.垂直对齐;

                colorSelector标签集合_颜色.color = tmpObj标签.Obj颜色.颜色;

                m_Obj标签集合Font = tmpObj标签.Obj字体.字体;

                pictureBox标签集合_字体.Refresh();
            }
        }

        private void customerPrintControl1_ArrayListOf标签Changed()
        {
            listBox标签集合.DataSource = null;
            listBox标签集合.DataSource = customerPrintControl1.Obj内容.ObjArrayList标签;
        }

        #region 字体操作

        //private void button标签集合_字体_Click(object sender, EventArgs e)
        //{
        //    标签 tmpOBJ标签 = (标签) listBox标签集合.SelectedItem;
        //    if (tmpOBJ标签!=null)
        //    {
        //        if (fontDialog1.ShowDialog(this)==System.Windows.Forms.DialogResult.OK)
        //        {
        //            m_Obj标签集合Font = fontDialog1.Font;
        //            pictureBox标签集合_字体.Refresh();
        //            customerPrintControl1.Refresh();
        //        }
        //    }
        //}
        private void pictureBox标签集合_字体_Click(object sender, EventArgs e)
        {
            标签 tmpOBJ标签 = (标签)listBox标签集合.SelectedItem;
            if (tmpOBJ标签 != null)
            {
                if (fontDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    m_Obj标签集合Font = fontDialog1.Font;
                    pictureBox标签集合_字体.Refresh();
                    customerPrintControl1.Refresh();
                }
            }
        }

        private void pictureBox标签集合_字体_Paint(object sender, PaintEventArgs e)
        {
            标签 tmpOBJ标签 = (标签)listBox标签集合.SelectedItem;
            PictureBox tmpPictureBox = (PictureBox) sender;
            if (tmpOBJ标签 != null)
            {
                
                SolidBrush tmpSolidBrush =new SolidBrush(tmpOBJ标签.Obj颜色.颜色);
                StringFormat tmpStringFormat=new StringFormat(StringFormatFlags.NoWrap);
                tmpStringFormat.LineAlignment = (StringAlignment)tmpOBJ标签.Obj对齐.垂直对齐;
                tmpStringFormat.Alignment = (StringAlignment) tmpOBJ标签.Obj对齐.水平对齐;

                e.Graphics.DrawString("字体", m_Obj标签集合Font, tmpSolidBrush, tmpPictureBox.ClientRectangle,tmpStringFormat);
                tmpSolidBrush.Dispose();
            }
        }

        #endregion

        #region 增加、修改、删除
        private void button标签集合_增加_Click(object sender, EventArgs e)
        {
            if (customerPrintControl1.Obj内容.XmlDocument.DocumentElement != null)
            {
                ListBox tmpListBox = listBox标签集合;

                string tmp名称 = textBox标签集合_名称.Text.Trim();
                string tmp文本 = textBox标签集合_文本.Text.Trim();
                string tmp关键字 = Guid.NewGuid().ToString();

                bool tmp是否打印 = trueOrFalseSelectorControl标签集合.Value;
                Rectangle tmp位置 = positionControl标签集合_位置.rectangle;
                Color tmp颜色 = colorSelector标签集合_颜色.color;
                enum水平对齐 tmp水平对齐 = (enum水平对齐) Enum.Parse(typeof (enum水平对齐), comboBox标签集合_水平对齐.SelectedItem.ToString());
                enum垂直对齐 tmp垂直对齐 = (enum垂直对齐) Enum.Parse(typeof (enum垂直对齐), comboBox标签集合_垂直对齐.SelectedItem.ToString());
                
                if (m_Obj标签集合Font==null)
                {
                    m_Obj标签集合Font=new Font("宋体",9);
                }
                标签 tmpObj标签 = new 标签(customerPrintControl1.Obj内容.XmlDocument, tmp名称, tmp关键字,tmp是否打印, tmp文本, tmp位置, m_Obj标签集合Font,tmp水平对齐,tmp垂直对齐,false, tmp颜色);
                customerPrintControl1.Obj内容.AddToArrayList标签(tmpObj标签);
                tmpListBox.SelectedItem = tmpObj标签;
                MessageBox.Show("添加成功！");
            }
        }

        private void button标签集合_修改_Click(object sender, EventArgs e)
        {
            ListBox tmpListBox = listBox标签集合;
            标签 tmp标签Obj = (标签)tmpListBox.SelectedItem;
            if (tmp标签Obj != null)
            {
                tmp标签Obj.名称=textBox标签集合_名称.Text;
                tmp标签Obj.是否打印 = trueOrFalseSelectorControl标签集合.Value;
                tmp标签Obj.Obj位置.位置 = positionControl标签集合_位置.rectangle;
                tmp标签Obj.Obj颜色.颜色 = colorSelector标签集合_颜色.color;
                tmp标签Obj.Obj对齐.水平对齐 = (enum水平对齐) Enum.Parse(typeof (enum水平对齐), comboBox标签集合_水平对齐.SelectedItem.ToString());
                tmp标签Obj.Obj对齐.垂直对齐 = (enum垂直对齐) Enum.Parse(typeof (enum垂直对齐), comboBox标签集合_垂直对齐.SelectedItem.ToString());
                tmp标签Obj.Obj字体.字体 = m_Obj标签集合Font;
            }
            customerPrintControl1_ArrayListOf标签Changed();
            customerPrintControl1.Refresh();
            MessageBox.Show("修改成功！");
        }

        private void button标签集合_删除_Click(object sender, EventArgs e)
        {
            ListBox tmpListBox = listBox标签集合;
            标签 tmpObj标签 = (标签)tmpListBox.SelectedItem;
            if ((tmpObj标签 != null))
            {
                customerPrintControl1.Obj内容.RemoveFromArrayList标签(tmpObj标签);
                customerPrintControl1.Refresh();
                MessageBox.Show("删除成功！");
            }
        }
        #endregion

        #region 移动
        private void button标签集合_上_Click(object sender, EventArgs e)
        {
            标签 tmpObj标签;
            ListBox tmpListBox = listBox标签集合;
            for (int i = 0; i < tmpListBox.SelectedItems.Count; i++)
            {
                tmpObj标签 = (标签)tmpListBox.SelectedItems[i];
                if (tmpObj标签 != null)
                {
                    tmpObj标签.Obj位置.向上移动(Convert.ToInt32(numericUpDown标签集合_移动步长.Value));
                    positionControl标签集合_位置.rectangle = tmpObj标签.Obj位置.位置;
                    customerPrintControl1.Refresh();
                }
            }
        }

        private void button标签集合_下_Click(object sender, EventArgs e)
        {
            标签 tmpObj标签;
            ListBox tmpListBox = listBox标签集合;
            for (int i = 0; i < tmpListBox.SelectedItems.Count; i++)
            {
                tmpObj标签 = (标签)tmpListBox.SelectedItems[i];
                if (tmpObj标签 != null)
                {
                    tmpObj标签.Obj位置.向下移动(Convert.ToInt32(numericUpDown标签集合_移动步长.Value));
                    positionControl标签集合_位置.rectangle = tmpObj标签.Obj位置.位置;
                    customerPrintControl1.Refresh();
                }
            }
        }

        private void button标签集合_左_Click(object sender, EventArgs e)
        {
            标签 tmpObj标签;
            ListBox tmpListBox = listBox标签集合;
            for (int i = 0; i < tmpListBox.SelectedItems.Count; i++)
            {
                tmpObj标签 = (标签)tmpListBox.SelectedItems[i];
                if (tmpObj标签 != null)
                {
                    tmpObj标签.Obj位置.向左移动(Convert.ToInt32(numericUpDown标签集合_移动步长.Value));
                    positionControl标签集合_位置.rectangle = tmpObj标签.Obj位置.位置;
                    customerPrintControl1.Refresh();
                }
            }
        }

        private void button标签集合_右_Click(object sender, EventArgs e)
        {
            标签 tmpObj标签;
            ListBox tmpListBox = listBox标签集合;
            for (int i = 0; i < tmpListBox.SelectedItems.Count; i++)
            {
                tmpObj标签 = (标签)tmpListBox.SelectedItems[i];
                if (tmpObj标签 != null)
                {
                    tmpObj标签.Obj位置.向右移动(Convert.ToInt32(numericUpDown标签集合_移动步长.Value));
                    positionControl标签集合_位置.rectangle = tmpObj标签.Obj位置.位置;
                    customerPrintControl1.Refresh();
                }
            }
        }
        #endregion

        #endregion

        #region 操作数据集合

        private Font m_Obj数据集合Font;

        private void listBox数据集合_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox tmpListBox = (ListBox)sender;
            数据 tmpObj数据 = (数据)tmpListBox.SelectedItem;

            customerPrintControl1.SelectedItem = tmpObj数据;
            customerPrintControl1.Refresh();
            if (tmpObj数据 != null)
            {
                textBox数据集合.Text = tmpObj数据.名称;

                trueOrFalseSelectorControl数据集合.Value = tmpObj数据.是否打印;

                positionControl数据集合.rectangle = tmpObj数据.Obj位置.位置;
                
                comboBox数据集合_对齐_水平对齐.SelectedItem = tmpObj数据.Obj对齐.水平对齐;
                comboBox数据集合_对齐_垂直对齐.SelectedItem = tmpObj数据.Obj对齐.垂直对齐;

                colorSelector数据集合.color = tmpObj数据.Obj颜色.颜色;

                if (tmpObj数据.Obj数据来源.数据来源类型==enum数据来源类型.数值)
                {
                    radioButton数据集合_数据类型_数值.Checked = true;
                }
                else
                {
                    radioButton数据集合_数据类型_文本.Checked = true;
                }

                m_Obj数据集合Font = tmpObj数据.Obj字体.字体;

                pictureBox数据集合_字体.Refresh();
            }
        }
        
        private void customerPrintControl1_ArrayListOf数据Changed()
        {
            listBox数据集合.DataSource = null;
            listBox数据集合.DataSource = customerPrintControl1.Obj内容.ObjArrayList数据;
        }

        #region 字体操作

        private void pictureBoxtBox数据集合_字体_Click(object sender, EventArgs e)
        {
            数据 tmpOBJ数据 = (数据)listBox数据集合.SelectedItem;
            if (tmpOBJ数据 != null)
            {
                if (fontDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    m_Obj数据集合Font = fontDialog1.Font;
                    pictureBox数据集合_字体.Refresh();
                    customerPrintControl1.Refresh();
                }
            }
        }
        private void pictureBoxtBox数据集合_字体_Paint(object sender, PaintEventArgs e)
        {
            数据 tmpOBJ数据 = (数据)listBox数据集合.SelectedItem;
            PictureBox tmpPictureBox = (PictureBox)sender;
            if (tmpOBJ数据 != null)
            {

                SolidBrush tmpSolidBrush = new SolidBrush(tmpOBJ数据.Obj颜色.颜色);
                StringFormat tmpStringFormat = new StringFormat(StringFormatFlags.NoWrap);
                tmpStringFormat.LineAlignment = (StringAlignment)tmpOBJ数据.Obj对齐.垂直对齐;
                tmpStringFormat.Alignment = (StringAlignment)tmpOBJ数据.Obj对齐.水平对齐;

                e.Graphics.DrawString("数据字体", m_Obj数据集合Font, tmpSolidBrush, tmpPictureBox.ClientRectangle, tmpStringFormat);
                tmpSolidBrush.Dispose();
            }
        }


        #endregion

        #region 增加、修改、删除

        private void button数据集合_增加_Click(object sender, EventArgs e)
        {
            if (customerPrintControl1.Obj内容.XmlDocument.DocumentElement != null)
            {
                ListBox tmpListBox = listBox数据集合;

                string tmp名称 = textBox数据集合.Text.Trim();
                string tmp关键字 = Guid.NewGuid().ToString();

                bool tmp数据_是否打印 = trueOrFalseSelectorControl数据集合.Value;
                Rectangle tmp数据_位置 = positionControl数据集合.rectangle;
                Color tmp数据_颜色 = colorSelector数据集合.color;

                enum水平对齐 tmp数据_水平对齐 = (enum水平对齐)Enum.Parse(typeof(enum水平对齐), comboBox数据集合_对齐_水平对齐.SelectedItem.ToString());
                enum垂直对齐 tmp数据_垂直对齐 = (enum垂直对齐)Enum.Parse(typeof(enum垂直对齐), comboBox数据集合_对齐_垂直对齐.SelectedItem.ToString());
                if (m_Obj数据集合Font == null)
                {
                    m_Obj标签集合Font = new Font("宋体", 9);
                }
                enum数据来源类型 tmp数据量来源类型 = radioButton数据集合_数据类型_数值.Checked ? enum数据来源类型.数值 : enum数据来源类型.文本;

                数据 tmpObj数据 =
                    new 数据(customerPrintControl1.Obj内容.XmlDocument, tmp名称, tmp关键字, tmp数据_是否打印, tmp数据_位置, tmp数据_颜色,
                           m_Obj数据集合Font, tmp数据_水平对齐, tmp数据_垂直对齐, false, tmp数据量来源类型);

                customerPrintControl1.Obj内容.AddToArrayList数据(tmpObj数据);
                tmpListBox.SelectedItem = tmpObj数据;
                MessageBox.Show("添加成功！");
            }
        }

        private void button数据集合_修改_Click(object sender, EventArgs e)
        {
            ListBox tmpListBox = listBox数据集合;
            数据 tmp数据Obj = (数据)tmpListBox.SelectedItem;
            if (tmp数据Obj != null)
            {

                string tmp名称 = textBox数据集合.Text.Trim();

                bool tmp数据_是否打印 = trueOrFalseSelectorControl数据集合.Value;
                Rectangle tmp数据_位置 = positionControl数据集合.rectangle;
                Color tmp数据_颜色 = colorSelector数据集合.color;

                enum水平对齐 tmp数据_水平对齐 = (enum水平对齐)Enum.Parse(typeof(enum水平对齐), comboBox数据集合_对齐_水平对齐.SelectedItem.ToString());
                enum垂直对齐 tmp数据_垂直对齐 = (enum垂直对齐)Enum.Parse(typeof(enum垂直对齐), comboBox数据集合_对齐_垂直对齐.SelectedItem.ToString());
                if (m_Obj数据集合Font == null)
                {
                    m_Obj标签集合Font = new Font("宋体", 9);
                }
                enum数据来源类型 tmp数据量来源类型 = radioButton数据集合_数据类型_数值.Checked ? enum数据来源类型.数值 : enum数据来源类型.文本;
                tmp数据Obj.名称 = tmp名称;
                tmp数据Obj.是否打印 = tmp数据_是否打印;
                tmp数据Obj.Obj位置.位置 = tmp数据_位置;
                tmp数据Obj.Obj颜色.颜色 = tmp数据_颜色;
                tmp数据Obj.Obj字体.字体 = m_Obj数据集合Font;
                tmp数据Obj.Obj对齐.水平对齐 = tmp数据_水平对齐;
                tmp数据Obj.Obj对齐.垂直对齐 = tmp数据_垂直对齐;
                tmp数据Obj.Obj数据来源.数据来源类型 = tmp数据量来源类型;
            }
            customerPrintControl1_ArrayListOf数据Changed();
            customerPrintControl1.Refresh();
            MessageBox.Show("修改成功！");
        }
 
        private void button数据集合_删除_Click(object sender, EventArgs e)
        {
            ListBox tmpListBox = listBox数据集合;
            数据 tmpObj数据 = (数据)tmpListBox.SelectedItem;
            if ((tmpObj数据 != null))
            {
                customerPrintControl1.Obj内容.RemoveFromArrayList数据(tmpObj数据);
                customerPrintControl1.Refresh();
                MessageBox.Show("删除成功！");
            }
        }
       
        #endregion

        #region 移动

        private void button数据集合_移动_上_Click(object sender, EventArgs e)
        {
            数据 tmpObj数据;
            ListBox tmpListBox = listBox数据集合;
            for (int i = 0; i < tmpListBox.SelectedItems.Count; i++)
            {
                tmpObj数据 = (数据)tmpListBox.SelectedItems[i];
                if (tmpObj数据 != null)
                {
                    tmpObj数据.Obj位置.向上移动(Convert.ToInt32(numericUpDown数据集合_移动步长.Value));
                    positionControl数据集合.rectangle = tmpObj数据.Obj位置.位置;
                    customerPrintControl1.Refresh();
                }
            }
        }

        private void button数据集合_移动_下_Click(object sender, EventArgs e)
        {
            数据 tmpObj数据;
            ListBox tmpListBox = listBox数据集合;
            for (int i = 0; i < tmpListBox.SelectedItems.Count; i++)
            {
                tmpObj数据 = (数据)tmpListBox.SelectedItems[i];
                if (tmpObj数据 != null)
                {
                    tmpObj数据.Obj位置.向下移动(Convert.ToInt32(numericUpDown数据集合_移动步长.Value));
                    positionControl数据集合.rectangle = tmpObj数据.Obj位置.位置;
                    customerPrintControl1.Refresh();
                }
            }
        }

        private void button数据集合_移动_左_Click(object sender, EventArgs e)
        {
            数据 tmpObj数据;
            ListBox tmpListBox = listBox数据集合;
            for (int i = 0; i < tmpListBox.SelectedItems.Count; i++)
            {
                tmpObj数据 = (数据)tmpListBox.SelectedItems[i];
                if (tmpObj数据 != null)
                {
                    tmpObj数据.Obj位置.向左移动(Convert.ToInt32(numericUpDown数据集合_移动步长.Value));
                    positionControl数据集合.rectangle = tmpObj数据.Obj位置.位置;
                    customerPrintControl1.Refresh();
                }
            }
        }

        private void button数据集合_移动_右_Click(object sender, EventArgs e)
        {
            数据 tmpObj数据;
            ListBox tmpListBox = listBox数据集合;
            for (int i = 0; i < tmpListBox.SelectedItems.Count; i++)
            {
                tmpObj数据 = (数据)tmpListBox.SelectedItems[i];
                if (tmpObj数据 != null)
                {
                    tmpObj数据.Obj位置.向右移动(Convert.ToInt32(numericUpDown数据集合_移动步长.Value));
                    positionControl数据集合.rectangle = tmpObj数据.Obj位置.位置;
                    customerPrintControl1.Refresh();
                }
            }
        }

        #endregion
        #endregion

        private void 显示为名称ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem显示为名称.Checked = !ToolStripMenuItem显示为名称.Checked;
            customerPrintControl1.显示为名称 = ToolStripMenuItem显示为名称.Checked;
            customerPrintControl1.Refresh();
        }

        private void toolStripLabel打印_Click(object sender, EventArgs e)
        {
            customerPrintControl1.打印();
        }

    }
}