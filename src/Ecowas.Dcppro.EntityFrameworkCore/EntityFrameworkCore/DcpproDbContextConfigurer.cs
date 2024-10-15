using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Ecowas.Dcppro.EntityFrameworkCore
{
    public static class DcpproDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DcpproDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DcpproDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
