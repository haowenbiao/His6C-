using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ClassLibraryDataTableFromQueryString;
using ClassLibraryEventArgs;
using ClassLibraryGetSQLString;
using CustomForm;
using FarPoint.Win.Spread;

namespace MedicineProduceCompany
{
    public partial class FormMedicineProduceCompanies : CustomForm.CustomForm
    {
        private BindingManagerBase bmb;
        private Thread t;

        public FormMedicineProduceCompanies(string valConnectionString)
        {
            InitializeComponent();
            ConnectionString = valConnectionString;
            loadThread();
        }

        #region 加载线程

        private void loadThread()
        {
            if (t != null)
            {
                t.Abort();
            }
            t = new Thread(load) { IsBackground = true };
            t.Start();
        }

        private void load()
        {
            
            try
            {
                SetControlEnabled(toolStripContainer1, false);
                string tmpHelpText = HelpText;
                setHelpText("正在加载生产企业信息列表...");
                //Thread.Sleep(1000);
                //(19)SELECT * FROM dbo.YKGL_药品生产企业表_View WHERE 名称 LIKE '{0}%' OR 拼音码 LIKE '{0}%'
                //或者(20) SELECT * FROM dbo.YKGL_药品生产企业表_View
                long tmpID = string.IsNullOrEmpty(toolStripTextBoxSearchString.Text.Trim()) ? 20 : 19;
                string tmpSQLString1 = ClassGetSQLString.GetSQLString(ConnectionString, tmpID);
                if (string.IsNullOrEmpty(tmpSQLString1))
                {
                    setHelpText("加载生产企业信息列表失败！");
                }
                else
                {
                    string tmpSQLString = tmpID == 20
                                              ? tmpSQLString1
                                              : string.Format(tmpSQLString1, toolStripTextBoxSearchString.Text.Trim());
                    DataTableFromQueryString tmpDepartmentInformations = new DataTableFromQueryString(ConnectionString,
                                                                                                      tmpSQLString);
                    if (tmpDepartmentInformations.value == null)
                    {
                        setHelpText("加载生产企业信息列表失败！");
                    }
                    else
                    {
                        bindingTofpSpread(fpSpreadMedicineProduceCompany, tmpDepartmentInformations.value);
                    }
                }

                setHelpText(tmpHelpText);
                SetControlEnabled(toolStripContainer1, true);
            }
            catch
            {
                setHelpText("加载部门信息列表失败！");
            }
        }

        private void bindingTofpSpread(object valControl, object valDatasource)
        {
            FpSpread tmpFpSpread = valControl as FpSpread;
            if (tmpFpSpread != null)
                if (tmpFpSpread.InvokeRequired)
                {
                    callBackTowParameterHandle c = bindingTofpSpread;
                    Invoke(c, new[] { valControl, valDatasource });
                }
                else
                {
                    tmpFpSpread.DataSource = valDatasource;
                    tmpFpSpread.ActiveSheet.Columns[0].Visible = false;
                    bmb = BindingContext[valDatasource];
                }
        }

        #endregion

        #region 事件
        private void OnSaveSucceed(object sender, EventArgsOfSaveSucceed e)
        {
            loadThread();
            DataTable d = fpSpreadMedicineProduceCompany.DataSource as DataTable;
            if (d != null)
            {
                //d.DefaultView.Sort = "ID";
                bmb.Position = d.DefaultView.Find(e.ID);
            }
        }

        private void OnError(object sender, EventArgsOfError e)
        {
            MessageBox.Show(e.MyErrorMessage + "\n" + e.InnerErrorMessage, "错误", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        #endregion

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            loadThread();
        }
    }
}
