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
        public double? AutonomousHighCubeAccuracy { get; set; }
        public double? AutonomousHighConeAccuracy { get; set; }
        public double? AutonomousMidCubeAccuracy { get; set; }
        public double? AutonomousMidConeAccuracy { get; set; }
        public double? AutonomousLowCubeAccuracy { get; set; }
        public double? AutonomousLowConeAccuracy { get; set; }
        public double? AutonomousAccuracy { get; set; }
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
        public double? DCHighCubeAccuracy { get; set; }
        public double? DCHighConeAccuracy { get; set; }
        public double? DCMidCubeAccuracy { get; set; }
        public double? DCMidConeAccuracy { get; set; }
        public double? DCLowCubeAccuracy { get; set; }
        public double? DCLowConeAccuracy { get; set; }
        public double? DCAccuracy { get; set; }
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
        Win = 1,
        Tie = 2,
        Loss = 3,
    }
}
