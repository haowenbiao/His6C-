﻿using System;
using System.Windows.Forms;

namespace CustomerPrint
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //try
            //{
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
                //Application.Run(new GraphForm());
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message);
            //}
        }
    }
}