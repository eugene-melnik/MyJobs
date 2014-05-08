using System;
using System.Windows.Forms;

namespace MyJobs
{
    public partial class FormAbout : Form
    {
        /* Constructors */
        public FormAbout()
        {
            InitializeComponent();
            Icon = Properties.Resources.Help_About_Icon_16;
            lAppName.Text = Version.AppName;
            lAppVersion.Text = "ver. " + Version.AppVersionFull;
            lAppAuthor.Text = Version.AppAuthor;
            lAppLicense.Text = Version.AppLicense;
        }

        /* Events' handlers */
        private void ActionEasterEgg(Object sender, EventArgs e)
        {
            if (--easterEgg < 0)
            {
                lAppName.Text = "O_O";
            }
        }

        private void ActionClose(Object sender, EventArgs e)
        {
            Close();
        }

        /* Variables */
        private Int16 easterEgg = 10;
    }
}
