using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstDatabase.Migrations
{
    public partial class ClientProjectConnectionAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "StartedDate",
                value: new DateTime(2022, 7, 9, 18, 20, 38, 961, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "StartedDate",
                value: new DateTime(2022, 7, 9, 18, 20, 38, 961, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "StartedDate",
                value: new DateTime(2022, 7, 9, 18, 20, 38, 961, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.CreateIndex(
                name: "IX_Project_ClientId",
                table: "Project",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Client_ClientId",
                table: "Project",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Client_ClientId",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Project_ClientId",
                table: "Project");

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "StartedDate",
                value: new DateTime(2022, 7, 9, 18, 11, 41, 670, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "StartedDate",
                value: new DateTime(2022, 7, 9, 18, 11, 41, 670, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "StartedDate",
                value: new DateTime(2022, 7, 9, 18, 11, 41, 670, DateTimeKind.Local).AddTicks(5097));
        }
    }
}
