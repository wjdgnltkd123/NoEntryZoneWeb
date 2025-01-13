using Microsoft.AspNetCore.Mvc;

namespace NoEntryZoneWeb.Controllers
{
    public class NoticeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
