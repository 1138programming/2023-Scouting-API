using MessagePack;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace Team1138.ScoutingApp.Data.Entities
{
    public class MatchResult
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int TeamNumber { get; set; }

        [ForeignKey(nameof(TeamNumber))]
        public int TeamId { get; set; }

        [Required]
        public int MatchNumber { get; set; }

        [ForeignKey(nameof(MatchNumber))]
        public int MatchId { get; set; }
        //Auton
        public int? AutonomousControlPoints { get; set; }
        public int? AutonomousHighCubeHit { get; set; }
        public int? AutonomousHighConeHit { get; set; }
        public int? AutonomousMidCubeHit { get; set; }
        public int? AutonomousMidConeHit { get; set; }
        public int? AutonomousLowCubeHit { get; set; }
        public int? AutonomousLowConeHit { get; set; }
        public int? AutonomousHighCubeMiss { get; set; }
        public int? AutonomousHighConeMiss { get; set; }
        public int? AutonomousMidCubeMiss { get; set; }
        public int? AutonomousMidConeMiss { get; set; }
        public int? AutonomousLowCubeMiss { get; set; }
        public int? AutonomousLowConeMiss { get; set; }
        public int? AutonomousHighCubeAccuracy { get; set; }
        public int? AutonomousHighConeAccuracy { get; set; }
        public int? AutonomousMidCubeAccuracy { get; set; }
        public int? AutonomousMidConeAccuracy { get; set; }
        public int? AutonomousLowCubeAccuracy { get; set; }
        public int? AutonomousLowConeAccuracy { get; set; }
        public bool? AutonDocking { get; set; }
        public bool? Engaged { get; set; }
        public bool? MobilityBonus { get; set; }
        public AutonWinner? AutonWinner { get; set; }
        public string? AutonNotes { get; set; }
        //DriverControl
        public int? DCControlPoints { get; set; }
        public int? DCHighCubeHit { get; set; }
        public int? DCHighConeHit { get; set; }
        public int? DCMidCubeHit { get; set; }
        public int? DCMidConeHit { get; set; }
        public int? DCLowCubeHit { get; set; }
        public int? DCLowConeHit { get; set; }
        public int? DCHighCubeMiss { get; set; }
        public int? DCHighConeMiss { get; set; }
        public int? DCMidCubeMiss { get; set; }
        public int? DCMidConeMiss { get; set; }
        public int? DCLowCubeMiss { get; set; }
        public int? DCLowConeMiss { get; set; }
        public int? DCHighCubeAccuracy { get; set; }
        public int? DCHighConeAccuracy { get; set; }
        public int? DCMidCubeAccuracy { get; set; }
        public int? DCMidConeAccuracy { get; set; }
        public int? DCLowCubeAccuracy { get; set; }
        public int? DCLowConeAccuracy { get; set; }
        public int? OPR { get; set; }
        public int? DPR { get; set; }
        public bool? DCDocking { get; set; }
        public bool? DCEngaged { get; set; }
        public bool? SustainabilityBonus { get; set; }
        public bool? ActivationBonus { get; set; }
        public bool? CoopertitionBonus { get; set; }
        public string? DCNotes { get; set; }
    }

    public enum AutonWinner
    {
        Unknown = 0,
        Blue = 1,
        Tie = 2,
        Red = 3,
    }
}
