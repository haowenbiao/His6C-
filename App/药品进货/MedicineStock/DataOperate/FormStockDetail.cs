using System;
using System.Windows.Forms;
using ClassLibraryAbstractDataInformation;
using ClassLibraryEventArgs.EventArgsOfRecord;
using ClassLibraryLoginInformation;
using ClassLibraryMedicineKind;
using ClassLibraryMedicineProductionBatch;
using ClassLibraryMedicineStock;
using ClassLibraryQuantityUnit;
using CustomForm;

namespace MedicineStock.DataOperate
{
    //public partial class FormStockDetail : FormCustomListItemAdd_Design
    public partial class FormStockDetail : FormCustomListItemAdd<ClassMedicineStockListItem>
    {
        public FormStockDetail(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation)
        {
            InitializeComponent();

            #region 初始化属性

            medicineKindSelectControl1.ConnectionSqlString = LoginInformation.ConnectionString;
            medicineBatchControl1.LoginInformation = LoginInformation;

            #endregion
        }

        private void medicineKindSelectControl1_SelectedValueChanged(object sender, EventArgs e)
        {
            long tmpMedicineKindID = medicineKindSelectControl1.ID;
            medicineBatchControl1.MedicineKindID = tmpMedicineKindID;

            //加载药品信息
            if (tmpMedicineKindID == 0)
            {
                ListItem.药品商品名称 = "";
                ListItem.药品通用名称 = "";
                ListItem.计量单位 = "";
                return;
            }
            ClassMedicineKindProperties tmpMedicineKindProperties = new ClassMedicineKindProperties { ID = tmpMedicineKindID };
            ClassDataLoader tmpMedicineKindPropertiesdataLoader = new ClassDataLoader(LoginInformation, tmpMedicineKindProperties);
            if (tmpMedicineKindPropertiesdataLoader.execute())
            {
                ListItem.药品商品名称 = tmpMedicineKindProperties.MedicineKindPropertiesBasis.商品名称;
                ListItem.药品通用名称 = tmpMedicineKindProperties.MedicineKindPropertiesBasis.通用名称;
            }

            //加载计量单位信息
            if (tmpMedicineKindProperties.MedicineKindPropertiesBasis.YKGL_计量单位_ID == 0) return;
            ClassQuantityUnitProperties tmpQuantityUnitProperties = new ClassQuantityUnitProperties
                                                                        {
                                                                            ID =
                                                                                tmpMedicineKindProperties.
                                                                                MedicineKindPropertiesBasis.YKGL_计量单位_ID
                                                                        };
            ClassDataLoader tmpQuantityUnitPropertiesLoader = new ClassDataLoader(LoginInformation, tmpQuantityUnitProperties);
            if (tmpQuantityUnitPropertiesLoader.execute())
            {
                ListItem.计量单位 = tmpQuantityUnitProperties.名称;
            }
            bindingSourceListItem.ResetBindings(false);
        }

        protected override void buttonOK_Click(object sender, EventArgs e)
        {
            #region 检查数据完整性
            if (medicineBatchControl1.ID <= 0)
            {
                medicineBatchControl1.Add();
            }
            if (medicineBatchControl1.ID <= 0)
            {
                MessageBox.Show(@"请设置生产批号！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                medicineBatchControl1.Focus();
                return;
            }
            if (ListItem.数量 < 1)
            {
                MessageBox.Show(@"进货数量必须大于等于“1”，请重新输入进货数量！",@"提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                numberTextBox进货数量.Focus();
                return;
            }
            if (ListItem.单价 < 0)
            {
                MessageBox.Show(@"进货单价不能为负，请重新输入进货单价！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currencyTextBox进货单价.Focus();
                return;
            }
            if (ListItem.单价 == 0)
            {
                if (MessageBox.Show(@"进货单价等于“零”元，是否确认正确？", @"提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    currencyTextBox进货单价.Focus();
                    return;
                }
            }
            #endregion

            bindingSourceListItem.EndEdit();
            string tmpMedicineProductionBatchName =
                ClassLibraryMedicineProductionBatchPublic.GetMedicineProductionBatchName(LoginInformation,
                                                                                         ListItem.
                                                                                             YKGL_药品生产批号_ID);
            ListItem.生产批号 = tmpMedicineProductionBatchName;
            EventArgsOfRecordDetail EventArgsOfMedicineStockListItem = new EventArgsOfRecordDetail(bindingSourceListItem.DataSource);
            OnListItemAdded(EventArgsOfMedicineStockListItem);

            //if (MessageBox.Show("Will Save!" + MedicineStockListItem.YKGL_药品生产批号_ID + Environment.NewLine + "是否继续增加进货明细？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //{
            //    Close();
            //}
            if (MessageBox.Show(@"是否继续增加进货明细？", @"提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Close();
            }


            ClassMedicineStockListItem tmpMedicineStockListItem = new ClassMedicineStockListItem();
            ListItem = tmpMedicineStockListItem;
            bindingSourceListItem.DataSource = tmpMedicineStockListItem;

            medicineKindSelectControl1.ClearResult();
            medicineBatchControl1.ClearResult();
            //ListItem.YKGL_药品生产批号_ID = 0L;
            //ListItem.备注 = "";
            //ListItem.单价 = 0.00M;
            //ListItem.数量 = 0L;
            //ListItem.计量单位 = "";
            //ListItem.生产批号 = "";
            //ListItem.药品商品名称 = "";
            //ListItem.药品通用名称 = "";

            bindingSourceListItem.ResetBindings(true);
            medicineKindSelectControl1.Focus();
        }

        protected void control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        public override void BindingData()
        {
            textBox计量单位.DataBindings.Add(new Binding("Text", bindingSourceListItem, "计量单位", false));
            medicineBatchControl1.DataBindings.Add(new Binding("ID", bindingSourceListItem, "YKGL_药品生产批号_ID", false));
            numberTextBox进货数量.DataBindings.Add(new Binding("Value", bindingSourceListItem, "数量", false));
            currencyTextBox进货单价.DataBindings.Add(new Binding("Value", bindingSourceListItem, "单价", false));
        }
    }
}
