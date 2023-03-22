using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork_1_5.Migrations
{
    /// <inheritdoc />
    public partial class mig_UpdateFatura : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faturas_Siparis_SiparisId1",
                table: "Faturas");

            migrationBuilder.DropIndex(
                name: "IX_Faturas_SiparisId1",
                table: "Faturas");

            migrationBuilder.DropColumn(
                name: "SiparisId",
                table: "Faturas");

            migrationBuilder.DropColumn(
                name: "SiparisId1",
                table: "Faturas");

            migrationBuilder.CreateIndex(
                name: "IX_Siparis_FaturaId",
                table: "Siparis",
                column: "FaturaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Siparis_Faturas_FaturaId",
                table: "Siparis",
                column: "FaturaId",
                principalTable: "Faturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Siparis_Faturas_FaturaId",
                table: "Siparis");

            migrationBuilder.DropIndex(
                name: "IX_Siparis_FaturaId",
                table: "Siparis");

            migrationBuilder.AddColumn<int>(
                name: "SiparisId",
                table: "Faturas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SiparisId1",
                table: "Faturas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Faturas_SiparisId1",
                table: "Faturas",
                column: "SiparisId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Faturas_Siparis_SiparisId1",
                table: "Faturas",
                column: "SiparisId1",
                principalTable: "Siparis",
                principalColumn: "Id");
        }
    }
}
