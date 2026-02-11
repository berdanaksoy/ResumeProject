using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultSkillComponentPartial:ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultSkillComponentPartial(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Skills
                     .OrderBy(x => x.SkillId)
                     .ToList();

            ViewBag.SkillDescription = _context.SkillDescription.Select(x=>x.Description).FirstOrDefault();

            return View(values);
        }
    }
}
