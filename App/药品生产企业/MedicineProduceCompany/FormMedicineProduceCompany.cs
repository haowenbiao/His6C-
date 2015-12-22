using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClassLibraryAbstractDataInformation;
using ClassLibraryEventArgs;
using ClassLibraryMedicineProduceCompany;
using CustomForm;

namespace MedicineProduceCompany
{
    public partial class FormMedicineProduceCompany : CustomForm.FormCustomBase
    {
        public event SaveSucceedHandler SaveSucceed;
        private readonly ClassAbstractDataExecute m_DataExecute;

        private delegate void MethodAfterSaveSucceedHandler();
        private MethodAfterSaveSucceedHandler MethodAfterSaveSucceed;

        public FormMedicineProduceCompany(string valConnectionString,long valOperaterID)
        {
            ConnectionString = valConnectionString;
            init();

            m_DataExecute = new ClassCompanyPropertiesAdded(ConnectionString, valOperaterID,
                                                            classCompanyPropertiesBindingSource.DataSource as
                                                            ClassCompanyProperties);
            MethodAfterSaveSucceed = AfterAddedSucceed;

            Text = "增加药品生产企业信息";

            init2();
        }

        public FormMedicineProduceCompany(string valConnectionString,long valOperaterID,long valCompanyID)
        {
            ConnectionString = valConnectionString;
            init();

            m_DataExecute = new ClassCompanyPropertiesEdited(ConnectionString,
                                                             classCompanyPropertiesBindingSource.DataSource as
                                                             ClassCompanyProperties, valCompanyID);
            MethodAfterSaveSucceed = AfterEditedSucceed;

            Text = "修改药品生产企业信息";

            init2();
        }

        private void init()
        {
            InitializeComponent();
            groupBox2.Visible = false;
            SizeState = EnumSizeState.MinHeith;
        }

        private void init2()
        {
            m_DataExecute.Error += OnError;
            m_DataExecute.SaveSucceed += OnSaveSucceed;
        }

        private void AfterAddedSucceed()
        {
            m_DataExecute.Data.clear();
            reBinding();
            textBox企业名称.Focus();
        }

        private void AfterEditedSucceed()
        {
            Close();
        }   
     
        #region 事件
        private void OnError(object sender, EventArgsOfError e)
        {
            MessageBox.Show(e.MyErrorMessage + "\n" + e.InnerErrorMessage, "错误");
        }

        private void OnSaveSucceed(object sender, EventArgsOfSaveSucceed e)
        {
            if (SaveSucceed != null)
            {
                SaveSucceed(sender, e);
            }
        }
        #endregion

        #region 按钮动作

        //保存按钮
        private void buttonOK_Click(object sender,EventArgs e)
        {
            try
            {
                long id = m_DataExecute.Save();

                if (id != -1L)
                {
                    MessageBox.Show("保存成功！", "提示");
                    MethodAfterSaveSucceed();
                }
                else
                {
                    MessageBox.Show("注意：保存失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("注意：保存失败！\n" + "number:" + ex.Number + "\n" + ex.Message);
            }
        }
        //关闭按钮
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        //显示附加内容
        private void buttonAdvanced_Click(object sender, EventArgs e)
        {
            if (SizeState == EnumSizeState.MaxHeith)
            {
                SizeState = EnumSizeState.MinHeith;
                groupBox2.Visible = false;
            }
            else
            {
                SizeState = EnumSizeState.MaxHeith;
                groupBox2.Visible = true;
            }
        }

        #endregion

        #region 绑定数据

        //绑定数据
        //private void bindingData()
        //{
        //    if (InvokeRequired)
        //    {
        //        callBackNoParameterHandle c = bindingData;
        //        Invoke(c);
        //    }
        //    else
        //    {
        //        ClassCompanyProperties tmpClassDepartmentProperties = m_DataExecute.Data as ClassDepartmentProperties;
        //        if (tmpClassDepartmentProperties != null)
        //        {
        //            textBox名称.DataBindings.Add("Text", tmpClassDepartmentProperties, "名称");
        //            textBox拼音码.DataBindings.Add("Text", tmpClassDepartmentProperties, "拼音码");
        //            comboBox部门类型.DataBindings.Add("SelectedValue", tmpClassDepartmentProperties, "部门类型_ID");
        //            textBox负责人.DataBindings.Add("Text", tmpClassDepartmentProperties, "负责人");
        //            textBoxWithButton备注.DataBindings.Add("Text", tmpClassDepartmentProperties, "备注");
        //        }
        //    }
        //}
        //重新绑定

        private void reBinding()
        {
            if (InvokeRequired)
            {
                MethodInvoker mi = reBinding;
                Invoke(mi);
            }
            else
            {
                //BindingManagerBase bmb = BindingContext[m_DataExecute.Data];
                //bmb.ResumeBinding();
                classCompanyPropertiesBindingSource.ResumeBinding();
            }

        }

        #endregion

    }
}
