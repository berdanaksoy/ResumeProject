using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.AdminViewComponents.Dashboard
{
    public class AdminDashboardCardsViewComponent:ViewComponent
    {
        private readonly ResumeContext _context;

        public AdminDashboardCardsViewComponent(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var totalMessages = _context.Messages.Count();
            var totalUnreadMessages = _context.Messages.Count(m => m.IsRead==false);
            var totalSkills = _context.Skills.Count();
            var totalProjects = _context.Portfolios.Count();
            var totalExperiences = _context.Experiences.Count();

            return View(new
            {
                TotalMessages=totalMessages,
                TotalUnreadMessages=totalUnreadMessages,
                TotalSkills=totalSkills,
                TotalProjects=totalProjects,
                TotalExperiences=totalExperiences
            });
        }
    }
}
