using Prochef.Core.Interfaces.Installer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Prochef.Core.Interfaces.Repositories;
using Prochef.Infrastructure.Repositories;

namespace Prochef.WebApi.Installer
{
    public class RepositoriesInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
