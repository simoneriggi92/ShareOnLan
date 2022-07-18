using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ShareOnLan
{
    public class HeaderTcp
    {
        public string Filename { get; set; }
        public string Username { get; set; }
        public long Filesize { get; set; }

        public void ExtractHeaderFields(string header)
        {
            string[] splitted = header.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            Dictionary<string, string> headers = new Dictionary<string, string>();
            foreach (string s in splitted)
            {
                if (s.Contains(":"))
                {
                    headers.Add(s.Substring(0, s.IndexOf(":")), s.Substring(s.IndexOf(":") + 1));
                }
            }
            Filesize = long.Parse(headers["Content-length"]);
            Filename = headers["Filename"];
            Username = headers["Username"];
        }

        /// <summary>
        /// Crea l'header tcp con tutte le informazioni che servono
        /// per inviare un file da mittente a destinatario
        /// </summary>
        /// <param name="username">Username del mittente</param>
        /// <param name="fs">Filestream del file da inviare</param>
        /// <param name="filename">Nome del file</param>
        /// <param name="header">Header byte array</param>
        /// <returns>Il tcp header creato</returns>
        public byte[] CreateHeaderTcp(string username, FileStream fs, string filename, byte[] header)
        {
            string headerStr = String.Format("Username:{0}{1}Content-length:{2}{3}Filename:{4}{5}", username, Environment.NewLine, fs.Length.ToString(), Environment.NewLine, filename, Environment.NewLine);
            Array.Copy(Encoding.ASCII.GetBytes(headerStr), header, Encoding.ASCII.GetBytes(headerStr).Length);
            return header;
        }

    }
}
