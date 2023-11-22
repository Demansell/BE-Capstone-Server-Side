namespace BeCapstone.Models
{
    public class PeopleGoing
    {  
        public int? Id{ get; set; }
        public string? Name{ get; set; }
        public string? TimeGoing { get; set; }
        public int? VenueId { get; set; }

        public List<Venue>? Venues { get; set;}

    }
}
