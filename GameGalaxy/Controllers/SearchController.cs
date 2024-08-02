using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using GameGalaxy.Models;
using System.Collections.Generic;

namespace GameGalaxy.Controllers
{
    public class SearchController : Controller
    {
        private GameContext context;
        public SearchController(GameContext ctx)
        {
            context = ctx;
        }
        public async Task<IActionResult> Search(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                return View("Results", new List<Game>());
            }

            // Retrieve data from the database
            var games = await context.Games
                .Include(g => g.Genre)
                .Include(g => g.GamePlatforms)
                .ThenInclude(gp => gp.Platform)
                .ToListAsync();

            // Perform normalization and filtering in memory
            query = query.NormalizeString().ToLower();
            var filteredGames = games.Where(g => g.Title.NormalizeString().ToLower().Contains(query)).ToList();

            return View("Results", filteredGames);
        }
    }
}
