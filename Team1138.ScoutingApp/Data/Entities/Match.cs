using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team1138.ScoutingApp.Data.Entities
{
    [PrimaryKey(nameof(CompetitionId), nameof(MatchNumber))]
    public class Match
    {
        [Required]
        [ForeignKey(nameof(Competition))]
        public int CompetitionId { get; set; }
        
        public virtual Competition Competition { get; set; }

        [Required]
        public int MatchNumber { get; set; }
    }
}
