using McNaboe.EntityDataObject.Server;
using McNaboe.EntityDataObject;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Riok.Mapperly.Abstractions;
using NTTPlayground.Client.EntityObjectServices;
using FacilityDto = ClientModel.Facility;
using EntityModel;

namespace NTTPlayground.Services
{
    public class FacilityDtoEntityService<db> : MappedEntityService<FacilityDto, db, int, EntityModel.Facility>, IEntityObjectService<ClientModel.Facility, int>, ClientModel.IFacilityDtoEntityService where db : DbContext
    {
        public FacilityDtoEntityService(IDbContextFactory<db> factory) : base(factory)
        {
        }

        public override List<ClientModel.Facility> MapOutput(List<Facility> input)
        {
            return new FacilityVmMapper().MapOutList(input);
        }
        public override ClientModel.Facility MapOutput(Facility input)
        {
            return new FacilityVmMapper().MapOut(input);
        }

        public override Facility MapInput(ClientModel.Facility input)
        {
            return new FacilityVmMapper().MapIn(input);
        }
        public override Facility UpdateFromInput(ClientModel.Facility vmInput, Facility Facility)
        {
            //var Facility = this.Context.Set<Facility>().Find(vmInput.Id);

            new FacilityVmMapper().FacilityToFacility(vmInput, Facility);
            return Facility;
        }
        public override Facility CreateFromVm(ClientModel.Facility vmInput)
        {
            var Facility = new Facility();

            new FacilityVmMapper().FacilityToFacility(vmInput, Facility);
            return Facility;
        }
        public override int GetKeyFromVm(ClientModel.Facility input)
        {
            return input.Id;
        }
    }

    [Mapper]
    public partial class FacilityVmMapper
    {
        public partial ClientModel.Facility MapOut(Facility data);
        public partial List<ClientModel.Facility> MapOutList(List<Facility> data);
        public partial Facility MapIn(ClientModel.Facility data);
        public partial List<Facility> MapInList(List<ClientModel.Facility> data);
        public partial void FacilityToFacility(ClientModel.Facility vm, Facility Facility);
    }
}
