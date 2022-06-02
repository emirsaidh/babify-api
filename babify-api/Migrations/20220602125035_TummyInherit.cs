using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace babify_api.Migrations
{
    public partial class TummyInherit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TummyActivities_Activities_ActivityId",
                table: "TummyActivities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TummyActivities",
                table: "TummyActivities");

            migrationBuilder.DropIndex(
                name: "IX_TummyActivities_ActivityId",
                table: "TummyActivities");

            migrationBuilder.DropColumn(
                name: "TummyId",
                table: "TummyActivities");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "BottleMilkType",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Activities");

            migrationBuilder.AddColumn<int>(
                name: "ActivityModelActivityId",
                table: "TummyActivities",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TummyActivities",
                table: "TummyActivities",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_TummyActivities_ActivityModelActivityId",
                table: "TummyActivities",
                column: "ActivityModelActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_TummyActivities_Activities_ActivityId",
                table: "TummyActivities",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "ActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_TummyActivities_Activities_ActivityModelActivityId",
                table: "TummyActivities",
                column: "ActivityModelActivityId",
                principalTable: "Activities",
                principalColumn: "ActivityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TummyActivities_Activities_ActivityId",
                table: "TummyActivities");

            migrationBuilder.DropForeignKey(
                name: "FK_TummyActivities_Activities_ActivityModelActivityId",
                table: "TummyActivities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TummyActivities",
                table: "TummyActivities");

            migrationBuilder.DropIndex(
                name: "IX_TummyActivities_ActivityModelActivityId",
                table: "TummyActivities");

            migrationBuilder.DropColumn(
                name: "ActivityModelActivityId",
                table: "TummyActivities");

            migrationBuilder.AddColumn<int>(
                name: "TummyId",
                table: "TummyActivities",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Amount",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BottleMilkType",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TummyActivities",
                table: "TummyActivities",
                column: "TummyId");

            migrationBuilder.CreateIndex(
                name: "IX_TummyActivities_ActivityId",
                table: "TummyActivities",
                column: "ActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_TummyActivities_Activities_ActivityId",
                table: "TummyActivities",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "ActivityId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
