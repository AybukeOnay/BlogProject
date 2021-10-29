using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlogProject.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Writer cls_writer)
        {
            Context c = new Context();
            var dataValue = c.Writers.FirstOrDefault(x => x.WriterMail == cls_writer.WriterMail && x.WriterPassword == cls_writer.WriterPassword);
            if (dataValue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, cls_writer.WriterMail)
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Writer");
            }
            else
            {
                return View();
            }

            //        Context c = new Context();
            //        var dataValue = c.Writers.FirstOrDefault(x => x.WriterMail == cls_writer.WriterMail && x.WriterPassword == cls_writer.WriterPassword);
            //            if (dataValue != null)
            //            {
            //                HttpContext.Session.SetString("username", cls_writer.WriterMail);
            //                return RedirectToAction("Index", "Writer");
            //    }
            //            else
            //            {
            //                return View();
            //}

        }
    }
}
    
