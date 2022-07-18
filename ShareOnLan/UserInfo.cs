using System;
using System.Net;

namespace ShareOnLan
{
    /// <summary>
    /// Rappresenta l'utente (il client cui mandare i file, e da cui riceverli)
    /// </summary>
    public class UserInfo
    {
        public UserInfo()
        {
        }

        public UserInfo(string username, IPEndPoint localEp)
        {
            Username = username;
        }

        public UserInfo(string username, string stringLocalEp, DateTime timestamp)
        {
            Username = username;
            StringLocalEp = stringLocalEp;
            Timestamp = timestamp;
        }

        //username dell'utente client
        public string Username { get; set; }

        //indirizzo IP dell'host su cui è connesso l'utente client
        public IPEndPoint LocalEp { get; set; }

        //indirizzo IP (stringa) utilizzato nel tcp
        public string StringLocalEp { get; set; }

        //timestamp dell'ultima volta in cui l'utente client si è annunciato online
        public DateTime Timestamp { get; set; }

    }
}
