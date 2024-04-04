using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataWave.Migrations
{
    /// <inheritdoc />
    public partial class Again : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Plans_PlanId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanUser_Plans_PlansId",
                table: "PlanUser");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanUser_Users_UsersId",
                table: "PlanUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlanUser",
                table: "PlanUser");

            migrationBuilder.DropIndex(
                name: "IX_Devices_PlanId",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "PlanId",
                table: "Devices");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "PlanUser",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "PlansId",
                table: "PlanUser",
                newName: "PlanId");

            migrationBuilder.RenameIndex(
                name: "IX_PlanUser_UsersId",
                table: "PlanUser",
                newName: "IX_PlanUser_UserId");

            migrationBuilder.AddColumn<Guid>(
                name: "PlanUserId",
                table: "PlanUser",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PlanUserId",
                table: "Devices",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlanUser",
                table: "PlanUser",
                column: "PlanUserId");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("b82a50f6-40b8-4b10-b8ef-9f401e3f0ac5"),
                column: "PlanUserId",
                value: new Guid("4fb2f9d1-8746-4850-9e1a-d2b3fc272780"));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("eaa6bc36-60f3-4815-b19a-8f2b79f4aa67"),
                column: "PlanUserId",
                value: new Guid("8f57b505-4bc2-4cb7-86de-9e8d64dfcf85"));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("f73f65e4-8b79-4fd1-b9a2-cb109ca932e2"),
                column: "PlanUserId",
                value: new Guid("c3aa48a0-1dc8-4f17-a6d4-ef57896fe57a"));

            migrationBuilder.InsertData(
                table: "PlanUser",
                columns: new[] { "PlanUserId", "PlanId", "UserId" },
                values: new object[,]
                {
                    { new Guid("4fb2f9d1-8746-4850-9e1a-d2b3fc272780"), new Guid("b82a50f6-40b8-4b10-b8ef-9f401e3f0ac5"), new Guid("798acf1b-7339-44bd-8367-7132a978d7b1") },
                    { new Guid("8f57b505-4bc2-4cb7-86de-9e8d64dfcf85"), new Guid("eaa6bc36-60f3-4815-b19a-8f2b79f4aa67"), new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb") },
                    { new Guid("c3aa48a0-1dc8-4f17-a6d4-ef57896fe57a"), new Guid("f73f65e4-8b79-4fd1-b9a2-cb109ca932e2"), new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlanUser_PlanId",
                table: "PlanUser",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_PlanUserId",
                table: "Devices",
                column: "PlanUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_PlanUser_PlanUserId",
                table: "Devices",
                column: "PlanUserId",
                principalTable: "PlanUser",
                principalColumn: "PlanUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlanUser_Plans_PlanId",
                table: "PlanUser",
                column: "PlanId",
                principalTable: "Plans",
                principalColumn: "PlanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanUser_Users_UserId",
                table: "PlanUser",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_PlanUser_PlanUserId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanUser_Plans_PlanId",
                table: "PlanUser");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanUser_Users_UserId",
                table: "PlanUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlanUser",
                table: "PlanUser");

            migrationBuilder.DropIndex(
                name: "IX_PlanUser_PlanId",
                table: "PlanUser");

            migrationBuilder.DropIndex(
                name: "IX_Devices_PlanUserId",
                table: "Devices");

            migrationBuilder.DeleteData(
                table: "PlanUser",
                keyColumn: "PlanUserId",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("4fb2f9d1-8746-4850-9e1a-d2b3fc272780"));

            migrationBuilder.DeleteData(
                table: "PlanUser",
                keyColumn: "PlanUserId",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("8f57b505-4bc2-4cb7-86de-9e8d64dfcf85"));

            migrationBuilder.DeleteData(
                table: "PlanUser",
                keyColumn: "PlanUserId",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("c3aa48a0-1dc8-4f17-a6d4-ef57896fe57a"));

            migrationBuilder.DropColumn(
                name: "PlanUserId",
                table: "PlanUser");

            migrationBuilder.DropColumn(
                name: "PlanUserId",
                table: "Devices");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "PlanUser",
                newName: "UsersId");

            migrationBuilder.RenameColumn(
                name: "PlanId",
                table: "PlanUser",
                newName: "PlansId");

            migrationBuilder.RenameIndex(
                name: "IX_PlanUser_UserId",
                table: "PlanUser",
                newName: "IX_PlanUser_UsersId");

            migrationBuilder.AddColumn<Guid>(
                name: "PlanId",
                table: "Devices",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlanUser",
                table: "PlanUser",
                columns: new[] { "PlansId", "UsersId" });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("b82a50f6-40b8-4b10-b8ef-9f401e3f0ac5"),
                column: "PlanId",
                value: new Guid("b82a50f6-40b8-4b10-b8ef-9f401e3f0ac5"));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("eaa6bc36-60f3-4815-b19a-8f2b79f4aa67"),
                column: "PlanId",
                value: new Guid("eaa6bc36-60f3-4815-b19a-8f2b79f4aa67"));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("f73f65e4-8b79-4fd1-b9a2-cb109ca932e2"),
                column: "PlanId",
                value: new Guid("f73f65e4-8b79-4fd1-b9a2-cb109ca932e2"));

            migrationBuilder.CreateIndex(
                name: "IX_Devices_PlanId",
                table: "Devices",
                column: "PlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Plans_PlanId",
                table: "Devices",
                column: "PlanId",
                principalTable: "Plans",
                principalColumn: "PlanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanUser_Plans_PlansId",
                table: "PlanUser",
                column: "PlansId",
                principalTable: "Plans",
                principalColumn: "PlanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanUser_Users_UsersId",
                table: "PlanUser",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
