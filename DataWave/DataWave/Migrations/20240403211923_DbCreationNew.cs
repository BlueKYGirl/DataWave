using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataWave.Migrations
{
    /// <inheritdoc />
    public partial class DbCreationNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PlanId",
                table: "Devices",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Plans_PlanId",
                table: "Devices");

            migrationBuilder.DropIndex(
                name: "IX_Devices_PlanId",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "PlanId",
                table: "Devices");
        }
    }
}
