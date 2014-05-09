using System;
using System.Collections;
using System.Windows.Forms;
using MyJobs.Properties;

namespace MyJobs
{
    public partial class FormFindJob : Form
    {
        /* Constructors */
        public FormFindJob(ref ArrayList refListJobs)
        {
            InitializeComponent();
            Icon = Resources.Jobs_Find_Icon_16;
            listJobs = refListJobs;
        }

        /* Events' handlers */
        private void ActionKeyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ActionSearch(this, null);
                e.Handled = true;
            }
        }

        private void ActionSearch(Object sender, EventArgs e)
        {
            if (textKeyword.Text.Length == 0)
            {
                MessageBox.Show(this, "Input keyword first!", "Error", MessageBoxButtons.OK);
                return;
            }

            listMain.Items.Clear();

            foreach (Job t in listJobs)
            {
                // Bicycle here...
                if ((t.Status == JobStatus.Active && checkActive.Checked)
                    || (t.Status == JobStatus.Completed && checkCompleted.Checked)
                    || (t.Status == JobStatus.Expired && checkExpired.Checked))
                {
                    if (t.Title.Contains(textKeyword.Text)
                        || t.Description.Contains(textKeyword.Text))
                    {
                        AddItemToList(t);
                    }
                }
            }
        }

        private void ActionClose(Object sender, EventArgs e)
        {
            Close();
        }

        /* Additional functions */
        private void AddItemToList(Job t)
        {
            ListViewItem item = new ListViewItem(t.Status.ToString());
            item.SubItems.Add(t.Title);

            if (t.Termless)
            {
                item.SubItems.Add("Termless");
            }
            else
            {
                item.SubItems.Add(t.DeadlineDate.ToShortDateString());
            }

            if (t.Status == JobStatus.Completed)
            {
                item.SubItems.Add(t.CompletedDate.ToShortDateString());
            }

            listMain.Items.Add(item);
        }

        /* Variables */
        private ArrayList listJobs;
    }
}
