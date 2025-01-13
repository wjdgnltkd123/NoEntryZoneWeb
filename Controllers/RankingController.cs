using Microsoft.AspNetCore.Mvc;

namespace NoEntryZoneWeb.Controllers
{
    public class RankingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
