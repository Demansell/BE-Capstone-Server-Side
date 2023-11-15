namespace BeCapstone.Models
{
    public class VenueType
    {
        public int Id { get; set; }
        public string? VenueTypeName { get; set; }
        public Venue? Venues { get; set; }
    }
}
