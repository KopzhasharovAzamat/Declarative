using Declarative.DAL.Entities;
using System.Data.Entity;


namespace Declarative.DAL.EntityFramework
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ProjectTask> ProjectTasks { get; set; }
        public DbSet<ProjectLeader> ProjectLeaders { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Company> Companies { get; set; }
        static AppDbContext()
        {
            Database.SetInitializer<AppDbContext>(new StoreDbInitializer());
        }
        public AppDbContext(string connectionString) : base(connectionString)
        {
        }
    }
    public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
    {
        protected override void Seed(AppDbContext db)
        {
            db.Employees.Add(new Employee
            {
                firstName = "aaa",
                lastName = "aaa",
                email = "aaa@gmail.com",
                position = "programmer"
            });
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
