using Declarative.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Diagnostics.Metrics;


namespace Declarative.DAL.EntityFramework
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<ProjectTask> ProjectTasks { get; set; }
        public virtual DbSet<ProjectLeader> ProjectLeaders { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        static AppDbContext()
        {
        }

        //public virtual DbSet<Project> Project {  get; set; }
        //public virtual DbSet<ProjectTask> ProjectTask { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .HasOne(x => x.Project)
                .WithOne(a => a.CustomerCompany)
                .HasForeignKey<Project>(c => c.Id);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>()
                .HasOne(x => x.Project)
                .WithOne(a => a.ProjectLeader)
                .HasForeignKey<Project>(c => c.Id);
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-2BAMTAJ\\SQL_2022;Initial Catalog=Declarative;User ID=sa;Password=123; MultipleActiveResultSets = True;");
            }
        }
    }
    //public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
    //{
    //    protected override void Seed(AppDbContext db)
    //    {
    //        db.Employees.Add(new Employee
    //        {
    //            firstName = "aaa",
    //            lastName = "aaa",
    //            email = "aaa@gmail.com",
    //            position = "programmer"
    //        });
    //        db.Employees.Add(new Employee
    //        {
    //            firstName = "bbb",
    //            lastName = "bbb",
    //            email = "bbb@gmail.com",
    //            position = "programmer"
    //        });
    //        db.Employees.Add(new Employee
    //        {
    //            firstName = "ccc",
    //            lastName = "ccc",
    //            email = "ccc@gmail.com",
    //            position = "programmer"
    //        });
    //        db.SaveChanges();
    //    }
    //}
}
