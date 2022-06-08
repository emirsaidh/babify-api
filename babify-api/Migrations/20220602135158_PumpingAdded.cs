using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace babify_api.Migrations
{
    public partial class PumpingAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Amount",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BathActivity_FinishTime",
                table: "Activities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BathActivity_Seconds",
                table: "Activities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BreastFeedingActivity_FinishTime",
                table: "Activities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BreastFeedingActivity_Seconds",
                table: "Activities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PumpingType",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TummyActivity_FinishTime",
                table: "Activities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TummyActivity_Seconds",
                table: "Activities",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "BathActivity_FinishTime",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "BathActivity_Seconds",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "BreastFeedingActivity_FinishTime",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "BreastFeedingActivity_Seconds",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "PumpingType",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "TummyActivity_FinishTime",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "TummyActivity_Seconds",
                table: "Activities");
        }
    }
}
