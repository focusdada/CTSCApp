using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace CTSCApp.EntityFramework.Core
{
    [AppDbContext("CTSCAppConn", DbProvider.SqlServer)]
    public class DefaultDbContext : AppDbContext<DefaultDbContext>
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {
        }
    }
}