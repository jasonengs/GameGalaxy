using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GameGalaxy.Models;
using System.Linq;

namespace GameGalaxy.Controllers
{
    public class CategoryController : BaseController
    {
        private const int PageSize = 12; // Number of games per page

        public CategoryController(GameContext context) : base(context)
        {
        }
        public IActionResult Genre(int id, int page = 1)
        {
            var genre = context.Genres
                .Where(g => g.GenreId == id)
                .FirstOrDefault();

            if (genre == null)
            {
                return NotFound();
            }

            var totalGames = context.Games
                .Where(g => g.GenreId == id)
                .Count();

            var totalPages = (int)Math.Ceiling(totalGames / (double)PageSize);

            var games = context.Games
                .Include(g => g.GamePlatforms)
                .ThenInclude(gp => gp.Platform)
                .Where(g => g.GenreId == id)
                .OrderByDescending(g => g.ReleaseDate)
                .Skip((page - 1) * PageSize)
                .Take(PageSize)
                .ToList();

            var model = new GenreViewModel
            {
                Genre = genre.Name,
                Games = games,
                CurrentPage = page,
                TotalPages = totalPages
            };

            ViewBag.GenreId = id; // Pass genre ID to the view for pagination links

            return View("Genres", model);
        }



    }
}
