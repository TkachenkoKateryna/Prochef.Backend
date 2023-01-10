
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Prochef.Application.Interfaces;
using Prochef.Application.Interfaces.Util;
using Prochef.Application.Services;
using Prochef.Application.Services.Util;
using Prochef.Core.Interfaces.Installer;

namespace Prochef.WebApi.Installer
{
    public class ServicesInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IChainService, ChainService>();
            services.AddScoped<IJwtTokenService, JWTTokenService>();
            services.AddScoped<IPasswordService, PasswordService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IExpensesService, ExpensesService>();
            services.AddTransient<IStringLocalizer, LocalizationService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IMenuService, MenuService>();
            services.AddScoped<IRestaurantService, RestaurantService>();
        }
    }
}
