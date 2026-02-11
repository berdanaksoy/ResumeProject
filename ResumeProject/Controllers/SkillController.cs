using Microsoft.AspNetCore.Mvc;

namespace ResumeProject.Controllers
{
    public class SkillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
