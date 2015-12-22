using System.Data;
using ClassLibraryDataListColumnShowInformationConfig;
using ClassLibraryDataTableFromQueryString;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;
using CustomForm;

namespace ClassLibraryAbstractFormDataListBase
{
    public partial class FormDataListColumnsShowInformation : FormCustomAuthoritied
    {
        public FormDataListColumnsShowInformation(ClassLoginInformation valLoginInformation,long valIDOfSqlStringThatGetColumnsOfDataTable,string valKey)
            : base(valLoginInformation, 0)
        {
            InitializeComponent();
            SqlStringID = valIDOfSqlStringThatGetColumnsOfDataTable;
            Key = valKey;

            LoadColumnInformation();
        }

        private string Key { get; set; }

        private long SqlStringID { get; set; }

        private void LoadColumnInformation()
        {
            LoadColumnInformationFromDataTable();
            LoadColumnInformationFromConfigFile();
        }

        private void LoadColumnInformationFromDataTable()
        {
            try
            {
                string SqlString = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, SqlStringID);
                DataTableFromQueryString dataTableFromQueryString =
                    new DataTableFromQueryString(LoginInformation.ConnectionString, SqlString);
                DataTable dataTable = dataTableFromQueryString.value;
                int tmpIndex;
                checkedListBox1.Items.Clear();
                for (int i = 1; i < dataTable.Columns.Count; i++)
                {
                    tmpIndex = checkedListBox1.Items.Add(dataTable.Columns[i].ColumnName);
                    checkedListBox1.SetItemChecked(tmpIndex, true);
                }
                return;
            }
            catch
            {
                return;
            }
        }

        private void LoadColumnInformationFromConfigFile()
        {
            try
            {
                ClassDataListColumnShowInformationConfig DataListColumnShowInformationConfig =
                    new ClassDataListColumnShowInformationConfig(Key);
                foreach (int i in DataListColumnShowInformationConfig.ListNotShowColumn)
                {
                    checkedListBox1.SetItemChecked(i - 1, false);
                }
                return;
            }
            catch
            {
                return;
            }
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, System.EventArgs e)
        {
            ClassDataListColumnShowInformationConfig DataListColumnShowInformationConfig = new ClassDataListColumnShowInformationConfig(Key);
            DataListColumnShowInformationConfig.ClearListNotShowColumn();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (!checkedListBox1.GetItemChecked(i))
                {
                    DataListColumnShowInformationConfig.ListNotShowColumn.Add(i + 1);
                }
            }
            if (DataListColumnShowInformationConfig.Save())
            {
                //this_ExecuteSucceed(this,new EventArgsOfExecuteSucceed(0,""));
                OnExecuteSucceed(new EventArgsOfExecuteSucceed(0,""));
            }
            Close();
        }
    }
}
