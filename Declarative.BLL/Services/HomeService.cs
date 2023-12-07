using Declarative.BLL.Services.Interfaces;
using Declarative.DAL.Entities;
using Declarative.DAL.Interfaces;

namespace Declarative.BLL.Services
{
    public class HomeService : IHomeService
    {
        private readonly IRepository<Employee> _employeeRepository;
        private readonly IRepository<Project> _projectRepository;
        private readonly IRepository<ProjectTask> _projectTaskRepository;
        private readonly IRepository<ProjectLeader> _projectLeaderRepository;
        private readonly IRepository<Company> _companyRepository;
        public HomeService(IRepository<Company> companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public HomeService(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public HomeService(IRepository<Project> projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public HomeService(IRepository<ProjectLeader> projectLeaderRepository)
        {
            _projectLeaderRepository = projectLeaderRepository;
        }
        public HomeService(IRepository<ProjectTask> projectTaskRepository)
        {
            _projectTaskRepository = projectTaskRepository;
        }

        public void Get(string id)
        {
            return;
        }

    }
}
