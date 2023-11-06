using McNaboe.EntityDataObject;

namespace ClientModel
{
    public class Facility
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int MaxCapacity { get; set; } = 0;

    }

    public interface IFacilityDtoEntityService : IIntKeyObjectService<Facility>
    {

    }
}
