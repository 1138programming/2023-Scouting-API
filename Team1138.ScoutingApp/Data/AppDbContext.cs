using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using Team1138.ScoutingApp.Data.Entities;

namespace Team1138.ScoutingApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Competition> Competitions { get; set; }

        public DbSet<Match> Matches { get; set; }

        public DbSet<PitSoutingResult> PitSoutingResults { get; set; }

        public DbSet<Team> Teams { get; set; }

    }
}
