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
            var highestSkill = _context.Skills.OrderByDescending(s => s.SkillLevel).FirstOrDefault();
            var lowestSkill = _context.Skills.OrderBy(s => s.SkillLevel).FirstOrDefault();

            return View(new
            {
                HighestSkill=highestSkill,
                LowestSkill=lowestSkill
            });
        }
    }
}
