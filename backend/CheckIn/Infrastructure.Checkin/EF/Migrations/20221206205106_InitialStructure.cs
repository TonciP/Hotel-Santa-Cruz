using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Estadia.EF.Migrations
{
    /// <inheritdoc />
    public partial class InitialStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreditCard",
                columns: table => new
                {
                    creditCardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tipotarjeta = table.Column<string>(name: "tipo_tarjeta", type: "nvarchar(max)", nullable: true),
                    numerotarjeta = table.Column<string>(name: "numero_tarjeta", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCard", x => x.creditCardId);
                });

            migrationBuilder.CreateTable(
                name: "Habitacion",
                columns: table => new
                {
                    habitacionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    codigohabitacion = table.Column<string>(name: "codigo_habitacion", type: "nvarchar(max)", nullable: true),
                    limitepersona = table.Column<string>(name: "limite_persona", type: "nvarchar(max)", nullable: true),
                    tipohabitacion = table.Column<Guid>(name: "tipo_habitacion", type: "uniqueidentifier", nullable: false),
                    preciohabitacion = table.Column<double>(name: "precio_habitacion", type: "float", nullable: false),
                    numerohabitacion = table.Column<int>(name: "numero_habitacion", type: "int", nullable: false),
                    caracteristicahabitacion = table.Column<string>(name: "caracteristica_habitacion", type: "nvarchar(max)", nullable: true),
                    disponibilidad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habitacion", x => x.habitacionId);
                });

            migrationBuilder.CreateTable(
                name: "Huesped",
                columns: table => new
                {
                    huespedId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dni = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Huesped", x => x.huespedId);
                });

            migrationBuilder.CreateTable(
                name: "Checkin",
                columns: table => new
                {
                    checkinId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    reservaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    creditCardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    habitacionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    huespedId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkin", x => x.checkinId);
                    table.ForeignKey(
                        name: "FK_Checkin_CreditCard_creditCardId",
                        column: x => x.creditCardId,
                        principalTable: "CreditCard",
                        principalColumn: "creditCardId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checkin_Habitacion_habitacionId",
                        column: x => x.habitacionId,
                        principalTable: "Habitacion",
                        principalColumn: "habitacionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checkin_Huesped_huespedId",
                        column: x => x.huespedId,
                        principalTable: "Huesped",
                        principalColumn: "huespedId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Checkin_creditCardId",
                table: "Checkin",
                column: "creditCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkin_habitacionId",
                table: "Checkin",
                column: "habitacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkin_huespedId",
                table: "Checkin",
                column: "huespedId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Checkin");

            migrationBuilder.DropTable(
                name: "CreditCard");

            migrationBuilder.DropTable(
                name: "Habitacion");

            migrationBuilder.DropTable(
                name: "Huesped");
        }
    }
}
