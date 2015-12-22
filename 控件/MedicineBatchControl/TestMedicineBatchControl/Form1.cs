using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClassLibraryLoginInformation;

namespace TestMedicineBatchControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //const string tmpConnectionString = @"Data Source=WINXP\SQLEXPRESS;Initial Catalog=his6;User ID=sa;Password=hwbhwb";
            const string tmpConnectionString = @"Data Source=Server;Initial Catalog=his6;User ID=sa;Password=hwbhwb";
            ClassLoginInformation tmpLoginInformation = new ClassLoginInformation(tmpConnectionString, 1);

            medicineBatchControl1.LoginInformation = tmpLoginInformation;
            medicineBatchControl1.MedicineKindID = 1L;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (medicineBatchControl1.ID <= 0)
            {
                medicineBatchControl1.Add();
            }
            if (medicineBatchControl1.ID <= 0)
            {
                MessageBox.Show(@"Can not save,Medicine batch Get Error!");
            }
            else
            {
                medicineBatchControl1.ClearResult();
                medicineBatchControl1.MedicineKindID = 1L;
            }

        }
    }
}
