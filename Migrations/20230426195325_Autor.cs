using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Libreria.Migrations
{
    /// <inheritdoc />
    public partial class Autor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Autor",
                table: "Libro");

            migrationBuilder.AddColumn<int>(
                name: "AutorId",
                table: "Libro",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Nacionalidad = table.Column<string>(type: "TEXT", nullable: false),
                    Contemporaneo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autor", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Libro_AutorId",
                table: "Libro",
                column: "AutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Libro_Autor_AutorId",
                table: "Libro",
                column: "AutorId",
                principalTable: "Autor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Libro_Autor_AutorId",
                table: "Libro");

            migrationBuilder.DropTable(
                name: "Autor");

            migrationBuilder.DropIndex(
                name: "IX_Libro_AutorId",
                table: "Libro");

            migrationBuilder.DropColumn(
                name: "AutorId",
                table: "Libro");

            migrationBuilder.AddColumn<string>(
                name: "Autor",
                table: "Libro",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
