using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaGestionEntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class Cambio3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Productos");

            migrationBuilder.RenameColumn(
                name: "Usuario",
                table: "Productos",
                newName: "Descripciones");

            migrationBuilder.AddColumn<int>(
                name: "IDusuario",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IDusuario",
                table: "Productos");

            migrationBuilder.RenameColumn(
                name: "Descripciones",
                table: "Productos",
                newName: "Usuario");

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
