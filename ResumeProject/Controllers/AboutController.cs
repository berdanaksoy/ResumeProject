using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;
using ResumeProject.Entities;

namespace ResumeProject.Controllers
{
    public class AboutController : Controller
    {
        private readonly ResumeContext _context;

        public AboutController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Abouts.ToList();

            return View(values);
        }

        public IActionResult SaveAbout(About about)
        {
            var value = _context.Abouts.Find(about.AboutId);
            value.Fullname = about.Fullname;
            value.Title = about.Title;
            value.Description = about.Description;
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult SaveEducation(List<Education> educations)
        {
            foreach (var item in educations)
            {
                var value = _context.Educations.Where(x => x.EducationId == item.EducationId).FirstOrDefault();
                value.EducationTitle = item.EducationTitle;
                value.EducationProvider = item.EducationProvider;
                value.EducationStartDate = item.EducationStartDate;
                value.EducationEndDate = item.EducationEndDate;
                _context.Educations.Update(value);
            }
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteEducation(int id)
        {
            var value = _context.Educations.Find(id);
            _context.Educations.Remove(value);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateEducation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEducation(Education education)
        {
            _context.Educations.Add(education);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult SaveHighlight(List<Highlight> highlights)
        {
            foreach (var item in highlights)
            {
                var value = _context.Highlights.Where(x => x.HighlightId == item.HighlightId).FirstOrDefault();
                value.HighlightTitle = item.HighlightTitle;
                value.HighlightDescription = item.HighlightDescription;
                _context.Highlights.Update(value);
            }
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteHighlight(int id)
        {
            var value = _context.Highlights.Find(id);
            _context.Highlights.Remove(value);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateHighlight()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateHighlight(Highlight highlight)
        {
            _context.Highlights.Add(highlight);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}