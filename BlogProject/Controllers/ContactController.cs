using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact cls_contact)
        {
            cls_contact.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            cls_contact.ContactStatus = true;
            cm.ContactAddBL(cls_contact);
            return RedirectToAction("Index","Blog");
        }
    }
}
