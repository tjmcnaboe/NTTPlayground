using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EntityModel;
using McNaboe.EntityDataObject.Server;
using McNaboe.EntityDataObject;

namespace EntityCore
{
    public class CapacityCounterEntityConfig : IEntityTypeConfiguration<CapacityCounter>
    {
        public virtual void Configure(EntityTypeBuilder<CapacityCounter> builder)
        {
            builder.ToTable("CapacityCounters");
        }
    }

    public class CapacityCounterEntityService<db> : EntityService<CapacityCounter, db, int>, IEntityObjectService<CapacityCounter, int>, ICapacityCounterEntityService where db : DbContext
    {
        public CapacityCounterEntityService(IDbContextFactory<db> factory) : base(factory)
        {
        }

    }

    public interface ICapacityCounterEntityService : IIntKeyObjectService<CapacityCounter>
    {

    }
}
