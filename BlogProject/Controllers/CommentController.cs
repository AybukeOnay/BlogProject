using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult CommentListByBlogPartial()
        {
            return PartialView();
        }
        public PartialViewResult AddCommentPartial()
        {
            return PartialView();
        }
    }
}
