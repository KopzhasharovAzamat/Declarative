﻿using Declarative.BLL.Services;
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
            service.AddTransient<IHomeService, HomeService>();

            //repositories
            service.AddTransient<IRepository<Employee>, EmployeeRepository>();
            service.AddTransient<IRepository<Project>, ProjectRepository>();
            service.AddTransient<IRepository<ProjectLeader>, ProjectLeaderRepository>();
            service.AddTransient<IRepository<ProjectTask>, ProjectTaskRepository>();
            service.AddTransient<IRepository<Company>, CompanyRepository>();

            service.AddTransient<IEmployeeRepository<Employee>, EmployeeRepository>();
            service.AddTransient<IProjectRepository<Project>, ProjectRepository>();
            service.AddTransient<IProjectLeaderRepository<ProjectLeader>, ProjectLeaderRepository>();
            service.AddTransient<IProjectTaskRepository<ProjectTask>, ProjectTaskRepository>();
            service.AddTransient<ICompanyRepository<Company>, CompanyRepository>();


        }
    }
}