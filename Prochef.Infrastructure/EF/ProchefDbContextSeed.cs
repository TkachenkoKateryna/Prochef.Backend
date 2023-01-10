
using System;
using Microsoft.EntityFrameworkCore;

namespace Prochef.Infrastructure.EF
{
    public static class ProchefDbContextSeed
    {
        public static void Seed(ProchefDbContext context, int retry = 0)
        {
            try
            {
                context.Database.Migrate();
                context.Database.EnsureCreated();
            }
            catch (Exception ex)
            {
                if (retry >= 10)
                {
                    throw;
                }

                retry++;
                Seed(context, retry);
                throw;
            }
        }
    }
}
