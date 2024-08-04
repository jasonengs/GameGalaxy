using GameGalaxy.Models.DomainModels;

namespace GameGalaxy.Models.ViewModel
{
    public class PlatformViewModel
    {
        public string Platform { get; set; }
        public List<Game> Games { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }

}
