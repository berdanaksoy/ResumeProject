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

        [HttpGet]
        public IActionResult CreateMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateMessage(Message message)
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

        [HttpGet]
        public IActionResult MessageDetails()
        {
            return View();
        }

        public IActionResult DeleteMessage(int id)
        {
            var message = _context.Messages.Find(id);
            _context.Messages.Remove(message);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
