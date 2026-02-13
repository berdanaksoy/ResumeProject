using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.AdminViewComponents.Dashboard
{
    public class AdminDashboardRecentMessagesViewComponent:ViewComponent
    {
        private readonly ResumeContext _context;

        public AdminDashboardRecentMessagesViewComponent(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values= _context.Messages.OrderByDescending(x=>x.SendDate).Take(3).ToList();

            return View(values);
        }
    }
}
