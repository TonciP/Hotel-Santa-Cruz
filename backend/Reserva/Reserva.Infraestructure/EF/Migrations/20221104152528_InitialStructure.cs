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
                    nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    fechaEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaSalida = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estadia", x => x.estadiaId);
                });

            migrationBuilder.CreateTable(
                name: "Tracking",
                columns: table => new
                {
                    trackingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    hash = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracking", x => x.trackingId);
                });

            migrationBuilder.CreateTable(
                name: "reservas",
                columns: table => new
                {
                    reservaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _trackingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    habitacionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _estadiaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _clienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservas", x => x.reservaId);
                    table.ForeignKey(
                        name: "FK_reservas_cliente__clienteId",
                        column: x => x._clienteId,
                        principalTable: "cliente",
                        principalColumn: "clienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservas_estadia__estadiaId",
                        column: x => x._estadiaId,
                        principalTable: "estadia",
                        principalColumn: "estadiaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservas_Tracking__trackingId",
                        column: x => x._trackingId,
                        principalTable: "Tracking",
                        principalColumn: "trackingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_reservas__clienteId",
                table: "reservas",
                column: "_clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_reservas__estadiaId",
                table: "reservas",
                column: "_estadiaId");

            migrationBuilder.CreateIndex(
                name: "IX_reservas__trackingId",
                table: "reservas",
                column: "_trackingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "reservas");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "estadia");

            migrationBuilder.DropTable(
                name: "Tracking");
        }
    }
}
