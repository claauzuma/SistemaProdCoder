using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaGestionEntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class Cambio4545 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "ProductosVendidos");

            migrationBuilder.DropColumn(
                name: "Costo",
                table: "ProductosVendidos");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "ProductosVendidos");

            migrationBuilder.DropColumn(
                name: "PrecioVenta",
                table: "ProductosVendidos");

            migrationBuilder.DropColumn(
                name: "Usuario",
                table: "ProductosVendidos");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Ventas",
                newName: "Coementarios");

            migrationBuilder.RenameColumn(
                name: "Cantidad",
                table: "Ventas",
                newName: "IdUsuario");

            migrationBuilder.AddColumn<int>(
                name: "IdProducto",
                table: "ProductosVendidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdVenta",
                table: "ProductosVendidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "ProductosVendidos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdProducto",
                table: "ProductosVendidos");

            migrationBuilder.DropColumn(
                name: "IdVenta",
                table: "ProductosVendidos");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "ProductosVendidos");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Ventas",
                newName: "Cantidad");

            migrationBuilder.RenameColumn(
                name: "Coementarios",
                table: "Ventas",
                newName: "Descripcion");

            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "Ventas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Cantidad",
                table: "ProductosVendidos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Costo",
                table: "ProductosVendidos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "ProductosVendidos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "PrecioVenta",
                table: "ProductosVendidos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Usuario",
                table: "ProductosVendidos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
