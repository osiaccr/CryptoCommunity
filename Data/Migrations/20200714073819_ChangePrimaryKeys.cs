using Microsoft.EntityFrameworkCore.Migrations;

namespace CryptoCommunity.Migrations
{
    public partial class ChangePrimaryKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listing_ListingType_ListingTypeId",
                table: "Listing");

            migrationBuilder.DropForeignKey(
                name: "FK_Socialmedia_Listing_ListingId",
                table: "Socialmedia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Socialmedia",
                table: "Socialmedia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ListingType",
                table: "ListingType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Listing",
                table: "Listing");

            migrationBuilder.DropColumn(
                name: "SocialmediaId",
                table: "Socialmedia");

            migrationBuilder.DropColumn(
                name: "ListingTypeId",
                table: "ListingType");

            migrationBuilder.DropColumn(
                name: "ListingId",
                table: "Listing");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Socialmedia",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ListingType",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Listing",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Socialmedia",
                table: "Socialmedia",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ListingType",
                table: "ListingType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Listing",
                table: "Listing",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Listing_ListingType_ListingTypeId",
                table: "Listing",
                column: "ListingTypeId",
                principalTable: "ListingType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Socialmedia_Listing_ListingId",
                table: "Socialmedia",
                column: "ListingId",
                principalTable: "Listing",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listing_ListingType_ListingTypeId",
                table: "Listing");

            migrationBuilder.DropForeignKey(
                name: "FK_Socialmedia_Listing_ListingId",
                table: "Socialmedia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Socialmedia",
                table: "Socialmedia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ListingType",
                table: "ListingType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Listing",
                table: "Listing");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Socialmedia");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ListingType");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Listing");

            migrationBuilder.AddColumn<int>(
                name: "SocialmediaId",
                table: "Socialmedia",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ListingTypeId",
                table: "ListingType",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ListingId",
                table: "Listing",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Socialmedia",
                table: "Socialmedia",
                column: "SocialmediaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ListingType",
                table: "ListingType",
                column: "ListingTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Listing",
                table: "Listing",
                column: "ListingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Listing_ListingType_ListingTypeId",
                table: "Listing",
                column: "ListingTypeId",
                principalTable: "ListingType",
                principalColumn: "ListingTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Socialmedia_Listing_ListingId",
                table: "Socialmedia",
                column: "ListingId",
                principalTable: "Listing",
                principalColumn: "ListingId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
