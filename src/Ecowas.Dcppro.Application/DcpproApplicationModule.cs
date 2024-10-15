using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Ecowas.Dcppro.Authorization;

namespace Ecowas.Dcppro
{
    [DependsOn(
        typeof(DcpproCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DcpproApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DcpproAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DcpproApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
