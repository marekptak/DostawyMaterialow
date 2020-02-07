using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DostawyMaterialow.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dostawy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Gatunek = table.Column<string>(nullable: true),
                    Wytop = table.Column<string>(nullable: true),
                    Srednica = table.Column<int>(nullable: false),
                    Dlugosc = table.Column<int>(nullable: false),
                    Masa = table.Column<int>(nullable: false),
                    DataDostawy = table.Column<string>(nullable: true),
                    Dostawca = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dostawy", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dostawy");
        }
    }
}
