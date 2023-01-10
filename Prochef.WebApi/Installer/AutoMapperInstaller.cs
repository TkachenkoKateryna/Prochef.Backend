using System.Collections.Generic;
using Prochef.Core.Interfaces.Installer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using AutoMapper;
using Prochef.Application.Mapper;

namespace Prochef.WebApi.Installer
{
    public class AutoMapperInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            var autoMapperConfiguration = new MapperConfiguration(cfg =>
                cfg.AddProfiles(new List<Profile>{new ApplicationMappingProfile()}))
                    .CreateMapper();
            services.AddSingleton(autoMapperConfiguration);
        }
    }
}
