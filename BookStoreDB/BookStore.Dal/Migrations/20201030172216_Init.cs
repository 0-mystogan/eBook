using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Dal.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false, comment: "This is date when object is updated"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Currrency = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Image = table.Column<byte[]>(nullable: true),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false, comment: "This is date when object is updated"),
                    CreatedBy = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    IsAdmin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookCategories",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategories", x => new { x.BookId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_BookCategories_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Total = table.Column<decimal>(nullable: false),
                    PaymantMethod = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CreatedAt", "CreatedBy", "Currrency", "Description", "Image", "ModifiedAt", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "Neki_autor1", new DateTime(2020, 10, 30, 17, 22, 16, 124, DateTimeKind.Utc).AddTicks(4248), "jasirbuirc", "BAM", "Dobar Roman", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orlovi rano lete", 5m, 13 },
                    { 2, "Neki_autor2", new DateTime(2020, 10, 30, 17, 22, 16, 124, DateTimeKind.Utc).AddTicks(9759), "jasirbuirc", "BAM", "Knjiga za svaki uzrast", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Odgoj dijece u islamu", 19m, 7 },
                    { 3, "Neki_autor3", new DateTime(2020, 10, 30, 17, 22, 16, 124, DateTimeKind.Utc).AddTicks(9840), "jasirbuirc", "BAM", "Dobar Roman", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zeleno busenje", 7m, 9 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "CreatedBy", "Email", "FirstName", "IsAdmin", "LastName", "ModifiedAt", "Password" },
                values: new object[,]
                {
                    { 1, "Gorazdanska 96", new DateTime(2020, 10, 30, 17, 22, 16, 141, DateTimeKind.Utc).AddTicks(2527), "jasirburic", "jasir.buric@edu.fit.ba", "Jasir", false, "Buric", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123445566666" },
                    { 2, "Halkici 23", new DateTime(2020, 10, 30, 17, 22, 16, 141, DateTimeKind.Utc).AddTicks(2640), "jasirburic", "muhamed.halkic@edu.fit.ba", "Muhamed", false, "Halkic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lksdjfllkl44444" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BookId", "CreatedAt", "CreatedBy", "Date", "ModifiedAt", "PaymantMethod", "Quantity", "Total", "UserId" },
                values: new object[] { 3, 1, new DateTime(2020, 10, 30, 17, 22, 16, 136, DateTimeKind.Utc).AddTicks(8240), "jasirbuirc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paypal", 2, 10m, 1 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BookId", "CreatedAt", "CreatedBy", "Date", "ModifiedAt", "PaymantMethod", "Quantity", "Total", "UserId" },
                values: new object[] { 1, 2, new DateTime(2020, 10, 30, 17, 22, 16, 136, DateTimeKind.Utc).AddTicks(4696), "jasirbuirc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paypal", 2, 38m, 2 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BookId", "CreatedAt", "CreatedBy", "Date", "ModifiedAt", "PaymantMethod", "Quantity", "Total", "UserId" },
                values: new object[] { 2, 2, new DateTime(2020, 10, 30, 17, 22, 16, 136, DateTimeKind.Utc).AddTicks(8180), "jasirbuirc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paypal", 1, 19m, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_BookCategories_CategoryId",
                table: "BookCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_BookId",
                table: "Carts",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BookId",
                table: "Orders",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCategories");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
