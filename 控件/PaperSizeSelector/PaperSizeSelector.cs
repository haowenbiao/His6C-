using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing.Printing;
using FarPoint.Win.Input;

namespace PaperSizeSelector
{
    public partial class PaperSizeSelector : UserControl
    {
        public PaperSizeSelector()
        {
            InitializeComponent();
            using (PrintDocument pd = new PrintDocument())
            {
                //string tmpDefaltPaperSizeName = pd.PrinterSettings.DefaultPageSettings.PaperSize.PaperName;
                PaperSize defaltPaperSize = null;
                List<PaperSize> PaperSizeList = new List<PaperSize>();
                foreach (PaperSize p in pd.PrinterSettings.PaperSizes)
                {
                    if (p.Height == pd.PrinterSettings.DefaultPageSettings.PaperSize.Height && p.Width == pd.PrinterSettings.DefaultPageSettings.PaperSize.Width)
                    {
                        if (defaltPaperSize == null)
                        {
                            defaltPaperSize = p;
                        }
                    }
                    PaperSizeList.Add(p);
                }
                PaperSize CustomPaperSize = new PaperSize("自定义纸张", 100, 100);
                PaperSizeList.Add(CustomPaperSize);
                comboBox1.DataSource = PaperSizeList;
                comboBox1.DisplayMember = "PaperName";
                if (defaltPaperSize != null)
                {
                    comboBox1.SelectedItem = defaltPaperSize;
                }
                //bindingData();
            }
        }

        public PaperSize Value
        {
            get
            {
                PaperSize p = comboBox1.SelectedItem as PaperSize;
                return p;
            }
            set
            {
                searchPaperSize(value);
            }
        }

        private void searchPaperSize(PaperSize valPaperSize)
        {
            List<PaperSize> PaperSizeList = comboBox1.DataSource as List<PaperSize>;
            if (PaperSizeList != null)
            {
                PaperSize tmpPaperSize = null;
                foreach (PaperSize p in PaperSizeList)
                {
                    if (p.Height == valPaperSize.Height && p.Width == valPaperSize.Width)
                    {
                        tmpPaperSize = p;
                        break;
                    }
                }
                if (tmpPaperSize==null)
                {
                    tmpPaperSize = comboBox1.Items[comboBox1.Items.Count - 1] as PaperSize;
                    if (tmpPaperSize != null)
                    {
                        tmpPaperSize.Height = valPaperSize.Height;
                        tmpPaperSize.Width = valPaperSize.Width;
                    }
                }
                comboBox1.SelectedItem = tmpPaperSize;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaperSize tmpPaperSize = (PaperSize) comboBox1.SelectedItem;
            if (comboBox1.SelectedIndex == comboBox1.Items.Count - 1)
            {
                fpIntegerWidth.Enabled = true;
                fpIntegerHeight.Enabled = true;
            }
            else
            {
                fpIntegerWidth.Enabled = false;
                fpIntegerHeight.Enabled = false;
            }
            fpIntegerHeight.Text =
                    (PrinterUnitConvert.Convert(tmpPaperSize.Height, PrinterUnit.Display,
                                                PrinterUnit.HundredthsOfAMillimeter)/100.0).ToString();
            fpIntegerWidth.Text =
                    (PrinterUnitConvert.Convert(tmpPaperSize.Width, PrinterUnit.Display,
                                                PrinterUnit.HundredthsOfAMillimeter)/100.0).ToString();
        }

        private void ControlOnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
            base.OnKeyDown(e);
        }

        private void fpIntegerWidth_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == comboBox1.Items.Count - 1)
            {
                PaperSize tmpPaperSize = comboBox1.SelectedItem as PaperSize;
                double d = 100.0*(int) ((FpInteger) sender).Value;
                if (tmpPaperSize != null)
                    tmpPaperSize.Width =
                        (int) (PrinterUnitConvert.Convert(d, PrinterUnit.HundredthsOfAMillimeter, PrinterUnit.Display));
            }
        }

        private void fpIntegerHeight_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == comboBox1.Items.Count - 1)
            {
                PaperSize tmpPaperSize = comboBox1.SelectedItem as PaperSize;
                double d = 100.0*(int) ((FpInteger) sender).Value;
                if (tmpPaperSize != null)
                    tmpPaperSize.Height =
                        (int) PrinterUnitConvert.Convert(d, PrinterUnit.HundredthsOfAMillimeter, PrinterUnit.Display);
            }
        }
    }
}
