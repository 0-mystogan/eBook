using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Dal.Migrations
{
    public partial class dataForUserAndBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CreatedAt", "CreatedBy", "Currrency", "Description", "Image", "ModifiedAt", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "Neki_autor1", new DateTime(2020, 10, 25, 15, 50, 54, 873, DateTimeKind.Utc).AddTicks(9801), "jasirbuirc", "BAM", "Dobar Roman", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orlovi rano lete", 5m, 13 },
                    { 2, "Neki_autor2", new DateTime(2020, 10, 25, 15, 50, 54, 874, DateTimeKind.Utc).AddTicks(8464), "jasirbuirc", "BAM", "Knjiga za svaki uzrast", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Odgoj dijece u islamu", 19m, 7 },
                    { 3, "Neki_autor3", new DateTime(2020, 10, 25, 15, 50, 54, 874, DateTimeKind.Utc).AddTicks(8588), "jasirbuirc", "BAM", "Dobar Roman", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zeleno busenje", 7m, 9 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "CreatedBy", "Email", "FirstName", "IsAdmin", "LastName", "ModifiedAt", "Password" },
                values: new object[,]
                {
                    { 1, "Gorazdanska 96", new DateTime(2020, 10, 25, 15, 50, 54, 892, DateTimeKind.Utc).AddTicks(2722), "jasirburic", "jasir.buric@edu.fit.ba", "Jasir", false, "Buric", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123445566666" },
                    { 2, "Halkici 23", new DateTime(2020, 10, 25, 15, 50, 54, 892, DateTimeKind.Utc).AddTicks(2882), "jasirburic", "muhamed.halkic@edu.fit.ba", "Muhamed", false, "Halkic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lksdjfllkl44444" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
