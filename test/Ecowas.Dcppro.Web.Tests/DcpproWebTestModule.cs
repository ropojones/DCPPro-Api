using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Ecowas.Dcppro.EntityFrameworkCore;
using Ecowas.Dcppro.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Ecowas.Dcppro.Web.Tests
{
    [DependsOn(
        typeof(DcpproWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class DcpproWebTestModule : AbpModule
    {
        public DcpproWebTestModule(DcpproEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DcpproWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(DcpproWebMvcModule).Assembly);
        }
    }
}