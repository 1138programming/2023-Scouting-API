using NuGet.Configuration;
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
        //Pit Details
        public int? NumBatteries { get; set; }
        public int? NumBatChargers { get; set; }
        //Bot and Gameplay Details
        public DriveTrainType driveTrainType { get; set; }

        public bool? Falcon { get; set; }
        public bool? Neo { get; set; }
        public bool? Cim { get; set; }
        public int? DrivetrainMotorNum { get; set; }
        public bool? NodeTypeHybridOrFloor { get; set; }
        public bool? NodeTypeMid { get; set; }
        public bool? NodeTypeHigh { get; set; }
        public bool? NodeTypeNone { get; set; }
        public GamePieces? DriverControlGamePiecesUsed { get; set; }
        public int? HowLongToPlaceTopNode { get; set; }
        public int? CycleTime { get; set; }
        //EndGame
        public ChargingStationActivation? EndGameDockingActivation { get; set; }
        //Auton
        public Mobility? MobilityPoints { get; set; }
        public bool? CoopNodeTypeHighCone { get; set; }
        public bool? CoopNodeTypeHighCube { get; set; }
        public bool? CoopNodeTypeMidCone { get; set; }
        public bool? CoopNodeTypeMidCube { get; set; }
        public bool? CoopNodeTypeHybridCone { get; set; }
        public bool? CoopNodeTypeHybridCube { get; set; }
        public bool? NodeTypeHighCone { get; set; }
        public bool? NodeTypeHighCube { get; set; }
        public bool? NodeTypeMidCone { get; set; }
        public bool? NodeTypeMidCube { get; set; }
        public bool? NodeTypeHybridCone { get; set; }
        public bool? NodeTypeHybridCube { get; set; }
        public ChargingStationActivation? ChargingStationActivation { get; set; }
        public ChargingStationPosition? ChargingStationPosition { get; set; }
        public GamePieces? GamePieceStartingPosFR { get; set; }
        public GamePieces? GamePieceStartingPosMR { get; set; }
        public GamePieces? GamePieceStartingPosML { get; set; }
        public GamePieces? GamePieceStartingPosFL { get; set; }
    }

    public enum ChargingStationActivation
    {
        Unknown = 0,
        Docked = 1,
        Engaged = 2,
        Unable = 3,
    }
    public enum ChargingStationPosition
    {
        Unknown = 0,
        Left = 1,
        Middle = 2,
        Right = 3,
    }
    public enum EndGameDock
    {
        Unknown = 0,
        Inside = 1,
        Outside = 2,
        Middle = 3,
        None = 4
    }
    public enum GamePieces
    {
        Unknown = 0,
        Cone = 1,
        Cube = 2,
        Both = 3,
        Undecided = 4,
    }
    public enum Mobility
    {
        Unknown = 0,
        Yes = 1,
        No = 2,
    }
    public enum MotorType
    {
        Unknown = 0,
        Faclon = 1,
        Neo = 2,
        Cim = 3,
        Other = 4
    }
    public enum DriveTrainType
    {
        Unknown = 0,
        Swerve = 1,
        WestCoast = 2,
        Tank = 3,
        Other = 4,
    }

}
