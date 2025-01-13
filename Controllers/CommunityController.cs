using Microsoft.AspNetCore.Mvc;

namespace NoEntryZoneWeb.Controllers
{
    public class CommunityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
