using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultServiceComponentPartial : ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultServiceComponentPartial(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Services.ToList();

            ViewBag.ServiceDescription = _context.ServiceDescription.Select(x=>x.Description).FirstOrDefault();

            return View(values);
        }
    }
}
