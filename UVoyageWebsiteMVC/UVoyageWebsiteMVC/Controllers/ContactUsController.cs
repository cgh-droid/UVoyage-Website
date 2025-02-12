using Microsoft.AspNetCore.Mvc;

namespace UVoyageWebsiteMVC.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult contactUs()
        {
            return View();
        }
    }
}
