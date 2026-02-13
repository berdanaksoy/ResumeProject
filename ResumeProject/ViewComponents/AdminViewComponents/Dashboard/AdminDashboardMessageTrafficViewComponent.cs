using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;
using System.Globalization;

namespace ResumeProject.ViewComponents.AdminViewComponents.Dashboard
{
    public class AdminDashboardMessageTrafficViewComponent : ViewComponent
    {
        private readonly ResumeContext _context;

        public AdminDashboardMessageTrafficViewComponent(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var sixMonthsAgo = DateTime.Now.AddMonths(-6);

            var monthlyData = _context.Messages
                .Where(m => m.SendDate >= sixMonthsAgo)
                .GroupBy(m => new
                {
                    Year = m.SendDate.Year,
                    Month = m.SendDate.Month
                })
                .Select(g => new
                {
                    g.Key.Year,
                    g.Key.Month,
                    Count = g.Count()
                })
                .ToList();

            string[] turkishMonths = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran",
                                       "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };

            var monthsList = new List<object>();

            for (int i = 5; i >= 0; i--)
            {
                var date = DateTime.Now.AddMonths(-i);
                var count = monthlyData
                    .FirstOrDefault(m => m.Year == date.Year && m.Month == date.Month)?.Count ?? 0;

                monthsList.Add(new
                {
                    MonthName = turkishMonths[date.Month - 1],
                    Count = count
                });
            }

            var maxCount = monthsList.Max(m => ((dynamic)m).Count);
            if (maxCount == 0) maxCount = 1;

            ViewBag.MonthsData = monthsList;
            ViewBag.MaxCount = maxCount;

            return View();
        }
    }
}