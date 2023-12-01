using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Employee> Employees { get; }
        IRepository<ProjectTask> ProjectTasks { get; }
        IRepository<ProjectLeader> ProjectLeaders { get; }
        IRepository<Project> Projects { get; }
        IRepository<Company> Companies { get; }
        void Save();
    }
}
