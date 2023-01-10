using Prochef.Core.Interfaces.Installer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Prochef.Application.Options;

namespace Prochef.WebApi.Installer
{
    public class OptionsInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<JWTOptions>(configuration.GetSection(JWTOptions.SectionName));
        }
    }
}
