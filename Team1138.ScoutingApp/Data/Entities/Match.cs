using Microsoft.EntityFrameworkCore;

namespace Team1138.ScoutingApp.Data.Entities
{
    [PrimaryKey(nameof(CompetitionId), nameof(MatchNumber))]
    public class Match
    {
        public int CompetitionId { get; set; }

        public Competition Competition { get; set; }

        public int MatchNumber { get; set; }
    }
}
