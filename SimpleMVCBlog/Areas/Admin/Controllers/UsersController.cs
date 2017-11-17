using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVCBlog.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        // GET: Admin/Ussers
        public ActionResult Index()
        {
            return View();
        }
    }
}