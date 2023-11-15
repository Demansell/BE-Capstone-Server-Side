namespace BeCapstone.Models
{
    public class Venue
    {
        public int Id { get; set; }
        public string? VenueName { get; set; }
        public string? VenueStreetAddress { get; set; }
        public string? VenueCountyId { get; set; }
        public string? VenueCityId { get; set; }
        public string? VenueZipcodeId { get; set; }
        public string? VenuePhoneNumber { get; set; }
        public string? VenueTypeId { get; set; }
        public string? VenuePriceId { get; set; }
        public int? PaymentTypeId { get; set; }
        public string? VenueHoursofOperationId { get; set; }
        public string? VenueClothingTypeId { get; set; }
        public string? VenueImage { get; set; }
        public string PaymentId { get; set; }
        public bool LikedVenue { get; set; }
        public bool VistedVenue { get; set; }
        public bool NextNightOut { get; set; }
        public List<PeopleGoing> PeopleGoings { get; set; }


    }
}
