using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace babify_api.Migrations
{
    public partial class FK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SleepActivities_Activities_ActivityId",
                table: "SleepActivities");

            migrationBuilder.DropIndex(
                name: "IX_SleepActivities_ActivityId",
                table: "SleepActivities");

            migrationBuilder.DropColumn(
                name: "ActivityId",
                table: "SleepActivities");

            migrationBuilder.AddColumn<int>(
                name: "SleepId",
                table: "Activities",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SleepId",
                table: "Activities");

            migrationBuilder.AddColumn<int>(
                name: "ActivityId",
                table: "SleepActivities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SleepActivities_ActivityId",
                table: "SleepActivities",
                column: "ActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_SleepActivities_Activities_ActivityId",
                table: "SleepActivities",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "ActivityId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
