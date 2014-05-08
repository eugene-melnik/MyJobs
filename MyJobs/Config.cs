using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using MyJobs.Properties;

namespace MyJobs
{
    [Serializable]
    public class Config
    {
        /* Constructor */
        public Config()
        {
            databaseFileName = Resources.strDatabaseStdFileName;

            windowState = FormWindowState.Normal;
            windowWidth = 400;
            windowHeight = 350;
            windowLeft = 25;
            windowTop = 25;
            windowShowToolbar = true;

            jobAutoremoveOld = false;
            jobAutoremoveOldDoned = true;
            jobAutoremoveOldFailed = true;
            jobAutoremoveOlderThanDays = 30;

            appShowSplashScreen = true;
            appHideToTrayOnClose = false;
            appShowNotifications = false;
        }

        /* Methods */
        public void SaveConfig()
        {
            try
            {
                FileStream f = new FileStream(Resources.strConfigFileName, FileMode.Create);
                BinaryFormatter ser = new BinaryFormatter();
                ser.Serialize(f, this);
                f.Close();
            }
            catch (Exception ex)
            {
                Log.AppendMessage(ex.Message);
            }
        }

        static public Config LoadConfig()
        {
            Config result;

            try
            {
                FileStream f = new FileStream(Resources.strConfigFileName, FileMode.Open);
                BinaryFormatter ser = new BinaryFormatter();
                result = (Config)ser.Deserialize(f);
                f.Close();
            }
            catch (Exception ex)
            {
                Log.AppendMessage(ex.Message);
                result = new Config();
            }

            return result;
        }

        /* Properties */
        public String DatabaseFileName
        {
            get { return databaseFileName; }
            set { databaseFileName = value; }
        }

        public FormWindowState WindowState
        {
            get { return windowState; }
            set { windowState = value; }
        }

        public Int32 WindowWidth
        {
            get { return windowWidth; }
            set { windowWidth = value; }
        }

        public Int32 WindowHeight
        {
            get { return windowHeight; }
            set { windowHeight = value; }
        }
        
        public Int32 WindowLeft
        {
            get { return windowLeft; }
            set { windowLeft = value; }
        }
        
        public Int32 WindowTop
        {
            get { return windowTop; }
            set { windowTop = value; }
        }

        public Boolean WindowShowToolbar
        {
            get { return windowShowToolbar; }
            set { windowShowToolbar = value; }
        }

        public Boolean JobAutoremoveOld
        {
            get { return jobAutoremoveOld; }
            set { jobAutoremoveOld = value; }
        }

        public Boolean JobAutoremoveOldDoned
        {
            get { return jobAutoremoveOldDoned; }
            set { jobAutoremoveOldDoned = value; }
        }

        public Boolean JobAutoremoveOldFailed
        {
            get { return jobAutoremoveOldFailed; }
            set { jobAutoremoveOldFailed = value; }
        }

        public Int32 JobAutoremoveOlderThanDays
        {
            get { return jobAutoremoveOlderThanDays; }
            set { jobAutoremoveOlderThanDays = value; }
        }

        public Boolean AppShowSplashScreen
        {
            get { return appShowSplashScreen; }
            set { appShowSplashScreen = value; }
        }

        public Boolean AppHideToTrayOnClose
        {
            get { return appHideToTrayOnClose; }
            set { appHideToTrayOnClose = value; }
        }

        public Boolean AppShowNotifications
        {
            get { return appShowNotifications; }
            set { appShowNotifications = value; }
        }

        /* Variables */
        private String databaseFileName;

        private FormWindowState windowState;
        private Int32 windowWidth;
        private Int32 windowHeight;
        private Int32 windowLeft;
        private Int32 windowTop;
        private Boolean windowShowToolbar;

        private Boolean jobAutoremoveOld;
        private Boolean jobAutoremoveOldDoned;
        private Boolean jobAutoremoveOldFailed;
        private Int32 jobAutoremoveOlderThanDays;

        private Boolean appShowSplashScreen;
        private Boolean appHideToTrayOnClose;
        private Boolean appShowNotifications;
    }
}
