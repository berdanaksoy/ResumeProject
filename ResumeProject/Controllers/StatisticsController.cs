using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly ResumeContext _context;

        public StatisticsController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.v1 = _context.Messages.Count();
            ViewBag.v2 = _context.Messages.Where(m => m.IsRead == false).Count();
            ViewBag.v3 = _context.Messages.Where(m => m.IsRead == true).Count();

            ViewBag.v4 = _context.Messages.Where(m=>m.MessageId==1).Select(m=>m.Fullname).FirstOrDefault();

            return View();
        }
    }
}
