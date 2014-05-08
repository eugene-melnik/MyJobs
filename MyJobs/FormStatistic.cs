using System;
using System.Drawing;
using System.Windows.Forms;
using MyJobs.Properties;

namespace MyJobs
{
    public partial class FormStatistic : Form
    {
        /* Constructors */
        public FormStatistic(Int32 totalJobs, Int32 completedJobs, Int32 expiredJobs)
        {
            InitializeComponent();
            Icon = Resources.Statistic_Icon_16;

            // Calculations
            activeJobs = totalJobs - completedJobs - expiredJobs;

            if (totalJobs == 0)
            {
                jobCompletedSize = 360;
                jobRemainingSize = jobExpiredSize = 0;
                jobsEfficiency = 100;
            }
            else
            {
                jobCompletedSize = 360 * completedJobs / totalJobs;
                jobRemainingSize = 360 * activeJobs / totalJobs;
                jobExpiredSize =  360 - jobRemainingSize - jobCompletedSize;
                jobsEfficiency = 100 * completedJobs / totalJobs;
            }

            // Fill data
            lTotalJobs.Text = totalJobs.ToString();
            lActiveJobs.Text = activeJobs.ToString();
            lCompletedJobs.Text = completedJobs.ToString();
            lExpiredJobs.Text = expiredJobs.ToString();
            lEfficiency.Text = jobsEfficiency.ToString() + "%";
        }

        /* Events' handlers */
        private void RedrawDiagram(object sender, PaintEventArgs e)
        {
            // Instruments 
            int size = panelDiagram.Width < panelDiagram.Height ? panelDiagram.Width : panelDiagram.Height;
            Rectangle rect = new Rectangle(0, 0, size, size);
            SolidBrush brushDone = new SolidBrush(Color.Green);
            SolidBrush brushRemained = new SolidBrush(Color.Blue);
            SolidBrush brushFailed = new SolidBrush(Color.Red);

            // Drawing
            e.Graphics.FillPie(brushDone, rect, 0, jobCompletedSize);
            e.Graphics.FillPie(brushRemained, rect, jobCompletedSize, jobRemainingSize);
            e.Graphics.FillPie(brushFailed, rect, jobCompletedSize + jobRemainingSize, jobExpiredSize);
        }

        private void ActionClose(object sender, EventArgs e)
        {
            Close();
        }

        /* Variables */
        private Int32 activeJobs;
        private float jobCompletedSize;
        private float jobRemainingSize;
        private float jobExpiredSize;
        private Int32 jobsEfficiency;
    }
}
