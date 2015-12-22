using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using SagaConfiguration;
using SagaSqlDataSouceEnumrator;

namespace Client
{
    public delegate void callBackHandle(bool valBool);

    public delegate void setControlValueCallBackHandle(string valString);

    public partial class Client : Form
    {
        private ClientConfig ClientConfig;
        public Client()
        {
            InitializeComponent();
            serverReady = false;
            ClientConfig = new ClientConfig("ClientConfig.xml",true);
        }

        #region 属性
        private bool serverReady { get; set; }
        #endregion
        private void setButtonLoginEnabled(bool valBool)
        {
            if (buttonLoging.InvokeRequired)
            {
                callBackHandle h = setButtonLoginEnabled;
                Invoke(h, new object[] {valBool});
            }
            else
            {
                buttonLoging.Enabled = valBool;
            }
        }
        private void setStatus(string valString)
        {
            if (statusStrip1.InvokeRequired)
            {
                setControlValueCallBackHandle h = setStatus;
                this.Invoke(h, new object[] {valString});
            }
            else
            {
                toolStripStatusLabel1.Text = valString;
            }
        }
        private void sendToServer(object obj)
        {
            TcpClient tc = null;
            NetworkStream ns = null;

            threadParameter p = obj as threadParameter;
            string valSendString = obj as string;
            try
            {
                tc = new TcpClient();
                tc.Connect(ClientConfig.serverInformation.communicateInformation.ComputerName, ClientConfig.serverInformation.communicateInformation.CommunicatePort);
                ns = tc.GetStream();
                if (sendMessageToServer(ns, valSendString))
                {
                    //Thread.Sleep(1000);
                    string tmpString = getMessageFromServer(ns);
                    if (tmpString != "")
                    {
                        setStatus("正在测试服务器返回的数据...");
                        stringAnalyze(tmpString);
                    }
                    else
                    {
                        setStatus("服务器接受了您的信息，但是没有响应！");
                    }
                }
                else
                {
                    setStatus("消息发送失败！");
                }
                ns.Close();
                tc.Close();
                setButtonLoginEnabled(true);
            }
            catch
            {

                if (tc != null)
                {
                    if (ns != null)
                    {
                        ns.Close();
                    }
                    tc.Close();
                }
                setStatus("无法与服务器建立连接！");
            }
        }
        private bool sendMessageToServer(NetworkStream valNetworkStream, string sendString)
        {
            try
            {
                byte[] sendByte = Encoding.Unicode.GetBytes(sendString);
                valNetworkStream.Write(sendByte, 0, sendByte.Length);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private string getMessageFromServer(NetworkStream valNetworkStream)
        {
            try
            {
                int bufferSize = ClientConfig.localInformation.communicateInformation.StreamBufferSize;
                byte[] recievedByre = new byte[bufferSize];
                int byteCount = 0;
                string recievedString = "";
                //超时时间
                int timeOut = 0;
                while ((byteCount == 0) && (timeOut < 10))
                {
                    byteCount = valNetworkStream.Read(recievedByre, 0, bufferSize);
                    recievedString = Encoding.Unicode.GetString(recievedByre, 0, byteCount);
                    Thread.Sleep(100);
                    timeOut += 1;
                } 
                return recievedString;
            }
            catch
            {
                return "";
            }
        }
        private void stringAnalyze(string valString)
        {
            string[] tmpSplitString = valString.Split(Convert.ToChar("|"));
            if (tmpSplitString[0]=="Server")
            {
                switch (tmpSplitString[1])
                {
                    case "ConnectInformation":
                        if (tmpSplitString[2] == "Ready")
                        {
                            #region 配置连接
                            SqlConnectionStringBuilder tmpSCSB = new SqlConnectionStringBuilder();
                            ServerType tmpServerType =
                                ClientConfig.serverInformation.serverConnectInformation.ServerType =
                                (ServerType)Enum.Parse(typeof(ServerType), tmpSplitString[3]);
                            String tmpServerName =
                                ClientConfig.serverInformation.serverConnectInformation.ServerName = tmpSplitString[4];
                            string tmpInstance =
                                ClientConfig.serverInformation.serverConnectInformation.Instance = tmpSplitString[5];
                            tmpSCSB.DataSource = tmpServerType == ServerType.SqlServerExpress
                                                     ? tmpServerName + @"\" + tmpInstance
                                                     : tmpServerName;
                            tmpSCSB.InitialCatalog =
                                ClientConfig.serverInformation.serverConnectInformation.DataBase = tmpSplitString[6];
                            tmpSCSB.UserID =
                                ClientConfig.serverInformation.serverConnectInformation.UserID = tmpSplitString[7];
                            tmpSCSB.Password =
                                ClientConfig.serverInformation.serverConnectInformation.Password = tmpSplitString[8];
                            #endregion
                            if (testConnectString(tmpSCSB.ConnectionString))
                            {
                                setStatus("服务器端正常，您可以登陆了！");
                                //保存设置。
                                ClientConfig.save();
                            }
                            else
                            {
                                setStatus("不能根据服务器返回的数据进行连接！");
                                MessageBox.Show("不能根据服务器返回的数据进行连接！\n有可能是以下原因造成：\n1、服务器防火墙阻止了针对数据库的连接！", "注意");
                            }
                        }
                        else
                        {
                            setStatus("服务器未设置或设置不当！");
                            MessageBox.Show("以下原因有可能引起本错误：\n1、服务器未准备好！\n2、服务器未设置或设置不当！\n请重新设置服务器或等待服务器！", "错误");
                        }
                        break;
                }
                    
            }
        }
        private bool testConnectString(string valString)
        {
            using (SqlConnection tmpSqlConnection = new SqlConnection(valString))
            {
                try
                {
                    tmpSqlConnection.Open();
                    tmpSqlConnection.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TcpClient tc = null;
            NetworkStream ns = null;
            try
            {
                tc = new TcpClient();
                tc.Connect(ClientConfig.serverInformation.communicateInformation.ComputerName, ClientConfig.serverInformation.communicateInformation.CommunicatePort);
                ns = tc.GetStream();
                if (sendMessageToServer(ns, "Client|Login|郝文标"))
                {
                    string tmpString = getMessageFromServer(ns);
                    if (tmpString !="")
                    {
                        MessageBox.Show(tmpString);
                    }
                    else
                    {
                        MessageBox.Show("服务器接受了您的信息，但是没有响应！");
                    }
                }
                else
                {
                    MessageBox.Show("消息发送失败！");
                }
                ns.Close();
                tc.Close();
            }
            catch
            {
                
                if (tc != null)
                {
                    if (ns != null)
                    {
                        ns.Close();
                    }
                    tc.Close();
                }
                MessageBox.Show("can't connet to server!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            TcpClient tc = null;
            NetworkStream ns = null;
            try
            {
                tc = new TcpClient();
                tc.Connect(ClientConfig.serverInformation.communicateInformation.ComputerName,
                           ClientConfig.serverInformation.communicateInformation.CommunicatePort);
                ns = tc.GetStream();
                if (sendMessageToServer(ns, "Client|Logout|郝文标"))
                {
                    string tmpString = getMessageFromServer(ns);
                    if (tmpString != "")
                    {
                        MessageBox.Show(tmpString);
                    }
                    else
                    {
                        MessageBox.Show("服务器接受了您的信息，但是没有响应！");
                    }
                }
                else
                {
                    MessageBox.Show("消息发送失败！");
                }
                ns.Close();
                tc.Close();
            }
            catch
            {

                if (tc != null)
                {
                    if (ns != null)
                    {
                        ns.Close();
                    }
                    tc.Close();
                }
                MessageBox.Show("can't connet to server!");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            TcpClient tc = null;
            NetworkStream ns = null;
            try
            {
                tc = new TcpClient();
                tc.Connect(ClientConfig.serverInformation.communicateInformation.ComputerName,
                           ClientConfig.serverInformation.communicateInformation.CommunicatePort);
                ns = tc.GetStream();
                if (sendMessageToServer(ns, "haowenbiao|message|" + textBox1.Text))
                {
                    string tmpString = getMessageFromServer(ns);
                    if (tmpString != "")
                    {
                        MessageBox.Show(tmpString);
                    }
                    else
                    {
                        MessageBox.Show("服务器接受了您的信息，但是没有响应！");
                    }
                }
                else
                {
                    MessageBox.Show("消息发送失败！");
                }
                ns.Close();
                tc.Close();
            }
            catch
            {

                if (tc != null)
                {
                    if (ns != null)
                    {
                        ns.Close();
                    }
                    tc.Close();
                }
                MessageBox.Show("can't connet to server!");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Search s = new Search();
            s.ShowDialog(this);
        }

        private void buttonLoging_Click(object sender, EventArgs e)
        {
            ParameterizedThreadStart p = sendToServer;
            Thread t = new Thread(p);
            t.IsBackground = true;
            
            string sendString = "Client|Loging|郝文标";
            toolStripStatusLabel1.Text = "正在发送消息...";
            ((Button)sender).Enabled = false;
            t.Start(sendString);
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
