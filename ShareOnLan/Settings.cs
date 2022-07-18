using System;

namespace ShareOnLan.Properties
{

    internal sealed partial class Settings
    {

        public Settings()
        {

            SettingsLoaded += SettingsLoadedEventHandler;

        }

        private void SettingsLoadedEventHandler(object sender, System.Configuration.SettingsLoadedEventArgs e)
        {
            if (DownloadPath.Equals(String.Empty))
            {
                DownloadPath = String.Format(@"C:\Users\{0}\Downloads", Environment.UserName);
            }

            if (PublicUsername.Equals(String.Empty))
            {
                PublicUsername = Environment.UserName;
            }
        }
    }
}
