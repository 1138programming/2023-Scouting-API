using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Team1138.ScoutingApp.Migrations
{
    /// <inheritdoc />
    public partial class v16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndGameChargingStationPosition",
                table: "PitSoutingResults");

            migrationBuilder.RenameColumn(
                name: "DCMidCube",
                table: "MatchResult",
                newName: "DCMidCubeMiss");

            migrationBuilder.RenameColumn(
                name: "DCMidCone",
                table: "MatchResult",
                newName: "DCMidCubeHit");

            migrationBuilder.RenameColumn(
                name: "DCLowCube",
                table: "MatchResult",
                newName: "DCMidCubeAccuracy");

            migrationBuilder.RenameColumn(
                name: "DCLowCone",
                table: "MatchResult",
                newName: "DCMidConeMiss");

            migrationBuilder.RenameColumn(
                name: "DCHighCube",
                table: "MatchResult",
                newName: "DCMidConeHit");

            migrationBuilder.RenameColumn(
                name: "DCHighCone",
                table: "MatchResult",
                newName: "DCMidConeAccuracy");

            migrationBuilder.RenameColumn(
                name: "AutonomousMidCube",
                table: "MatchResult",
                newName: "DCLowCubeMiss");

            migrationBuilder.RenameColumn(
                name: "AutonomousMidCone",
                table: "MatchResult",
                newName: "DCLowCubeHit");

            migrationBuilder.RenameColumn(
                name: "AutonomousLowCube",
                table: "MatchResult",
                newName: "DCLowCubeAccuracy");

            migrationBuilder.RenameColumn(
                name: "AutonomousLowCone",
                table: "MatchResult",
                newName: "DCLowConeMiss");

            migrationBuilder.RenameColumn(
                name: "AutonomousHighCube",
                table: "MatchResult",
                newName: "DCLowConeHit");

            migrationBuilder.RenameColumn(
                name: "AutonomousHighCone",
                table: "MatchResult",
                newName: "DCLowConeAccuracy");

            migrationBuilder.AddColumn<int>(
                name: "AutonomousHighConeAccuracy",
                table: "MatchResult",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutonomousHighConeHit",
                table: "MatchResult",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutonomousHighConeMiss",
                table: "MatchResult",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutonomousHighCubeAccuracy",
                table: "MatchResult",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutonomousHighCubeHit",
                table: "MatchResult",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutonomousHighCubeMiss",
                table: "MatchResult",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutonomousLowConeAccuracy",
                table: "MatchResult",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutonomousLowConeHit",
                table: "MatchResult",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutonomousLowConeMiss",
                table: "MatchResult",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutonomousLowCubeAccuracy",
                table: "MatchResult",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutonomousLowCubeHit",
                table: "MatchResult",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutonomousLowCubeMiss",
                table: "MatchResult",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutonomousMidConeAccuracy",
                table: "MatchResult",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutonomousMidConeHit",
                table: "MatchResult",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutonomousMidConeMiss",
                table: "MatchResult",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutonomousMidCubeAccuracy",
                table: "MatchResult",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutonomousMidCubeHit",
                table: "MatchResult",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutonomousMidCubeMiss",
                table: "MatchResult",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DCHighConeAccuracy",
                table: "MatchResult",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DCHighConeHit",
                table: "MatchResult",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DCHighConeMiss",
                table: "MatchResult",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DCHighCubeAccuracy",
                table: "MatchResult",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DCHighCubeHit",
                table: "MatchResult",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DCHighCubeMiss",
                table: "MatchResult",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AutonomousHighConeAccuracy",
                table: "MatchResult");

            migrationBuilder.DropColumn(
                name: "AutonomousHighConeHit",
                table: "MatchResult");

            migrationBuilder.DropColumn(
                name: "AutonomousHighConeMiss",
                table: "MatchResult");

            migrationBuilder.DropColumn(
                name: "AutonomousHighCubeAccuracy",
                table: "MatchResult");

            migrationBuilder.DropColumn(
                name: "AutonomousHighCubeHit",
                table: "MatchResult");

            migrationBuilder.DropColumn(
                name: "AutonomousHighCubeMiss",
                table: "MatchResult");

            migrationBuilder.DropColumn(
                name: "AutonomousLowConeAccuracy",
                table: "MatchResult");

            migrationBuilder.DropColumn(
                name: "AutonomousLowConeHit",
                table: "MatchResult");

            migrationBuilder.DropColumn(
                name: "AutonomousLowConeMiss",
                table: "MatchResult");

            migrationBuilder.DropColumn(
                name: "AutonomousLowCubeAccuracy",
                table: "MatchResult");

            migrationBuilder.DropColumn(
                name: "AutonomousLowCubeHit",
                table: "MatchResult");

            migrationBuilder.DropColumn(
                name: "AutonomousLowCubeMiss",
                table: "MatchResult");

            migrationBuilder.DropColumn(
                name: "AutonomousMidConeAccuracy",
                table: "MatchResult");

            migrationBuilder.DropColumn(
                name: "AutonomousMidConeHit",
                table: "MatchResult");

            migrationBuilder.DropColumn(
                name: "AutonomousMidConeMiss",
                table: "MatchResult");

            migrationBuilder.DropColumn(
                name: "AutonomousMidCubeAccuracy",
                table: "MatchResult");

            migrationBuilder.DropColumn(
                name: "AutonomousMidCubeHit",
                table: "MatchResult");

            migrationBuilder.DropColumn(
                name: "AutonomousMidCubeMiss",
                table: "MatchResult");

            migrationBuilder.DropColumn(
                name: "DCHighConeAccuracy",
                table: "MatchResult");

            migrationBuilder.DropColumn(
                name: "DCHighConeHit",
                table: "MatchResult");

            migrationBuilder.DropColumn(
                name: "DCHighConeMiss",
                table: "MatchResult");

            migrationBuilder.DropColumn(
                name: "DCHighCubeAccuracy",
                table: "MatchResult");

            migrationBuilder.DropColumn(
                name: "DCHighCubeHit",
                table: "MatchResult");

            migrationBuilder.DropColumn(
                name: "DCHighCubeMiss",
                table: "MatchResult");

            migrationBuilder.RenameColumn(
                name: "DCMidCubeMiss",
                table: "MatchResult",
                newName: "DCMidCube");

            migrationBuilder.RenameColumn(
                name: "DCMidCubeHit",
                table: "MatchResult",
                newName: "DCMidCone");

            migrationBuilder.RenameColumn(
                name: "DCMidCubeAccuracy",
                table: "MatchResult",
                newName: "DCLowCube");

            migrationBuilder.RenameColumn(
                name: "DCMidConeMiss",
                table: "MatchResult",
                newName: "DCLowCone");

            migrationBuilder.RenameColumn(
                name: "DCMidConeHit",
                table: "MatchResult",
                newName: "DCHighCube");

            migrationBuilder.RenameColumn(
                name: "DCMidConeAccuracy",
                table: "MatchResult",
                newName: "DCHighCone");

            migrationBuilder.RenameColumn(
                name: "DCLowCubeMiss",
                table: "MatchResult",
                newName: "AutonomousMidCube");

            migrationBuilder.RenameColumn(
                name: "DCLowCubeHit",
                table: "MatchResult",
                newName: "AutonomousMidCone");

            migrationBuilder.RenameColumn(
                name: "DCLowCubeAccuracy",
                table: "MatchResult",
                newName: "AutonomousLowCube");

            migrationBuilder.RenameColumn(
                name: "DCLowConeMiss",
                table: "MatchResult",
                newName: "AutonomousLowCone");

            migrationBuilder.RenameColumn(
                name: "DCLowConeHit",
                table: "MatchResult",
                newName: "AutonomousHighCube");

            migrationBuilder.RenameColumn(
                name: "DCLowConeAccuracy",
                table: "MatchResult",
                newName: "AutonomousHighCone");

            migrationBuilder.AddColumn<int>(
                name: "EndGameChargingStationPosition",
                table: "PitSoutingResults",
                type: "int",
                nullable: true);
        }
    }
}
