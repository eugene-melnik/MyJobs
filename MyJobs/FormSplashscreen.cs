using System;
using System.Windows.Forms;

namespace MyJobs
{
    public partial class FormSplashscreen : Form
    {
        /* Constructors */
        public FormSplashscreen()
        {
            InitializeComponent();
            lAppNameFull.Text = Version.AppNameFull;
            lAppAuthor.Text = Version.AppAuthor;
            lAppLicense.Text = Version.AppLicense;
        }

        /* Events' handlers */
        private void FadeIn(object sender, EventArgs e)
        {
            /*
            // FIXME: This do not works
            for (Opacity = 0.1 ; Opacity <= 1.0; Opacity += 0.1)
            {
                Refresh();
            }
            */
        }

        private void FadeOut(object sender, FormClosingEventArgs e)
        {
            /*
            // FIXME: And this one to
            for (Opacity = 1.0 ; Opacity >= 0.1; Opacity -= 0.1)
            {
                Refresh();
            }
            */
        }

        /* Properties */
        public String Status
        {
            set
            {
                lStatus.Text = value;
                Refresh();
            }
        }
    }
}
