using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PainTrackerPT.Migrations
{
    public partial class Ginyu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnalyticsLog",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    timeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalyticsLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DoctorsLog",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    timeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorsLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventsLog",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    timeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventsLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FollowupsLog",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    timeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowupsLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicineLog",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    timeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PainDiary",
                columns: table => new
                {
                    PainDiaryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PatientID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PainDiary", x => x.PainDiaryID);
                });

            migrationBuilder.CreateTable(
                name: "PainDiaryLog",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    timeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PainDiaryLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interference",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Severity = table.Column<int>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    PainDiaryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interference", x => x.id);
                    table.ForeignKey(
                        name: "FK_Interference_PainDiary_PainDiaryID",
                        column: x => x.PainDiaryID,
                        principalTable: "PainDiary",
                        principalColumn: "PainDiaryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mood",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MoodType = table.Column<int>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    PainDiaryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mood", x => x.id);
                    table.ForeignKey(
                        name: "FK_Mood_PainDiary_PainDiaryID",
                        column: x => x.PainDiaryID,
                        principalTable: "PainDiary",
                        principalColumn: "PainDiaryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PainIntensity",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PainDiaryID = table.Column<int>(nullable: false),
                    painRating = table.Column<int>(nullable: false),
                    painArea = table.Column<int>(nullable: false),
                    duration = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PainIntensity", x => x.id);
                    table.ForeignKey(
                        name: "FK_PainIntensity_PainDiary_PainDiaryID",
                        column: x => x.PainDiaryID,
                        principalTable: "PainDiary",
                        principalColumn: "PainDiaryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sleep",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PainDiaryID = table.Column<int>(nullable: false),
                    sleepHours = table.Column<int>(nullable: false),
                    comfortLevel = table.Column<int>(nullable: false),
                    tiredness = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: false)

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sleep", x => x.id);
                    table.ForeignKey(
                        name: "FK_Sleep_PainDiary_PainDiaryID",
                        column: x => x.PainDiaryID,
                        principalTable: "PainDiary",
                        principalColumn: "PainDiaryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Interference_PainDiaryID",
                table: "Interference",
                column: "PainDiaryID");

            migrationBuilder.CreateIndex(
                name: "IX_Mood_PainDiaryID",
                table: "Mood",
                column: "PainDiaryID");

            migrationBuilder.CreateIndex(
                name: "IX_PainIntensity_PainDiaryID",
                table: "PainIntensity",
                column: "PainDiaryID");

            migrationBuilder.CreateIndex(
                name: "IX_Sleep_PainDiaryID",
                table: "Sleep",
                column: "PainDiaryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnalyticsLog");

            migrationBuilder.DropTable(
                name: "DoctorsLog");

            migrationBuilder.DropTable(
                name: "EventsLog");

            migrationBuilder.DropTable(
                name: "FollowupsLog");

            migrationBuilder.DropTable(
                name: "Interference");

            migrationBuilder.DropTable(
                name: "MedicineLog");

            migrationBuilder.DropTable(
                name: "Mood");

            migrationBuilder.DropTable(
                name: "PainDiaryLog");

            migrationBuilder.DropTable(
                name: "PainIntensity");

            migrationBuilder.DropTable(
                name: "Sleep");

            migrationBuilder.DropTable(
                name: "PainDiary");
        }
    }
}
