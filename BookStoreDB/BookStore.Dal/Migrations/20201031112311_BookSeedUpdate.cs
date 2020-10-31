using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Dal.Migrations
{
    public partial class BookSeedUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Books",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 10, 31, 11, 23, 9, 99, DateTimeKind.Utc).AddTicks(1472), "../../assets/Vjencanje.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 10, 31, 11, 23, 9, 99, DateTimeKind.Utc).AddTicks(8763), "../../assets/Mi_protiv_vas.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 10, 31, 11, 23, 9, 99, DateTimeKind.Utc).AddTicks(8860), "../../assets/Zivotinja_srca.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 10, 31, 11, 23, 9, 99, DateTimeKind.Utc).AddTicks(8863), "../../assets/Zivim_tiho.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 10, 31, 11, 23, 9, 99, DateTimeKind.Utc).AddTicks(8866), "../../assets/Casovnicareva_kci.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 10, 31, 11, 23, 9, 99, DateTimeKind.Utc).AddTicks(8872), "../../assets/Tudja_pravila.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 10, 31, 11, 23, 9, 99, DateTimeKind.Utc).AddTicks(8874), "../../assets/Garavi_sokak.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 10, 31, 11, 23, 9, 99, DateTimeKind.Utc).AddTicks(8876), "../../assets/Ime_ruze.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 10, 31, 11, 23, 9, 99, DateTimeKind.Utc).AddTicks(8878), "../../assets/Medvjedgrad.jpg" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                table: "Books",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 10, 30, 18, 20, 12, 403, DateTimeKind.Utc).AddTicks(7050), null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 10, 30, 18, 20, 12, 405, DateTimeKind.Utc).AddTicks(2421), null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 10, 30, 18, 20, 12, 405, DateTimeKind.Utc).AddTicks(3039), null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 10, 30, 18, 20, 12, 405, DateTimeKind.Utc).AddTicks(3073), null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 10, 30, 18, 20, 12, 405, DateTimeKind.Utc).AddTicks(3079), null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 10, 30, 18, 20, 12, 405, DateTimeKind.Utc).AddTicks(3257), null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 10, 30, 18, 20, 12, 405, DateTimeKind.Utc).AddTicks(3267), null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 10, 30, 18, 20, 12, 405, DateTimeKind.Utc).AddTicks(3288), null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 10, 30, 18, 20, 12, 405, DateTimeKind.Utc).AddTicks(3294), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 30, 18, 20, 12, 417, DateTimeKind.Utc).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 30, 18, 20, 12, 417, DateTimeKind.Utc).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 30, 18, 20, 12, 417, DateTimeKind.Utc).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 30, 18, 20, 12, 422, DateTimeKind.Utc).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 30, 18, 20, 12, 423, DateTimeKind.Utc).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 30, 18, 20, 12, 423, DateTimeKind.Utc).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 30, 18, 20, 12, 430, DateTimeKind.Utc).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 30, 18, 20, 12, 430, DateTimeKind.Utc).AddTicks(5534));
        }
    }
}
