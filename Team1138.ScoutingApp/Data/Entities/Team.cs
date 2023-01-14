using System.ComponentModel.DataAnnotations;

namespace Team1138.ScoutingApp.Data.Entities
{
    public class Team
    {
        [Key]
        public int TeamNumber { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }
    }
}
