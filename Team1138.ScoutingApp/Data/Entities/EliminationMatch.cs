using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace Team1138.ScoutingApp.Data.Entities
{
    public class EliminationMatch
    {
        [Key]
        public int ElimMatchID { get; set; }
        [Required]
        public int CompetitionID { get; set; }

        [ForeignKey(nameof(CompetitionID))]
        public int Competition { get; set; }

        [Required]
        public int ElimMatchNumber { get; set; }
    }
}
