using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassLibraryLoginInformation;
using MedicineKindAdjustPrice.DataList;
using MedicineKindAdjustPrice.DataOperate;

namespace MedicineKindAdjustPrice
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
            string tmpConnectionString = @"Data Source=WINXP\SQLEXPRESS;Initial Catalog=his6;User ID=sa;Password=hwbhwb";
            //string tmpConnectionString = @"Data Source=Server;Initial Catalog=his6;User ID=sa;Password=hwbhwb";
            ClassLoginInformation tmpLoginInformation = new ClassLoginInformation(tmpConnectionString, 1);
            //Application.Run(new FormMedicineKindAdjustPriceRecords(tmpLoginInformation, 0));
            Application.Run(new FormMedicineKindAdjustPriceEdit(tmpLoginInformation, 4));
        }
    }
}
