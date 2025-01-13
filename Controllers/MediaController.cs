using Microsoft.AspNetCore.Mvc;

namespace NoEntryZoneWeb.Controllers
{
    public class MediaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
