using System;
using System.Windows.Forms;
using MyJobs.Properties;

namespace MyJobs
{
    public partial class FormCreateJob : Form
    {
        /* Constructors */
        public FormCreateJob()
        {
            InitializeComponent();
            Icon = Resources.Jobs_Create_Icon_16;
            newJob = new Job();
        }

        // Edit job mode
        public FormCreateJob(Job job)
        {
            InitializeComponent();
            Text = "Edit job";
            Icon = Resources.Jobs_Edit_Icon_16;
            newJob = job;

            textTitle.Text = newJob.Title;
            textDescription.Text = newJob.Description;

            if (newJob.Termless)
            {
                checkTermless.Checked = true;
                ActionTermless(this, null);
            }
            else
            {
                calendarDeadline.SelectionStart = newJob.DeadlineDate;
            }
        }

        /* Events' handlers */
        private void ActionTermless(Object sender, EventArgs e)
        {
            if (checkTermless.Checked)
            {
                calendarDeadline.Enabled = false;
                calendarDeadline.SelectionStart = DateTime.MinValue; // for termless job
            }
            else
            {
                calendarDeadline.Enabled = true;
                calendarDeadline.SelectionStart = DateTime.Now;
            }
        }

        private void ActionOK(Object sender, EventArgs e)
        {
            newJob.Title = textTitle.Text;
            newJob.Description = textDescription.Text;
            newJob.DeadlineDate = calendarDeadline.SelectionStart;

            // Checking title text
            if (newJob.Title.Length == 0)
            {
                MessageBox.Show(this, "Field \"Title\" can't be empty!", "Error");
                textTitle.Focus();
                return;
            }

            // Checking selected date
            if ((newJob.DeadlineDate <= DateTime.Now.AddDays(-1))  // yesterday and before
                && (newJob.DeadlineDate != DateTime.MinValue))     // termless
            {
                MessageBox.Show(this, "You can't create expired job!", "Error");
                calendarDeadline.Focus();
                return;
            }

            if (OnJobAddition != null)
            {
                OnJobAddition(this, newJob);
            }

            Close();
        }

        private void ActionCancel(Object sender, EventArgs e)
        {
            Close();
        }

        /* Adding job event */
        public delegate void JobAdditionHandler(Object sender, Job newJob);
        public event JobAdditionHandler OnJobAddition;

        /* Variables */
        private Job newJob;
    }
}
