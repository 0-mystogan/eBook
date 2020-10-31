using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Dal.Migrations
{
    public partial class dataorders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 12, 37, 14, 388, DateTimeKind.Utc).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 12, 37, 14, 389, DateTimeKind.Utc).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 12, 37, 14, 389, DateTimeKind.Utc).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2020, 10, 31, 12, 37, 14, 398, DateTimeKind.Utc).AddTicks(7306), 7 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2020, 10, 31, 12, 37, 14, 399, DateTimeKind.Utc).AddTicks(2232), 7 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CreatedAt" },
                values: new object[] { 2, new DateTime(2020, 10, 31, 12, 37, 14, 399, DateTimeKind.Utc).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 12, 37, 14, 407, DateTimeKind.Utc).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 12, 37, 14, 407, DateTimeKind.Utc).AddTicks(3316));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 12, 33, 11, 204, DateTimeKind.Utc).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 12, 33, 11, 205, DateTimeKind.Utc).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 12, 33, 11, 205, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2020, 10, 31, 12, 33, 11, 213, DateTimeKind.Utc).AddTicks(7275), 5 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2020, 10, 31, 12, 33, 11, 214, DateTimeKind.Utc).AddTicks(2232), 5 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CreatedAt" },
                values: new object[] { 1, new DateTime(2020, 10, 31, 12, 33, 11, 214, DateTimeKind.Utc).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 12, 33, 11, 222, DateTimeKind.Utc).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 12, 33, 11, 222, DateTimeKind.Utc).AddTicks(2700));
        }
    }
}
