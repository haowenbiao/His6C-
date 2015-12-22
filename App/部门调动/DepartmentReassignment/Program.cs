using System;
using System.Windows.Forms;
using ClassLibraryLoginInformation;
using DepartmentReassignment.DataList;
using DepartmentReassignment.DataOperate;

namespace DepartmentReassignment
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
            string tmpConnectionString = @"Data Source=Server;Initial Catalog=his6;User ID=sa;Password=hwbhwb";
            ClassLoginInformation tmpLoginInformation = new ClassLoginInformation(tmpConnectionString, 1);
            //Application.Run(new FormReassignmentIn(tmpLoginInformation, 27));
            //Application.Run(new FormReassignmentOut(tmpLoginInformation, 27));
            Application.Run(new FormReassignmentRecords(tmpLoginInformation));
        }
    }
}
