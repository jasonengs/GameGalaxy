using System.ComponentModel.DataAnnotations;

namespace GameGalaxy.Models
{
    public class Game
    {
        public int GameId { get; set; } // Primary Key

        [Required(ErrorMessage = "Please Enter a Name")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please Enter a Game Description")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Enter a Developer Name")]
        public string Developer { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please Enter a Publisher Name")]
        public string Publisher { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please Enter a Game Genre")]

        // Foreign Key
        public int GenreId { get; set; }

        // Navigation Property
        public Genre Genre { get; set; }
        [Required(ErrorMessage = "Please Enter a Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "Please Enter a Game Rating")]
        [Range(0, 100, ErrorMessage = "Rating must be between 0 and 100")]
        public int Rating { get; set; }
        public string Image{ get; set; }
        public IList<GamePlatform> GamePlatforms { get; } = new List<GamePlatform>();
    }
}
