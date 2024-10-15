using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Ecowas.Dcppro.Configuration;

namespace Ecowas.Dcppro.Web.Host.Startup
{
    [DependsOn(
       typeof(DcpproWebCoreModule))]
    public class DcpproWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DcpproWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DcpproWebHostModule).GetAssembly());
        }
    }
}
