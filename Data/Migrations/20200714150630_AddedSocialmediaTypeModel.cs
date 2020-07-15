using Microsoft.EntityFrameworkCore.Migrations;

namespace CryptoCommunity.Migrations
{
    public partial class AddedSocialmediaTypeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Socialmedia");

            migrationBuilder.CreateTable(
                name: "SocialmediaType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ButtonClass = table.Column<string>(nullable: true),
                    IconClass = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialmediaType", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SocialmediaType");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Socialmedia",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
