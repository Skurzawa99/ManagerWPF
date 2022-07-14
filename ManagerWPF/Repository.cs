using ManagerWPF.Models.Converters;
using ManagerWPF.Models.Domains;
using ManagerWPF.Models.Wrappers;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerWPF
{
    public class Repository
    {
        public List<Group> GetGroups()
        {
            using (var contex = new ApplicationDbContext())
            {
                return contex.Groups.ToList();
            }
        }

        public List<EmployeeWrapper> GetEmployees(int groupId)
        {
            using (var context = new ApplicationDbContext())
            {
                var employees = context
                    .Employees
                    .Include(x => x.Group)
                    .AsQueryable();

                if(groupId != 0)
                    employees = employees.Where(x => x.GroupId == groupId);

                return employees
                    .ToList()
                    .Select(x => x.ToWrapper())
                    .ToList();

            }
        }

        public void AddEmployee(EmployeeWrapper employeeWrapper)
        {
            var employee = employeeWrapper.ToDao();

            using (var contex = new ApplicationDbContext())
            {
                var dbEmployee = contex.Employees.Add(employee);

                contex.SaveChanges();
            }
        }

        public void UpdateEmployee(EmployeeWrapper employeeWrapper)
        {
            var employee = employeeWrapper.ToDao();
            
            using (var contex = new ApplicationDbContext())
            {
                var employeeToUpdate = contex.Employees.Find(employee.EmployeeId);
                employeeToUpdate.FirstName = employee.FirstName;
                employeeToUpdate.LastName = employee.LastName;
                employeeToUpdate.DateToEmployee = employee.DateToEmployee;
                employeeToUpdate.DateDismiss = employee.DateDismiss;
                employeeToUpdate.Money = employee.Money;
                employeeToUpdate.Comments = employee.Comments;

                contex.SaveChanges();
            }
        }

        public void DismissEmployee(EmployeeWrapper employeeWrapper)
        {
            var employee = employeeWrapper.ToDao();

            using (var contex = new ApplicationDbContext())
            {
                var employeeToDelete = contex.Employees.Find(employee.EmployeeId);
                employeeToDelete.DateDismiss = employee.DateDismiss;
                employeeToDelete.GroupId = 2;

                contex.SaveChanges();
            }
        }



    }
}
