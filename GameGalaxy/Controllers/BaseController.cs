using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using GameGalaxy.Models;

namespace GameGalaxy.Controllers
{
    public class BaseController : Controller
    {
        protected GameContext context;

        public BaseController(GameContext ctx)
        {
            context = ctx;
        }

        public override void OnActionExecuting(ActionExecutingContext ctx)
        {
            var genres = context.Genres.ToList();
            ViewBag.Genres = genres;
            base.OnActionExecuting(ctx);
        }
    }
}
