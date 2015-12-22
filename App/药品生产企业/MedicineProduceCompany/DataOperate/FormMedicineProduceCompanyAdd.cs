using System;
using ClassLibraryLoginInformation;
using ClassLibraryMedicineProduceCompany;

namespace MedicineProduceCompany.DataOperate
{
    public partial class FormMedicineProduceCompanyAdd : FormMedicineProduceCompanyBase
    {
        public FormMedicineProduceCompanyAdd(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation, 47)
        {
            InitializeComponent();

            SizeState = EnumSizeState.MinSize;
            //初始化CompanyProperties
            Data = new ClassCompanyProperties();
            BindingData();
        }

        protected override void buttonOK_Click(object sender, EventArgs e)
        {
            ClassCompanyPropertiesAdder CompanyPropertiesAdder =
                new ClassCompanyPropertiesAdder(LoginInformation, Data);
            CompanyPropertiesAdder.Error += this_Error;
            CompanyPropertiesAdder.ExecuteSucceed += this_ExecuteSucceed;
            CompanyPropertiesAdder.execute();
            CompanyPropertiesAdder.Error -= this_Error;

            base.buttonOK_Click(sender, e);
        }

        protected override void OnExecuteSucceed(ClassLibraryEventArgs.EventArgsOfExecuteSucceed e)
        {
            Data.clear();
            ReBinding();

            base.OnExecuteSucceed(e);
        }
    }
}
