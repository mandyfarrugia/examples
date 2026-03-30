using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using XboxGames.Models;

namespace XboxGames.Data.Context
{
    public class XboxGamesDbContext : DbContext
    {
        public XboxGamesDbContext(DbContextOptions<XboxGamesDbContext> options) : base(options) {}

        public DbSet<Game> Games { get; set; }
        public DbSet<XboxGame> XboxGames { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<Game>()
                .Property(game => game.ReleaseDate)
                .HasConversion<DateOnlyConverter>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}