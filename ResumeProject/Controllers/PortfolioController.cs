using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using ResumeProject.Context;
using ResumeProject.Entities;

namespace ResumeProject.Controllers
{
    public class PortfolioController : Controller
    {
        public readonly ResumeContext _context;

        public PortfolioController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values=_context.Portfolios.ToList();

            return View(values);
        }

        public IActionResult CreatePortfolio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio p)
        {
            p.ImageURL = "test";
            _context.Portfolios.Add(p);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
