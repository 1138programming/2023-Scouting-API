using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Team1138.ScoutingApp.Migrations
{
    /// <inheritdoc />
    public partial class v8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "chargingStationPosition",
                table: "PitSoutingResults",
                newName: "ChargingStationPosition");

            migrationBuilder.RenameColumn(
                name: "ChargingStationPosition",
                table: "PitSoutingResults",
                newName: "EndGameChargingStationPosition");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ChargingStationPosition",
                table: "PitSoutingResults",
                newName: "chargingStationPosition");

            migrationBuilder.RenameColumn(
                name: "EndGameChargingStationPosition",
                table: "PitSoutingResults",
                newName: "ChargingStationPosition");
        }
    }
}
