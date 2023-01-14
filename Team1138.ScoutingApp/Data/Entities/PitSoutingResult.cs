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
