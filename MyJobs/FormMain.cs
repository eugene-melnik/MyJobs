using System;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using MyJobs.Properties;

namespace MyJobs
{
    public partial class FormMain : Form
    {
        /* Constructors */
        public FormMain()
        {
            InitializeComponent();
            Text = Version.AppNameFull;
            Icon = Resources.MyJobs_MainIcon_16;
        }

        /* Events' handlers */
        private void FormLoad(Object sender, EventArgs e)
        {
            // Loading settings from configuration file
            config = Config.LoadConfig();

            // Splashscreen
            FormSplashscreen splash = new FormSplashscreen();

            if (config.AppShowSplashScreen)
            {
                this.Hide();
                splash.Show();
                splash.Status = "Loading...";
            }

            // Main window properties
            Width = config.WindowWidth;
            Height = config.WindowHeight;
            Left = config.WindowLeft;
            Top = config.WindowTop;
            WindowState = config.WindowState;
            menuActionEditShowToolbar.Checked = config.WindowShowToolbar;
            ActionShowToolbar(this, null);

            // Loading database file
            try
            {
                FileStream f = new FileStream(config.DatabaseFileName, FileMode.Open);
                BinaryFormatter ser = new BinaryFormatter();
                listJobs = (ArrayList)ser.Deserialize(f);
                f.Close();
            }
            catch (Exception ex)
            {
                Log.AppendMessage(ex.Message);
                listJobs = new ArrayList();
                jobsChanged = true;
            }

            foreach (Job t in listJobs)
            {
                // Looking for expired jobs
                if (!t.Termless && (t.DeadlineDate > DateTime.Now))
                {
                    t.Status = JobStatus.Expired;
                }

                // Output data to the main window
                AddItemInList(t);
            }

            // End of processing
            splash.Close();
            this.Show();
        }

        private void ActionShowToolbar(Object sender, EventArgs e)
        {
            if ((config.WindowShowToolbar = menuActionEditShowToolbar.Checked) == true)
            {
                toolsMain.Show();
            }
            else
            {
                toolsMain.Hide();
            }
        }

        private void ActionPreferences(Object sender, EventArgs e)
        {
            FormPreferences form = new FormPreferences(ref config);
            form.ShowDialog(this);
        }

        private void ActionStatistic(Object sender, EventArgs e)
        {
            FormStatistic form = new FormStatistic(listJobs.Count,
                                                   GetNumberOfJobs(JobStatus.Completed),
                                                   GetNumberOfJobs(JobStatus.Expired));
            form.ShowDialog(this);
        }

        private void ActionCreateJob(Object sender, EventArgs e)
        {
            FormCreateJob form = new FormCreateJob();
            form.OnJobAddition += new FormCreateJob.JobAdditionHandler(ActionJobAdding);
            form.ShowDialog(this);
        }

        private void ActionJobAdding(Object sender, Job newJob)
        {
            AddItemInList(newJob);
            listJobs.Add(newJob);
            jobsChanged = true;
        }

        private void ActionAbout(Object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog(this);
        }

        private void ActionClosing(object sender, FormClosingEventArgs e)
        {
            // Works only when close button on window decoration were pressed
            if ((e.CloseReason == CloseReason.UserClosing) && config.AppHideToTrayOnClose)
            {
                WindowState = FormWindowState.Minimized;
                e.Cancel = true;
            }
        }

        private void ActionExit(Object sender, EventArgs e)
        {
            // Saving main window state
            config.WindowState = WindowState;
            config.WindowWidth = Width;
            config.WindowHeight = Height;
            config.WindowLeft = Left;
            config.WindowTop = Top;
            config.SaveConfig();

            // Saving database
            ActionAutosave(this, null);

            // And exit
            Application.Exit();
        }

        private void ActionAutosave(Object sender, EventArgs e)
        {
            if (jobsChanged)
            {
                try
                {
                    FileStream f = new FileStream(config.DatabaseFileName, FileMode.Create);
                    BinaryFormatter ser = new BinaryFormatter();
                    ser.Serialize(f, listJobs);
                    f.Close();
                    jobsChanged = false;
                }
                catch (Exception ex)
                {
                    Log.AppendMessage(ex.Message);
                    MessageBox.Show(this, ex.Message, "Saving error", MessageBoxButtons.OK);
                }
            }
        }

        /* Additional functions */
        private Int32 GetNumberOfJobs(JobStatus status)
        {
            Int32 res = 0;

            foreach (Job t in listJobs)
            {
                if (t.Status == status) res++;
            }

            return res;
        }

        private void AddItemInList(Job t)
        {
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(t.Title);

            if (t.Status == JobStatus.Completed)
            {
                item.Checked = true;
            }

            if (t.Termless)
            {
                item.SubItems.Add("Termless");
            }
            else
            {
                item.SubItems.Add(t.DeadlineDate.ToShortDateString());
            }

            listMain.Items.Add(item);
        }

        /* Variables */
        private Config config;
        private ArrayList listJobs;
        private Boolean jobsChanged = false;
    }
}
