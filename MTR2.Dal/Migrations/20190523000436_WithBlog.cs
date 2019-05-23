using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MTR2.Dal.Migrations
{
    public partial class WithBlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BlogArticles",
                columns: new[] { "Id", "AuthorId", "Content", "CreationDate", "Title" },
                values: new object[] { 1, 1, @"
## Big Demo article...
", new DateTimeOffset(new DateTime(2019, 5, 23, 2, 4, 34, 886, DateTimeKind.Unspecified).AddTicks(9631), new TimeSpan(0, 2, 0, 0, 0)), "Welcome all!" });

            migrationBuilder.InsertData(
                table: "BlogArticles",
                columns: new[] { "Id", "AuthorId", "Content", "CreationDate", "Title" },
                values: new object[] { 2, 1, @"
## Big Demo article...

__asd___asd_
a
*a**a**
eh
", new DateTimeOffset(new DateTime(2019, 5, 23, 2, 4, 34, 889, DateTimeKind.Unspecified).AddTicks(4462), new TimeSpan(0, 2, 0, 0, 0)), "Another post here" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogArticles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BlogArticles",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
