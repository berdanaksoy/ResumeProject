using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;
using ResumeProject.Entities;

namespace ResumeProject.ViewComponents.AdminViewComponents.About
{
    public class AdminAboutEducationViewComponent : ViewComponent
    {
        private readonly ResumeContext _context;

        public AdminAboutEducationViewComponent(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Educations.ToList();

            return View(values);
        }
    }
}
