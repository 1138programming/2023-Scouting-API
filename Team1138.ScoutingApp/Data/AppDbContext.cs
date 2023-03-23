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

        public DbSet<PitScoutingResult> PitSoutingResults { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Team1138.ScoutingApp.Data.Entities.MatchResult> MatchResult { get; set; }

        public DbSet<Team1138.ScoutingApp.Data.Entities.EliminationMatch> EliminationMatch { get; set; }

        public DbSet<Team1138.ScoutingApp.Data.Entities.EliminationMatchResults> EliminationMatchResults { get; set; }

    }
}
