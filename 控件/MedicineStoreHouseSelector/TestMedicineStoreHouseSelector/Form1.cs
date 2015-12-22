using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestMedicineStoreHouseSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string tmpConnectionString = @"Data Source=WINXP\SQLEXPRESS;Initial Catalog=his6;User ID=sa;Password=hwbhwb";
            //string tmpConnectionString = @"Data Source=Server;Initial Catalog=his6;User ID=sa;Password=hwbhwb";
            medicineStoreHouseSelector1.ConnectionSqlString = tmpConnectionString;
            medicineStoreHouseSelector2.ConnectionSqlString = tmpConnectionString;
            medicineStoreHouseSelector3.ConnectionSqlString = tmpConnectionString;
        }
    }
}
