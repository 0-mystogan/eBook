using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Dal.Migrations
{
    public partial class updataBookEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                table: "Books",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AddColumn<string>(
                name: "Currrency",
                table: "Books",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currrency",
                table: "Books");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                table: "Books",
                type: "varbinary(max)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldNullable: true);
        }
    }
}
