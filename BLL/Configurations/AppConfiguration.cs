using BLL.Services;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BLL.Configurations
{
    public static class AppConfiguration
    {
        public static void AddServices(this IServiceCollection service)
        {
            //services
            service.AddTransient<IHomeService, HomeService>();

            //repositories
            service.AddTransient<IRepository<Company>, CompanyRepository>();
        }
    }
}
