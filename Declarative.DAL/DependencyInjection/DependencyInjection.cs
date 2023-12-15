using Microsoft.Extensions.DependencyInjection;
using Declarative.DAL.Repositories;
using Declarative.DAL.Interfaces;
using Declarative.DAL.Entities;

namespace Declarative.DAL.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IEmployeeRepository<Employee>, EmployeeRepository>();
            services.AddTransient<IProjectRepository<Project>, ProjectRepository>();
            services.AddTransient<IProjectTaskRepository<ProjectTask>, ProjectTaskRepository>();
            services.AddTransient<IProjectLeaderRepository<ProjectLeader>, ProjectLeaderRepository>();
            services.AddTransient<ICompanyRepository<Company>, CompanyRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
