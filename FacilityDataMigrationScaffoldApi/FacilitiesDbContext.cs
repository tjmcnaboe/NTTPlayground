using EntityCore;
using Microsoft.EntityFrameworkCore;

namespace FacilityDataMigrationScaffoldApi
{
    public class FacilitiesDbContext : DbContext
    {
        public FacilitiesDbContext(DbContextOptions<FacilitiesDbContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.BuildCoreSqlModel();
        }
    }
}
