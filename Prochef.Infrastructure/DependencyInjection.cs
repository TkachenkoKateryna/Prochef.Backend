
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Prochef.Infrastructure.EF;

namespace Prochef.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
                                                          IConfiguration configuration)
        {
            services.AddDbContext<ProchefDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("ProchefDbConnection"))
            );

            return services;
        }
    }
}
