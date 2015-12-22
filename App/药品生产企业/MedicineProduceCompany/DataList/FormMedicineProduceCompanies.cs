using System;
using System.Data;
using System.Windows.Forms;
using ClassLibraryLoginInformation;
using ClassLibraryMedicineProduceCompany;
using MedicineProduceCompany.DataOperate;

namespace MedicineProduceCompany.DataList
{
    public partial class FormMedicineProduceCompanies : FormDataListUseFpSpreadBaseFromAbstract
    {
        public FormMedicineProduceCompanies(ClassLoginInformation valLoginInformation):base(valLoginInformation)
        {
            InitializeComponent();

            #region 定义工具栏

            AddItemOfToolStripToToolStripSpecial(toolStripTmp);
            AddItemOfcontextMenuStripTocontextMenuStripOnListControl(contextMenuStripTmp);

            #endregion
        }

        protected override void ListControlDoubleClick()
        {
            Edit();
            base.ListControlDoubleClick();
        }

        private void Add()
        {
            FormMedicineProduceCompanyAdd f = new FormMedicineProduceCompanyAdd(LoginInformation);
            f.ExecuteSucceed += this_ExecuteSucceed;
            f.Show(this);
        }

        private void Edit()
        {
            if (Bmb.Position < 0) return;
            DataRowView drv = Bmb.Current as DataRowView;
            if (drv != null)
            {
                long tmpID = (long)drv["ID"];
                FormMedicineProduceCompanyEdit f = new FormMedicineProduceCompanyEdit(LoginInformation, tmpID);
                f.ExecuteSucceed += this_ExecuteSucceed;
                f.Show(this);
            }
        }

        private void Remove()
        {
            if (Bmb.Position < 0) return;
            DataRowView drv = Bmb.Current as DataRowView;
            if (drv != null)
            {
                if (MessageBox.Show("是否删除“" + drv["名称"] + "”的信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                long tmpID = (long)drv["ID"];

                ClassCompanyPropertiesRemover f = new ClassCompanyPropertiesRemover(LoginInformation, tmpID);
                f.ExecuteSucceed += this_ExecuteSucceed;
                f.Error += this_Error;
                f.execute();
            }
        }

        protected override string MedicineProductCompanyNameOrPYMForSearch
        {
            get
            {
                return toolStripTextBoxCompanyNameOrPYM != null
                           ? toolStripTextBoxCompanyNameOrPYM.Text.Trim()
                           : string.Empty;
                //return base.MedicineProductCompanyNameOrPYMForSearch;
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

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            LoadDataThread();
        }

        private void toolStripTextBoxCompanyNameOrPYM_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadDataThread();
            }
        }
    }
}
