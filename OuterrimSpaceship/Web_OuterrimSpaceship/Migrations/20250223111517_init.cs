using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_OuterrimSpaceship.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aircraft_Spezifications",
                columns: table => new
                {
                    SpezificationId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Structure = table.Column<int>(type: "INTEGER", nullable: false),
                    FuelTankCapacity = table.Column<int>(type: "INTEGER", nullable: false),
                    MinSpeed = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxSpeed = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxAltitude = table.Column<int>(type: "INTEGER", nullable: false),
                    SpezificationCode = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aircraft_Spezifications", x => x.SpezificationId);
                });

            migrationBuilder.CreateTable(
                name: "Crime_Syndicates",
                columns: table => new
                {
                    SyndicateId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crime_Syndicates", x => x.SyndicateId);
                });

            migrationBuilder.CreateTable(
                name: "Mercenaries",
                columns: table => new
                {
                    MercenaryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    BodySkills = table.Column<int>(type: "INTEGER", nullable: false),
                    CombatSkill = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mercenaries", x => x.MercenaryId);
                });

            migrationBuilder.CreateTable(
                name: "Aircrafts",
                columns: table => new
                {
                    AircraftId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fuel = table.Column<int>(type: "INTEGER", nullable: false),
                    Speed = table.Column<int>(type: "INTEGER", nullable: false),
                    Altitude = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    SpezificationId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aircrafts", x => x.AircraftId);
                    table.ForeignKey(
                        name: "FK_Aircrafts_Aircraft_Spezifications_SpezificationId",
                        column: x => x.SpezificationId,
                        principalTable: "Aircraft_Spezifications",
                        principalColumn: "SpezificationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mercenary_Reputations",
                columns: table => new
                {
                    SyndicateId = table.Column<int>(type: "INTEGER", nullable: false),
                    MercenaryId = table.Column<int>(type: "INTEGER", nullable: false),
                    ReputationChange = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mercenary_Reputations", x => new { x.SyndicateId, x.MercenaryId });
                    table.ForeignKey(
                        name: "FK_Mercenary_Reputations_Crime_Syndicates_SyndicateId",
                        column: x => x.SyndicateId,
                        principalTable: "Crime_Syndicates",
                        principalColumn: "SyndicateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mercenary_Reputations_Mercenaries_MercenaryId",
                        column: x => x.MercenaryId,
                        principalTable: "Mercenaries",
                        principalColumn: "MercenaryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Aircraft_Crew_JT",
                columns: table => new
                {
                    AircraftId = table.Column<int>(type: "INTEGER", nullable: false),
                    MercenaryId = table.Column<int>(type: "INTEGER", nullable: false),
                    JoinedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aircraft_Crew_JT", x => new { x.AircraftId, x.MercenaryId });
                    table.ForeignKey(
                        name: "FK_Aircraft_Crew_JT_Aircrafts_AircraftId",
                        column: x => x.AircraftId,
                        principalTable: "Aircrafts",
                        principalColumn: "AircraftId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Aircraft_Crew_JT_Mercenaries_MercenaryId",
                        column: x => x.MercenaryId,
                        principalTable: "Mercenaries",
                        principalColumn: "MercenaryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Compartments",
                columns: table => new
                {
                    CompartmentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AircraftId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compartments", x => x.CompartmentId);
                    table.ForeignKey(
                        name: "FK_Compartments_Aircrafts_AircraftId",
                        column: x => x.AircraftId,
                        principalTable: "Aircrafts",
                        principalColumn: "AircraftId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Machineries",
                columns: table => new
                {
                    MachineryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Label = table.Column<string>(type: "TEXT", nullable: false),
                    Function = table.Column<string>(type: "TEXT", nullable: false),
                    CompartmentId = table.Column<int>(type: "INTEGER", nullable: false),
                    Type = table.Column<string>(type: "TEXT", maxLength: 21, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machineries", x => x.MachineryId);
                    table.ForeignKey(
                        name: "FK_Machineries_Compartments_CompartmentId",
                        column: x => x.CompartmentId,
                        principalTable: "Compartments",
                        principalColumn: "CompartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aircraft_Crew_JT_MercenaryId",
                table: "Aircraft_Crew_JT",
                column: "MercenaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Aircrafts_SpezificationId",
                table: "Aircrafts",
                column: "SpezificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Compartments_AircraftId",
                table: "Compartments",
                column: "AircraftId");

            migrationBuilder.CreateIndex(
                name: "IX_Machineries_CompartmentId",
                table: "Machineries",
                column: "CompartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Machineries_Label",
                table: "Machineries",
                column: "Label",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mercenary_Reputations_MercenaryId",
                table: "Mercenary_Reputations",
                column: "MercenaryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aircraft_Crew_JT");

            migrationBuilder.DropTable(
                name: "Machineries");

            migrationBuilder.DropTable(
                name: "Mercenary_Reputations");

            migrationBuilder.DropTable(
                name: "Compartments");

            migrationBuilder.DropTable(
                name: "Crime_Syndicates");

            migrationBuilder.DropTable(
                name: "Mercenaries");

            migrationBuilder.DropTable(
                name: "Aircrafts");

            migrationBuilder.DropTable(
                name: "Aircraft_Spezifications");
        }
    }
}
