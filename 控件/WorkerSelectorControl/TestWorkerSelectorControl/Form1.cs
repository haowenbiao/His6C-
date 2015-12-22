using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestWorkerSelectorControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //string tmpConnectionString = @"Data Source=WINXP\SQLEXPRESS;Initial Catalog=his6;User ID=sa;Password=hwbhwb";
            string tmpConnectionString = @"Data Source=Server;Initial Catalog=his6;User ID=sa;Password=hwbhwb";
            workerSelectorComboBoxWithDataGridView1.ConnectionSqlString = tmpConnectionString;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
