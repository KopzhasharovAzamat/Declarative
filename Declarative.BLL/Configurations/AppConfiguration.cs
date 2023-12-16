using Declarative.BLL.AutoMapper1;
using Declarative.BLL.Services;
using Declarative.BLL.Services.Interfaces;
using Declarative.DAL.Entities;
using Declarative.DAL.Interfaces;
using Declarative.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Declarative.BLL.Configurations
{
    public static class AppConfiguration
    {
        public static void AddServices(this IServiceCollection service)
        {
            //services
            service.AddTransient<ICompanyService, CompanyService>();   
            service.AddTransient<IEmployeeService, EmployeeService>();
            service.AddTransient<IProjectService, ProjectService>();
            service.AddTransient<IProjectLeaderService, ProjectLeaderService>();
            service.AddTransient<IProjectTaskService, ProjectTaskService>();
          //  service.AddAutoMapper(typeof(AutoMapperProfile));
            //repositories
            service.AddTransient<IEmployeeRepository<Employee>, EmployeeRepository>();
            service.AddTransient<IProjectRepository<Project>, ProjectRepository>();
            service.AddTransient<IProjectLeaderRepository<ProjectLeader>, ProjectLeaderRepository>();
            service.AddTransient<IProjectTaskRepository<ProjectTask>, ProjectTaskRepository>();
            service.AddTransient<ICompanyRepository<Company>, CompanyRepository>();
        }
    }
}
