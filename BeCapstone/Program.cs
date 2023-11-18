using BeCapstone.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.AspNetCore.Http.Features;
using BeCapstone;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// allows passing datetimes without time zone data 
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// allows our api endpoints to access the database through Entity Framework Core
builder.Services.AddNpgsql<BeCapstoneDbContext>(builder.Configuration["BeCapstoneDbConnectionString"]);

// Set the JSON serializer options
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins("http://localhost:3000",
                                "http://localhost:5169")
                                .AllowAnyHeader()
                                .AllowAnyMethod()
                                .AllowAnyOrigin();
        });
});

var app = builder.Build();

app.UseCors();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();


// get all payments 
app.MapGet("/api/Payments", (BeCapstoneDbContext db) =>
{
    List<Payment> payments = db.Payments.ToList();
    if (payments.Count == 0)
    {
        return Results.NotFound();
    }

    return Results.Ok(payments);
});

// get Payment by Id
app.MapGet("/api/Payments/{id}", (BeCapstoneDbContext db, int id) =>
{
    var payment = db.Payments.FirstOrDefault(s => s.Id == id);
    return payment;
}
);

// Post a Payment

app.MapPost("/api/Payments", (BeCapstoneDbContext db, Payment payment) =>
{
    try
    {
        db.Add(payment);
        db.SaveChanges();
        return Results.Created($"/api/Payments/{payment.Id}", payment);
    }
    catch (DbUpdateException)
    {
        return Results.NotFound();
    }
});

// delete payment type
app.MapDelete("/api/Payments/{Id}", (BeCapstoneDbContext db, int Id) =>
{
    Payment deletePayment = db.Payments.FirstOrDefault(c => c.Id == Id);
    if (deletePayment == null)
    {
        return Results.NotFound();
    }
    db.Remove(deletePayment);
    db.SaveChanges();
    return Results.Ok(deletePayment);
});

// PeopleGoing Endpoints

// Get People Going 
app.MapGet("/api/PeopleGoing", (BeCapstoneDbContext db) =>
{
    List<PeopleGoing> peoplegoings = db.PeopleGoings.ToList();
    if (peoplegoings.Count == 0)
    {
        return Results.NotFound();
    }

    return Results.Ok(peoplegoings);
});

// get paymetns by Id

