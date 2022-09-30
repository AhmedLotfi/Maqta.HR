using Maqta.HR.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Maqta.HR.Infrastructure.DBContexts
{
    public class MaqtaHRDBContext : DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; } = default!;

        public MaqtaHRDBContext(DbContextOptions<MaqtaHRDBContext> dbContextOptions)
            : base(dbContextOptions) { }
    }
}