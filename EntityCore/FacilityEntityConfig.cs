using McNaboe.EntityDataObject.Server;
using McNaboe.EntityDataObject;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EntityModel;

namespace EntityCore
{
    public class FacilityEntityConfig : IEntityTypeConfiguration<Facility>
    {
        public virtual void Configure(EntityTypeBuilder<Facility> builder)
        {
            builder.Property(x => x.Id).UseIdentityColumn(77, 1);
            builder.ToTable("Facilities");
        }
    }

    public class FacilityEntityService<db> : EntityService<Facility, db, int>, IEntityObjectService<Facility, int>, IFacilityEntityService where db : DbContext
    {
        public FacilityEntityService(IDbContextFactory<db> factory) : base(factory)
        {
        }

    }

    public interface IFacilityEntityService : IIntKeyObjectService<Facility>
    {

    }




}
