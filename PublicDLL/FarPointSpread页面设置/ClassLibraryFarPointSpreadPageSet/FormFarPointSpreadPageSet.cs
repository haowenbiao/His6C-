using System;
using System.Windows.Forms;

namespace ClassLibraryFarPointSpreadPageSet
{
    public partial class FormFarPointSpreadPageSet : Form
    {
        private readonly ClassFarPointSpreadPageSet FarPointSpreadPageSet;
        public FormFarPointSpreadPageSet(string valStringOfXmlNode)
        {
            InitializeComponent();
	    //获得当前文件夹AppDomain.CurrentDomain.BaseDirectory
            FarPointSpreadPageSet =
                new ClassFarPointSpreadPageSet("FarPointSpreadPageSet.xml", valStringOfXmlNode);

            trueOrFalseSelectorControlShowBorder.DataBindings.Add("Value", FarPointSpreadPageSet, "ShowBorder");
            trueOrFalseSelectorControlShowColor.DataBindings.Add("Value", FarPointSpreadPageSet, "ShowColor");
            trueOrFalseSelectorControlShowGrid.DataBindings.Add("Value", FarPointSpreadPageSet, "ShowGrid");
            trueOrFalseSelectorControlShowShadow.DataBindings.Add("Value", FarPointSpreadPageSet, "ShowShadows");

            printHeaderSelectorColumHead.DataBindings.Add("Value", FarPointSpreadPageSet, "ShowColumnHeader");
            printHeaderSelectorRowHead.DataBindings.Add("Value", FarPointSpreadPageSet, "ShowRowHeader");
            
            paperSizeSelector1.DataBindings.Add("Value", FarPointSpreadPageSet, "PaperSize");
            paperMarginSetor1.DataBindings.Add("Value", FarPointSpreadPageSet, "Margin");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            FarPointSpreadPageSet.save();
            Close();
        }
    }
}
