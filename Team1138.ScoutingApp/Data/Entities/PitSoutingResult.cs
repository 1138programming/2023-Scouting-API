using System.ComponentModel.DataAnnotations.Schema;

namespace Team1138.ScoutingApp.Data.Entities
{
    public class PitSoutingResult
    {
        public int Id { get; set; }

        public int CompetitionId { get; set; }

        [ForeignKey(nameof(CompetitionId))]
        public Competition Competition { get; set; }

        public int TeamNumber { get; set; }

        [ForeignKey(nameof(TeamNumber))]
        public Team Team { get; set; }

        public EndGameDock EndGameDock { get; set; }

        public string Notes { get; set; }

        public int NumBatteries { get; set; }

        public int NumBatChargers { get; set; }

        public int DrivetrainMotorNum { get; set; }

        public bool NodeTypeHigh { get; set; }

        public bool NodeTypeMid { get; set; }

        public bool NodeTypeHybridOrFloor { get; set; }

        public bool CoopNodeTypeHigh { get; set; }

        public bool CoopNodeTypeMid { get; set; }

        public bool CoopNodeTypeHybridOrFloor { get; set; }

        public bool CantScoreNode { get; set; }

        public GamePieceStartingPos GamePieceStartingPosFR { get; set; }

        public GamePieceStartingPos GamePieceStartingPosMR { get; set; }

        public GamePieceStartingPos GamePieceStartingPosML { get; set; }

        public GamePieceStartingPos GamePieceStartingPosFL { get; set; }
        
        public bool CanDockOnChargingStation { get; set; }

        public bool CanEngageOnChargingStation { get; set; }
    }

    public enum ChargingStationActivation
    {
        Left = 0,
        Middle = 1,
        Right = 2,
        Undecided = 3,
        Cannot = 4,
    }
    public enum GamePieceStartingPos
    {
        Cone = 0,
        Cube = 1,
        Undecided = 2,
    }
    public enum MotorType
    {
        Faclon = 0,
        Neo = 1,
        Cim = 2,
        Other = 3, 
    }
    public enum Drivetrain
    {
        
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
