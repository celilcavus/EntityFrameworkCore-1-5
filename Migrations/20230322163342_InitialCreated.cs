using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork_1_5.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Musteris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KimlikNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusteriAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusteriSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YasaidigiIlId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SiparisUruns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiparisId = table.Column<int>(type: "int", nullable: false),
                    UrunId = table.Column<int>(type: "int", nullable: false),
                    BirimFiyati = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Miktari = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiparisUruns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Siparis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiparisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToplamTutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KargoFirmasiId = table.Column<int>(type: "int", nullable: false),
                    FaturaId = table.Column<int>(type: "int", nullable: false),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    SatisTemsilcisiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Siparis_Musteris_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Faturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiparisId = table.Column<int>(type: "int", nullable: false),
                    SiparisId1 = table.Column<int>(type: "int", nullable: true),
                    FaturaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Faturas_Siparis_SiparisId1",
                        column: x => x.SiparisId1,
                        principalTable: "Siparis",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SatisTemsilcisis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SatisTemsilcisiAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SatisTemsilcisiSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiparisId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatisTemsilcisis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SatisTemsilcisis_Siparis_SiparisId",
                        column: x => x.SiparisId,
                        principalTable: "Siparis",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Faturas_SiparisId1",
                table: "Faturas",
                column: "SiparisId1");

            migrationBuilder.CreateIndex(
                name: "IX_SatisTemsilcisis_SiparisId",
                table: "SatisTemsilcisis",
                column: "SiparisId");

            migrationBuilder.CreateIndex(
                name: "IX_Siparis_MusteriId",
                table: "Siparis",
                column: "MusteriId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faturas");

            migrationBuilder.DropTable(
                name: "SatisTemsilcisis");

            migrationBuilder.DropTable(
                name: "SiparisUruns");

            migrationBuilder.DropTable(
                name: "Siparis");

            migrationBuilder.DropTable(
                name: "Musteris");
        }
    }
}
