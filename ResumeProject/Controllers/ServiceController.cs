using Microsoft.AspNetCore.Mvc;

namespace ResumeProject.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
