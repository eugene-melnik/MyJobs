using System;

namespace KPI
{
    public class JobRecord
    {
        public JobRecord(string title, string description, DateTime deadline, bool indefinitely = false)
        {
            this.title = title;
            this.description = description;
            this.deadline = deadline;
            this.indefinitely = indefinitely;
        }

        public string Title {
            get {
                return title;
            }
            set {
                title = value;
            }
        }

        public string Description {
            get {
                return description;
            }
            set {
                description = value;
            }
        }

        public DateTime Deadline {
            get {
                return deadline;
            }
            set {
                deadline = value;
            }
        }

        public bool Indefinitely {
            get {
                return indefinitely;
            }
            set {
                indefinitely = value;
            }
        }

        private string title;
        private string description;
        private DateTime deadline;
        private bool indefinitely;
    }
}

