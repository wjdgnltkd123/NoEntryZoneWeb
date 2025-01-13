using Microsoft.AspNetCore.Mvc;

namespace NoEntryZoneWeb.Controllers
{
    public class SupportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
