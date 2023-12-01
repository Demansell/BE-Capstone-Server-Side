using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeCapstone.Migrations
{
    /// <inheritdoc />
    public partial class HoursofOp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Friday",
                table: "VenueHourOfOperations");

            migrationBuilder.DropColumn(
                name: "Monday",
                table: "VenueHourOfOperations");

            migrationBuilder.DropColumn(
                name: "Saturday",
                table: "VenueHourOfOperations");

            migrationBuilder.DropColumn(
                name: "Sunday",
                table: "VenueHourOfOperations");

            migrationBuilder.DropColumn(
                name: "Thursday",
                table: "VenueHourOfOperations");

            migrationBuilder.DropColumn(
                name: "Tuesday",
                table: "VenueHourOfOperations");

            migrationBuilder.DropColumn(
                name: "Wednesday",
                table: "VenueHourOfOperations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Friday",
                table: "VenueHourOfOperations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Monday",
                table: "VenueHourOfOperations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Saturday",
                table: "VenueHourOfOperations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sunday",
                table: "VenueHourOfOperations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Thursday",
                table: "VenueHourOfOperations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tuesday",
                table: "VenueHourOfOperations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Wednesday",
                table: "VenueHourOfOperations",
                type: "text",
                nullable: true);
        }
    }
}
