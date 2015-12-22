using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;
using DepartmentReassignment.DataOperate;

namespace WorkerInformations.DataOperate
{
    public partial class FormWorkerInformationAdd : FormWorkerInformationBase
    {
        public FormWorkerInformationAdd(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation)
        {
            InitializeComponent();
            checkBoxDepartmentReassign.Checked = true;
        }

        protected override void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
        {
            Data.Clear();
            ReBinding();

            //岗位调动(调入)
            if (checkBoxDepartmentReassign.Checked && checkBoxDepartmentReassign.Enabled)
            {
                FormReassignmentIn tmpFormReassignmentIn = new FormReassignmentIn(LoginInformation, e.ID);
                tmpFormReassignmentIn.ShowDialog(this);
            }

            base.OnExecuteSucceed(e);
        }
    }
}
