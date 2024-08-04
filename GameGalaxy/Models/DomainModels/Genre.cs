namespace GameGalaxy.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public ICollection<Game> Games { get; } = new List<Game>(); // Navigation Property

    }
}
