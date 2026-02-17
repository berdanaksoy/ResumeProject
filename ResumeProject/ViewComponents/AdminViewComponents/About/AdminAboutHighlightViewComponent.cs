using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.AdminViewComponents.About
{
    public class AdminAboutHighlightViewComponent : ViewComponent
    {
        private readonly ResumeContext _context;
        public AdminAboutHighlightViewComponent(ResumeContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Highlights.ToList();

            return View(values);
        }
    }
}
