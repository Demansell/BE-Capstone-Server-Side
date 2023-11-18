using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeCapstone.Migrations
{
    /// <inheritdoc />
    public partial class clasesVenues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venues_Payments_PaymentId",
                table: "Venues");

            migrationBuilder.DropForeignKey(
                name: "FK_Venues_VenueClothingTypes_VenueClothingTypeId",
                table: "Venues");

            migrationBuilder.DropForeignKey(
                name: "FK_Venues_VenueCounties_VenueCountyId",
                table: "Venues");

            migrationBuilder.DropForeignKey(
                name: "FK_Venues_VenuePrices_VenuePriceId",
                table: "Venues");

            migrationBuilder.DropForeignKey(
                name: "FK_Venues_VenueTypes_VenueTypeId",
                table: "Venues");

            migrationBuilder.DropIndex(
                name: "IX_Venues_PaymentId",
                table: "Venues");

            migrationBuilder.DropIndex(
                name: "IX_Venues_VenueClothingTypeId",
                table: "Venues");

            migrationBuilder.DropIndex(
                name: "IX_Venues_VenueCountyId",
                table: "Venues");

            migrationBuilder.DropIndex(
                name: "IX_Venues_VenuePriceId",
                table: "Venues");

            migrationBuilder.DropIndex(
                name: "IX_Venues_VenueTypeId",
                table: "Venues");

            migrationBuilder.AddColumn<int>(
                name: "VenuesId",
                table: "VenueTypes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VenuesId",
                table: "VenuePrices",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VenuesId",
                table: "VenueCounties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VenuesId",
                table: "VenueClothingTypes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VenuesId",
                table: "Payments",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VenueTypes_VenuesId",
                table: "VenueTypes",
                column: "VenuesId");

            migrationBuilder.CreateIndex(
                name: "IX_VenuePrices_VenuesId",
                table: "VenuePrices",
                column: "VenuesId");

            migrationBuilder.CreateIndex(
                name: "IX_VenueCounties_VenuesId",
                table: "VenueCounties",
                column: "VenuesId");

            migrationBuilder.CreateIndex(
                name: "IX_VenueClothingTypes_VenuesId",
                table: "VenueClothingTypes",
                column: "VenuesId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_VenuesId",
                table: "Payments",
                column: "VenuesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Venues_VenuesId",
                table: "Payments",
                column: "VenuesId",
                principalTable: "Venues",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VenueClothingTypes_Venues_VenuesId",
                table: "VenueClothingTypes",
                column: "VenuesId",
                principalTable: "Venues",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VenueCounties_Venues_VenuesId",
                table: "VenueCounties",
                column: "VenuesId",
                principalTable: "Venues",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VenuePrices_Venues_VenuesId",
                table: "VenuePrices",
                column: "VenuesId",
                principalTable: "Venues",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VenueTypes_Venues_VenuesId",
                table: "VenueTypes",
                column: "VenuesId",
                principalTable: "Venues",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Venues_VenuesId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_VenueClothingTypes_Venues_VenuesId",
                table: "VenueClothingTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_VenueCounties_Venues_VenuesId",
                table: "VenueCounties");

            migrationBuilder.DropForeignKey(
                name: "FK_VenuePrices_Venues_VenuesId",
                table: "VenuePrices");

            migrationBuilder.DropForeignKey(
                name: "FK_VenueTypes_Venues_VenuesId",
                table: "VenueTypes");

            migrationBuilder.DropIndex(
                name: "IX_VenueTypes_VenuesId",
                table: "VenueTypes");

            migrationBuilder.DropIndex(
                name: "IX_VenuePrices_VenuesId",
                table: "VenuePrices");

            migrationBuilder.DropIndex(
                name: "IX_VenueCounties_VenuesId",
                table: "VenueCounties");

            migrationBuilder.DropIndex(
                name: "IX_VenueClothingTypes_VenuesId",
                table: "VenueClothingTypes");

            migrationBuilder.DropIndex(
                name: "IX_Payments_VenuesId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "VenuesId",
                table: "VenueTypes");

            migrationBuilder.DropColumn(
                name: "VenuesId",
                table: "VenuePrices");

            migrationBuilder.DropColumn(
                name: "VenuesId",
                table: "VenueCounties");

            migrationBuilder.DropColumn(
                name: "VenuesId",
                table: "VenueClothingTypes");

            migrationBuilder.DropColumn(
                name: "VenuesId",
                table: "Payments");

            migrationBuilder.CreateIndex(
                name: "IX_Venues_PaymentId",
                table: "Venues",
                column: "PaymentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Venues_VenueClothingTypeId",
                table: "Venues",
                column: "VenueClothingTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Venues_VenueCountyId",
                table: "Venues",
                column: "VenueCountyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Venues_VenuePriceId",
                table: "Venues",
                column: "VenuePriceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Venues_VenueTypeId",
                table: "Venues",
                column: "VenueTypeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Venues_Payments_PaymentId",
                table: "Venues",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Venues_VenueClothingTypes_VenueClothingTypeId",
                table: "Venues",
                column: "VenueClothingTypeId",
                principalTable: "VenueClothingTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Venues_VenueCounties_VenueCountyId",
                table: "Venues",
                column: "VenueCountyId",
                principalTable: "VenueCounties",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Venues_VenuePrices_VenuePriceId",
                table: "Venues",
                column: "VenuePriceId",
                principalTable: "VenuePrices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Venues_VenueTypes_VenueTypeId",
                table: "Venues",
                column: "VenueTypeId",
                principalTable: "VenueTypes",
                principalColumn: "Id");
        }
    }
}
