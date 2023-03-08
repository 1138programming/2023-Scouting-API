using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Team1138.ScoutingApp.Migrations
{
    /// <inheritdoc />
    public partial class v19 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "AutonomousAccuracy",
                table: "MatchResult",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DCAccuracy",
                table: "MatchResult",
                type: "float",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AutonomousAccuracy",
                table: "MatchResult");

            migrationBuilder.DropColumn(
                name: "DCAccuracy",
                table: "MatchResult");
        }
    }
}
