using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameGalaxy.Models
{
    internal class ConfigureGenres : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> entity)
        {
            // Configure the Primary key for the Genre entity
            entity.HasKey(g => g.GenreId);

            // Configure the relationship between the Games and Genre entities
            entity.HasMany(g => g.Games).WithOne(g => g.Genre).HasForeignKey(g => g.GenreId);
            
            entity.HasData(
                new Genre { GenreId = 1, Name = "Role-Playing (RPG)" },
                new Genre { GenreId = 2, Name = "Adventure" },
                new Genre { GenreId = 3, Name = "Shooter" },
                new Genre { GenreId = 4, Name = "Sport" },
                new Genre { GenreId = 5, Name = "Racing" },
                new Genre { GenreId = 6, Name = "Simulator" },
                new Genre { GenreId = 7, Name = "Fighting" },
                new Genre { GenreId = 8, Name = "Indie" },
                new Genre { GenreId = 9, Name = "Puzzle" }
            );
        }
    }
}
