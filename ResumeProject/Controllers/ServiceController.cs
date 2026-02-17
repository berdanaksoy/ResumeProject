using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;
using ResumeProject.Entities;

namespace ResumeProject.Controllers
{
    public class ServiceController : Controller
    {
        private readonly ResumeContext _context;

        public ServiceController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var value = _context.ServiceDescription.FirstOrDefault();

            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateDescription(ServiceDescription serviceDescription)
        {
            var value = _context.ServiceDescription.FirstOrDefault();
            value.Description = serviceDescription.Description;
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateServices(List<Service> services)
        {
            foreach (var item in services)
            {
                var value = _context.Services.Find(item.ServiceId);
                value.Title = item.Title;
                value.Description = item.Description;
                value.IconClass = item.IconClass;
            }
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateService(Service service)
        {
            _context.Services.Add(service);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteService(int id)
        {
            var value = _context.Services.Find(id);
            _context.Services.Remove(value);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
