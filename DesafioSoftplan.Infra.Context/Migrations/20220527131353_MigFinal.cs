using Microsoft.EntityFrameworkCore.Migrations;

namespace DesafioSoftplan.Infra.Data.Migrations
{
    public partial class MigFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "teste@teste.com");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "teste@teste.123");
        }
    }
}
