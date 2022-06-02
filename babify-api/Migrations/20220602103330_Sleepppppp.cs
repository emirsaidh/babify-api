using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace babify_api.Migrations
{
    public partial class Sleepppppp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FinishTime",
                table: "Activities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Seconds",
                table: "Activities",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "FinishTime",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "Seconds",
                table: "Activities");
        }
    }
}
