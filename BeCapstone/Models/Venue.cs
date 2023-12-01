namespace BeCapstone.Models
{
    public class Venue
    {
        public int Id { get; set; }
        public string? VenueName { get; set; }
        public string? Description { get; set; }
        public string? VenueStreetAddress { get; set; }
        public int? VenueCountyId { get; set; }
        public int? VenueCityId { get; set; }
        public int? VenueZipcodeId { get; set; }
        public int? VenuePhoneNumber { get; set; }
        public int? VenueTypeId { get; set; }
        public int? VenuePriceId { get; set; }
        public int? PaymentTypeId { get; set; }
        public int? VenueHoursofOperationId { get; set; }
        public int? VenueClothingTypeId { get; set; }
        public string? VenueImage { get; set; }
        public int? PaymentId { get; set; }
        public string? Uid { get; set; }
        public bool LikedVenue { get; set; }
        public bool VistedVenue { get; set; }
        public bool NextNightOut { get; set; }
        public List<PeopleGoing>? PeopleGoings { get; set; }
        public User? User { get; set; }
        public List <VenueCity>? VenueCities { get; set; }
        public List <VenueClothingType>? VenueClothingTypes { get; set; }
        public List <VenueCounty>? VenueCounties { get; set; }
        public List <VenueHourOfOperation>? VenueHourOfOperations { get; set; }
        public List <VenuePrice>? VenuePrices { get; set; }
        public List <VenueType>? VenueTypes { get; set; }
        public List <VenueZipCode>? VenueZipCodes { get; set;}
        public List <Payment>? Payments { get; set; }

    }
}
