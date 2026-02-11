using Microsoft.AspNetCore.Mvc;

namespace ResumeProject.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
