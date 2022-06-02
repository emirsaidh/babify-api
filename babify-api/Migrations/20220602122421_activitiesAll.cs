using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace babify_api.Migrations
{
    public partial class activitiesAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "type",
                table: "Activities",
                newName: "Type");

            migrationBuilder.CreateTable(
                name: "BathActivities",
                columns: table => new
                {
                    BathId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Seconds = table.Column<int>(type: "int", nullable: false),
                    FinishTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BathActivities", x => x.BathId);
                    table.ForeignKey(
                        name: "FK_BathActivities_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BottleMilkActivities",
                columns: table => new
                {
                    BottleMilkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BottleMilkType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "BreastFeedingActivities",
                columns: table => new
                {
                    BreastFeedingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Seconds = table.Column<int>(type: "int", nullable: false),
                    FinishTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreastFeedingActivities", x => x.BreastFeedingId);
                    table.ForeignKey(
                        name: "FK_BreastFeedingActivities_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiaperActivities",
                columns: table => new
                {
                    DiaperId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiaperType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaperActivities", x => x.DiaperId);
                    table.ForeignKey(
                        name: "FK_DiaperActivities_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MeasureActivities",
                columns: table => new
                {
                    MeasureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Head = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasureActivities", x => x.MeasureId);
                    table.ForeignKey(
                        name: "FK_MeasureActivities_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicationActivities",
                columns: table => new
                {
                    MedicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicationActivities", x => x.MedicationId);
                    table.ForeignKey(
                        name: "FK_MedicationActivities_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PumpingActivities",
                columns: table => new
                {
                    PumpingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PumpingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PumpingActivities", x => x.PumpingId);
                    table.ForeignKey(
                        name: "FK_PumpingActivities_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VaccinationActivities",
                columns: table => new
                {
                    VaccinationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VaccinationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccinationActivities", x => x.VaccinationId);
                    table.ForeignKey(
                        name: "FK_VaccinationActivities_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WalkActivities",
                columns: table => new
                {
                    WalkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Seconds = table.Column<int>(type: "int", nullable: false),
                    FinishTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalkActivities", x => x.WalkId);
                    table.ForeignKey(
                        name: "FK_WalkActivities_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BathActivities_ActivityId",
                table: "BathActivities",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_BottleMilkActivities_ActivityId",
                table: "BottleMilkActivities",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_BreastFeedingActivities_ActivityId",
                table: "BreastFeedingActivities",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_DiaperActivities_ActivityId",
                table: "DiaperActivities",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_MeasureActivities_ActivityId",
                table: "MeasureActivities",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicationActivities_ActivityId",
                table: "MedicationActivities",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_PumpingActivities_ActivityId",
                table: "PumpingActivities",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_VaccinationActivities_ActivityId",
                table: "VaccinationActivities",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_WalkActivities_ActivityId",
                table: "WalkActivities",
                column: "ActivityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BathActivities");

            migrationBuilder.DropTable(
                name: "BottleMilkActivities");

            migrationBuilder.DropTable(
                name: "BreastFeedingActivities");

            migrationBuilder.DropTable(
                name: "DiaperActivities");

            migrationBuilder.DropTable(
                name: "MeasureActivities");

            migrationBuilder.DropTable(
                name: "MedicationActivities");

            migrationBuilder.DropTable(
                name: "PumpingActivities");

            migrationBuilder.DropTable(
                name: "VaccinationActivities");

            migrationBuilder.DropTable(
                name: "WalkActivities");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Activities",
                newName: "type");
        }
    }
}
