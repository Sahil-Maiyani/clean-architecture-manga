using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Manga.Infrastructure.EntityFrameworkDataAccess.Migrations
{
    public partial class NewSSNFieldv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.AddColumn<string>(
                name: "SSN",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Credit",
                keyColumn: "Id",
                keyValue: new Guid("f5117315-e789-491a-b662-958c37237f9b"),
                column: "TransactionDate",
                value: new DateTime(2019, 7, 12, 11, 27, 22, 523, DateTimeKind.Utc).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "Debit",
                keyColumn: "Id",
                keyValue: new Guid("3d6032df-7a3b-46e6-8706-be971e3d539f"),
                column: "TransactionDate",
                value: new DateTime(2019, 7, 12, 11, 27, 22, 523, DateTimeKind.Utc).AddTicks(3898));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SSN",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SSN = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Credit",
                keyColumn: "Id",
                keyValue: new Guid("f5117315-e789-491a-b662-958c37237f9b"),
                column: "TransactionDate",
                value: new DateTime(2019, 7, 8, 6, 41, 36, 905, DateTimeKind.Utc).AddTicks(537));

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Name", "SSN" },
                values: new object[] { new Guid("197d0438-e04b-453d-b5de-eca05960c6ae"), "Test User", "19860817-9999" });

            migrationBuilder.UpdateData(
                table: "Debit",
                keyColumn: "Id",
                keyValue: new Guid("3d6032df-7a3b-46e6-8706-be971e3d539f"),
                column: "TransactionDate",
                value: new DateTime(2019, 7, 8, 6, 41, 36, 905, DateTimeKind.Utc).AddTicks(2241));
        }
    }
}
