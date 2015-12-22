using System;
using ClassLibraryLoginInformation;
using ClassLibraryMedicineStock;
using CustomForm;

namespace MedicineStock.DataOperate
{
    //public partial class FormStockInformation : FormCustomDataLoaded_Design
    public partial class FormStockInformation : FormCustomDataLoaded<ClassMedicineStockFullProperties>
    {
        /// <summary>
        /// 进货单详细信息
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valID"></param>
        public FormStockInformation(ClassLoginInformation valLoginInformation, long valID)
            : base(valLoginInformation, 36, valID)
        {
            InitializeComponent();
        }

        /// <summary>
        /// 入库审核
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valAuthority"></param>
        /// <param name="valID"></param>
        protected FormStockInformation(ClassLoginInformation valLoginInformation,long valAuthority, long valID)
            : base(valLoginInformation, valAuthority, valID)
        {
            InitializeComponent();
        }

        protected override void BindingData()
        {
            ClassMedicineStockFullProperties MedicineStockFullProperties = Data as ClassMedicineStockFullProperties;
            if (MedicineStockFullProperties != null)
            {
                bool tmpStockVeriyied =
                    ClassMedicineStockPublic.GetMedicineStockIsVerified(LoginInformation.ConnectionString, Data.ID);
                if (tmpStockVeriyied)
                {
                    MedicineStockFullProperties.P_审核意见_ID = 0;
                    MedicineStockFullProperties.审核时间 = DateTime.Now;
                }
                MedicineStockFullProperties.LoadStockList(LoginInformation);
                classMedicineStockFullPropertiesBindingSource.DataSource = MedicineStockFullProperties;
                dataGridView1.DataSource = MedicineStockFullProperties.MedicineStockList;
            }
        }
    }
}
