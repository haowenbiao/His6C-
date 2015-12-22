using System;
using System.Windows.Forms;
using ClassLibraryLoginInformation;
using DepartmentInformation.DataList;

namespace DepartmentInformation
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //string tmpConnectionString = @"Data Source=WINXP\SQLEXPRESS;Initial Catalog=his6;User ID=sa;Password=hwbhwb";
            string tmpConnectionString = @"Data Source=SERVER;Initial Catalog=his6;User ID=sa;Password=hwbhwb";
            ClassLoginInformation tmpLoginInformation = new ClassLoginInformation(tmpConnectionString, 1);
            #region 增加修改部门信息

            //FormDepartmentInformation f = new FormDepartmentInformation(tmpConnectionString,36);
            //FormDepartmentInformation f = new FormDepartmentInformation(tmpConnectionString);

            #endregion
            #region 部门信息

            //FormDepartmentInformations f = new FormDepartmentInformations(tmpLoginInformation);
            DeparmentInformations f = new DeparmentInformations(tmpLoginInformation);
            //Form2 f=new Form2(tmpLoginInformation);
            #endregion
            Application.Run(f);
        }
    }
}
