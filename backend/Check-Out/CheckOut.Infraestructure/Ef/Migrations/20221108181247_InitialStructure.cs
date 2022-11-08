using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheckOut.Infraestructure.Ef.MIgrations
{
    public partial class InitialStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetalleFactura",
                columns: table => new
                {
                    detalleFacturaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    servicioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    precioServicio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleFactura", x => x.detalleFacturaId);
                });

            migrationBuilder.CreateTable(
                name: "pagos",
                columns: table => new
                {
                    pagoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pagos", x => x.pagoId);
                });

            migrationBuilder.CreateTable(
                name: "facturas",
                columns: table => new
                {
                    facturaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    numerofactura = table.Column<int>(type: "int", nullable: false),
                    total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    fechafactura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _detalleFacturaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_facturas", x => x.facturaId);
                    table.ForeignKey(
                        name: "FK_facturas_DetalleFactura__detalleFacturaId",
                        column: x => x._detalleFacturaId,
                        principalTable: "DetalleFactura",
                        principalColumn: "detalleFacturaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "checkouts",
                columns: table => new
                {
                    checkoutId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    checkinId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _clienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    credicartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _facturaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _pagoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_checkouts", x => x.checkoutId);
                    table.ForeignKey(
                        name: "FK_checkouts_facturas__facturaId",
                        column: x => x._facturaId,
                        principalTable: "facturas",
                        principalColumn: "facturaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_checkouts_pagos__pagoId",
                        column: x => x._pagoId,
                        principalTable: "pagos",
                        principalColumn: "pagoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_checkouts__facturaId",
                table: "checkouts",
                column: "_facturaId");

            migrationBuilder.CreateIndex(
                name: "IX_checkouts__pagoId",
                table: "checkouts",
                column: "_pagoId");

            migrationBuilder.CreateIndex(
                name: "IX_facturas__detalleFacturaId",
                table: "facturas",
                column: "_detalleFacturaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "checkouts");

            migrationBuilder.DropTable(
                name: "facturas");

            migrationBuilder.DropTable(
                name: "pagos");

            migrationBuilder.DropTable(
                name: "DetalleFactura");
        }
    }
}
