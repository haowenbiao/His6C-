using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;

namespace WorkerInformations.DataOperate
{
    public partial class FormWorkerInformationEdit : FormWorkerInformationBase
    {
        public FormWorkerInformationEdit(ClassLoginInformation valLoginInformation, long valID)
            : base(valLoginInformation, valID)
        {
            InitializeComponent();

            //当修改职工信息时，不进行岗位调动
            checkBoxDepartmentReassign.Enabled = false;
            checkBoxDepartmentReassign.Checked = false;
        }

        protected override void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            base.OnExecuteSucceed(e);
            Close();
        }
    }
}
