using System;
using ClassLibraryCostItemAdjustPrice;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;

namespace CostItemAdjustPrice.DataList
{
    public partial class FormCostItemAdjustPrice : FormDataListUseUseFpSpreadFromAbstract
    {
        private long _CostItemID;


        public FormCostItemAdjustPrice(ClassLoginInformation valLoginInformation,long valCostItemID)
            : base(valLoginInformation)
        {
            InitializeComponent();
            AddItemOfToolStripToToolStripSpecial(toolStripTmp);

            if (toolStripComboBoxCostItems.ComboBox != null)
            {
                toolStripComboBoxCostItems.ComboBox.ValueMember = "ID";
                toolStripComboBoxCostItems.ComboBox.DisplayMember = "收费项目";
                toolStripComboBoxCostItems.ComboBox.DataSource =
                    ClassCostItemAdjustPricePublic.LoadAllCostItem(LoginInformation.ConnectionString);
            }

            CostItemID = valCostItemID;
            LoadDataThread();
        }

        private long CostItemID
        {
            get
            {
                return _CostItemID;
            }
            set
            {
                if (toolStripComboBoxCostItems.ComboBox != null)
                {
                    try
                    {
                        toolStripComboBoxCostItems.ComboBox.SelectedValue = value;
                    }
                    catch
                    {
                        return;
                    }
                    
                }
                _CostItemID = value;
            }
        }

        protected override string LoadSqlString
        {
            get
            {
                string tmpSQLString;
                if (CostItemID == 0)
                {
                    //加载所有
                    //(62)SELECT ID,收费项目,调整后价格,调价日期,调价会计期,备注,操作员 FROM dbo.P_收费项目价格调整记录表_View
                    string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 62);
                    if (string.IsNullOrEmpty(tmpSQLString1))
                    {
                        return null;
                    }
                    tmpSQLString = tmpSQLString1;
                }
                else
                {

                    //(63)SELECT ID,收费项目,调整后价格,调价日期,调价会计期,备注,操作员 FROM dbo.P_收费项目价格调整记录表_View WHERE P_收费项目_ID = {0}
                    string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 63);
                    if (string.IsNullOrEmpty(tmpSQLString1))
                    {
                        return null;
                    }
                    tmpSQLString = string.Format(tmpSQLString1, CostItemID);
                }
                return tmpSQLString;
            }
        }

        private void toolStripComboBoxCostItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBoxCostItems.ComboBox != null)
                CostItemID = (long)toolStripComboBoxCostItems.ComboBox.SelectedValue;
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            LoadDataThread();
        }
    }
}
