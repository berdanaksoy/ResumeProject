using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.Controllers
{
    public class AdminLayoutController : Controller
    {
        private readonly ResumeContext _context;

        public AdminLayoutController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
