using System;
using System.Threading;
using System.Windows.Forms;

namespace SagaSqlDataSouceEnumrator
{
    public partial class Waiter : Form
    {
        private delegate void refreshProgresBarHandle();

        public Thread t;
        public Waiter()
        {
            InitializeComponent();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if(t!=null)
            {
                t.Abort();
            }
            Search s = Owner as Search;
            if (s.t!=null)
            {
                s.t.Abort();
            }
            Close();
        }
        public void wait()
        {
            while (true)
            {
                refreshProgresBar();
                Thread.Sleep(100);
            }
        }
        
        public void refreshProgresBar()
        {
            if (progressBar1.InvokeRequired)
            {
                refreshProgresBarHandle r = refreshProgresBar;
                Invoke(r);
            }
            else
            {
                if (progressBar1.Value==progressBar1.Maximum)
                {
                    progressBar1.Value = 0;
                }
                progressBar1.Value += 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Waiter_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (t!=null)
            {
                t.Abort();
            }
        }

        private void Waiter_Load(object sender, EventArgs e)
        {
            t = new Thread(wait);
            t.Start();
        }
    }
}
