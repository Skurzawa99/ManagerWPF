using ManagerWPF.Models.Domains;
using ManagerWPF.Models.Wrappers;

namespace ManagerWPF.Models.Converters
{
    public static class EmployeeConverter
    {
        public static EmployeeWrapper ToWrapper(this Employee model)
        {
            return new EmployeeWrapper
            {
                EmployeeId = model.EmployeeId,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Comments = model.Comments,
                Money = model.Money,
                DateDismiss = model.DateDismiss,
                DateToEmployee = model.DateToEmployee,
                Group = new GroupWrapper
                {
                    Id = model.Group.Id,
                    Name = model.Group.Name
                },
            };
        }

        public static Employee ToDao(this EmployeeWrapper model)
        {
            return new Employee
            {
                EmployeeId = model.EmployeeId,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Comments = model.Comments,
                Money = model.Money,
                DateDismiss = model.DateDismiss,
                DateToEmployee = model.DateToEmployee,
                GroupId = model.Group.Id,
            };
        }
    }
}
