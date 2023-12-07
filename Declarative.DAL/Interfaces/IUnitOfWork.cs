using Declarative.DAL.Entities;

namespace Declarative.DAL.Interfaces
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
