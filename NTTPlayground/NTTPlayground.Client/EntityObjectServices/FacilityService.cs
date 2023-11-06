using McNaboe.EntityDataObject.Client;
using McNaboe.EntityDataObject;
using ClientModel;

namespace NTTPlayground.Client.EntityObjectServices
{
    public interface IFacilityDtoHttpService : IHttpObjectService<Facility, int>
    {

    }

    public class FacilityDtoHttpApiService : HttpApiServiceWrapper<Facility, int>, IFacilityDtoEntityService
    {

        public FacilityDtoHttpApiService(IFacilityDtoHttpService api) : base(api)
        {
            _api = api;
        }
        

    }

}
