using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.AdminViewComponents.Skill
{
    public class AdminSkillListViewComponent : ViewComponent
    {
        private readonly ResumeContext _context;
        public AdminSkillListViewComponent(ResumeContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Skills.ToList();

            return View(values);
        }
    }
}
