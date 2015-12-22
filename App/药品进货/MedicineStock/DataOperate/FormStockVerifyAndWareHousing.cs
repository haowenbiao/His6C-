using System;
using System.Windows.Forms;
using ClassLibraryAbstractDataInformation;
using ClassLibraryLoginInformation;
using ClassLibraryMedicineStock;
using CustomForm;
using loginForm;


namespace MedicineStock.DataOperate
{
    /// <summary>
    /// 药品审核入库
    /// </summary>
    //public partial class FormStockVerifyAndWareHousing : FormCustomDataLoaded_Design
    public partial class FormStockVerifyAndWareHousing : FormStockInformation
    {
        public FormStockVerifyAndWareHousing(ClassLoginInformation valLoginInformation, long valID)
            : base(valLoginInformation, 92, valID)
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            bool tmpStockVeriyied =
                    ClassMedicineStockPublic.GetMedicineStockIsVerified(LoginInformation.ConnectionString, Data.ID);
            if (tmpStockVeriyied)
            {
                buttonOK.Enabled = false;
            }
            base.OnLoad(e);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            FormVerify Verify = new FormVerify(LoginInformation);
            Verify.LoginSucceed += Verify_LoginSucceed;
            Verify.ShowDialog(this);
            Verify.LoginSucceed -= Verify_LoginSucceed;
        }

        private void Verify_LoginSucceed(object o, EventArgsOfLoginSucceed e)
        {
            EventArgsOfVerifid tmpEventArgsOfVerifid = (EventArgsOfVerifid) e;
            if (tmpEventArgsOfVerifid == null)
            {
                return;
            }
            ClassMedicineStockVerifyAndWareHousing MedicineStockVerifyAndWareHousingData =
                new ClassMedicineStockVerifyAndWareHousing
                    {
                        ID = Data.ID,
                        YKGL_进货记录_ID = Data.ID,
                        P_审核人_ID = tmpEventArgsOfVerifid.LoginInformation.OperaterID,
                        P_审核意见_ID = tmpEventArgsOfVerifid.P_审核意见_ID,
                        备注 = tmpEventArgsOfVerifid.备注
                    };

            ClassDataAdder dataAdder = new ClassDataAdder
            {
                AuthorityID = AuthorityID,
                LoginInformation = LoginInformation,
                Data = MedicineStockVerifyAndWareHousingData
            };
            dataAdder.ExecuteError += this_ExecuteError;
            dataAdder.ExecuteSucceed += this_ExecuteSucceed;
            dataAdder.execute();
            dataAdder.ExecuteError -= this_ExecuteError;
            dataAdder.ExecuteSucceed -= this_ExecuteSucceed;
        }

        protected override void OnExecuteSucceed(ClassLibraryEventArgs.EventArgsOfExecute.EventArgsOfExecuteSucceed e)
        {
            MessageBox.Show(e.Message, @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            base.OnExecuteSucceed(e);
            Close();
        }

    }
}
