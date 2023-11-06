using ClientModel;
using McNaboe.EntityDataObject.Controller;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NTTPlayground.Client.EntityObjectServices;

namespace NTTPlayground.EntityObjectControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacilityDtoController : GenericController<ClientModel.Facility, int>
    {
        public FacilityDtoController(IFacilityDtoEntityService service) : base(service)
        {
        }

    }
}
