using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyTask.Business.ExternalServices.Implementation;
using UdemyTask.Business.ExternalServices.Interfaces;
using UdemyTask.Business.Services.Implementations;
using UdemyTask.Business.Services.Interfaces;

namespace UdemyTask.Business
{
    public static class ServiceRegistration
    {
        public  static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<ITokenService, TokenService>();
        }
    }
}
