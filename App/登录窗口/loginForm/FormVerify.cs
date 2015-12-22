using ClassLibraryLoginInformation;

namespace loginForm
{
    public partial class FormVerify : FormLogin
    {
        public FormVerify(ClassLoginInformation valLoginInformation) : base(valLoginInformation)
        {
            InitializeComponent();
            verifyDifferSelector1.ConnectionSqlString = valLoginInformation.ConnectionString;
        }

        protected  FormVerify()
        {
            InitializeComponent();
        }

        internal override void setEventArgsOfLoginSucceed()
        {
            EventArgsOfVerifid eventArgsOfVerifid = new EventArgsOfVerifid
                                                        {
                                                            LoginInformation = eventArgsOfLoginSucceed.LoginInformation,
                                                            P_审核意见_ID = (long)verifyDifferSelector1.SelectedValue,
                                                            备注 = textBoxWithButton备注.Text
                                                        };
            eventArgsOfLoginSucceed = eventArgsOfVerifid;

            base.setEventArgsOfLoginSucceed();
        }

    }

    public class EventArgsOfVerifid : EventArgsOfLoginSucceed
    {
        public long P_审核意见_ID { get; set; }
        public string 备注 { get; set; }
    }
}