app.MapGet("/api/PeopleGoing/{id}", (BeCapstoneDbContext db, int id) =>
{
    PeopleGoing peoplegoing = db.PeopleGoings.SingleOrDefault(c => c.Id == id);
    if (peoplegoing == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(peoplegoing);
});

// Post a PersonGoing

app.MapPost("/api/PeopleGoing", (BeCapstoneDbContext db, PeopleGoing peoplegoing) =>
{
    try
    {
        db.Add(peoplegoing);
        db.SaveChanges();
        return Results.Created($"/api/PersonGoing/{peoplegoing.Id}", peoplegoing);
    }
    catch (DbUpdateException)
    {
        return Results.NotFound();
    }
});

//Update a PersonGoing

app.MapPut("api/PeopleGoing/{id}", async (BeCapstoneDbContext db, int id, PeopleGoing peoplegoing) =>
{
    PeopleGoing personGoingToUpdate = await db.PeopleGoings.SingleOrDefaultAsync(peoplegoing => peoplegoing.Id == id);
    if (personGoingToUpdate == null)
    {
        return Results.NotFound();
    }
    personGoingToUpdate.Id = peoplegoing.Id;
    personGoingToUpdate.Name = peoplegoing.Name;
    personGoingToUpdate.TimeGoing = peoplegoing.TimeGoing;
    personGoingToUpdate.VenueId = peoplegoing.VenueId;

    db.SaveChanges();
    return Results.NoContent();
});

// delete a PersonGoing
app.MapDelete("/api/PeopleGoing/{Id}", (BeCapstoneDbContext db, int Id) =>
{
    PeopleGoing deletePeopleGoing = db.PeopleGoings.FirstOrDefault(c => c.Id == Id);
    if (deletePeopleGoing == null)
    {
        return Results.NotFound();
    }
    db.Remove(deletePeopleGoing);
    db.SaveChanges();
    return Results.Ok(deletePeopleGoing);
});

// User Endpoints

//Check User

app.MapGet("/checkuser/{uid}", (BeCapstoneDbContext db, string uid) =>
{
    var user = db.Users.Where(x => x.Uid == uid).ToList();
    if (uid == null)
    {
        return Results.NotFound();
    }
    else
    {
        return Results.Ok(user);
    }
});

//Get all Users
app.MapGet("/users", (BeCapstoneDbContext db) =>
{
    return db.Users.ToList();
});

// Venue Endpoints

//Get All Venues
app.MapGet("/api/Venue", (BeCapstoneDbContext db) =>
{
    List<Venue> venues = db.Venues.ToList();
    if (venues.Count == 0)
    {
        return Results.NotFound();
    }

    return Results.Ok(venues);
});

// get Venues by Id

app.MapGet("/api/Venues/{id}", (BeCapstoneDbContext db, int id) =>
{
    Venue venues = db.Venues.SingleOrDefault(c => c.Id == id);
    if (venues == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(venues);
});

// Post a PersonGoing

// create a disaster
app.MapPost("api/Venue", async (BeCapstoneDbContext db, Venue venue) =>
{
    db.Venues.Add(venue);
    db.SaveChanges();
    return Results.Created($"/api/Venue{venue.Id}", venue);
});

//Update a Venue

app.MapPut("api/Venue/{id}", async (BeCapstoneDbContext db, int id, Venue venue) =>
{
    Venue venueToUpdate = await db.Venues.SingleOrDefaultAsync(venue => venue.Id == id);
    if (venueToUpdate == null)
    {
        return Results.NotFound();
    }
    venueToUpdate.Id = venue.Id;
    venueToUpdate.VenueName = venue.VenueName;
    venueToUpdate.Description = venue.Description;
    venueToUpdate.VenueStreetAddress = venue.VenueStreetAddress;
    venueToUpdate.VenueCountyId = venue.VenueCountyId;
    venueToUpdate.VenueCityId = venue.VenueCityId;
    venueToUpdate.VenueZipcodeId = venue.VenueZipcodeId;
    venueToUpdate.VenueStreetAddress = venue.VenueStreetAddress;
    venueToUpdate.VenueTypeId = venue.VenueTypeId;
    venueToUpdate.VenuePriceId = venue.VenuePriceId;
    venueToUpdate.PaymentTypeId = venue.PaymentTypeId;
    venueToUpdate.VenueHoursofOperationId = venue.VenueHoursofOperationId;
    venueToUpdate.VenueClothingTypeId = venue.VenueClothingTypeId;
    venueToUpdate.VenueImage = venue.VenueImage;
    venueToUpdate.PaymentId = venue.PaymentId;
    venueToUpdate.LikedVenue = venue.LikedVenue;
    venueToUpdate.VistedVenue = venue.VistedVenue;
    venueToUpdate.NextNightOut = venue.NextNightOut;
    db.SaveChanges();
    return Results.NoContent();
});

// delete a PersonGoing
app.MapDelete("/api/Venue/{Id}", (BeCapstoneDbContext db, int Id) =>
{
    Venue deleteVenue = db.Venues.FirstOrDefault(c => c.Id == Id);
    if (deleteVenue == null)
    {
        return Results.NotFound();
    }
    db.Remove(deleteVenue);
    db.SaveChanges();
    return Results.NoContent();
});

// Liked Venues
app.MapGet("/api/LikedVenues", (BeCapstoneDbContext db) =>
{
    var likedVenues = db.Venues.Where(s => s.LikedVenue == true);
    return likedVenues.ToList();
});

// Visted Venues
app.MapGet("/api/VistedVenues", (BeCapstoneDbContext db) =>
{
    var vistedVenues = db.Venues.Where(s => s.VistedVenue == true);
    return vistedVenues.ToList();
});

// Visted Venues
app.MapGet("/api/NexyNightOutVenues", (BeCapstoneDbContext db) =>
{
    var nextNightOutVenues = db.Venues.Where(s => s.NextNightOut == true);
    return nextNightOutVenues.ToList();
});


// Venue City Endpoints

// Get Single Venue City

app.MapGet("/venueCity1", (BeCapstoneDbContext db) =>
{
    var venueCities = db.Venues
        .Where(s => s.VenueCityId == 1)
        .Include(s => s.VenueCities)
        .ToList();
    return venueCities;
});

app.MapGet("/venueCity2", (BeCapstoneDbContext db) =>
{
    var venueCities = db.Venues
        .Where(s => s.VenueCityId == 2)
        .Include(s => s.VenueCities)
        .ToList();
    return venueCities;
});

app.Run();
