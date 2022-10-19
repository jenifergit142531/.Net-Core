using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreApproachDemo.Migrations
{
    public partial class Initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FilmDetail01",
                columns: table => new
                {
                    FilmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmDetail01", x => x.FilmId);
                });

            migrationBuilder.CreateTable(
                name: "Filmshooting01",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScheduledDays = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmshooting01", x => x.LocationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmDetail01");

            migrationBuilder.DropTable(
                name: "Filmshooting01");
        }
    }
}
