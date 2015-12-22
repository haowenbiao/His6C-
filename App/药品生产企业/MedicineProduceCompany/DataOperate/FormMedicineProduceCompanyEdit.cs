using System;
using ClassLibraryLoginInformation;
using ClassLibraryMedicineProduceCompany;

namespace MedicineProduceCompany.DataOperate
{
    public partial class FormMedicineProduceCompanyEdit : FormMedicineProduceCompanyBase
    {
        public FormMedicineProduceCompanyEdit(ClassLoginInformation valLoginInformation, long valID)
            : base(valLoginInformation, 48)
        {
            InitializeComponent();
            SizeState = EnumSizeState.MinSize;

            //初始化CompanyProperties
            Data = new ClassCompanyProperties(valID);
            ClassCompanyPropertiesLoader CompanyPropertiesLoader =
                new ClassCompanyPropertiesLoader(LoginInformation, Data);
            CompanyPropertiesLoader.Error += OnLoadError;
            if (CompanyPropertiesLoader.execute())
            {
                BindingData();
            }
        }

        protected override void buttonOK_Click(object sender, EventArgs e)
        {
            ClassCompanyPropertiesEditer CompanyPropertiesEditer =
                new ClassCompanyPropertiesEditer(LoginInformation, Data);
            CompanyPropertiesEditer.Error += this_Error;
            CompanyPropertiesEditer.ExecuteSucceed += this_ExecuteSucceed;
            CompanyPropertiesEditer.execute();
            CompanyPropertiesEditer.Error -= this_Error;

            base.buttonOK_Click(sender, e);
        }

        protected override void OnExecuteSucceed(ClassLibraryEventArgs.EventArgsOfExecuteSucceed e)
        {
            base.OnExecuteSucceed(e);

            Close();
        }
    }
}
