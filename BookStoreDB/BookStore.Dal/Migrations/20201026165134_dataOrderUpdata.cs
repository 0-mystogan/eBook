using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Dal.Migrations
{
    public partial class dataOrderUpdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 10, 26, 16, 51, 33, 198, DateTimeKind.Utc).AddTicks(6225), 5 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 10, 26, 16, 51, 33, 199, DateTimeKind.Utc).AddTicks(1322), 5 });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 16, 36, 56, 879, DateTimeKind.Utc).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 16, 36, 56, 880, DateTimeKind.Utc).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 16, 36, 56, 880, DateTimeKind.Utc).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 10, 25, 16, 36, 56, 889, DateTimeKind.Utc).AddTicks(3720), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 10, 25, 16, 36, 56, 889, DateTimeKind.Utc).AddTicks(8722), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 16, 36, 56, 889, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 16, 36, 56, 898, DateTimeKind.Utc).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 16, 36, 56, 898, DateTimeKind.Utc).AddTicks(921));
        }
    }
}
