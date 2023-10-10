using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaGestionEntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class cambios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cantidad",
                table: "Productos",
                newName: "Costo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Costo",
                table: "Productos",
                newName: "cantidad");
        }
    }
}
