using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstDatabase.Migrations
{
    public partial class SomeProjectsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "BudGet", "Name", "StartedDate" },
                values: new object[] { 1, 100m, "Some1", new DateTime(2022, 7, 9, 17, 38, 50, 76, DateTimeKind.Local).AddTicks(8296) });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "BudGet", "Name", "StartedDate" },
                values: new object[] { 2, 200m, "Some2", new DateTime(2022, 7, 9, 17, 38, 50, 76, DateTimeKind.Local).AddTicks(8326) });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "BudGet", "Name", "StartedDate" },
                values: new object[] { 3, 300m, "Some3", new DateTime(2022, 7, 9, 17, 38, 50, 76, DateTimeKind.Local).AddTicks(8328) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3);
        }
    }
}
