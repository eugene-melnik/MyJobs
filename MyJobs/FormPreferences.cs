using System;
using System.Windows.Forms;
using MyJobs.Properties;

namespace MyJobs
{
    public partial class FormPreferences : Form
    {
        /* Constructors */
        public FormPreferences(ref Config c)
        {
            InitializeComponent();
            Icon = Resources.Properties_Icon_16;

            // Restoring options
            config = c;
            checkAutoremoveOld.Checked = config.JobAutoremoveOld;
            ActionAutoremoveOld(this, null);
            checkAutoremoveDoned.Checked = config.JobAutoremoveOldDoned;
            checkAutoremoveFailed.Checked = config.JobAutoremoveOldFailed;
            textOlderThanDays.Text = config.JobAutoremoveOlderThanDays.ToString();
            checkShowSplashScreen.Checked = config.AppShowSplashScreen;
            checkHideToTray.Checked = config.AppHideToTrayOnClose;
            checkSHowNotifications.Checked = config.AppShowNotifications;
        }

        /* Events' handlers */
        private void ActionAutoremoveOld(object sender, EventArgs e)
        {
            if (checkAutoremoveOld.Checked)
            {
                checkAutoremoveDoned.Enabled = true;
                checkAutoremoveFailed.Enabled = true;
                textOlderThanDays.Enabled = true;
            }
            else
            {
                checkAutoremoveDoned.Enabled = false;
                checkAutoremoveFailed.Enabled = false;
                textOlderThanDays.Enabled = false;
            }
        }

        private void ActionOK(object sender, EventArgs e)
        {
            //Saving options
            config.JobAutoremoveOld = checkAutoremoveOld.Checked;
            config.JobAutoremoveOldDoned = checkAutoremoveDoned.Checked;
            config.JobAutoremoveOldFailed = checkAutoremoveFailed.Checked;
            config.JobAutoremoveOlderThanDays = Convert.ToInt32(textOlderThanDays.Text);
            config.AppShowSplashScreen = checkShowSplashScreen.Checked;
            config.AppHideToTrayOnClose = checkHideToTray.Checked;
            config.AppShowNotifications = checkSHowNotifications.Checked;
            config.SaveConfig();
            // And exit
            Close();
        }

        private void ActionCancel(object sender, EventArgs e)
        {
            Close();
        }

        /* Variables */
        private Config config;
    }
}
