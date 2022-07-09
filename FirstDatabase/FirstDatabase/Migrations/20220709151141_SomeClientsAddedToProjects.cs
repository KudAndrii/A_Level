using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstDatabase.Migrations
{
    public partial class SomeClientsAddedToProjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "ClientId", "StartedDate" },
                values: new object[] { 1, new DateTime(2022, 7, 9, 18, 11, 41, 670, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "ClientId", "StartedDate" },
                values: new object[] { 3, new DateTime(2022, 7, 9, 18, 11, 41, 670, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3,
                columns: new[] { "ClientId", "StartedDate" },
                values: new object[] { 4, new DateTime(2022, 7, 9, 18, 11, 41, 670, DateTimeKind.Local).AddTicks(5097) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Project");

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "StartedDate",
                value: new DateTime(2022, 7, 9, 17, 38, 50, 76, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "StartedDate",
                value: new DateTime(2022, 7, 9, 17, 38, 50, 76, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "StartedDate",
                value: new DateTime(2022, 7, 9, 17, 38, 50, 76, DateTimeKind.Local).AddTicks(8328));
        }
    }
}
