using Declarative.DAL.Entities;
using Declarative.DAL.EntityFramework;
using Declarative.DAL.Interfaces;

namespace Declarative.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext context;
        private EmployeeRepository employeeRepository;
        private ProjectTaskRepository projectTaskRepository;
        private ProjectLeaderRepository projectLeaderRepository;
        private ProjectRepository projectRepository;
        private CompanyRepository companyRepository;

        public UnitOfWork(AppDbContext context)
        {
            this.context = context;
        }
        public IEmployeeRepository<Employee> Employees
        {
            get
            {
                if (employeeRepository == null)
                    employeeRepository = new EmployeeRepository(context);
                return employeeRepository;
            }
        }

        public IProjectTaskRepository<ProjectTask> ProjectTasks
        {
            get
            {
                if (projectTaskRepository == null)
                    projectTaskRepository = new ProjectTaskRepository(context);
                return projectTaskRepository;
            }
        }
        public IProjectLeaderRepository<ProjectLeader> ProjectLeaders
        {
            get
            {
                if (projectLeaderRepository == null)
                    projectLeaderRepository = new ProjectLeaderRepository(context);
                return projectLeaderRepository;
            }
        }
        public IProjectRepository<Project> Projects
        {
            get
            {
                if (projectRepository == null)
                    projectRepository = new ProjectRepository(context);
                return projectRepository;
            }
        }
        public ICompanyRepository<Company> Companies
        {
            get
            {
                if (companyRepository == null)
                    companyRepository = new CompanyRepository(context);
                return companyRepository;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }
        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
