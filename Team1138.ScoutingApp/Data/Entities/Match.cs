using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace Team1138.ScoutingApp.Data.Entities
{
   // [PrimaryKey(nameof(CompetitionId), nameof(MatchNumber))]
    public class Match
    {
        [Key]
        public int MatchID { get; set; }
       
        [Required]
        public int CompetitionID { get; set; }

        [ForeignKey(nameof(CompetitionID))]
        public int Competition { get; set; }

        [Required]
        public int MatchNumber { get; set; }
    }
}
