using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataWave.Migrations
{
    /// <inheritdoc />
    public partial class FifthConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Plans",
                columns: new[] { "PlanId", "DeviceLimit", "PlanName", "Price" },
                values: new object[,]
                {
                    { new Guid("b82a50f6-40b8-4b10-b8ef-9f401e3f0ac5"), 20, "Premium Plan", 49.99m },
                    { new Guid("eaa6bc36-60f3-4815-b19a-8f2b79f4aa67"), 3, "Free Plan", 0m },
                    { new Guid("f73f65e4-8b79-4fd1-b9a2-cb109ca932e2"), 10, "Basic Plan", 29.99m }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceId", "PhoneNumber", "PlanId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b82a50f6-40b8-4b10-b8ef-9f401e3f0ac5"), "0987654321", new Guid("b82a50f6-40b8-4b10-b8ef-9f401e3f0ac5"), new Guid("798acf1b-7339-44bd-8367-7132a978d7b1") },
                    { new Guid("eaa6bc36-60f3-4815-b19a-8f2b79f4aa67"), "5432167890", new Guid("eaa6bc36-60f3-4815-b19a-8f2b79f4aa67"), new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb") },
                    { new Guid("f73f65e4-8b79-4fd1-b9a2-cb109ca932e2"), "1234567890", new Guid("f73f65e4-8b79-4fd1-b9a2-cb109ca932e2"), new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("b82a50f6-40b8-4b10-b8ef-9f401e3f0ac5"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("eaa6bc36-60f3-4815-b19a-8f2b79f4aa67"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("f73f65e4-8b79-4fd1-b9a2-cb109ca932e2"));

            migrationBuilder.DeleteData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("b82a50f6-40b8-4b10-b8ef-9f401e3f0ac5"));

            migrationBuilder.DeleteData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("eaa6bc36-60f3-4815-b19a-8f2b79f4aa67"));

            migrationBuilder.DeleteData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("f73f65e4-8b79-4fd1-b9a2-cb109ca932e2"));
        }
    }
}
