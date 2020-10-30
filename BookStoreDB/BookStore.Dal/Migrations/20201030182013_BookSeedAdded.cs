using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Dal.Migrations
{
    public partial class BookSeedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "CreatedAt", "CreatedBy", "Description", "Name", "Price" },
                values: new object[] { "Julie Garwood", new DateTime(2020, 10, 30, 18, 20, 12, 403, DateTimeKind.Utc).AddTicks(7050), "jasirburic", "Roman Vjenčanje nezaboravna je ljubavna priča puna strasti i uzbudljivih intriga iz pera nenadmašne Julie Garwood. Putujući iz Engleske u Škotsku kako bi se udala.", "Vjenčanje", 22m });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "CreatedAt", "CreatedBy", "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Fredrik Bakman", new DateTime(2020, 10, 30, 18, 20, 12, 405, DateTimeKind.Utc).AddTicks(2421), "jasirburic", "Ponekad je tako jednostavno potaći ljude da mrze jedni druge da je prosto neshvatljivo kako bilo šta drugo i radimo. Nakon užasnih zbivanja koja su potresla Medvjedgrad.", "Mi protiv vas", 20m, 13 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "CreatedAt", "CreatedBy", "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Herta Miler", new DateTime(2020, 10, 30, 18, 20, 12, 405, DateTimeKind.Utc).AddTicks(3039), "jasirburic", "Dobitnica Nobelove nagrade. Lolino samoubistvo, koje je možda i ubistvo, povezuje četvoro mladih ljudi. Između njih se razvija neraskidivo prijateljstvo.", "Životinja srca", 15m, 13 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CreatedAt", "CreatedBy", "Currrency", "Description", "Image", "ModifiedAt", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 9, "Fredrik Bakman", new DateTime(2020, 10, 30, 18, 20, 12, 405, DateTimeKind.Utc).AddTicks(3294), "jasirburic", "BAM", "Roman Medvjedgrad prvi je dio autorove duologije o problemima što ih donosi život u maloj zajednici. Problemima što ih se lako može preslikati i na šire i veće zajednice.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medvjedgrad", 20m, 13 },
                    { 4, "Fadil Duranović", new DateTime(2020, 10, 30, 18, 20, 12, 405, DateTimeKind.Utc).AddTicks(3073), "jasirburic", "BAM", "Fadil Duranović se suočio sa sobom i svijetom, a potom zatočen slikom i međusobnim odnosom, pjesnički osvijestio svoju komunikaciju.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Živim tiho", 15m, 13 },
                    { 7, "Miroslav Antić", new DateTime(2020, 10, 30, 18, 20, 12, 405, DateTimeKind.Utc).AddTicks(3267), "jasirburic", "BAM", "Veselo cigansko vašarište sa nekoliko suza i kapi kiše Miroslav Antić posvećuje ovu knjigu mladom Ciganinu Miletu Dileji, koga su fašisti jedne noći odveli.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garavi sokak", 16m, 13 },
                    { 6, "Džon Irving", new DateTime(2020, 10, 30, 18, 20, 12, 405, DateTimeKind.Utc).AddTicks(3257), "jasirburic", "BAM", "Radnja ovog romana odvija se u ruralnim krajevima Nove Engleske u prvoj polovini dvadesetog veka. To je priča o doktoru Vilburu Larču.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tuđa pravila", 30m, 13 },
                    { 5, "Kejt Morton", new DateTime(2020, 10, 30, 18, 20, 12, 405, DateTimeKind.Utc).AddTicks(3079), "jasirburic", "BAM", "Mog pravog imena niko se ne seća. Istinu o tom letu niko ne zna. U leto 1862. grupa mladih umetnika na čelu sa talentovanim Edvardom Redklifom.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Časovničareva kći", 26m, 13 },
                    { 8, "Umberto Eko", new DateTime(2020, 10, 30, 18, 20, 12, 405, DateTimeKind.Utc).AddTicks(3288), "jasirburic", "BAM", "Jedan od temeljnih postmodernističkih romana o fatalnom dejstvu jedne zabranjene knjige smješten je u godinu 1327. Franjevački monasi u bogatoj italijanskoj opatiji.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ime ruže", 15m, 13 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 10, 30, 18, 20, 12, 417, DateTimeKind.Utc).AddTicks(4253), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roman" },
                    { 2, new DateTime(2020, 10, 30, 18, 20, 12, 417, DateTimeKind.Utc).AddTicks(6295), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Drama" },
                    { 3, new DateTime(2020, 10, 30, 18, 20, 12, 417, DateTimeKind.Utc).AddTicks(6346), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Poezija" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "CreatedAt", "CreatedBy", "Description", "Name", "Price" },
                values: new object[] { "Neki_autor1", new DateTime(2020, 10, 30, 17, 22, 16, 124, DateTimeKind.Utc).AddTicks(4248), "jasirbuirc", "Dobar Roman", "Orlovi rano lete", 5m });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "CreatedAt", "CreatedBy", "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Neki_autor2", new DateTime(2020, 10, 30, 17, 22, 16, 124, DateTimeKind.Utc).AddTicks(9759), "jasirbuirc", "Knjiga za svaki uzrast", "Odgoj dijece u islamu", 19m, 7 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "CreatedAt", "CreatedBy", "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Neki_autor3", new DateTime(2020, 10, 30, 17, 22, 16, 124, DateTimeKind.Utc).AddTicks(9840), "jasirbuirc", "Dobar Roman", "Zeleno busenje", 7m, 9 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 30, 17, 22, 16, 136, DateTimeKind.Utc).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 30, 17, 22, 16, 136, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 30, 17, 22, 16, 136, DateTimeKind.Utc).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 30, 17, 22, 16, 141, DateTimeKind.Utc).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 30, 17, 22, 16, 141, DateTimeKind.Utc).AddTicks(2640));
        }
    }
}
