using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BeCapstone.Migrations
{
    /// <inheritdoc />
    public partial class Create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PeopleGoings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    TimeGoing = table.Column<string>(type: "text", nullable: true),
                    VenueId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeopleGoings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Uid = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Venues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VenueName = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    VenueStreetAddress = table.Column<string>(type: "text", nullable: true),
                    VenueCountyId = table.Column<int>(type: "integer", nullable: true),
                    VenueCityId = table.Column<int>(type: "integer", nullable: true),
                    VenueZipcodeId = table.Column<int>(type: "integer", nullable: true),
                    VenuePhoneNumber = table.Column<int>(type: "integer", nullable: true),
                    VenueTypeId = table.Column<int>(type: "integer", nullable: true),
                    VenuePriceId = table.Column<int>(type: "integer", nullable: true),
                    PaymentTypeId = table.Column<int>(type: "integer", nullable: true),
                    VenueHoursofOperationId = table.Column<string>(type: "text", nullable: true),
                    VenueClothingTypeId = table.Column<int>(type: "integer", nullable: true),
                    VenueImage = table.Column<string>(type: "text", nullable: true),
                    PaymentId = table.Column<int>(type: "integer", nullable: true),
                    Uid = table.Column<string>(type: "text", nullable: true),
                    LikedVenue = table.Column<bool>(type: "boolean", nullable: false),
                    VistedVenue = table.Column<bool>(type: "boolean", nullable: false),
                    NextNightOut = table.Column<bool>(type: "boolean", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Venues_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    VenuesId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Venues_VenuesId",
                        column: x => x.VenuesId,
                        principalTable: "Venues",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PeopleGoingVenue",
                columns: table => new
                {
                    PeopleGoingsId = table.Column<int>(type: "integer", nullable: false),
                    VenuesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeopleGoingVenue", x => new { x.PeopleGoingsId, x.VenuesId });
                    table.ForeignKey(
                        name: "FK_PeopleGoingVenue_PeopleGoings_PeopleGoingsId",
                        column: x => x.PeopleGoingsId,
                        principalTable: "PeopleGoings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeopleGoingVenue_Venues_VenuesId",
                        column: x => x.VenuesId,
                        principalTable: "Venues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VenueCities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CityName = table.Column<string>(type: "text", nullable: true),
                    VenuesId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VenueCities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VenueCities_Venues_VenuesId",
                        column: x => x.VenuesId,
                        principalTable: "Venues",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VenueClothingTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    VenuesId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VenueClothingTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VenueClothingTypes_Venues_VenuesId",
                        column: x => x.VenuesId,
                        principalTable: "Venues",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VenueCounties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VenueCountyName = table.Column<string>(type: "text", nullable: true),
                    VenuesId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VenueCounties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VenueCounties_Venues_VenuesId",
                        column: x => x.VenuesId,
                        principalTable: "Venues",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VenueHourOfOperations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HoursOfOperation = table.Column<string>(type: "text", nullable: true),
                    Monday = table.Column<string>(type: "text", nullable: true),
                    Tuesday = table.Column<string>(type: "text", nullable: true),
                    Wednesday = table.Column<string>(type: "text", nullable: true),
                    Thursday = table.Column<string>(type: "text", nullable: true),
                    Friday = table.Column<string>(type: "text", nullable: true),
                    Saturday = table.Column<string>(type: "text", nullable: true),
                    Sunday = table.Column<string>(type: "text", nullable: true),
                    VenuesId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VenueHourOfOperations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VenueHourOfOperations_Venues_VenuesId",
                        column: x => x.VenuesId,
                        principalTable: "Venues",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VenuePrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Price = table.Column<string>(type: "text", nullable: true),
                    VenuesId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VenuePrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VenuePrices_Venues_VenuesId",
                        column: x => x.VenuesId,
                        principalTable: "Venues",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VenueTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VenueTypeName = table.Column<string>(type: "text", nullable: true),
                    VenuesId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VenueTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VenueTypes_Venues_VenuesId",
                        column: x => x.VenuesId,
                        principalTable: "Venues",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VenueZipCodes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Zipcode = table.Column<string>(type: "text", nullable: true),
                    VenuesId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VenueZipCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VenueZipCodes_Venues_VenuesId",
                        column: x => x.VenuesId,
                        principalTable: "Venues",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_VenuesId",
                table: "Payments",
                column: "VenuesId");

            migrationBuilder.CreateIndex(
                name: "IX_PeopleGoingVenue_VenuesId",
                table: "PeopleGoingVenue",
                column: "VenuesId");

            migrationBuilder.CreateIndex(
                name: "IX_VenueCities_VenuesId",
                table: "VenueCities",
                column: "VenuesId");

            migrationBuilder.CreateIndex(
                name: "IX_VenueClothingTypes_VenuesId",
                table: "VenueClothingTypes",
                column: "VenuesId");

            migrationBuilder.CreateIndex(
                name: "IX_VenueCounties_VenuesId",
                table: "VenueCounties",
                column: "VenuesId");

            migrationBuilder.CreateIndex(
                name: "IX_VenueHourOfOperations_VenuesId",
                table: "VenueHourOfOperations",
                column: "VenuesId");

            migrationBuilder.CreateIndex(
                name: "IX_VenuePrices_VenuesId",
                table: "VenuePrices",
                column: "VenuesId");

            migrationBuilder.CreateIndex(
                name: "IX_Venues_UserId",
                table: "Venues",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VenueTypes_VenuesId",
                table: "VenueTypes",
                column: "VenuesId");

            migrationBuilder.CreateIndex(
                name: "IX_VenueZipCodes_VenuesId",
                table: "VenueZipCodes",
                column: "VenuesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "PeopleGoingVenue");

            migrationBuilder.DropTable(
                name: "VenueCities");

            migrationBuilder.DropTable(
                name: "VenueClothingTypes");

            migrationBuilder.DropTable(
                name: "VenueCounties");

            migrationBuilder.DropTable(
                name: "VenueHourOfOperations");

            migrationBuilder.DropTable(
                name: "VenuePrices");

            migrationBuilder.DropTable(
                name: "VenueTypes");

            migrationBuilder.DropTable(
                name: "VenueZipCodes");

            migrationBuilder.DropTable(
                name: "PeopleGoings");

            migrationBuilder.DropTable(
                name: "Venues");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
