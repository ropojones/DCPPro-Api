using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Ecowas.Dcppro.Authorization.Roles;
using Ecowas.Dcppro.Authorization.Users;
using Ecowas.Dcppro.MultiTenancy;

namespace Ecowas.Dcppro.EntityFrameworkCore
{
    public class DcpproDbContext : AbpZeroDbContext<Tenant, Role, User, DcpproDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DcpproDbContext(DbContextOptions<DcpproDbContext> options)
            : base(options)
        {
        }
    }
}
