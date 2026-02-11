using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.AdminViewComponents.Dashboard
{
    public class AdminDashboardSkillsViewComponent:Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private readonly ResumeContext _context;

        public AdminDashboardSkillsViewComponent(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
