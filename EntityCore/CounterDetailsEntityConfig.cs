using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EntityModel;
using McNaboe.EntityDataObject.Server;
using McNaboe.EntityDataObject;

namespace EntityCore
{
    public class CounterDetailsEntityConfig : IEntityTypeConfiguration<CounterDetails>
    {
        public virtual void Configure(EntityTypeBuilder<CounterDetails> builder)
        {
            builder.ToTable("CounterDetails");
        }
    }

    public class CounterDetailsEntityService<db> : EntityService<CounterDetails, db, int>, IEntityObjectService<CounterDetails, int>, ICounterDetailsEntityService where db : DbContext
    {
        public CounterDetailsEntityService(IDbContextFactory<db> factory) : base(factory)
        {
        }

    }

    public interface ICounterDetailsEntityService : IIntKeyObjectService<CounterDetails>
    {

    }
}
