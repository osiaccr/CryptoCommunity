using Microsoft.EntityFrameworkCore.Migrations;

namespace CryptoCommunity.Migrations
{
    public partial class CreateFKSocialmediaType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SocialmediaTypeId",
                table: "Socialmedia",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Socialmedia_SocialmediaTypeId",
                table: "Socialmedia",
                column: "SocialmediaTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Socialmedia_SocialmediaType_SocialmediaTypeId",
                table: "Socialmedia",
                column: "SocialmediaTypeId",
                principalTable: "SocialmediaType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Socialmedia_SocialmediaType_SocialmediaTypeId",
                table: "Socialmedia");

            migrationBuilder.DropIndex(
                name: "IX_Socialmedia_SocialmediaTypeId",
                table: "Socialmedia");

            migrationBuilder.DropColumn(
                name: "SocialmediaTypeId",
                table: "Socialmedia");
        }
    }
}
