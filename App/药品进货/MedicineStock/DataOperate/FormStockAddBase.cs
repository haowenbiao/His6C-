using System;
using System.Windows.Forms;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryEventArgs.EventArgsOfRecord;
using ClassLibraryLoginInformation;
using ClassLibraryMedicineStock;
using CustomForm;

namespace MedicineStock.DataOperate
{
    public partial class FormStockAddBase : FormCustomSaved<ClassMedicineStockProperties>
    {
        public FormStockAddBase()
        {
            InitializeComponent();
        }

        protected FormStockAddBase(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation, 21)
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }

            medicineStoreHouseSelector1.ConnectionSqlString = LoginInformation.ConnectionString;
            supplierSelectorComboBoxWithDataGridView1.ConnectionSqlString = LoginInformation.ConnectionString;
            workerSelectorComboBoxWithDataGridView1.ConnectionSqlString = LoginInformation.ConnectionString;
            ClassMedicineStockProperties tmpMedicineStockProperties = Data as ClassMedicineStockProperties;
            if (tmpMedicineStockProperties==null)
            {
                //SetButtonOKEnableAttribute(false);
                HelpText = "未知错误！";
                return;
            }
            tmpMedicineStockProperties.进货单编号 = ClassMedicineStockPublic.GetStockNumber(LoginInformation.ConnectionString);

            classMedicineStockPropertiesBindingSource.DataSource = tmpMedicineStockProperties;
            medicineStockListBindingSource.DataSource = tmpMedicineStockProperties.MedicineStockList;

            Data = tmpMedicineStockProperties; 

            base.OnLoad(e);
        }

        #region 按钮动作

        protected sealed override void control_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.control_KeyPress(sender, e);
        }

        void f_MedicineStockListItemAdded(object sender, EventArgsOfRecordDetail e)
        {
            ClassMedicineStockListItem tmpMedicineStockListItem = e.DetailItem as ClassMedicineStockListItem;
            if (tmpMedicineStockListItem == null) return;
            bool tmpExitInMedicineStockList = ExitInMedicineStockList(tmpMedicineStockListItem.YKGL_药品生产批号_ID);
            if (tmpExitInMedicineStockList)
            {
                MessageBox.Show(@"该生产批号已存在于药品进货明细中，不能再次录入该生产批号的药品！",@"提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            ClassMedicineStockProperties MedicineStockProperties =
                classMedicineStockPropertiesBindingSource.DataSource as ClassMedicineStockProperties;
            if (MedicineStockProperties != null)
            {
                MedicineStockProperties.MedicineStockList.Add(tmpMedicineStockListItem);
                medicineStockListBindingSource.ResetBindings(false);
                classMedicineStockPropertiesBindingSource.ResetBindings(false);
            }
        }

        //检查是否已经在药品进货明细中存在某药品生产批号，即药品进货明细中药品生产批号不能重复。
        private bool ExitInMedicineStockList(long valMedicineProductionID)
        {
            ClassMedicineStockProperties tmpMedicineStockProperties =
                classMedicineStockPropertiesBindingSource.DataSource as ClassMedicineStockProperties;
            if (tmpMedicineStockProperties == null) return true;
            foreach (ClassMedicineStockListItem tmpMedicineStockListItem in tmpMedicineStockProperties.MedicineStockList)
            {
                if (tmpMedicineStockListItem.YKGL_药品生产批号_ID == valMedicineProductionID)
                {
                    return true;
                }
            }
            return false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormStockDetail f = new FormStockDetail(LoginInformation);
            f.ListItemAdded += f_MedicineStockListItemAdded;
            f.ShowDialog(this);
            f.ListItemAdded -= f_MedicineStockListItemAdded;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            BindingManagerBase bmb = BindingContext[medicineStockListBindingSource];
            if (bmb.Position >= 0)
            {
                bmb.RemoveAt(bmb.Position);
            }
        }

        #endregion

        protected override void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            base.OnExecuteSucceed(e);
            Close();
        }

        protected override void BindingData()
        {
            return;
        }
    }
}
