using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_task_2.Models
{
    internal class Exam
    {
        public string Student { get; set; }
        public int Point { get; set; }
        public string Subject { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Exam(string student, int point, string subject, DateTime startDate, DateTime endDate)
        {
            Student = student;
            Point = point;
            Subject = subject;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
    
}
