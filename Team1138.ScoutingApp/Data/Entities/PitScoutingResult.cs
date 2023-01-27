using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team1138.ScoutingApp.Data.Entities
{
    public class PitScoutingResult
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CompetitionId { get; set; }

        [ForeignKey(nameof(CompetitionId))]
        public virtual Competition Competition { get; set; }

        [Required]
        public int TeamNumber { get; set; }

        [ForeignKey(nameof(TeamNumber))]
        public virtual Team Team { get; set; }

        public EndGameDock? EndGameDock { get; set; }

        public string? Notes { get; set; }

        public int? NumBatteries { get; set; }

        public int? NumBatChargers { get; set; }

        public int? DrivetrainMotorNum { get; set; }

        public MotorType? MotorType { get; set; }

        public bool? NodeTypeHigh { get; set; }

        public bool? NodeTypeMid { get; set; }

        public bool? NodeTypeHybridOrFloor { get; set; }

        public bool? CoopNodeTypeHigh { get; set; }

        public bool? CoopNodeTypeMid { get; set; }

        public bool? CoopNodeTypeHybridOrFloor { get; set; }

        public bool? CantScoreNode { get; set; }

        public GamePieceStartingPos? GamePieceStartingPosFR { get; set; }

        public GamePieceStartingPos? GamePieceStartingPosMR { get; set; }

        public GamePieceStartingPos? GamePieceStartingPosML { get; set; }

        public GamePieceStartingPos? GamePieceStartingPosFL { get; set; }

        public bool? CanDockOnChargingStation { get; set; }

        public bool? CanEngageOnChargingStation { get; set; }
    }

    public enum ChargingStationActivation
    {
        Unknown = 0,
        Left = 1,
        Middle = 2,
        Right = 3,
        Undecided = 4,
        Cannot = 5,
    }
    public enum GamePieceStartingPos
    {
        Unknown = 0,
        Cone = 1,
        Cube = 2,
        Undecided = 3,
    }
    public enum MotorType
    {
        Unknown = 0,
        Faclon = 1,
        Neo = 2,
        Cim = 3,
        Other = 4
    }
    public enum EndGameDock
    {
        Unknown = 0,
        Inside = 1,
        Outside = 2,
        Middle = 3,
        None = 4
    }
}
