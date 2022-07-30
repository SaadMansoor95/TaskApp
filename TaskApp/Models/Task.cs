using System;

namespace TaskApp.Models
{
    public class Tasks
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public DateTime TaskDateTime { get; set; }
        public bool SetReminder { get; set; }
    }
}
