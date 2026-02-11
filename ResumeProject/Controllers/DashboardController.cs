using Microsoft.AspNetCore.Mvc;

namespace ResumeProject.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
