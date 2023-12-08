using Declarative.DAL.Entities;

namespace Declarative.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository<Employee> Employees { get; }
        IProjectTaskRepository<ProjectTask> ProjectTasks { get; }
        IProjectLeaderRepository<ProjectLeader> ProjectLeaders { get; }
        IProjectRepository<Project> Projects { get; }
        ICompanyRepository<Company> Companies { get; }
        void Save();
    }
}
