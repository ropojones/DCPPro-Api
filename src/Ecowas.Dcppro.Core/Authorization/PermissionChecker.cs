using Abp.Authorization;
using Ecowas.Dcppro.Authorization.Roles;
using Ecowas.Dcppro.Authorization.Users;

namespace Ecowas.Dcppro.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
