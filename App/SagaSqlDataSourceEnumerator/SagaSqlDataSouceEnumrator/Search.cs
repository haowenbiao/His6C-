using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using System.Data.Sql;

namespace SagaSqlDataSouceEnumrator
{
    

    public partial class Search : Form
    {
        delegate void setDataTableHandle(DataTable valDataTable);
        private Waiter w;
        public Thread t;
        public Search()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonBegin_Click(object sender, EventArgs e)
        {
            //w.Show(this);
            t = new Thread(searchDataSource);
            t.Start();

            if (w==null)
            {
                w = new Waiter();
            }
            w.progressBar1.Value = 0;
            w.ShowDialog(this);

        }

        private void searchDataSource()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();
            
            setGridDataSource(table);
            if (w==null)
            {
                return;
            }
            if (w.t !=null)
            {
                w.t.Abort();
            }
            MethodInvoker m = w.Close;
            if (w.InvokeRequired)
            {
                w.Invoke(m);
            }
            else
            {
                w.Close();
            }
        }
        private void setGridDataSource(DataTable valDataTable)
        {
            if (listBox1.InvokeRequired)
            {
                setDataTableHandle s = setGridDataSource;
                object[] o = new object[1];
                o[0] = valDataTable;
                Invoke(s,o);
            }
            else
            {
                listBox1.DataSource = valDataTable;
                listBox1.DisplayMember = "ServerName";
            }
        }

        private void Search_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (t!=null)
            {
                t.Abort();
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            DataRowView r = (DataRowView)listBox1.SelectedItem;
            if (r != null)
            {
                MessageBox.Show(r.Row[0].ToString());
            }
        }
    }
}
