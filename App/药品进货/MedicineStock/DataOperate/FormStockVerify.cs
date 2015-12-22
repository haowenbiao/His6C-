using System;
using System.Windows.Forms;
using ClassLibraryLoginInformation;
using CustomForm;

namespace MedicineStock.DataOperate
{
    public partial class FormStockVerify : FormCustomAuthoritied
    {
        public FormStockVerify(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation, 0)
        {
            InitializeComponent();
            workerSelectorComboBoxWithDataGridView1.ConnectionSqlString = valLoginInformation.ConnectionString;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //EventArgsOfStockVerifySucceed eventArgsOfStockVerifySucceed = new EventArgsOfStockVerifySucceed
            //                                                                {
            //                                                                    P_审核意见_ID = 1,
            //                                                                    P_审核人_ID =
            //                                                                        workerSelectorComboBoxWithDataGridView1
            //                                                                        .ID,
            //                                                                    备注 = textBoxWithButton备注.Text
            //                                                                };
            MessageBox.Show(@":" + workerSelectorComboBoxWithDataGridView1.ID);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region 自定义事件

        public event EventHandler<EventArgsOfStockVerifySucceed> VerifySucceed;

        public void OnVerifySucceed(EventArgsOfStockVerifySucceed e)
        {
            
            EventHandler<EventArgsOfStockVerifySucceed> handler = VerifySucceed;
            if (handler != null) handler(this, e);
        }

        public class EventArgsOfStockVerifySucceed : EventArgs
        {
            public long P_审核人_ID { get; set; }

            public long P_审核意见_ID { get; set; }

            public string 备注 { get; set; }
        }

        #endregion

        private void control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
