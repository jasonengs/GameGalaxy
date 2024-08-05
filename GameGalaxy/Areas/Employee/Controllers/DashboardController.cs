using GameGalaxy.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameGalaxy.Areas.Employee.Controllers
{
    [Area("Employee")]
    [Authorize(Roles = "Employee")]
    public class DashboardController : Controller
    {
        private GameContext context { get; set; }
        public DashboardController(GameContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index(int page = 1)
        {
            var games = context.Games
                .Include(g => g.Genre)
                .Include(g => g.GamePlatforms)
                .ThenInclude(gp => gp.Platform)
                .OrderByDescending(g => g.GameId)
                .ToList();
            return View(games);
        }
    }
}
