using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCWatches.Migrations
{
    public partial class AddWatchesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Watches",
                columns: table => new
                {
                    IDWatch = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ano = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Watches", x => x.IDWatch);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Watches");
        }
    }
}
