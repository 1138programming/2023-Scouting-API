using System.ComponentModel.DataAnnotations;

namespace Team1138.ScoutingApp.Data.Entities
{
    public class Competition
    {
        [Key]
        public int CompetitionID { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public DateTime StartDateTime { get; set; }
    }
}
