using System;
using System.Data;
using System.Windows.Forms;
using ClassLibraryAbstractDataInformation;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;
using ClassLibraryMedicineStoreHouseInfomation;
using MedicineStoreHouseInformation.DataOperate;

namespace MedicineStoreHouseInformation.DataList
{
    public partial class FormMedicineStoreHouseInformations : FormDataListUseFpSpreadBaseFromAbstract
    {
        public FormMedicineStoreHouseInformations(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation)
        {
            InitializeComponent();

            #region 定义工具栏

            AddItemOfToolStripToToolStripSpecial(toolStripTmp);
            AddItemOfcontextMenuStripTocontextMenuStripOnListControl(contextMenuStripTmp);

            #endregion

        }

        protected override string LoadSqlString
        {
            get
            {
                //(80)SELECT * FROM dbo.YKGL_药库信息表_View
                string tmpSQLString1 = ClassGetSQLString.GetSQLString(LoginInformation.ConnectionString, 80);
                if (string.IsNullOrEmpty(tmpSQLString1))
                {
                    return null;
                }
                string tmpSQLString = tmpSQLString1;
                return tmpSQLString;
            }
        }

        protected override void ListControlDoubleClick()
        {
            Edit();
            base.ListControlDoubleClick();
        }

        private void Add()
        {
            FormMedicineStoreHouseInformationAdd f = new FormMedicineStoreHouseInformationAdd(LoginInformation);
            f.ExecuteSucceed += this_ExecuteSucceed;
            f.ShowDialog(this);
            f.ExecuteSucceed -= this_ExecuteSucceed;
        }

        private void Edit()
        {
            if (Bmb.Position < 0) return;
            DataRowView drv = Bmb.Current as DataRowView;
            if (drv != null)
            {
                long tmpID = (long)drv["ID"];
                FormMedicineStoreHouseInformationEdit f = new FormMedicineStoreHouseInformationEdit(LoginInformation, tmpID);
                f.ExecuteSucceed += this_ExecuteSucceed;
                f.ShowDialog(this);
                f.ExecuteSucceed -= this_ExecuteSucceed;
            }
        }

        private void Remove()
        {
            if (Bmb.Position < 0) return;
            DataRowView drv = Bmb.Current as DataRowView;
            if (drv != null)
            {
                if (MessageBox.Show(@"是否删除药库名称为“" + drv["药库名称"] + @"”的信息？", @"提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
                long tmpID = (long)drv["ID"];

                ClassDataRemover<ClassMedicineStoreHouseInfomationProperties> classDataRemover = new ClassDataRemover<ClassMedicineStoreHouseInfomationProperties>(LoginInformation, tmpID, 75);
                classDataRemover.ExecuteSucceed += this_ExecuteSucceed;
                classDataRemover.ExecuteError += this_ExecuteError;
                if (classDataRemover.execute())
                {
                    MessageBox.Show(@"删除成功！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                classDataRemover.ExecuteSucceed -= this_ExecuteSucceed;
                classDataRemover.ExecuteError -= this_ExecuteError;
            }
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }
    }
}
