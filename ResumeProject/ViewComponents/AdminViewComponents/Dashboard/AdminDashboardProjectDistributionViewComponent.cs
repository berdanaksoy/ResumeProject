using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.AdminViewComponents.Dashboard
{
    public class AdminDashboardProjectDistributionViewComponent:ViewComponent
    {
        private readonly ResumeContext _context;

        public AdminDashboardProjectDistributionViewComponent(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Portfolios
                .Where(p => p.IsActive)
                .GroupBy(p => p.Category.CategoryName)
                .Select(g => new
                {
                    Category = g.Key,
                    Count = g.Count()
                })
                .ToList();

            return View(values);
        }

    }
}
