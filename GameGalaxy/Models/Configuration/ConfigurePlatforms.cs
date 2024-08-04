using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GameGalaxy.Models.DomainModels;

namespace GameGalaxy.Models
{
    internal class ConfigurePlatforms : IEntityTypeConfiguration<Platform>
    {
        public void Configure(EntityTypeBuilder<Platform> entity)
        {
            // Configure the Primary key for the Platform entity
            entity.HasKey(p => p.PlatformId);
            entity.HasData(
                new Platform { PlatformId = 1, Name = "Microsoft Windows" },
                new Platform { PlatformId = 2, Name = "Playstation 5" },
                new Platform { PlatformId = 3, Name = "Xbox Series X|S" },
                new Platform { PlatformId = 4, Name = "Nintendo Switch" }
            );
        }
    }
}
