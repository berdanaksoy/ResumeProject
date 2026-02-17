using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.AdminViewComponents.Dashboard
{
    public class AdminDashboardTimelineViewComponent:ViewComponent
    {
        private readonly ResumeContext _context;

        public AdminDashboardTimelineViewComponent(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Experiences.ToList();

            return View(values); 
        }
    }
}
