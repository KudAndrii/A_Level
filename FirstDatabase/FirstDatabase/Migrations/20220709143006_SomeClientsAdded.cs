using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstDatabase.Migrations
{
    public partial class SomeClientsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientId", "Age", "Login", "Password" },
                values: new object[,]
                {
                    { 1, 14, "Jerry", "1234" },
                    { 2, 20, "Sara", "0000" },
                    { 3, 43, "John", "1111" },
                    { 4, 30, "Joe", "0000" },
                    { 5, 25, "Din", "1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 5);
        }
    }
}
