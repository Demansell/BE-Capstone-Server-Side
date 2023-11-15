using Microsoft.EntityFrameworkCore;
using BeCapstone.Models;



namespace BeCapstone
{
    public class BeCapstoneDbContext : DbContext
    {
        public DbSet<User>? Users { get; set; }

        public DbSet<PeopleGoing>? PeopleGoings { get; set; }
        public DbSet<Payment>? Payments { get; set; }
        public DbSet<Venue>? Venues { get; set; }
        public DbSet<VenueClothingType> VenueClothingTypes { get; set; }
        public DbSet<VenueCounty> VenueCounties { get; set; }
        public DbSet<VenueCity> VenueCities { get; set; }
        public DbSet<VenueHourOfOperation> VenueHourOfOperations { get; set; }
        public DbSet<VenuePrice> VenuePrices { get; set; }
        public DbSet<VenueType> VenueTypes { get; set; }
        public DbSet<VenueZipCode> VenueZipCodes { get; set; }

        public BeCapstoneDbContext(DbContextOptions<BeCapstoneDbContext> context) : base(context)
        {

        }

    }

}