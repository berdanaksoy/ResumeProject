using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultPortfolioComponentPartial:ViewComponent
    {
        private readonly ResumeContext _context;
        public _DefaultPortfolioComponentPartial(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Portfolios.ToList();

            return View(values);
        }
    }
}
