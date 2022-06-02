using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace babify_api.Migrations
{
    public partial class BottleMilkInherit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BottleMilkActivities");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "BottleMilkType",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Activities");

            migrationBuilder.CreateTable(
                name: "BottleMilkActivities",
                columns: table => new
                {
                    BottleMilkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BottleMilkType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BottleMilkActivities", x => x.BottleMilkId);
                    table.ForeignKey(
                        name: "FK_BottleMilkActivities_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BottleMilkActivities_ActivityId",
                table: "BottleMilkActivities",
                column: "ActivityId");
        }
    }
}
