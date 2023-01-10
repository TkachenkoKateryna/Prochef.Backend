using FluentValidation.AspNetCore;
using Prochef.Core.Interfaces.Installer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Prochef.WebApi.Filters;

namespace Prochef.WebApi.Installer
{
    public class ControllerInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers(options =>
                    options.Filters.Add(new ValidationFilter()))
                .AddFluentValidation(cfg => cfg.RegisterValidatorsFromAssembly(typeof(Startup).Assembly));
        }
    }
}
