using System;
using System.Data;
using System.Windows.Forms;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;
using ClassLibraryMedicineKind;

namespace MedicineKindAdjustPrice.DataList
{
    public partial class FormMedicineKindAdjustPriceRecords : FormDataListUseUseFpSpreadFromAbstract
    {
        /// <summary>
        /// valMedicineKindID等于0时，表示所有药品
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valMedicineKindID">valMedicineKindID等于0时，表示所有药品</param>
        public FormMedicineKindAdjustPriceRecords(ClassLoginInformation valLoginInformation, long valMedicineKindID)
            : base(valLoginInformation)
        {
            InitializeComponent();
            ToolStripControlHost toolStripControlHost = new ToolStripControlHost(comboBoxWithListBoxMedicineKinds)
                                                            {AutoSize = false};
            
            toolStripTmp.Items.Insert(0, toolStripControlHost);
            AddItemOfToolStripToToolStripSpecial(toolStripTmp);

            comboBoxWithListBoxMedicineKinds.ListBox.ValueMember = "ID";
            comboBoxWithListBoxMedicineKinds.ListBox.DisplayMember = "商品名称";
            comboBoxWithListBoxMedicineKinds.ListBox.DataSource = ClassMedicineKindPublic.LoadAllMedicineKindsWithAll(LoginInformation.ConnectionString);

            MedicineKindID = valMedicineKindID;
            LoadDataThread();
        }

        private long MedicineKindID
        {
            get
            {
                return (long)(comboBoxWithListBoxMedicineKinds.SelectedValue ?? 0L);
            }
            set
            {
                comboBoxWithListBoxMedicineKinds.SelectedValue = value;
            }
        }

        protected override string LoadSqlString
        {
            get
            {
                string tmpSQLString;
                if (MedicineKindID == 0)
                {
                    //加载所有
                    //(73)SELECT ID,药品商品名称,调整后单价,调价时间,调价会计期,备注,操作员 FROM dbo.YKGL_药品销售价格调整记录表_View ORDER BY 药品商品名称,ID
                    string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 73);
                    if (string.IsNullOrEmpty(tmpSQLString1))
                    {
                        return null;
                    }
                    tmpSQLString = tmpSQLString1;
                }
                else
                {

                    //(74)SELECT ID,药品商品名称,调整后单价,调价时间,调价会计期,备注,操作员 FROM dbo.YKGL_药品销售价格调整记录表_View WHERE YKGL_药品种类_ID = {0} ORDER BY ID
                    string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 74);
                    if (string.IsNullOrEmpty(tmpSQLString1))
                    {
                        return null;
                    }
                    tmpSQLString = string.Format(tmpSQLString1, MedicineKindID);
                }
                return tmpSQLString;
            }
        }

        private void comboBoxWithListBoxMedicineKinds_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable = comboBoxWithListBoxMedicineKinds.ListBox.DataSource as DataTable;
            string tmpString = string.Format("商品名称_拼音码 LIKE '{0}%' OR 商品名称 LIKE '{0}%' OR 通用名称_拼音码 LIKE '{0}%' OR 通用名称 LIKE '{0}%'", comboBoxWithListBoxMedicineKinds.Text.Trim());
            if (dataTable != null) dataTable.DefaultView.RowFilter = tmpString;
        }

        private void comboBoxWithListBoxMedicineKinds_AfterSelector(object sender, EventArgs e)
        {
            DataTable dataTable = comboBoxWithListBoxMedicineKinds.ListBox.DataSource as DataTable;
            if (dataTable != null) dataTable.DefaultView.RowFilter = "";
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBoxWithListBoxMedicineKinds.SelectedValue.ToString());
            LoadDataThread();
        }
    }
}
