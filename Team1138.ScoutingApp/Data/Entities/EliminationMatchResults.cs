using MessagePack;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;


namespace Team1138.ScoutingApp.Data.Entities
{
    public class EliminationMatchResults
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int TeamNumber { get; set; }

        [ForeignKey(nameof(TeamNumber))]
        public int TeamId { get; set; }

        [Required]
        public int ElimMatchNumber { get; set; }

        [ForeignKey(nameof(ElimMatchNumber))]
        public int ElimMatchId { get; set; }

        public string? Notes { get; set; }

    }
}
