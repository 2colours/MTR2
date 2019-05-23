using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MTR2.Dal.Migrations
{
    public partial class WithShortDescrip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "BlogArticles",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BlogArticles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ShortDescription" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 5, 23, 3, 51, 15, 762, DateTimeKind.Unspecified).AddTicks(7657), new TimeSpan(0, 2, 0, 0, 0)), "Ehn order to put it on screen easily :D" });

            migrationBuilder.UpdateData(
                table: "BlogArticles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "CreationDate", "ShortDescription" },
                values: new object[] { 2, new DateTimeOffset(new DateTime(2019, 5, 23, 3, 51, 15, 765, DateTimeKind.Unspecified).AddTicks(3529), new TimeSpan(0, 2, 0, 0, 0)), "In order to put it on screen easily :D" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "BlogArticles");

            migrationBuilder.UpdateData(
                table: "BlogArticles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTimeOffset(new DateTime(2019, 5, 23, 2, 4, 34, 886, DateTimeKind.Unspecified).AddTicks(9631), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "BlogArticles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "CreationDate" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2019, 5, 23, 2, 4, 34, 889, DateTimeKind.Unspecified).AddTicks(4462), new TimeSpan(0, 2, 0, 0, 0)) });
        }
    }
}
