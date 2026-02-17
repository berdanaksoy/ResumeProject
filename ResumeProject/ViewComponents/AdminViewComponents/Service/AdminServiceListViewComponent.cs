using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.AdminViewComponents.Service
{
    public class AdminServiceListViewComponent : ViewComponent
    {
        private readonly ResumeContext _context;
        public AdminServiceListViewComponent(ResumeContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Services.ToList();

            return View(values);
        }
    }
}
