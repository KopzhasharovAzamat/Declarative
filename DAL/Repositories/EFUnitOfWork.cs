using DAL.Entities;
using DAL.EntityFramework;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private context db;
        private EmployeeRepository employeeRepository;
        private ProjectTaskRepository projectTaskRepository;
        private ProjectLeaderRepository projectLeaderRepository;
        private ProjectRepository projectRepository;
        private CompanyRepository companyRepository;


        public EFUnitOfWork(string connectionString)
        {
            db = new context(connectionString);
        }
        public IRepository<Employee> Employees
        {
            get
            {
                if (employeeRepository == null)
                    employeeRepository = new EmployeeRepository(db);
                return employeeRepository;
            }
        }

        public IRepository<ProjectTask> ProjectTasks
        {
            get
            {
                if (projectTaskRepository == null)
                    projectTaskRepository = new ProjectTaskRepository(db);
                return projectTaskRepository;
            }
        }
        public IRepository<ProjectLeader> ProjectLeaders
        {
            get
            {
                if (projectLeaderRepository == null)
                    projectLeaderRepository = new ProjectLeaderRepository(db);
                return projectLeaderRepository;
            }
        }
        public IRepository<Project> Projects
        {
            get
            {
                if (projectRepository == null)
                    projectRepository = new ProjectRepository(db);
                return projectRepository;
            }
        }
        public IRepository<Company> Companies
        {
            get
            {
                if (companyRepository == null)
                    companyRepository = new CompanyRepository(db);
                return companyRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
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
