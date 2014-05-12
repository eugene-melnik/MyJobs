using System;
using System.Windows.Forms;

namespace MyJobs
{
    public partial class FormJobDetails : Form
    {
        /* Constructors */
        public FormJobDetails(Job job)
        {
            InitializeComponent();

            textMain.Text += "Title: " + job.Title + Environment.NewLine + Environment.NewLine;
            textMain.Text += "Description: " + job.Description + Environment.NewLine + Environment.NewLine;
            textMain.Text += "Deadline: " + job.DeadlineDate.ToShortDateString() + Environment.NewLine + Environment.NewLine;
            textMain.Text += "Status: " + job.Status.ToString();

            if (job.Status == JobStatus.Completed)
            {
                textMain.Text += " (at " + job.CompletedDate.ToShortDateString() + ")";
            }

            textMain.Text += Environment.NewLine;
        }

        /* Events' handlers */
        private void ActionClose(Object sender, EventArgs e)
        {
            Close();
        }
    }
}
