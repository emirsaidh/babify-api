using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace babify_api.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "SleepActivities",
                columns: table => new
                {
                    SleepId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Seconds = table.Column<int>(type: "int", nullable: false),
                    FinishTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SleepActivities", x => x.SleepId);
                    table.ForeignKey(
                        name: "FK_SleepActivities_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SleepActivities_ActivityId",
                table: "SleepActivities",
                column: "ActivityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SleepActivities");

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
    }
}
