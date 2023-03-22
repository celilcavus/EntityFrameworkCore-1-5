using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork_1_5.Migrations
{
    /// <inheritdoc />
    public partial class mig_UpdateFatura2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SiporisId",
                table: "Faturas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SiporisId",
                table: "Faturas");
        }
    }
}
