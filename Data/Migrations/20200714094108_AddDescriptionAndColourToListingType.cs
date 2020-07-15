using Microsoft.EntityFrameworkCore.Migrations;

namespace CryptoCommunity.Migrations
{
    public partial class AddDescriptionAndColourToListingType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CardCoverColour",
                table: "ListingType",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ListingType",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardCoverColour",
                table: "ListingType");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ListingType");
        }
    }
}
