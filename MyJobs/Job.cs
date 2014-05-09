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
            Random r = new Random((Int32)DateTime.Now.Ticks);
            key = r.Next();

            Status = JobStatus.Active;
            Title = "";
            Description = "";
            DeadlineDate = DateTime.MinValue;
        }

        public Job(JobStatus status, String title, String description, DateTime deadline)
        {
            Random r = new Random((Int32)DateTime.Now.Ticks);
            key = r.Next();

            Status = status;
            Title = title;
            Description = description;
            DeadlineDate = deadline;
        }

        /* Properties */
        public Int32 Key
        {
            get { return key; }
        }

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

        public Boolean Termless
        {
            get { return (deadlineDate==DateTime.MinValue); }
        }

        public DateTime DeadlineDate
        {
            get { return deadlineDate; }
            set { deadlineDate = value; }
        }

        public DateTime CompletedDate
        {
            get { return completedDate; }
            set { completedDate = value; }
        }
        
        /* Variables */
        private Int32 key;
        private JobStatus status;
        private String title;
        private String description;
        private DateTime deadlineDate;
        private DateTime completedDate;
    }
}
