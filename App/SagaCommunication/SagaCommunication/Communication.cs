using System.Net.Sockets;
using System.Text;


namespace SagaCommunication
{
    public class Communication
    {
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
                int bufferSize = Properties.Settings.Default.bufferSize;
                byte[] recievedByre = new byte[bufferSize];
                int byteCount = 0;
                string recievedString = "";
                while ((byteCount == 0) && (valNetworkStream.CanRead))
                {
                    byteCount = valNetworkStream.Read(recievedByre, 0, bufferSize);
                    recievedString = Encoding.Unicode.GetString(recievedByre, 0, byteCount);
                }
                return recievedString;
            }
            catch
            {
                return "";
            }
        }
    }
}
