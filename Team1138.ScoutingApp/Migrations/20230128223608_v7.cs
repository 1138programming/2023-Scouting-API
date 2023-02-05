using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Team1138.ScoutingApp.Migrations
{
    /// <inheritdoc />
    public partial class v7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CanDockOnChargingStation",
                table: "PitSoutingResults");

            migrationBuilder.DropColumn(
                name: "CanEngageOnChargingStation",
                table: "PitSoutingResults");

            migrationBuilder.AddColumn<int>(
                name: "ChargingStationActivation",
                table: "PitSoutingResults",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChargingStationPosition",
                table: "PitSoutingResults",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChargingStationActivation",
                table: "PitSoutingResults");

            migrationBuilder.DropColumn(
                name: "ChargingStationPosition",
                table: "PitSoutingResults");

            migrationBuilder.AddColumn<bool>(
                name: "CanDockOnChargingStation",
                table: "PitSoutingResults",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CanEngageOnChargingStation",
                table: "PitSoutingResults",
                type: "bit",
                nullable: true);
        }
    }
}
