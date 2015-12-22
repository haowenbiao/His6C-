using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;

namespace DepartmentInformation.DataOperate
{
    public partial class FormDepartmentInformationAdd : FormDepartmentInformationBase
    {
        public FormDepartmentInformationAdd(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation)
        {
            InitializeComponent();
        }

        protected override void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            Data.Clear();
            ReBinding();
             
            base.OnExecuteSucceed(e);
        }

    }
}