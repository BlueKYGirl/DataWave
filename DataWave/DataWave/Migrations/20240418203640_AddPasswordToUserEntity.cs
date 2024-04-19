using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataWave.Migrations
{
    /// <inheritdoc />
    public partial class AddPasswordToUserEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"),
                column: "Password",
                value: "password1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"),
                column: "Password",
                value: "password3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"),
                column: "Password",
                value: "password2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");
        }
    }
}
