using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Entities;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;

namespace DAL.EntityFramework
{
    public class context : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ProjectTask> ProjectTasks { get; set; }
        public DbSet<ProjectLeader> ProjectLeaders { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Company> Companies { get; set; }
        static context()
        {
            Database.SetInitializer<context>(new StoreDbInitializer());
        }
        public context(string connectionString) : base(connectionString)
        {
        }
    }
    public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<context>
    {
        protected override void Seed(context db)
        {
            db.Employees.Add(new Employee { 
                firstName = "aaa", 
                lastName = "aaa", 
                email = "aaa@gmail.com", 
                position="programmer" });
            db.Employees.Add(new Employee
            {
                firstName = "bbb",
                lastName = "bbb",
                email = "bbb@gmail.com",
                position = "programmer"
            });
            db.Employees.Add(new Employee
            {
                firstName = "ccc",
                lastName = "ccc",
                email = "ccc@gmail.com",
                position = "programmer"
            });
            db.SaveChanges();
        }
    }
}
