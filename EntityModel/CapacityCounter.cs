namespace EntityModel
{
    public class CapacityCounter
    { 
        public int Id { get; set; }
        public DateTime Open { get; set; }
        public DateTime Close { get; set; }
        public List<CounterDetails> CounterDetails { get; set; }
        public int CurrentCount { get { return CounterDetails.Sum(x => x.Count); } }
        
    }

}
