using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestDateSelectControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //string tmpConnectionString = @"Data Source=WINXP\SQLEXPRESS;Initial Catalog=his6;User ID=sa;Password=hwbhwb";
            string tmpConnectionString = @"Data Source=Server;Initial Catalog=his6;User ID=sa;Password=hwbhwb";

            dateSelectControl1.ConnectionString = tmpConnectionString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = dateSelectControl1.NaturalPeriod.Start.ToLongDateString();
            label1.Text = dateSelectControl1.CurrentAccountingPeriod.会计期String;
        }
    }
}
