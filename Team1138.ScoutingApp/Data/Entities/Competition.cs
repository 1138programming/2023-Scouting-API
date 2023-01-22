using System;
using System.ComponentModel.DataAnnotations;

namespace Team1138.ScoutingApp.Data.Entities
{
    public class Competition
    {
        [Key]
        public int CompetitionID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public DateTime StartDateTime { get; set; }
    }
}
