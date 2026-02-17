using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;
using ResumeProject.Entities;

namespace ResumeProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly ResumeContext _context;

        public ContactController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Contacts.FirstOrDefault();

            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {
            var value = _context.Contacts.Find(contact.ContactId);
            value.Description = contact.Description;
            value.PhoneNumber = contact.PhoneNumber;
            value.PhoneNumber2 = contact.PhoneNumber2;
            value.Address = contact.Address;
            value.Email = contact.Email;
            value.Email2 = contact.Email2;
            _context.Update(value);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
