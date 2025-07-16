using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Domain
{
    internal class Job
    {
        public string JobId { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public string CompanyName { get; set; }
        public DateTime PostedDate { get; set; }
        public string EmployeeId { get; set; } // Foreign key to Employee
        public Employee Employee { get; set; } // Navigation property to Employee
    }
}
