using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reserva.Infraestructure.Ef.Migrations
{
    public partial class InitialStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    clienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nombres = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    apellidos = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.clienteId);
                });

            migrationBuilder.CreateTable(
                name: "estadia",
                columns: table => new
                {
                    estadiaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fechaEntrada = table.Column<DateTime>(type: "Date", nullable: false),
                    fechaSalida = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estadia", x => x.estadiaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "estadia");
        }
    }
}
