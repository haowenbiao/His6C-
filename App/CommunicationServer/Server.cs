using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Data.SqlClient;
using SagaConfiguration;
//using CommunicateServer;


namespace CommunicateServer
{
    public partial class Server : Form
    {

        private TcpListener server;
        private Thread listenThread;
        private delegate void controlCallback(string valString);

        private delegate void controlWithColorCallback(string valString, Color valColor);

        private Thread testDatabaseThread;

        public Server()
        {
            InitializeComponent();
            ClientConfig clientConfig = new ClientConfig("ClientConfig.xml", true);
            bufferSize = clientConfig.serverInformation.communicateInformation.StreamBufferSize;
            communicatePort = clientConfig.serverInformation.communicateInformation.CommunicatePort;
            ready = false;
            beginService();
            beginTestDatabase();
        }

        #region 属性
        private int bufferSize { get; set; }
        private int communicatePort { get; set; }
        private bool ready { get; set; }
        private ServerType serverType { get; set; }
        private string serverName { get; set; }
        private string instance { get; set; }
        private string database { get; set; }
        private string userID { get; set; }
        private string password { get; set; }
        #endregion

        #region 方法
        private IPAddress localIPAddress()
        {
            IPAddress tmpIPAddress = Dns.GetHostAddresses(Dns.GetHostName())[0];
            return tmpIPAddress;
        }
        private string getConnectionString()
        {
            ClientConfig tmpClientConfig = new ClientConfig("ClientConfig.xml", true);
            SqlConnectionStringBuilder tmpSqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            serverType = tmpClientConfig.serverInformation.serverConnectInformation.ServerType;
            instance = tmpClientConfig.serverInformation.serverConnectInformation.Instance;
            serverName = tmpClientConfig.serverInformation.serverConnectInformation.ServerName;
            tmpSqlConnectionStringBuilder.DataSource =
                tmpClientConfig.serverInformation.serverConnectInformation.ServerType == ServerType.SqlServerExpress
                    ? tmpClientConfig.serverInformation.serverConnectInformation.ServerName + @"\" + instance
                    : tmpClientConfig.serverInformation.serverConnectInformation.ServerName;
            database =
                tmpSqlConnectionStringBuilder.InitialCatalog =
                tmpClientConfig.serverInformation.serverConnectInformation.DataBase;
            userID =
                tmpSqlConnectionStringBuilder.UserID = tmpClientConfig.serverInformation.serverConnectInformation.UserID;
            password =
                tmpSqlConnectionStringBuilder.Password =
                tmpClientConfig.serverInformation.serverConnectInformation.Password;
            return tmpSqlConnectionStringBuilder.ConnectionString;
        }
        #endregion

        #region 侦听服务
        private void beginService()
        {
            if (server==null)
            {
                server = new TcpListener(localIPAddress(), communicatePort);
            }
            server.Start();
            listenThread = new Thread(listen);
            listenThread.IsBackground = true;
            listenThread.Start();
            toolStripStatusLabel1.Text = "服务已启动！";
        }
        private void listen()
        {
            while(true)
            {
                TcpClient tc = server.AcceptTcpClient();
                NetworkStream ns = tc.GetStream();
                EndPoint ep = tc.Client.RemoteEndPoint;
                
                string readString = readStringFromTcpClient(ns);
                
                string[] tmpString = readString.Split(Convert.ToChar("|"));
                if (tmpString.Length >= 2)
                {
                    if (tmpString[0]=="Client")
                    {
                        switch (tmpString[1])
                        {
                            case "Loging":
                                string tmpConnString = "Server|ConnectInformation|" + (ready ? "Ready" : "NotReady") +
                                                       "|" + serverType + "|" + serverName + "|" + instance + "|" +
                                                       database + "|" + userID + "|" + password;
                                sendStringToTcpClient(ns, tmpConnString);
                                break;
                            case "Login":
                                listBoxAddItem("login:" + tmpString[2] + "(" + ep + ")");
                                sendStringToTcpClient(ns, "login success!");
                                break;
                            case "Logout":
                                listBoxAddItem("logout:" + tmpString[2] + "(" + ep + ")");
                                sendStringToTcpClient(ns, "logout success!");
                                break;
                            case "Message":
                                sendStringToTcpClient(ns, "Server Recieved!");
                                MessageBox.Show(tmpString[2]);
                                break;
                        }
                    }
                }
                ns.Close();
                tc.Close();
            }
        }
        private void listBoxAddItem(string valString)
        {
            if (listBox1.InvokeRequired)
            {
                controlCallback l = listBoxAddItem;
                Invoke(l, new object[] { valString });
            }
            else
            {
                listBox1.Items.Add(valString);
            }
        }
        private string readStringFromTcpClient(NetworkStream valNetworkStream)
        {
            try
            {
                //NetworkStream clientNS = valTcpClient.GetStream();
                
                byte[] buffer = new byte[bufferSize];
                int readBytes = 0;
                readBytes = valNetworkStream.Read(buffer, 0, bufferSize);

                string readString = Encoding.Unicode.GetString(buffer, 0, readBytes);
                return readString;
            }
            catch
            {
                return "";
            }
        }
        private bool sendStringToTcpClient(NetworkStream valNetworkStream, string valString)
        {
            try
            {
                //NetworkStream clientNS = valTcpClient.GetStream();
                byte[] sendString = Encoding.Unicode.GetBytes(valString);
                valNetworkStream.Write(sendString, 0, sendString.Length);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region 测试连接数据库服务器
        private void beginTestDatabase()
        {
            if (testDatabaseThread !=null)
            {
                if (testDatabaseThread.IsAlive)
                {
                    testDatabaseThread.Abort();
                }
            }
            testDatabaseThread = new Thread(testDatabase);
            testDatabaseThread.IsBackground = true;
            ready = false;
            testDatabaseThread.Start();
            toolStripStatusLabel2.Text = "正在尝试连接到数据库...";
            //toolStripStatusLabel2.ToolTipText = "正在尝试连接到数据库...";
        }
        private void testDatabase()
        {
            using (SqlConnection tmpSqlConnection = new SqlConnection(getConnectionString()))
            {
                try
                {
                    tmpSqlConnection.Open();
                    ready = true;
                    setToolStripStatusLabel("数据库连接正常！",Color.Green);
                }
                catch
                {
                    ready = false;
                    setToolStripStatusLabel("注意：数据库未能正常连接！请进行设置！",Color.Red);
                }
                finally
                {
                    tmpSqlConnection.Close();
                }
            }
        }
        private void setToolStripStatusLabel(string valString,Color valColor)
        {
            if (statusStrip1.InvokeRequired)
            {
                controlWithColorCallback c = setToolStripStatusLabel;
                Invoke(c, new object[] {valString, valColor});
            }
            else
            {
                toolStripStatusLabel2.Text = valString;
                toolStripStatusLabel2.AutoToolTip = true;
                toolStripStatusLabel2.ToolTipText = valString;
                toolStripStatusLabel2.ForeColor = valColor;
            }
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            listenThread.Abort();
            server.Stop();
            toolStripStatusLabel1.Text = "服务已停止！";
            button1.Enabled = true;
            button2.Enabled = false;
        }
        
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (testDatabaseThread != null && testDatabaseThread.IsAlive) testDatabaseThread.Abort();
            if (listenThread != null && listenThread.IsAlive) listenThread.Abort();
            if (server != null)
            {
                server.Stop();
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void buttonConfig_Click(object sender, EventArgs e)
        {
            FormConfig formConfig = new FormConfig();
            if (formConfig.ShowDialog(this)==DialogResult.OK)
            {
                beginTestDatabase();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
    }
}