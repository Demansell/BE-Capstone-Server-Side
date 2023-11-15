namespace BeCapstone.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Venue? Venues { get; set;}
    }
}
