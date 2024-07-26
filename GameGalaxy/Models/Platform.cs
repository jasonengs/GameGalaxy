namespace GameGalaxy.Models
{
    public class Platform
    {
        public int PlatformId { get; set; }
        public string Name { get; set; }
        public IList<GamePlatform> GamePlatforms { get; } = new List<GamePlatform>(); 
    }
}
