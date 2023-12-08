using Microsoft.Extensions.DependencyInjection;
using Declarative.DAL.Repositories;
using Declarative.DAL.Interfaces;

namespace Declarative.DAL.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IProjectRepository, ProjectRepository>();
            services.AddTransient<IProjectTaskRepository, ProjectTaskRepository>();
            services.AddTransient<IProjectLeaderRepository, ProjectLeaderRepository>();
            services.AddTransient<ICompanyRepository, CompanyRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
