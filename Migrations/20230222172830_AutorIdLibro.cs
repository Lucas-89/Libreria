using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibreriaDigital.Migrations
{
    public partial class AutorIdLibro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Contenporaneo",
                table: "Autores",
                newName: "Contemporaneo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Contemporaneo",
                table: "Autores",
                newName: "Contenporaneo");
        }
    }
}
