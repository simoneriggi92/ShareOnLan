using System;
using System.Collections.Concurrent;

namespace ShareOnLan
{

    public class UsersDB
    {
        public UsersDB()
        {
            UsersList = new ConcurrentDictionary<string, UserInfo>();
        }

        public ConcurrentDictionary<string, UserInfo> UsersList { get; set; }

        /// <summary>
        /// Memorizza gli utenti online e setta/aggiorna il loro timestamp
        /// </summary>
        /// <param name="userInfo">Contiene tutte le informazioni dell'utente online</param>
        public void StoreUsersToDB(UserInfo userInfo)
        {

            //aggiungo timestamp di arrivo
            userInfo.Timestamp = DateTime.Now;

            //se l'utente è già presente, aggiorno il suo timestamp
            UsersList.AddOrUpdate(userInfo.LocalEp.Address.ToString(), userInfo, (k, v) =>
            {
                v.Timestamp = DateTime.Now; return v;
            });

        }
    }
}