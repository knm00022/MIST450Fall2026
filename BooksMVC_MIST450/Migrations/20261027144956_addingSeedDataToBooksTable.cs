using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BooksMVC_MIST450.Migrations
{
    /// <inheritdoc />
    public partial class addingSeedDataToBooksTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Books",
                newName: "Title");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "DatePublished", "Description", "Genre", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Salman Nazir", new DateTime(2025, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "This book has no description", "Programming", 19.99m, "C# for Beginners" },
                    { 2, "Adam Freeman", new DateTime(2026, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "This book has no description", "Programming", 29.99m, "C# Advanced" },
                    { 3, "Morgan Freeman", new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "This book has no description", "Programming", 15.99m, "ASP.NET for Beginners" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Books",
                newName: "Name");
        }
    }
}
