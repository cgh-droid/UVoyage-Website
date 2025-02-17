using Microsoft.AspNetCore.Mvc;

namespace UVoyageWebsiteMVC.Controllers
{
    public class MoreController : Controller
    {
        public IActionResult ourStory()
        {
            return View();
        }
        public IActionResult ourTeams()
        {
            return View();
        }
        public IActionResult ourMembers()
        {
            return View();
        }
    }
}
