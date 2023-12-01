using BLL.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Configurations
{
    public static class AppConfiguration
    {
        public static void AddServices(this IServiceCollection service)
        {
            service.AddTransient<IHomeService, HomeService>();
        }
    }
}
