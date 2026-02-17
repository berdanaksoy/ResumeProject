using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;
using ResumeProject.Entities;

namespace ResumeProject.Controllers
{
    public class SkillController : Controller
    {
        private readonly ResumeContext _context;

        public SkillController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Skills.ToList();
            ViewBag.SkillDescription = _context.SkillDescription.FirstOrDefault();

            return View(values);
        }

        public IActionResult SaveDescription(SkillDescription skillDescription)
        {
            var value = _context.SkillDescription.Find(skillDescription.SkillDescriptionId);
            value.Description = skillDescription.Description;
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult SaveSkillList(List<Skill> skills)
        {
            foreach (var item in skills)
            {
                var value = _context.Skills.Find(item.SkillId);
                value.SkillName = item.SkillName;
                value.SkillLevel = item.SkillLevel;
                _context.Skills.Update(value);
            }
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            var value = _context.Skills.Find(id);
            _context.Skills.Remove(value);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            _context.Skills.Add(skill);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
