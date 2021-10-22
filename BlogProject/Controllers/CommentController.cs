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
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult CommentListByBlogPartial(int id)
        {
            var values=cm.GetList(id);
            return PartialView(values);
        }
        [HttpGet]
        public PartialViewResult AddCommentPartial()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult AddCommentPartial(Comment cls_comment)
        {
            cls_comment.BlogID = 2;
            cls_comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            cls_comment.CommentStatus = true;
            cm.CommentAddBL(cls_comment);
            return PartialView();
        }
    }
}
