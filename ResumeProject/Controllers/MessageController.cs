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
        public IActionResult MessageDetails(int id)
        {
            var message = _context.Messages.Find(id);
            message.IsRead = true;
            _context.Messages.Update(message);
            _context.SaveChanges();

            return View(message);
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
