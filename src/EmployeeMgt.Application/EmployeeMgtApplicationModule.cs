﻿using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EmployeeMgt.Authorization;

namespace EmployeeMgt
{
    [DependsOn(
        typeof(EmployeeMgtCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class EmployeeMgtApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<EmployeeMgtAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(EmployeeMgtApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
