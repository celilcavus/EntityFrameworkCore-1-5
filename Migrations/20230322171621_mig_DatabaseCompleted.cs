using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork_1_5.Migrations
{
    /// <inheritdoc />
    public partial class mig_DatabaseCompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YasaidigiIlId",
                table: "Musteris",
                newName: "IlId");

            migrationBuilder.AddColumn<int>(
                name: "SiparisUrunId",
                table: "Siparis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ils",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ils", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "kargoFirmasis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KargoAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temsilci = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiparisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kargoFirmasis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SiparisSiparisUrun",
                columns: table => new
                {
                    SiparisId = table.Column<int>(type: "int", nullable: false),
                    SiparisUrunId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiparisSiparisUrun", x => new { x.SiparisId, x.SiparisUrunId });
                    table.ForeignKey(
                        name: "FK_SiparisSiparisUrun_SiparisUruns_SiparisUrunId",
                        column: x => x.SiparisUrunId,
                        principalTable: "SiparisUruns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiparisSiparisUrun_Siparis_SiparisId",
                        column: x => x.SiparisId,
                        principalTable: "Siparis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Urun",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiparisUrunId = table.Column<int>(type: "int", nullable: false),
                    UrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StokMiktari = table.Column<int>(type: "int", nullable: false),
                    BirimFiyati = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urun", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "kategoris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunId = table.Column<int>(type: "int", nullable: false),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kategoris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_kategoris_Urun_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Urun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SiparisUruns_UrunId",
                table: "SiparisUruns",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_Siparis_KargoFirmasiId",
                table: "Siparis",
                column: "KargoFirmasiId");

            migrationBuilder.CreateIndex(
                name: "IX_Musteris_IlId",
                table: "Musteris",
                column: "IlId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_kategoris_UrunId",
                table: "kategoris",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_SiparisSiparisUrun_SiparisUrunId",
                table: "SiparisSiparisUrun",
                column: "SiparisUrunId");

            migrationBuilder.AddForeignKey(
                name: "FK_Musteris_ils_IlId",
                table: "Musteris",
                column: "IlId",
                principalTable: "ils",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Siparis_kargoFirmasis_KargoFirmasiId",
                table: "Siparis",
                column: "KargoFirmasiId",
                principalTable: "kargoFirmasis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SiparisUruns_Urun_UrunId",
                table: "SiparisUruns",
                column: "UrunId",
                principalTable: "Urun",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musteris_ils_IlId",
                table: "Musteris");

            migrationBuilder.DropForeignKey(
                name: "FK_Siparis_kargoFirmasis_KargoFirmasiId",
                table: "Siparis");

            migrationBuilder.DropForeignKey(
                name: "FK_SiparisUruns_Urun_UrunId",
                table: "SiparisUruns");

            migrationBuilder.DropTable(
                name: "ils");

            migrationBuilder.DropTable(
                name: "kargoFirmasis");

            migrationBuilder.DropTable(
                name: "kategoris");

            migrationBuilder.DropTable(
                name: "SiparisSiparisUrun");

            migrationBuilder.DropTable(
                name: "Urun");

            migrationBuilder.DropIndex(
                name: "IX_SiparisUruns_UrunId",
                table: "SiparisUruns");

            migrationBuilder.DropIndex(
                name: "IX_Siparis_KargoFirmasiId",
                table: "Siparis");

            migrationBuilder.DropIndex(
                name: "IX_Musteris_IlId",
                table: "Musteris");

            migrationBuilder.DropColumn(
                name: "SiparisUrunId",
                table: "Siparis");

            migrationBuilder.RenameColumn(
                name: "IlId",
                table: "Musteris",
                newName: "YasaidigiIlId");
        }
    }
}
