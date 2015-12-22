using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;

namespace DepartmentInformation.DataOperate
{
    public partial class FormDepartmentInformationEdit : FormDepartmentInformationBase
    {
        public FormDepartmentInformationEdit(ClassLoginInformation valLoginInformation, long valId)
            : base(valLoginInformation, valId)
        {
            InitializeComponent();
        }


        protected override void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            base.OnExecuteSucceed(e);
            Close();
        }
    }
}