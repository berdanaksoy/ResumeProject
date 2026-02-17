using Microsoft.AspNetCore.Mvc;
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
            var values = _context.Portfolios.ToList();
            ViewBag.Categories = _context.Categories.ToList();

            return View(values);
        }

        public IActionResult CreatePortfolio()
        {
            var values = _context.Categories.ToList();

            return View(values);
        }

        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio p)
        {
            _context.Portfolios.Add(p);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdatePortfolios(List<Portfolio> portfolios)
        {
            foreach (var portfolio in portfolios)
            {
                var existingPortfolio = _context.Portfolios.Find(portfolio.PortfolioId);
                existingPortfolio.Title = portfolio.Title;
                existingPortfolio.CategoryId = portfolio.CategoryId;
                existingPortfolio.ImageURL = portfolio.ImageURL;
                existingPortfolio.IsActive = portfolio.IsActive;
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeletePortfolio(int id)
        {
            var portfolio = _context.Portfolios.Find(id);
            _context.Portfolios.Remove(portfolio);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}