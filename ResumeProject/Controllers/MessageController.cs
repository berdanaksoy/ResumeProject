using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;
using ResumeProject.Entities;

namespace ResumeProject.Controllers
{
    public class MessageController : Controller
    {
        private readonly ResumeContext _context;

        public MessageController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values=_context.Messages.ToList();

            return View(values);
        }

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            try
            {
                message.SendDate = DateTime.Now;
                message.IsRead = false;
                _context.Messages.Add(message);
                _context.SaveChanges();

                if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                {
                    return Json(new { success = true, message = "Mesajınız başarıyla gönderildi!" });
                }

                return RedirectToAction("Index", "Default");
            }
            catch (Exception ex)
            {
                if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                {
                    return Json(new { success = false, message = "Mesaj gönderilirken bir hata oluştu." });
                }

                return RedirectToAction("Index", "Default");
            }
        }
    }
}
