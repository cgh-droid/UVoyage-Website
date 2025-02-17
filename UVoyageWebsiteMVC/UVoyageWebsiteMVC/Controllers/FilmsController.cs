using Microsoft.AspNetCore.Mvc;

namespace UVoyageWebsiteMVC.Controllers
{
    public class FilmsController : Controller
    {
        public IActionResult filmsMain() { return View(); }
        public IActionResult buildYourCharacter()
        {
            return View();
        }
        public IActionResult contributeToSociety()
        {
            return View();
        }
        public IActionResult inspiredToLearn()
        {
            return View();
        }
        public IActionResult succeedInLife()
        {
            return View();
        }
        public IActionResult takeCareOfYourself()
        {
            return View();
        }
    }
}
