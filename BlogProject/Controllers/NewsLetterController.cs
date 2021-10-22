using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Controllers
{
    public class NewsLetterController : Controller
    {
        NewLetterManager nm = new NewLetterManager(new EfNewsLetterRepository());

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter cls_newsLetter)
        {
            cls_newsLetter.MailStatus = true;
            nm.AddNewsLetter(cls_newsLetter);
            return PartialView();
        }
    }
}
