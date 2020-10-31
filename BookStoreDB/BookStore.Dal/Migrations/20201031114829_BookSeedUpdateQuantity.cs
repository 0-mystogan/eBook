using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Dal.Migrations
{
    public partial class BookSeedUpdateQuantity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 48, 28, 155, DateTimeKind.Utc).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 48, 28, 156, DateTimeKind.Utc).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Quantity" },
                values: new object[] { new DateTime(2020, 10, 31, 11, 48, 28, 156, DateTimeKind.Utc).AddTicks(6645), 0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 48, 28, 156, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 48, 28, 156, DateTimeKind.Utc).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Quantity" },
                values: new object[] { new DateTime(2020, 10, 31, 11, 48, 28, 156, DateTimeKind.Utc).AddTicks(6657), 0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 48, 28, 156, DateTimeKind.Utc).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 48, 28, 156, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 48, 28, 156, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 48, 28, 164, DateTimeKind.Utc).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 48, 28, 164, DateTimeKind.Utc).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 48, 28, 164, DateTimeKind.Utc).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 48, 28, 167, DateTimeKind.Utc).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 48, 28, 168, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 48, 28, 168, DateTimeKind.Utc).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 48, 28, 172, DateTimeKind.Utc).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 48, 28, 172, DateTimeKind.Utc).AddTicks(6985));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 23, 9, 99, DateTimeKind.Utc).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 23, 9, 99, DateTimeKind.Utc).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Quantity" },
                values: new object[] { new DateTime(2020, 10, 31, 11, 23, 9, 99, DateTimeKind.Utc).AddTicks(8860), 13 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 23, 9, 99, DateTimeKind.Utc).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 23, 9, 99, DateTimeKind.Utc).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Quantity" },
                values: new object[] { new DateTime(2020, 10, 31, 11, 23, 9, 99, DateTimeKind.Utc).AddTicks(8872), 13 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 23, 9, 99, DateTimeKind.Utc).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 23, 9, 99, DateTimeKind.Utc).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 23, 9, 99, DateTimeKind.Utc).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 23, 9, 109, DateTimeKind.Utc).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 23, 9, 109, DateTimeKind.Utc).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 23, 9, 109, DateTimeKind.Utc).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 23, 9, 115, DateTimeKind.Utc).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 23, 9, 115, DateTimeKind.Utc).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 23, 9, 115, DateTimeKind.Utc).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 23, 9, 121, DateTimeKind.Utc).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 31, 11, 23, 9, 121, DateTimeKind.Utc).AddTicks(4029));
        }
    }
}
