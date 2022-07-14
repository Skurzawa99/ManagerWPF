using ManagerWPF.Models.Configuration;
using ManagerWPF.Models.Domains;
using System;
using System.Data.Entity;
using System.Linq;

namespace ManagerWPF
{
    public class ApplicationDbContext : DbContext
    {

        private static string _serwerAdress = Properties.Settings.Default.SerwerAdress;
        private static string _serwerName = Properties.Settings.Default.SerwerName;
        private static string _databaseName = Properties.Settings.Default.DatabaseName;
        private static string _userName = Properties.Settings.Default.UserName;
        private static string _userPassword = Properties.Settings.Default.UserPassword;

        public ApplicationDbContext()
            : base($@"Server = {_serwerAdress}\{_serwerName}; 
            Database={_databaseName}; 
            User Id = {_userName}; 
            Password={_userPassword};")
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
            modelBuilder.Configurations.Add(new GroupConfiguration());
        }
    }

}