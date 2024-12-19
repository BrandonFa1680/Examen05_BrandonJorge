using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen05_BrandonJorge.Migrations
{
    /// <inheritdoc />
    public partial class ChangenameofelemeentonCategortiaV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Categorias",
                newName: "NombreCategoria");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NombreCategoria",
                table: "Categorias",
                newName: "Nombre");
        }
    }
}
