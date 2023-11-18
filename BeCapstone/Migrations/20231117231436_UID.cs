using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeCapstone.Migrations
{
    /// <inheritdoc />
    public partial class UID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venues_VenueCities_VenueCityId",
                table: "Venues");

            migrationBuilder.DropIndex(
                name: "IX_Venues_VenueCityId",
                table: "Venues");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Venues",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Venues",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "VenueClothingTypes",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "VenuesId",
                table: "VenueCities",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Venues_UserId1",
                table: "Venues",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_VenueCities_VenuesId",
                table: "VenueCities",
                column: "VenuesId");

            migrationBuilder.AddForeignKey(
                name: "FK_VenueCities_Venues_VenuesId",
                table: "VenueCities",
                column: "VenuesId",
                principalTable: "Venues",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Venues_Users_UserId1",
                table: "Venues",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VenueCities_Venues_VenuesId",
                table: "VenueCities");

            migrationBuilder.DropForeignKey(
                name: "FK_Venues_Users_UserId1",
                table: "Venues");

            migrationBuilder.DropIndex(
                name: "IX_Venues_UserId1",
                table: "Venues");

            migrationBuilder.DropIndex(
                name: "IX_VenueCities_VenuesId",
                table: "VenueCities");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Venues");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Venues");

            migrationBuilder.DropColumn(
                name: "VenuesId",
                table: "VenueCities");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "VenueClothingTypes",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Venues_VenueCityId",
                table: "Venues",
                column: "VenueCityId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Venues_VenueCities_VenueCityId",
                table: "Venues",
                column: "VenueCityId",
                principalTable: "VenueCities",
                principalColumn: "Id");
        }
    }
}
