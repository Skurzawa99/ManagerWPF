using ManagerWPF.Models.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerWPF.Models.Configuration
{
    public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            ToTable("dbp.Employees");

            HasKey(x => x.EmployeeId);

        }
    }
}
