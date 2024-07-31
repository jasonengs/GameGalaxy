using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GameGalaxy.Models;

namespace GameGalaxy.Controllers
{
    public class AdminController : Controller
    {
        private GameContext context { get; set; }

        public AdminController(GameContext ctx) 
        {
            context = ctx;
        }

        public IActionResult Dashboard(int page = 1)
        {
            //int pageSize = 10;
            //var totalGames = context.Games.Count();
            //var games = context.Games
            //    .Include(g => g.Genre)
            //    .Include(g => g.GamePlatforms)
            //        .ThenInclude(gp => gp.Platform)
            //    .OrderByDescending(g => g.GameId)
            //    .Skip((page - 1) * pageSize)
            //    .Take(pageSize)
            //    .ToList();

            //ViewBag.CurrentPage = page;
            //ViewBag.TotalPages = (int)Math.Ceiling((double)totalGames / pageSize);
            //return View(games);

            var games = context.Games
                .Include(g => g.Genre)
                .Include(g => g.GamePlatforms)
                    .ThenInclude(gp => gp.Platform)
                .OrderByDescending(g => g.GameId)
                .ToList();
            return View(games);
        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}
