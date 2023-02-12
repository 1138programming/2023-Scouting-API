using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Team1138.ScoutingApp.Migrations
{
    /// <inheritdoc />
    public partial class v15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competitions",
                columns: table => new
                {
                    CompetitionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitions", x => x.CompetitionID);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    MatchID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetitionID = table.Column<int>(type: "int", nullable: false),
                    Competition = table.Column<int>(type: "int", nullable: false),
                    MatchNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.MatchID);
                });

            migrationBuilder.CreateTable(
                name: "MatchResult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamNumber = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    MatchNumber = table.Column<int>(type: "int", nullable: false),
                    MatchId = table.Column<int>(type: "int", nullable: false),
                    AutonomousControlPoints = table.Column<int>(type: "int", nullable: true),
                    AutonomousHighCube = table.Column<int>(type: "int", nullable: true),
                    AutonomousHighCone = table.Column<int>(type: "int", nullable: true),
                    AutonomousMidCube = table.Column<int>(type: "int", nullable: true),
                    AutonomousMidCone = table.Column<int>(type: "int", nullable: true),
                    AutonomousLowCube = table.Column<int>(type: "int", nullable: true),
                    AutonomousLowCone = table.Column<int>(type: "int", nullable: true),
                    AutonDocking = table.Column<bool>(type: "bit", nullable: true),
                    AutonWinner = table.Column<int>(type: "int", nullable: true),
                    Engaged = table.Column<bool>(type: "bit", nullable: true),
                    MobilityBonus = table.Column<bool>(type: "bit", nullable: true),
                    AutonNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCControlPoints = table.Column<int>(type: "int", nullable: true),
                    DCHighCube = table.Column<int>(type: "int", nullable: true),
                    DCHighCone = table.Column<int>(type: "int", nullable: true),
                    DCMidCube = table.Column<int>(type: "int", nullable: true),
                    DCMidCone = table.Column<int>(type: "int", nullable: true),
                    DCLowCube = table.Column<int>(type: "int", nullable: true),
                    DCLowCone = table.Column<int>(type: "int", nullable: true),
                    OPR = table.Column<int>(type: "int", nullable: true),
                    DPR = table.Column<int>(type: "int", nullable: true),
                    DCDocking = table.Column<bool>(type: "bit", nullable: true),
                    DCEngaged = table.Column<bool>(type: "bit", nullable: true),
                    SustainabilityBonus = table.Column<bool>(type: "bit", nullable: true),
                    ActivationBonus = table.Column<bool>(type: "bit", nullable: true),
                    CoopertitionBonus = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchResult", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamNumber);
                });

            migrationBuilder.CreateTable(
                name: "PitSoutingResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetitionId = table.Column<int>(type: "int", nullable: false),
                    TeamNumber = table.Column<int>(type: "int", nullable: false),
                    NumBatteries = table.Column<int>(type: "int", nullable: true),
                    NumBatChargers = table.Column<int>(type: "int", nullable: true),
                    MotorType = table.Column<int>(type: "int", nullable: true),
                    DrivetrainMotorNum = table.Column<int>(type: "int", nullable: true),
                    NodeTypeHybridOrFloor = table.Column<bool>(type: "bit", nullable: true),
                    NodeTypeMid = table.Column<bool>(type: "bit", nullable: true),
                    NodeTypeHigh = table.Column<bool>(type: "bit", nullable: true),
                    NodeTypeNone = table.Column<bool>(type: "bit", nullable: true),
                    DriverControlGamePiecesUsed = table.Column<int>(type: "int", nullable: true),
                    EndGameDockingActivation = table.Column<int>(type: "int", nullable: true),
                    EndGameChargingStationPosition = table.Column<int>(type: "int", nullable: true),
                    MobilityPoints = table.Column<int>(type: "int", nullable: true),
                    CoopNodeTypeHighCone = table.Column<bool>(type: "bit", nullable: true),
                    CoopNodeTypeHighCube = table.Column<bool>(type: "bit", nullable: true),
                    CoopNodeTypeMidCone = table.Column<bool>(type: "bit", nullable: true),
                    CoopNodeTypeMidCube = table.Column<bool>(type: "bit", nullable: true),
                    CoopNodeTypeHybridCone = table.Column<bool>(type: "bit", nullable: true),
                    CoopNodeTypeHybridCube = table.Column<bool>(type: "bit", nullable: true),
                    NodeTypeHighCone = table.Column<bool>(type: "bit", nullable: true),
                    NodeTypeHighCube = table.Column<bool>(type: "bit", nullable: true),
                    NodeTypeMidCone = table.Column<bool>(type: "bit", nullable: true),
                    NodeTypeMidCube = table.Column<bool>(type: "bit", nullable: true),
                    NodeTypeHybridCone = table.Column<bool>(type: "bit", nullable: true),
                    NodeTypeHybridCube = table.Column<bool>(type: "bit", nullable: true),
                    ChargingStationActivation = table.Column<int>(type: "int", nullable: true),
                    ChargingStationPosition = table.Column<int>(type: "int", nullable: true),
                    GamePieceStartingPosFR = table.Column<int>(type: "int", nullable: true),
                    GamePieceStartingPosMR = table.Column<int>(type: "int", nullable: true),
                    GamePieceStartingPosML = table.Column<int>(type: "int", nullable: true),
                    GamePieceStartingPosFL = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PitSoutingResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PitSoutingResults_Competitions_CompetitionId",
                        column: x => x.CompetitionId,
                        principalTable: "Competitions",
                        principalColumn: "CompetitionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PitSoutingResults_Teams_TeamNumber",
                        column: x => x.TeamNumber,
                        principalTable: "Teams",
                        principalColumn: "TeamNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PitSoutingResults_CompetitionId",
                table: "PitSoutingResults",
                column: "CompetitionId");

            migrationBuilder.CreateIndex(
                name: "IX_PitSoutingResults_TeamNumber",
                table: "PitSoutingResults",
                column: "TeamNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "MatchResult");

            migrationBuilder.DropTable(
                name: "PitSoutingResults");

            migrationBuilder.DropTable(
                name: "Competitions");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
