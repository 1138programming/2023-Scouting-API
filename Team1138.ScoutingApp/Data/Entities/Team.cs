using System.ComponentModel.DataAnnotations;

namespace Team1138.ScoutingApp.Data.Entities
{
    public class Team
    {
        [Key]
        public int TeamNumber { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Location { get; set; }
    }
}
