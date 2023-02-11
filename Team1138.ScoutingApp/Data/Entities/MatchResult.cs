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
        public int? AutonomousHighCube { get; set; }
        public int? AutonomousHighCone { get; set; }
        public int? AutonomousMidCube { get; set; }
        public int? AutonomousMidCone { get; set; }
        public int? AutonomousLowCube { get; set; }
        public int? AutonomousLowCone { get; set; }
        public bool? AutonDocking { get; set; }
        public AutonWinner? AutonWinner { get; set; }
        public bool? Engaged { get; set; }
        public bool? MobilityBonus { get; set; }
        public string? AutonNotes { get; set; }
        //DriverControl
        public int? DCControlPoints { get; set; }
        public int? DCHighCube { get; set; }
        public int? DCHighCone { get; set; }
        public int? DCMidCube { get; set; }
        public int? DCMidCone { get; set; }
        public int? DCLowCube { get; set; }
        public int? DCLowCone { get; set; }
        public int? OPR { get; set; }
        public int? DPR { get; set; }
        public bool? DCDocking { get; set; }
        public bool? DCEngaged { get; set; }
        public bool? SustainabilityBonus { get; set; }
        public bool? ActivationBonus { get; set; }
        public bool? CoopertitionBonus { get; set; }
    }

    public enum AutonWinner
    {
        Unknown = 0,
        Blue = 1,
        Tie = 2,
        Red = 3,
    }
}
