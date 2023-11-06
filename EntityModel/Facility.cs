namespace EntityModel
{
    public class Facility
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int MaxCapacity { get; set; } = 0;
        public string InternalIdentifier { get; set; } = Guid.NewGuid().ToString();
        public List<CapacityCounter> Counters { get; set; } = new List<CapacityCounter>();
        

    }

}
