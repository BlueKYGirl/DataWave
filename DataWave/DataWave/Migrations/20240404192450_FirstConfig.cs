using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataWave.Migrations
{
    /// <inheritdoc />
    public partial class FirstConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"), "calexander@contosouniversity.edu", "Carson", "Alexander" },
                    { new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"), "aanand@contosouniversity.edu", "Arturo", "Anand" },
                    { new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"), "malonso@contosouniversity.edu", "Meredith", "Alonso" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"));
        }
    }
}
