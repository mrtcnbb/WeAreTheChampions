using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    public class WeAreTheChampionsDbContext : DbContext
    {

        public WeAreTheChampionsDbContext() : base("name=WeAreTheChampionsConntection")
        {

        }

        public DbSet<Match> Matches { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Color> Colors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>().HasRequired(a => a.HomeTeam).WithMany(b => b.HomeMatches).HasForeignKey(c => c.HomeTeamId).WillCascadeOnDelete(false);
            modelBuilder.Entity<Match>().HasRequired(a => a.AwayTeam).WithMany(b => b.AwayMatches).HasForeignKey(c => c.AwayTeamId).WillCascadeOnDelete(false);
        }
    }


}
