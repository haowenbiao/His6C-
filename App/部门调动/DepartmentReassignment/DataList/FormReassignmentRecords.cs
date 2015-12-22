using System;
using System.Windows.Forms;
using ClassLibraryDepartmentReassignment;
using ClassLibraryLoginInformation;

namespace DepartmentReassignment.DataList
{
    public partial class FormReassignmentRecords : FormDataListUseFpSpreadBaseFromAbstract
    {
        public FormReassignmentRecords(ClassLoginInformation valLoginInformation):base(valLoginInformation)
        {
            InitializeComponent();

            if (toolStripComboBoxWorker.ComboBox != null)
            {
                toolStripComboBoxWorker.ComboBox.DataSource =
                    ClassDepartmentReassignmentPublic.LoadAllWorkers(LoginInformation.ConnectionString);
                toolStripComboBoxWorker.ComboBox.ValueMember = "姓名";
                toolStripComboBoxWorker.ComboBox.DisplayMember = "姓名";
                toolStripComboBoxWorker.ComboBox.SelectedIndex = -1;
            }

            #region 定义工具栏

            AddItemOfToolStripToToolStripSpecial(toolStripTmp);

            #endregion

            LoadDataThread();
        }

        protected override string WorkerNameOrPYMForSearch
        {
            get
            {
                return toolStripComboBoxWorker.Text.Trim();
            }
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            LoadDataThread();
        }

        private void toolStripComboBoxWorker_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                LoadDataThread();
            }
        }
    }
}