using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeProject.Context;
using ResumeProject.Entities;

namespace ResumeProject.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ResumeContext _context;

        public DefaultController(IWebHostEnvironment webHostEnvironment, ResumeContext context)
        {
            _webHostEnvironment = webHostEnvironment;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Download_CV()
        {
            var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Example_CV.pdf");

            return PhysicalFile(filePath, "application/pdf", "Example_CV.pdf");
        }

        
    }
}
