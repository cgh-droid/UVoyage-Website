using Microsoft.AspNetCore.Mvc;

namespace UVoyageWebsiteMVC.Controllers
{
    public class IndexRedirectsController : Controller
    {
        public IActionResult newestAdditions()
        {
            return View();
        }
        public IActionResult whoWeAre()
        {
            return View();
        }
        public IActionResult whyJoinUs()
        {
            return View();
        }
    }
}
