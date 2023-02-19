using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Team1138.ScoutingApp.Migrations
{
    /// <inheritdoc />
    public partial class v18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MotorType",
                table: "PitSoutingResults",
                newName: "HowLongToPlaceTopNode");

            migrationBuilder.AddColumn<bool>(
                name: "Cim",
                table: "PitSoutingResults",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CycleTime",
                table: "PitSoutingResults",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Falcon",
                table: "PitSoutingResults",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Neo",
                table: "PitSoutingResults",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cim",
                table: "PitSoutingResults");

            migrationBuilder.DropColumn(
                name: "CycleTime",
                table: "PitSoutingResults");

            migrationBuilder.DropColumn(
                name: "Falcon",
                table: "PitSoutingResults");

            migrationBuilder.DropColumn(
                name: "Neo",
                table: "PitSoutingResults");

            migrationBuilder.RenameColumn(
                name: "HowLongToPlaceTopNode",
                table: "PitSoutingResults",
                newName: "MotorType");
        }
    }
}
