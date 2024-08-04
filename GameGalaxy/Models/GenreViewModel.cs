namespace GameGalaxy.Models
{
    public class GenreViewModel
    {
        public string Genre { get; set; }
        public IEnumerable<Game> Games { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }

    }
}
