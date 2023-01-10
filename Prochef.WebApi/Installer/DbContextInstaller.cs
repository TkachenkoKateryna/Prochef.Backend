using Prochef.Core.Interfaces.Installer;
using Prochef.Infrastructure.EF;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Prochef.WebApi.Installer
{
    public class DbContextInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            string connectionsString = configuration.GetConnectionString("ProchefDev");

            services.AddDbContext<ProchefDbContext>(options =>
                options.UseSqlServer(connectionsString));
        }
    }
}
