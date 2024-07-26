using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GameGalaxy.Models;
using System.Diagnostics;

namespace GameGalaxy.Controllers
{
    public class HomeController : Controller
    {
        private GameContext context;

        public HomeController(GameContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var upcomingGames = context.Games
                .Include(g => g.Genre)
                .Include(g => g.GamePlatforms)
                    .ThenInclude(gp => gp.Platform)
                .Where(g => g.ReleaseDate > DateTime.Now)
                .ToList();

            var mostPopularGames = context.Games
                .Include(g => g.Genre)
                .Include(g => g.GamePlatforms)
                    .ThenInclude(gp => gp.Platform)
                .Where(g => g.Rating > 95)
                .OrderByDescending(g => g.ReleaseDate)
                .ToList();

            var mostRecentReleasedGames = context.Games
                .Include(g => g.Genre)
                .Include(g => g.GamePlatforms)
                    .ThenInclude(gp => gp.Platform)
                .Where(g => g.ReleaseDate.Year == 2024 && g.ReleaseDate < DateTime.Now)
                .ToList();

            var model = new GameViewModel
            {
                UpcomingGames = upcomingGames,
                MostPopularGames = mostPopularGames,
                MostRecentReleasedGames = mostRecentReleasedGames
            };

            return View(model);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult GameDetails(string id)
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Wishlist()
        {
            return View();
        }
        public IActionResult Account()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
