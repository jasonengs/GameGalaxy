using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GameGalaxy.Models;
using GameGalaxy.Models.ViewModel;
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
                .Take(4)
                .ToList();

            var mostPopularGames = context.Games
                .Include(g => g.Genre)
                .Include(g => g.GamePlatforms)
                    .ThenInclude(gp => gp.Platform)
                .Where(g => g.Rating > 95)
                .OrderByDescending(g => g.ReleaseDate)
                .Take(4)
                .ToList();

            var mostRecentReleasedGames = context.Games
                .Include(g => g.Genre)
                .Include(g => g.GamePlatforms)
                    .ThenInclude(gp => gp.Platform)
                .Where(g => g.ReleaseDate.Year == 2024 && g.ReleaseDate < DateTime.Now)
                .Take(4)
                .ToList();

            var model = new GameViewModel
            {
                UpcomingGames = upcomingGames,
                MostPopularGames = mostPopularGames,
                MostRecentReleasedGames = mostRecentReleasedGames
            };

            //ViewBag.Category = context.Genres.ToList();

            return View(model);
        }

        public IActionResult GameDetails(int id)
        {
            var game = context.Games
                .Include(g => g.Genre)
                .Include(g => g.GamePlatforms)
                    .ThenInclude(gp => gp.Platform)
                .FirstOrDefault(g => g.GameId == id);

            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }



        //public IActionResult Privacy()
        //{
        //    return View();
        //}
        public IActionResult Login()
        {
            return View("Login");
        }
        public IActionResult Cart()
        {
            return View("Cart");
        }
        public IActionResult Wishlist()
        {
            return View("Wishlist");
        }
        public IActionResult Account()
        {
            return View("Account");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
