using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassLibraryLoginInformation;
using MedicineKinds.DataList;
using MedicineKinds.DataOperate;

namespace MedicineKinds
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
            string tmpConnectionString = @"Data Source=192.168.1.68;Initial Catalog=his6;User ID=sa;Password=hwbhwb";
            ClassLoginInformation tmpLoginInformation = new ClassLoginInformation(tmpConnectionString, 1);
            Application.Run(new FormMedicineKinds(tmpLoginInformation));
            //Application.Run(new FormMedicineKindInformation(tmpLoginInformation, 1));
        }
    }
}