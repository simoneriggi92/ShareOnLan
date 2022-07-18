using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ShareOnLan
{
    class UdpRxMulticast
    {
        private UdpClient udpClient;
        private IPEndPoint localEp;

        public UdpRxMulticast()
        {
        }

        //metodo per settare l'endpoint a ricevere il multicastUDP
        public void SetUdpConfiguration()
        {

            udpClient = new UdpClient();
            IPEndPoint localEp = new IPEndPoint(IPAddress.Any, Properties.Settings.Default.PortUDP);
            udpClient.Client.Bind(localEp);
            IPAddress multicastaddress = IPAddress.Parse(Properties.Settings.Default.McastGroup);
            udpClient.JoinMulticastGroup(multicastaddress);

        }

        public UserInfo ListenOnMulticastPort()
        {
            UserInfo userInfo = null;

            byte[] data = udpClient.Receive(ref localEp);

            string message = Encoding.Unicode.GetString(data);
            userInfo = new UserInfo
            {
                LocalEp = localEp,
                Username = message,
            };
            return userInfo;
        }

    }
}
