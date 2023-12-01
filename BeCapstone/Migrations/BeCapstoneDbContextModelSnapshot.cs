﻿// <auto-generated />
using System;
using BeCapstone;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BeCapstone.Migrations
{
    [DbContext(typeof(BeCapstoneDbContext))]
    partial class BeCapstoneDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BeCapstone.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("VenuesId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("VenuesId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("BeCapstone.Models.PeopleGoing", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("TimeGoing")
                        .HasColumnType("text");

                    b.Property<int?>("VenueId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("PeopleGoings");
                });

            modelBuilder.Entity("BeCapstone.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BeCapstone.Models.Venue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("LikedVenue")
                        .HasColumnType("boolean");

                    b.Property<bool>("NextNightOut")
                        .HasColumnType("boolean");

                    b.Property<int?>("PaymentId")
                        .HasColumnType("integer");

                    b.Property<int?>("PaymentTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("Uid")
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.Property<int?>("VenueCityId")
                        .HasColumnType("integer");

                    b.Property<int?>("VenueClothingTypeId")
                        .HasColumnType("integer");

                    b.Property<int?>("VenueCountyId")
                        .HasColumnType("integer");

                    b.Property<int?>("VenueHoursofOperationId")
                        .HasColumnType("integer");

                    b.Property<string>("VenueImage")
                        .HasColumnType("text");

                    b.Property<string>("VenueName")
                        .HasColumnType("text");

                    b.Property<int?>("VenuePhoneNumber")
                        .HasColumnType("integer");

                    b.Property<int?>("VenuePriceId")
                        .HasColumnType("integer");

                    b.Property<string>("VenueStreetAddress")
                        .HasColumnType("text");

                    b.Property<int?>("VenueTypeId")
                        .HasColumnType("integer");

                    b.Property<int?>("VenueZipcodeId")
                        .HasColumnType("integer");

                    b.Property<bool>("VistedVenue")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Venues");
                });

            modelBuilder.Entity("BeCapstone.Models.VenueCity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CityName")
                        .HasColumnType("text");

                    b.Property<int?>("VenuesId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("VenuesId");

                    b.ToTable("VenueCities");
                });

            modelBuilder.Entity("BeCapstone.Models.VenueClothingType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("VenuesId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("VenuesId");

                    b.ToTable("VenueClothingTypes");
                });

            modelBuilder.Entity("BeCapstone.Models.VenueCounty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("VenueCountyName")
                        .HasColumnType("text");

                    b.Property<int?>("VenuesId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("VenuesId");

                    b.ToTable("VenueCounties");
                });

            modelBuilder.Entity("BeCapstone.Models.VenueHourOfOperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("HoursOfOperation")
                        .HasColumnType("text");

                    b.Property<int?>("VenuesId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("VenuesId");

                    b.ToTable("VenueHourOfOperations");
                });

            modelBuilder.Entity("BeCapstone.Models.VenuePrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Price")
                        .HasColumnType("text");

                    b.Property<int?>("VenuesId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("VenuesId");

                    b.ToTable("VenuePrices");
                });

            modelBuilder.Entity("BeCapstone.Models.VenueType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("VenueTypeName")
                        .HasColumnType("text");

                    b.Property<int?>("VenuesId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("VenuesId");

                    b.ToTable("VenueTypes");
                });

            modelBuilder.Entity("BeCapstone.Models.VenueZipCode", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int?>("VenuesId")
                        .HasColumnType("integer");

                    b.Property<string>("Zipcode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("VenuesId");

                    b.ToTable("VenueZipCodes");
                });

            modelBuilder.Entity("PeopleGoingVenue", b =>
                {
                    b.Property<int>("PeopleGoingsId")
                        .HasColumnType("integer");

                    b.Property<int>("VenuesId")
                        .HasColumnType("integer");

                    b.HasKey("PeopleGoingsId", "VenuesId");

                    b.HasIndex("VenuesId");

                    b.ToTable("PeopleGoingVenue");
                });

            modelBuilder.Entity("BeCapstone.Models.Payment", b =>
                {
                    b.HasOne("BeCapstone.Models.Venue", "Venues")
                        .WithMany("Payments")
                        .HasForeignKey("VenuesId");

                    b.Navigation("Venues");
                });

            modelBuilder.Entity("BeCapstone.Models.Venue", b =>
                {
                    b.HasOne("BeCapstone.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BeCapstone.Models.VenueCity", b =>
                {
                    b.HasOne("BeCapstone.Models.Venue", "Venues")
                        .WithMany("VenueCities")
                        .HasForeignKey("VenuesId");

                    b.Navigation("Venues");
                });

            modelBuilder.Entity("BeCapstone.Models.VenueClothingType", b =>
                {
                    b.HasOne("BeCapstone.Models.Venue", "Venues")
                        .WithMany("VenueClothingTypes")
                        .HasForeignKey("VenuesId");

                    b.Navigation("Venues");
                });

            modelBuilder.Entity("BeCapstone.Models.VenueCounty", b =>
                {
                    b.HasOne("BeCapstone.Models.Venue", "Venues")
                        .WithMany("VenueCounties")
                        .HasForeignKey("VenuesId");

                    b.Navigation("Venues");
                });

            modelBuilder.Entity("BeCapstone.Models.VenueHourOfOperation", b =>
                {
                    b.HasOne("BeCapstone.Models.Venue", "Venues")
                        .WithMany("VenueHourOfOperations")
                        .HasForeignKey("VenuesId");

                    b.Navigation("Venues");
                });

            modelBuilder.Entity("BeCapstone.Models.VenuePrice", b =>
                {
                    b.HasOne("BeCapstone.Models.Venue", "Venues")
                        .WithMany("VenuePrices")
                        .HasForeignKey("VenuesId");

                    b.Navigation("Venues");
                });

            modelBuilder.Entity("BeCapstone.Models.VenueType", b =>
                {
                    b.HasOne("BeCapstone.Models.Venue", "Venues")
                        .WithMany("VenueTypes")
                        .HasForeignKey("VenuesId");

                    b.Navigation("Venues");
                });

            modelBuilder.Entity("BeCapstone.Models.VenueZipCode", b =>
                {
                    b.HasOne("BeCapstone.Models.Venue", "Venues")
                        .WithMany("VenueZipCodes")
                        .HasForeignKey("VenuesId");

                    b.Navigation("Venues");
                });

            modelBuilder.Entity("PeopleGoingVenue", b =>
                {
                    b.HasOne("BeCapstone.Models.PeopleGoing", null)
                        .WithMany()
                        .HasForeignKey("PeopleGoingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeCapstone.Models.Venue", null)
                        .WithMany()
                        .HasForeignKey("VenuesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BeCapstone.Models.Venue", b =>
                {
                    b.Navigation("Payments");

                    b.Navigation("VenueCities");

                    b.Navigation("VenueClothingTypes");

                    b.Navigation("VenueCounties");

                    b.Navigation("VenueHourOfOperations");

                    b.Navigation("VenuePrices");

                    b.Navigation("VenueTypes");

                    b.Navigation("VenueZipCodes");
                });
#pragma warning restore 612, 618
        }
    }
}
