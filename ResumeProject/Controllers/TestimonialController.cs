using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;
using ResumeProject.Entities;

namespace ResumeProject.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly ResumeContext _context;

        public TestimonialController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Testimonials.ToList();

            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateTestimonials(List<Testimonial> testimonials)
        {
            foreach (var item in testimonials)
            {
                var value = _context.Testimonials.Find(item.TestimonialId);
                value.Fullname = item.Fullname;
                value.Title = item.Title;
                value.Company = item.Company;
                value.CommentDetail = item.CommentDetail;
                value.ImageURL = item.ImageURL;
                value.IsConfirm = item.IsConfirm;
                _context.Testimonials.Update(value);
            }
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial testimonial)
        {
            _context.Testimonials.Add(testimonial);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _context.Testimonials.Find(id);
            _context.Testimonials.Remove(value);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
