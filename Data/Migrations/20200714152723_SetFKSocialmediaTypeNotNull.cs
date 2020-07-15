using Microsoft.EntityFrameworkCore.Migrations;

namespace CryptoCommunity.Migrations
{
    public partial class SetFKSocialmediaTypeNotNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Socialmedia_SocialmediaType_SocialmediaTypeId",
                table: "Socialmedia");

            migrationBuilder.AlterColumn<int>(
                name: "SocialmediaTypeId",
                table: "Socialmedia",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Socialmedia_SocialmediaType_SocialmediaTypeId",
                table: "Socialmedia",
                column: "SocialmediaTypeId",
                principalTable: "SocialmediaType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Socialmedia_SocialmediaType_SocialmediaTypeId",
                table: "Socialmedia");

            migrationBuilder.AlterColumn<int>(
                name: "SocialmediaTypeId",
                table: "Socialmedia",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Socialmedia_SocialmediaType_SocialmediaTypeId",
                table: "Socialmedia",
                column: "SocialmediaTypeId",
                principalTable: "SocialmediaType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
