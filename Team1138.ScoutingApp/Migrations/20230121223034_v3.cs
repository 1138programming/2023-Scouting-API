using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Team1138.ScoutingApp.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CanDockOnChargingStation",
                table: "PitSoutingResults",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanEngageOnChargingStation",
                table: "PitSoutingResults",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CantScoreNode",
                table: "PitSoutingResults",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CoopNodeTypeHigh",
                table: "PitSoutingResults",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CoopNodeTypeHybridOrFloor",
                table: "PitSoutingResults",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CoopNodeTypeMid",
                table: "PitSoutingResults",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "DrivetrainMotorNum",
                table: "PitSoutingResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GamePieceStartingPosFL",
                table: "PitSoutingResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GamePieceStartingPosFR",
                table: "PitSoutingResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GamePieceStartingPosML",
                table: "PitSoutingResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GamePieceStartingPosMR",
                table: "PitSoutingResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "NodeTypeHigh",
                table: "PitSoutingResults",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NodeTypeHybridOrFloor",
                table: "PitSoutingResults",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NodeTypeMid",
                table: "PitSoutingResults",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "NumBatChargers",
                table: "PitSoutingResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumBatteries",
                table: "PitSoutingResults",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CanDockOnChargingStation",
                table: "PitSoutingResults");

            migrationBuilder.DropColumn(
                name: "CanEngageOnChargingStation",
                table: "PitSoutingResults");

            migrationBuilder.DropColumn(
                name: "CantScoreNode",
                table: "PitSoutingResults");

            migrationBuilder.DropColumn(
                name: "CoopNodeTypeHigh",
                table: "PitSoutingResults");

            migrationBuilder.DropColumn(
                name: "CoopNodeTypeHybridOrFloor",
                table: "PitSoutingResults");

            migrationBuilder.DropColumn(
                name: "CoopNodeTypeMid",
                table: "PitSoutingResults");

            migrationBuilder.DropColumn(
                name: "DrivetrainMotorNum",
                table: "PitSoutingResults");

            migrationBuilder.DropColumn(
                name: "GamePieceStartingPosFL",
                table: "PitSoutingResults");

            migrationBuilder.DropColumn(
                name: "GamePieceStartingPosFR",
                table: "PitSoutingResults");

            migrationBuilder.DropColumn(
                name: "GamePieceStartingPosML",
                table: "PitSoutingResults");

            migrationBuilder.DropColumn(
                name: "GamePieceStartingPosMR",
                table: "PitSoutingResults");

            migrationBuilder.DropColumn(
                name: "NodeTypeHigh",
                table: "PitSoutingResults");

            migrationBuilder.DropColumn(
                name: "NodeTypeHybridOrFloor",
                table: "PitSoutingResults");

            migrationBuilder.DropColumn(
                name: "NodeTypeMid",
                table: "PitSoutingResults");

            migrationBuilder.DropColumn(
                name: "NumBatChargers",
                table: "PitSoutingResults");

            migrationBuilder.DropColumn(
                name: "NumBatteries",
                table: "PitSoutingResults");
        }
    }
}
