using Microsoft.AspNetCore.Mvc;

namespace UVoyageWebsiteMVC.Controllers
{
    public class TechnologyController : Controller
    {
        public IActionResult technologyMain() {  
            return View(); 
        }
        public IActionResult Blender3D()
        {
            return View();
        }
        public IActionResult Procreate()
        {
            return View();
        }
        public IActionResult visualStudio()
        {
            return View();
        }
        public IActionResult fl()
        {
            return View();
        }
    }
}
