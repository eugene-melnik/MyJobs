using System;

namespace MyJobs
{
    /* Job status enumeration */
    public enum JobStatus
    {
        Active,
        Completed,
        Expired
    }

    [Serializable]
    public class Job
    {
        /* Constructors */
        public Job()
        {
            Status = JobStatus.Active;
            Title = "";
            Description = "";
            Deadline = DateTime.Now;
        }

        public Job(JobStatus status, String title, String description, DateTime deadline)
        {
            Status = status;
            Title = title;
            Description = description;
            Deadline = deadline;
        }

        /* Properties */
        public JobStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        public String Title
        {
            get { return title; }
            set { title = value; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public DateTime Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }
        
        /* Variables */
        private JobStatus status;
        private String title;
        private String description;
        private DateTime deadline;
    }
}
