using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace CheckList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new CheckList.Models.Reminder();
            model.Statement = "Hux";
            return View("Index",model);
        }
    }
}
