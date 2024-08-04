using Microsoft.EntityFrameworkCore;
using GameGalaxy.Models.DomainModels;

namespace GameGalaxy.Models
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options)
        {
        }
        public DbSet<Game> Games { get; set; } = null!; 
        public DbSet<Genre> Genres { get; set; } = null!;
        public DbSet<Platform> Platforms { get; set; } = null!;
        public DbSet<GamePlatform> GamePlatforms { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure entities
            modelBuilder.ApplyConfiguration(new ConfigureGenres());
            modelBuilder.ApplyConfiguration(new ConfigureGames());
            modelBuilder.ApplyConfiguration(new ConfigurePlatforms());
            modelBuilder.ApplyConfiguration(new ConfigureGamePlatforms());
        }

    }
}
