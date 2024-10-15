using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Ecowas.Dcppro.Controllers
{
    public abstract class DcpproControllerBase: AbpController
    {
        protected DcpproControllerBase()
        {
            LocalizationSourceName = DcpproConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
