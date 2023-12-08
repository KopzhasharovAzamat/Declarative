using Declarative.BLL.Services.Interfaces;
using Declarative.DAL.Entities;
using Declarative.DAL.Interfaces;

namespace Declarative.BLL.Services
{
    public class HomeService : IHomeService
    {
        private readonly IEmployeeRepository<Employee> _employeeRepository;
        private readonly IProjectRepository<Project> _projectRepository;
        private readonly IProjectTaskRepository<ProjectTask> _projectTaskRepository;
        private readonly IProjectLeaderRepository<ProjectLeader> _projectLeaderRepository;
        private readonly ICompanyRepository<Company> _companyRepository;
        public HomeService(IEmployeeRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public HomeService(IProjectRepository<Project> projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public HomeService(IProjectTaskRepository<ProjectTask> projectTaskRepository)
        {
            _projectTaskRepository = projectTaskRepository;
        }
        public HomeService(IProjectLeaderRepository<ProjectLeader> projectLeaderRepository)
        {
            _projectLeaderRepository = projectLeaderRepository;
        }
        
        public HomeService(ICompanyRepository<Company> companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public void Get(string id)
        {
            return;
        }

    }
}
