using Microsoft.EntityFrameworkCore.Migrations;

namespace DesafioSoftplan.Infra.Data.Migrations
{
    public partial class SeedUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "City", "Complementar", "District", "Email", "LoginProvider", "Name", "Number", "Password", "Photo", "State", "Street", "ZipCode" },
                values: new object[] { 1, null, null, null, "teste@teste.123", null, "Administrador", null, "C8E453E305380C3C103BE203AA7720F444333D6F", null, null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
