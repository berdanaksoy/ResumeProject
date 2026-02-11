using Microsoft.AspNetCore.Mvc;

namespace ResumeProject.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
