using System;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;
using SagaConfiguration;

//using SagaConfiguration;

namespace CommunicateServer
{
    public partial class FormConfig : Form
    {
        //private ClientConfig clientConfig;
        public FormConfig()
        {
            InitializeComponent();
            ClientConfig clientConfig = new ClientConfig("ClientConfig.xml",true);
            //clientConfig.load();
            textBoxServerName.Text = clientConfig.serverInformation.serverConnectInformation.ServerName;
            textBoxPassword.Text = clientConfig.serverInformation.serverConnectInformation.Password;
            getLocalInformation();
        }
        private void getLocalInformation()
        {
            ClientConfig clientConfig = new ClientConfig("ClientConfig.xml", true);
            clientConfig.localInformation.communicateInformation.ComputerName = Dns.GetHostName();
            clientConfig.localInformation.communicateInformation.ComputerIP =
                Dns.GetHostAddresses(Dns.GetHostName())[0].ToString();
            labelComputerName.Text = clientConfig.serverInformation.communicateInformation.ComputerName =
                                     clientConfig.localInformation.communicateInformation.ComputerName;
            labelIPAddress.Text = clientConfig.serverInformation.communicateInformation.ComputerIP =
                                  clientConfig.localInformation.communicateInformation.ComputerIP;
            clientConfig.save();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ClientConfig clientConfig = new ClientConfig("ClientConfig.xml", true);
            clientConfig.serverInformation.serverConnectInformation.Password = textBoxPassword.Text;
            clientConfig.serverInformation.serverConnectInformation.ServerName = textBoxServerName.Text;
            clientConfig.save();
            Close();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            ClientConfig clientConfig = new ClientConfig("ClientConfig.xml", true);
            SqlConnectionStringBuilder tmpSCSB = new SqlConnectionStringBuilder();

            if (clientConfig.serverInformation.serverConnectInformation.ServerType == ServerType.SqlServerExpress)
            {
                tmpSCSB.DataSource = @".\SQLExpress";
            }
            else
            {
                tmpSCSB.DataSource = @"(local)";
            }
            tmpSCSB.InitialCatalog = clientConfig.serverInformation.serverConnectInformation.DataBase;
            tmpSCSB.UserID = clientConfig.serverInformation.serverConnectInformation.UserID;
            tmpSCSB.Password = textBoxPassword.Text;
            SqlConnection tmpSqlConnection = new SqlConnection(tmpSCSB.ConnectionString);
            SqlCommand tmpSqlCommand;
            try
            {
                tmpSqlCommand = new SqlCommand("Select Host_name()", tmpSqlConnection);
                tmpSqlConnection.Open();
                clientConfig.serverInformation.serverConnectInformation.ServerName =
                    Convert.ToString(tmpSqlCommand.ExecuteScalar());
                tmpSqlConnection.Close();
                textBoxServerName.Text = clientConfig.serverInformation.serverConnectInformation.ServerName;
                MessageBox.Show("连接成功！");
            }
            catch (Exception exception)
            {
                MessageBox.Show("连接失败！\n" + exception.Message,"连接失败");
            }
            finally
            {
                tmpSqlConnection.Close();
            }
        }
    }
}