using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Dal.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 30, 8, 39, 11, 836, DateTimeKind.Utc).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 30, 8, 39, 11, 836, DateTimeKind.Utc).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 30, 8, 39, 11, 836, DateTimeKind.Utc).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 30, 8, 39, 11, 844, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 30, 8, 39, 11, 844, DateTimeKind.Utc).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 30, 8, 39, 11, 844, DateTimeKind.Utc).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 30, 8, 39, 11, 851, DateTimeKind.Utc).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 30, 8, 39, 11, 851, DateTimeKind.Utc).AddTicks(6695));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 26, 16, 51, 33, 188, DateTimeKind.Utc).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 26, 16, 51, 33, 188, DateTimeKind.Utc).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 26, 16, 51, 33, 188, DateTimeKind.Utc).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 26, 16, 51, 33, 198, DateTimeKind.Utc).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 26, 16, 51, 33, 199, DateTimeKind.Utc).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 26, 16, 51, 33, 199, DateTimeKind.Utc).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 26, 16, 51, 33, 209, DateTimeKind.Utc).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 26, 16, 51, 33, 209, DateTimeKind.Utc).AddTicks(3897));
        }
    }
}
