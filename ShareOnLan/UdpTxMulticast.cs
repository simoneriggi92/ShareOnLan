using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace ShareOnLan
{
    class UdpTxMulticast
    {
        /*oggetti di configurazione endPoint*/
        private UdpClient udpClient;
        private IPEndPoint remoteEP;
        private Encoding encoder;
        private byte[] data;

        //costruttore senza parametri
        public UdpTxMulticast()
        {
        }

        //metodo per settare l'endpoint UDP
        public void SetUdpConfiguration()
        {
            udpClient = new UdpClient();
            IPAddress multicastaddress = IPAddress.Parse(Properties.Settings.Default.McastGroup);
            udpClient.JoinMulticastGroup(multicastaddress);
            remoteEP = new IPEndPoint(multicastaddress, Properties.Settings.Default.PortUDP);
            data = null;
        }

        //metodo per inviare il pacchetto in multicastUDP
        public void SendMulticastPacket()
        {
            string message = Properties.Settings.Default.PublicUsername;
            data = Encoding.Unicode.GetBytes(message);
            udpClient.Send(data, data.Length, remoteEP);
        }


        //metodo per il controllo della nick(up, down)
        public bool CheckNIC()
        {
            //controllo se la NIC è up
            bool isNetworkUp = NetworkInterface.GetIsNetworkAvailable();
            if (isNetworkUp)
            {
                //nome pc locale e lo risolvo
                var host = Dns.GetHostEntry(Dns.GetHostName());
                encoder = Encoding.Unicode;

                //imposto e ottengo lista ip del mio host
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        Properties.Settings.Default.MyIpAddress = ip.ToString();
                    }
                }
                return true;
            }
            else return false;
        }
    }
}