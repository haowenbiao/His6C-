using System.Data;
using ClassLibraryDataTableFromQueryString;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;
using CustomForm;

namespace ClassLibraryWorkerInformations
{
    //public partial class FormWorkerInformationView : FormCustomDataLoaded_Design
    public partial class FormWorkerInformationView : FormCustomDataLoaded<ClassWorkerProperties>
    {
        public FormWorkerInformationView(ClassLoginInformation valLoginInformation, long valID):base(valLoginInformation,1,valID)
        {
            InitializeComponent();
        }

        protected override void LoadData()
        {
            listBox1.DataSource = LoadDepartmentsOfWorkerIn(LoginInformation.ConnectionString, Data.ID);
            listBox1.DisplayMember = "部门名称";
            base.LoadData();
        }

        /// <summary>
        /// 加载职工所在的部门列表。与ClassLibraryDepartmentReassignment.ClassDepartmentReassignmentPublic.LoadDepartmentsOfWorkerIn相同。
        /// </summary>
        /// <param name="valConnectionString"></param>
        /// <param name="valID"></param>
        /// <returns></returns>
        private DataTable LoadDepartmentsOfWorkerIn(string valConnectionString, long valID)
        {
            //"SELECT ID,部门名称 FROM [P_职工信息_部门信息_表_View] Where P_职工信息_ID = {0}"
            string tmpSQLString1 = ClassGetSQLString.GetSQLString(valConnectionString, 1);
            if (string.IsNullOrEmpty(tmpSQLString1))
            {
                return null;
            }
            string tmpSQLstring = string.Format(tmpSQLString1, valID);
            DataTableFromQueryString tmpDepartmentInformations = new DataTableFromQueryString(valConnectionString,
                                                                                              tmpSQLstring);
            return tmpDepartmentInformations.value;
        }

        protected override void BindingData()
        {
            ClassWorkerProperties WorkerProperties = Data as ClassWorkerProperties;
            if (WorkerProperties != null)
            {
                label姓名.Text = WorkerProperties.姓名;
                label拼音码.Text = WorkerProperties.拼音码;
                label性别.Text = WorkerProperties.性别 == 0 ? "男" : "女";
                label出生日期.Text = WorkerProperties.出生日期.ToLongDateString();
                label是否操作员.Text = WorkerProperties.是否操作员 == 0 ? "否" : "是";
                label身份证号码.Text = WorkerProperties.身份证号码;
                label家庭住址.Text = WorkerProperties.家庭住址;
                label联系电话1.Text = WorkerProperties.联系电话1;
                label联系电话2.Text = WorkerProperties.联系电话2;
                label备注.Text = WorkerProperties.备注;
            }
        }
    }
}