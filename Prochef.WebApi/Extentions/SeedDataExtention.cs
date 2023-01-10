using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Prochef.Infrastructure.EF;

namespace Prochef.WebApi.Extentions
{
    public static class SeedDataExtension
    {
        public static IHost SeedDatabase(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;
            var context = services.GetRequiredService<ProchefDbContext>();
            ProchefDbContextSeed.Seed(context);

            return host;
        }
    }
}
