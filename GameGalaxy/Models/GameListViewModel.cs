using System.Collections.Generic;
using GameGalaxy.Models.DomainModels;
using GameGalaxy.Models.ViewModel;

namespace GameGalaxy.Models
{
    public class GameListViewModel : GameViewModel
    {
        public List<Game> Games { get; set; }

        private List<Genre> genres;
        public List<Genre> Genres
        {
            get => genres;
            set
            {
                genres = new List<Genre>
                {
                    new Genre { GenreId = 100, Name = "All" }
                };
                genres.AddRange(value);
            }
        }
        private List<Platform> platforms;
        public List<Platform> Platforms
        {
            get => platforms;
            set
            {
                platforms = new List<Platform>
                {
                    new Platform{ PlatformId = 100, Name = "All" }
                };
                platforms.AddRange(value);
            }
        }
    }
}
