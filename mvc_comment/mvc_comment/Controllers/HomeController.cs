using mvc_comment.Models;
using System.Web.Mvc;

namespace mvc_comment.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult CommentSave(commentTB c)
        {
            var app = new CommentApp();

            return Json(app.CommentSave(c), JsonRequestBehavior.AllowGet);
        }
    }
}