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

        /* Events' handlers */
        private void ActionNoStatute(Object sender, EventArgs e)
        {
            if (checkNoStatute.Checked)
            {
                calendarDeadline.Enabled = false;
            }
            else
            {
                calendarDeadline.Enabled = true;
            }
        }

        private void ActionOK(Object sender, EventArgs e)
        {
            newJob.Title = textTitle.Text;
            newJob.Description = textDescription.Text;
            newJob.Deadline = calendarDeadline.SelectionStart;

            if (newJob.Title.Length == 0)
            {
                MessageBox.Show(this, "Field \"Title\" can't be empty!", "Error", MessageBoxButtons.OK);
                textTitle.Focus();
                return;
            }

            if (newJob.Deadline <= DateTime.Now.AddDays(-1))  // <- yesterday
            {
                MessageBox.Show(this, "You can't create overdue job!", "Error", MessageBoxButtons.OK);
                calendarDeadline.Focus();
                return;
            }

            OnJobAddition(this, newJob);
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
