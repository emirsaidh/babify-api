using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace babify_api.Migrations
{
    public partial class oneToManyTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDay",
                table: "Babies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "Babies",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "PhotoURL",
                table: "Babies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "Babies",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "BabyId",
                table: "Activities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Activities_BabyId",
                table: "Activities",
                column: "BabyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Babies_BabyId",
                table: "Activities",
                column: "BabyId",
                principalTable: "Babies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Babies_BabyId",
                table: "Activities");

            migrationBuilder.DropIndex(
                name: "IX_Activities_BabyId",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "BirthDay",
                table: "Babies");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Babies");

            migrationBuilder.DropColumn(
                name: "PhotoURL",
                table: "Babies");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Babies");

            migrationBuilder.DropColumn(
                name: "BabyId",
                table: "Activities");
        }
    }
}
