namespace BeCapstone.Models
{
    public class VenuePrice
    {
        public int Id { get; set; }
        public string? Price { get; set; }
        public Venue? Venues { get; set; }
    }
}
