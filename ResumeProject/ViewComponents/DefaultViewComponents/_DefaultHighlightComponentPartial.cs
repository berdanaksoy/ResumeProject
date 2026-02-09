using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultHighlightComponentPartial : ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultHighlightComponentPartial(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var highlights = _context.Highlights.ToList();

            return View(highlights);
        }
    }
}
