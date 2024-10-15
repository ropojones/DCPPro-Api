using Abp.MultiTenancy;
using Ecowas.Dcppro.Authorization.Users;

namespace Ecowas.Dcppro.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
