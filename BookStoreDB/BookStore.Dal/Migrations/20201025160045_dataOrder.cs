using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Dal.Migrations
{
    public partial class dataOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 16, 0, 44, 937, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 16, 0, 44, 938, DateTimeKind.Utc).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 16, 0, 44, 938, DateTimeKind.Utc).AddTicks(6824));

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "BookId", "CreatedAt", "CreatedBy", "Date", "ModifiedAt", "PaymantMethod", "Quatity", "Total", "UserId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2020, 10, 25, 16, 0, 44, 947, DateTimeKind.Utc).AddTicks(823), "jasirbuirc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paypal", 2, 38m, 1 },
                    { 2, 2, new DateTime(2020, 10, 25, 16, 0, 44, 947, DateTimeKind.Utc).AddTicks(5748), "jasirbuirc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paypal", 1, 19m, 1 },
                    { 3, 1, new DateTime(2020, 10, 25, 16, 0, 44, 947, DateTimeKind.Utc).AddTicks(5836), "jasirbuirc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paypal", 2, 10m, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 16, 0, 44, 956, DateTimeKind.Utc).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 16, 0, 44, 956, DateTimeKind.Utc).AddTicks(4576));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 15, 50, 54, 873, DateTimeKind.Utc).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 15, 50, 54, 874, DateTimeKind.Utc).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 15, 50, 54, 874, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 15, 50, 54, 892, DateTimeKind.Utc).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 15, 50, 54, 892, DateTimeKind.Utc).AddTicks(2882));
        }
    }
}
