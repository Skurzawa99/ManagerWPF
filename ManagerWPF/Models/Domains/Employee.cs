using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerWPF.Models.Domains
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateToEmployee { get; set; }
        public string DateDismiss { get; set; }
        public decimal Money { get; set; }
        public string Comments { get; set; }
        public int GroupId { get; set; }

        public Group Group { get; set; }
        public object ToWrapper { get; internal set; }
    }
}
