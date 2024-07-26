using System.ComponentModel.DataAnnotations;

namespace GameGalaxy.Models
{
    public class GamePlatform
    {
        public int GameId { get; set; }
        public int PlatformId { get; set; }
        public Game Game { get; set; }
        [Required(ErrorMessage = "Please Enter a Price")]
        public double Price { get; set; }
        public Platform Platform { get; set; }
    }
}
