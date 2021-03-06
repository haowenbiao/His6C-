﻿using System;
using System.Windows.Forms;
using ClassLibraryLoginInformation;
using CostItemAdjustPrice.DataList;
using CostItemAdjustPrice.DataOperate;

namespace CostItemAdjustPrice
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
            //Application.Run(new FormCostItemAdjustPrice(tmpLoginInformation, 0));
            Application.Run(new FormCostItemAdjustPriceEdit(tmpLoginInformation, 4L));
        }
    }
}
